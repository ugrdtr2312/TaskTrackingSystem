using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs.Project;
using BLL.Exceptions;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace BLL.Services.Realizations
{
    public class ProjectService : IProjectService
    {
        private readonly IUoW _uow;
        private readonly IMapper _mapper;

        public ProjectService(IUoW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        /// <summary>
        /// Gives an info about projects in system
        /// </summary>
        /// <returns>List of projects</returns>
        public async Task<IEnumerable<ProjectDto>> GetAllProjectsAsync()
        {
            var projects =  await _uow.Projects.GetAllAsync();

            return _mapper.Map<IEnumerable<ProjectDto>>(projects);
        }

        /// <summary>
        /// Gives an info about projects of current user
        /// </summary>
        /// <param name="userId">Id of current user</param>
        /// <returns>List of projects</returns>
        /// <exception cref="InvalidDataException">Throws when user id is invalid</exception>
        public async Task<IEnumerable<ProjectDto>> GetAllProjectsByUserIdAsync(int userId)
        {
            if (userId == 0)
                throw new InvalidDataException("Value of UserId in token can't be null or empty");
            
            var projects = await _uow.Projects.GetManyAsync
                (pr => pr.Users.Any(u => u.Id == userId));
            
            return _mapper.Map<IEnumerable<ProjectDto>>(projects);
        }

        /// <summary>
        /// Gives projects by id
        /// </summary>
        /// <param name="id">Id of the project</param>
        /// <returns>Project</returns>
        /// <exception cref="InvalidDataException">Throws when id is invalid</exception>
        /// <exception cref="DbQueryResultNullException">Throws when project wasn't find by id</exception>
        public async Task<ProjectDto> GetByIdAsync(int id)
        {
            if (id <= 0) throw new InvalidDataException("Value of id must be positive");
            
            var project =  await _uow.Projects.GetByIdAsync(id);
            
            if (project == null)
                throw new DbQueryResultNullException("This project wasn't found");

            return _mapper.Map<ProjectDto>(project);
        }

        /// <summary>
        /// Adds new project
        /// </summary>
        /// <param name="projectDto">Project</param>
        /// <param name="userId">User id</param>
        /// <exception cref="DbQueryResultNullException">Throws when project wasn't saved</exception>
        /// <exception cref="InvalidDataException">Throws when user id is invalid</exception>
        public async Task<ProjectDto> CreateAsync(ProjectCreateDto projectDto, int userId)
        {
            if (userId == 0)
                throw new InvalidDataException("Value of UserId in token can't be null or empty");
            
            var user = await _uow.UserManager.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
                throw new DbQueryResultNullException("User doesn't exist");
            
            var project = _mapper.Map<Project>(projectDto);
            
            await _uow.Projects.CreateAsync(project);
            if (!await _uow.SaveChangesAsync())
                throw new DbQueryResultNullException("This project wasn't created");
            
            project.Users = new List<User> {user};
            
            _uow.Projects.Update(project);
            if (!await _uow.SaveChangesAsync())
                throw new DbQueryResultNullException("Manager wasn't added to project");

            return _mapper.Map<ProjectDto>(project);
        }

        /// <summary>
        /// Changes project info
        /// </summary>
        /// <param name="projectDto">Project</param>
        /// <param name="userId">User id</param>
        /// <exception cref="DbQueryResultNullException">Throws when project doesn't exist or changes wasn't produced</exception>
        /// <exception cref="IdentityException">Throws when user is not a manager of this project</exception>
        /// <exception cref="InvalidDataException">Throws when user id is invalid</exception>
        public async Task UpdateAsync(ProjectDto projectDto, int userId)
        {
            if (userId == 0)
                throw new InvalidDataException("Value of UserId in token can't be null or empty");

            var project =  await _uow.Projects.GetByIdAsync(projectDto.Id);
            
            if (project == null)
                throw new DbQueryResultNullException("This project wasn't found");

            if (project.Users.All(user => user.Id != userId))
                throw new IdentityException("Only manager of this project can change it");
            
            project = _mapper.Map<Project>(projectDto);
            
            _uow.Projects.Update(project);
            if (!await _uow.SaveChangesAsync())
                throw new DbQueryResultNullException("This project wasn't updated");
        }
        
        /// <summary>
        /// Removes project
        /// </summary>
        /// <param name="projectId">Project Id</param>
        /// <param name="userId">User id</param>
        /// <exception cref="DbQueryResultNullException">Throws when project doesn't exist or removal wasn't produced</exception>
        /// <exception cref="IdentityException">Throws when user is not a manager of this project</exception>
        /// <exception cref="InvalidDataException">Throws when user id is invalid</exception>
        public async Task RemoveAsync(int projectId , int userId)
        {
            if (userId == 0)
                throw new InvalidDataException("Value of UserId in token can't be null or empty");
            
            var project = await _uow.Projects.GetByIdAsync(projectId);
            
            if (project == null)
                throw new DbQueryResultNullException("No record to remove from projects");
            
            if (project.Users.All(user => user.Id != userId))
                throw new IdentityException("Only manager of this project can remove it");

            _uow.Projects.Remove(project);
            if (!await _uow.SaveChangesAsync())
                throw new DbQueryResultNullException("This project wasn't removed");
        }

        
        /// <summary>
        /// Adds new user to project
        /// </summary>
        /// <param name="userId">User id</param>
        /// <param name="addUserToProjectDto">User id and project id info</param>
        /// <exception cref="DbQueryResultNullException">Throws when project doesn't exist or changes wasn't produced</exception>
        /// <exception cref="IdentityException">Throws when user is not a manager of this project</exception>
        /// <exception cref="InvalidDataException">Throws when user id is invalid</exception>
        public async Task AddUserToProject(AddUserToProjectDto addUserToProjectDto, int userId)
        {
            if (userId == 0)
                throw new InvalidDataException("Value of UserId in token can't be null or empty");
            
            // TODO: ASTRACKING
            var project = await _uow.Projects.GetByIdAsyncAsTracking(addUserToProjectDto.ProjectId);
            
            if (project == null)
                throw new DbQueryResultNullException("This project doesn't exist");
            
            var user = await _uow.UserManager.Users.FirstOrDefaultAsync(u => u.Id == addUserToProjectDto.UserId);
            
            if (user == null) 
                throw new DbQueryResultNullException("This user doesn't exist");
           
            if (project.Users.All(u => u.Id != userId))
                throw new IdentityException("Only manager of this project can add user to it");
            
            if (project.Users.Any(u => u.Id == addUserToProjectDto.UserId))
                throw new IdentityException("This user is already in this project");

            project.Users.Add(user);
            _uow.Projects.Update(project);

            if (!await _uow.SaveChangesAsync())
                throw new DbQueryResultNullException("Changes to projects weren't produced");
        }

    }
}