using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTOs.Project;

namespace BLL.Services.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDto>> GetAllAsync();
        Task<ProjectDto> GetByIdAsync(int id);
        Task<ProjectDto> CreateAsync(ProjectDto projectDto);
        void Update(ProjectDto projectDto);
        void Remove(int id);
        void AddUserToProject(AddUserToProjectDto addUserToProjectDto);
    }
}