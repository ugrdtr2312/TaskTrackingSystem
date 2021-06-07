﻿using System;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs.User;
using BLL.Exceptions;
using BLL.HelpModels;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Shared.Roles;

namespace BLL.Services.Realizations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUoW _uow;
        private readonly IMapper _mapper;
        private readonly TokensSettings _tokensSettings;

        public AuthenticationService(IUoW uow, IMapper mapper, IOptions<TokensSettings> tokensSettings)
        {
            _uow = uow;
            _mapper = mapper;
            _tokensSettings = tokensSettings.Value;
        }
        
        /// <summary>
        /// Generate jwt-token for user if login data is correct
        /// </summary>
        /// <param name="loginDto">User login data</param>
        /// <returns>Jwt-token</returns>
        /// <exception cref="InvalidDataException">Throws if user login data is invalid</exception>
        public async Task<string> SignInAsync(LoginDto loginDto)
        {
            var user = await _uow.UserManager.FindByNameAsync(loginDto.UserName);
            
            if (user == null)
                throw new InvalidDataException("User with this login doesn't exist");
            if ( !await _uow.UserManager.CheckPasswordAsync(user, loginDto.Password))
                throw new InvalidDataException("This password is incorrect");

            return await GenerateJwtToken(user);
        }

        /// <summary>
        /// Add user to database
        /// </summary>
        /// <param name="registrationDto">User registration data</param>
        /// <returns>User info</returns>
        /// <exception cref="InvalidDataException">Throws when user registration data is invalid</exception>
        public async Task<UserDto> SignUpAsync(RegistrationDto registrationDto)
        {
            var user = _mapper.Map<User>(registrationDto);

            var result = await _uow.UserManager.CreateAsync(user, registrationDto.Password);
            
            if (!result.Succeeded)
                throw new InvalidDataException(result.Errors?.FirstOrDefault()?.Description);

            await _uow.UserManager.AddToRoleAsync(user, RoleTypes.User);
            await _uow.SaveChangesAsync();
            
            return _mapper.Map<UserDto>(user);
        }
        
        /// <summary>
        /// Generate jwt-token method
        /// </summary>
        /// <param name="user">User data</param>
        /// <returns>Jwt-token</returns>
        private async Task<string> GenerateJwtToken(User user)
        {
            var utcNow = DateTime.UtcNow;
            var roles = await _uow.UserManager.GetRolesAsync(user);
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokensSettings.Key));

            var claims = new []
            {
                new Claim("UserId", user.Id.ToString()),
                new Claim(ClaimTypes.Role,roles.FirstOrDefault() ?? string.Empty),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, utcNow.ToString(CultureInfo.InvariantCulture))
            };

            var claimsIdentity = new ClaimsIdentity(claims);
            
            var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            var jwt = new JwtSecurityToken(
                signingCredentials: signingCredentials,
                claims: claimsIdentity.Claims,
                notBefore: utcNow,
                expires: utcNow.AddMinutes(_tokensSettings.ExpiryMinutes)
            );

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}