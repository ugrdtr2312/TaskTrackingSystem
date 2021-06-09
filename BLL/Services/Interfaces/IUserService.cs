using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTOs.User;

namespace BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserOfProjectDto>> GetUsersOfProjectAsync(int projectId, int userId);
        Task<IEnumerable<UserIsInProjectDto>> GetUsersForProjectUsersAsync(int projectId, int userId);
        Task<IEnumerable<UserRoleDto>> GetUsersAndManagersAsync();
        Task SetUserRoleAsync(UserRoleDto userRoleDto);
        Task UpdateUserAsync(int id);
        Task DeleteByIdAsync(int id);
    }
}