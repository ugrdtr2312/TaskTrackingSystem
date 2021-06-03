using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs.User;
using BLL.Exceptions;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Task = System.Threading.Tasks.Task;

namespace BLL.Services.Realizations
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IUoW _uoW;
        private readonly IMapper _mapper;

        public UserService(IMapper mapper, IUoW uoW, SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _mapper = mapper;
            _uoW = uoW;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        
        public async Task<bool> IsUserInRoleAsync(int id, string role)
        {
            var user = await _userManager.Users.
                FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
                throw new DbQueryResultNullException("Db query result to users is null");

            return await _userManager.IsInRoleAsync(user, role); 
        }

        public Task<ICollection<string>> GetRolesAsync(int userId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<SignedInUserDto> SignInAsync(LoginDto loginDto, string tokenKey, int tokenLifetime)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDto.UserName, loginDto.Password, false, false);

            if (!result.Succeeded)
                throw new InvalidDataException("Failed to sign in user, login data is incorrect"); 

            var user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (user == null)
                throw new DbQueryResultNullException("Db query result to users is null");

            var token = await GenerateJwtToken(user, tokenKey, tokenLifetime);
            var userDto = _mapper.Map<UserDto>(user);

            return new SignedInUserDto(userDto, token);
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<SignedInUserDto> SignUpAsync(RegistrationDto registrationDto, string tokenKey, int tokenLifetime)
        {
            var user = _mapper.Map<User>(registrationDto);

            var result = await _userManager.CreateAsync(user, registrationDto.Password);

            if (!result.Succeeded)
                throw new UserCreationException("Failed to create user");

            await _uoW.SaveChangesAsync();

            await _signInManager.SignInAsync(user, false);
            var token = await GenerateJwtToken(user, tokenKey, tokenLifetime);

            var userDto = _mapper.Map<UserDto>(user);

            return new SignedInUserDto(userDto, token);
        }

        public Task<UserDto> GetUserDetailsAsync(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Deactivate(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateImage(int userId, string profileImageName, string rootPath, byte[] image)
        {
            throw new System.NotImplementedException();
        }
        
        private async Task<string> GenerateJwtToken(User user, string tokenKey, int tokenLifetime)
        {
            var utcNow = DateTime.UtcNow;

            var claims = new []
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, utcNow.ToString(CultureInfo.InvariantCulture))
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims);

            var roles = await _userManager.GetRolesAsync(user);

            claimsIdentity.AddClaims(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));
            var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            var jwt = new JwtSecurityToken(
                signingCredentials: signingCredentials,
                claims: claimsIdentity.Claims,
                notBefore: utcNow,
                expires: utcNow.AddMinutes(tokenLifetime)
            );

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}