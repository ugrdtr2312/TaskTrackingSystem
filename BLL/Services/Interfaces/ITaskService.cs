using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTOs.Task;

namespace BLL.Services.Interfaces
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskDto>> GetAllTasksByProjectIdAsync(int projectId, int userId);
       /* Task<ProjectDto> GetByIdAsync(int id);
        Task<ProjectDto> CreateAsync(ProjectCreateDto projectDto, int userId);
        Task UpdateAsync(ProjectDto projectDto, int userId);
        Task RemoveAsync(int projectId, int userId);
        Task AddUserToProjectAsync(UserToProjectDto userToProjectDto, int userId);
        Task RemoveUserFromProjectAsync(UserToProjectDto userToProjectDto, int userId);*/
    }
}