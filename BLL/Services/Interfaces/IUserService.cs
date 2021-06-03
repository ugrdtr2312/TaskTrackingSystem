using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTOs.User;

namespace BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> IsUserInRoleAsync(int id, string role);

        Task<ICollection<string>> GetRolesAsync(int userId);

        Task<SignedInUserDto> SignInAsync(LoginDto loginDto, string tokenKey, int tokenLifetime);

        Task SignOutAsync();

        Task<SignedInUserDto> SignUpAsync(RegistrationDto registrationDto, string tokenKey, int tokenLifetime);

        Task<UserDto> GetUserDetailsAsync(int userId);

        Task<bool> Deactivate(int userId);

        Task UpdateImage(int userId, string profileImageName, string rootPath, byte[] image);
    }
}