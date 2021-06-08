using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTOs.User;

namespace BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetUsersAsync();
        Task<IEnumerable<UserIsInProjectDto>> GetUsersForProjectUsersAsync(int projectId, int userId);
        Task ChangeUserRoleAsync(string id);
        Task UpdateUserAsync(int id);
        Task DeleteByIdAsync(int id);
    }
}