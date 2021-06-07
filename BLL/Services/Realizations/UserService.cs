using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTOs.User;
using BLL.Services.Interfaces;

namespace BLL.Services.Realizations
{
    public class UserService : IUserService
    {
        public Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task ChangeUserRoleAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateUserAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}