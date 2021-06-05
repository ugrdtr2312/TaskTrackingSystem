using System.Threading.Tasks;
using BLL.DTOs.User;

namespace BLL.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<SignedInUserDto> SignInAsync(LoginDto loginDto);
        Task<SignedInUserDto> SignUpAsync(RegistrationDto registrationDto);
    }
}