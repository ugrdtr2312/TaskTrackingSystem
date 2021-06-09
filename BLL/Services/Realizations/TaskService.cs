using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs.Project;
using BLL.DTOs.Task;
using BLL.Exceptions;
using BLL.Services.Interfaces;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Roles;

namespace BLL.Services.Realizations
{
    public class TaskService : ITaskService
    {
        private readonly IUoW _uow;
        private readonly IMapper _mapper;

        public TaskService(IUoW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        
        /// <summary>
        /// Gives all tasks of project
        /// </summary>
        /// <param name="userId">User id of person who wants to do this action</param>
        /// <param name="projectId">Project id</param>
        /// <returns>List of tasks</returns>
        /// <exception cref="InvalidDataException">Throws when user id is invalid</exception>
        /// <exception cref="DbQueryResultNullException">Throws when project wasn't find by id</exception>
        public async Task<IEnumerable<TaskDto>> GetAllTasksByProjectIdAsync(int projectId, int userId)
        {
            if (userId == 0)
                throw new InvalidDataException("Value of UserId in token can't be null or empty");
            
            var user = await _uow.UserManager.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
                throw new DbQueryResultNullException("User doesn't exist");
            
            if (projectId <= 0) throw new InvalidDataException("Value of projectId must be positive");
            
            var project =  await _uow.Projects.GetByIdAsync(projectId);
            
            if (project == null)
                throw new DbQueryResultNullException("This project wasn't found");
            
            if (await _uow.UserManager.IsInRoleAsync(user, RoleTypes.Manager))
                return _mapper.Map<IEnumerable<TaskDto>>(project.Tasks);
            
            return _mapper.Map<IEnumerable<TaskDto>>(project.Tasks.Where(t => t.UserId == userId));
        }

        /// <summary>
        /// Removes project
        /// </summary>
        /// <param name="taskId">Task Id</param>
        /// <param name="userId">User id of person who wants to do this action</param>
        /// <exception cref="DbQueryResultNullException">Throws when task doesn't exist or removal wasn't produced</exception>
        /// <exception cref="IdentityException">Throws when user is not a manager of this project</exception>
        /// <exception cref="InvalidDataException">Throws when user id is invalid</exception>
        public async Task<int> RemoveAsync(int taskId, int userId)
        {
            if (userId == 0)
                throw new InvalidDataException("Value of UserId in token can't be null or empty");
            
            var task = await _uow.Tasks.GetByIdAsync(taskId);
            
            if (task == null)
                throw new DbQueryResultNullException("No record to remove from tasks");
            
            var project = await _uow.Projects.GetByIdAsync(task.ProjectId);
            
            if (project.Users.All(user => user.Id != userId))
                throw new IdentityException("Only manager of this project can remove it");

            _uow.Tasks.Remove(task);
            if (!await _uow.SaveChangesAsync())
                throw new DbQueryResultNullException("This task wasn't removed");

            return Convert.ToInt32(task.UserId);
        }


        // public Task<IEnumerable<TaskDto>> GetAllTasksOfUserByProjectIdAsync(int projectId, int userId)
        // {
        //     throw new System.NotImplementedException();
        // }
        //
        // public Task<ProjectDto> GetByIdAsync(int id)
        // {
        //     throw new System.NotImplementedException();
        // }
        //
        // public Task<ProjectDto> CreateAsync(ProjectCreateDto projectDto, int userId)
        // {
        //     throw new System.NotImplementedException();
        // }
        //
        // public Task UpdateAsync(ProjectDto projectDto, int userId)
        // {
        //     throw new System.NotImplementedException();
        // }
        //
        // public Task RemoveAsync(int projectId, int userId)
        // {
        //     throw new System.NotImplementedException();
        // }
        //
        // public Task AddUserToProjectAsync(UserToProjectDto userToProjectDto, int userId)
        // {
        //     throw new System.NotImplementedException();
        // }
        //
        // public Task RemoveUserFromProjectAsync(UserToProjectDto userToProjectDto, int userId)
        // {
        //     throw new System.NotImplementedException();
        // }
    }
}