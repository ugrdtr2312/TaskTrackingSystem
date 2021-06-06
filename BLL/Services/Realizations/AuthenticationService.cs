using System;
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
        
        /*public async Task<bool> IsUserInRoleAsync(int id, string role)
        {
            var user = await _userManager.Users.
                FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
                throw new DbQueryResultNullException("Db query result to users is null");

            return await _userManager.IsInRoleAsync(user, role); 
        }*/
        
        public async Task<SignedInUserDto> SignInAsync(LoginDto loginDto)
        {
            var user = await _uow.UserManager.FindByNameAsync(loginDto.UserName);
            
            if (user == null)
                throw new InvalidDataException("User with this login doesn't exist");
            if ( !await _uow.UserManager.CheckPasswordAsync(user, loginDto.Password))
                throw new InvalidDataException("This password is incorrect");
            
            var token = await GenerateJwtToken(user);
            var userDto = _mapper.Map<UserDto>(user);

            return new SignedInUserDto(userDto, token);
        }

        public async Task<SignedInUserDto> SignUpAsync(RegistrationDto registrationDto)
        {
            var user = _mapper.Map<User>(registrationDto);

            var result = await _uow.UserManager.CreateAsync(user, registrationDto.Password);
            
            if (!result.Succeeded)
                throw new InvalidDataException("Failed to create user");

            await _uow.UserManager.AddToRoleAsync(user, RoleTypes.User);
            await _uow.SaveChangesAsync();

            var token = await GenerateJwtToken(user);
            var userDto = _mapper.Map<UserDto>(user);

            return new SignedInUserDto(userDto, token);
        }
        
        private async Task<string> GenerateJwtToken(User user)
        {
            var utcNow = DateTime.UtcNow;
            var roles = await _uow.UserManager.GetRolesAsync(user);
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokensSettings.Key));

            var claims = new []
            {
                new Claim("UserId", user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(ClaimTypes.Role,roles.FirstOrDefault() ?? string.Empty),
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