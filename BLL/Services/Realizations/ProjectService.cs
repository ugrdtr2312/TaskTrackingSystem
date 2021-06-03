using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs.Project;
using BLL.Exceptions;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services.Realizations
{
    public class ProjectService : IProjectService
    {
        private readonly IUoW _uow;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public ProjectService(IUoW uow, IMapper mapper, UserManager<User> userManager)
        {
            _uow = uow;
            _mapper = mapper;
            _userManager = userManager;
        }
        
        public async Task<IEnumerable<ProjectDto>> GetAllAsync()
        {
            var projects =  await _uow.Projects.GetAllAsync();

            return _mapper.Map<IEnumerable<ProjectDto>>(projects);
        }

        public async Task<ProjectDto> GetByIdAsync(int id)
        {
            var project =  await _uow.Projects.GetByIdAsync(id);
            
            if (project == null)
                throw new DbQueryResultNullException("Db query result to projects is null");

            return _mapper.Map<ProjectDto>(project);
        }

        public async Task<ProjectDto> CreateAsync(ProjectDto projectDto)
        {
            var project = _mapper.Map<Project>(projectDto);
            
            await _uow.Projects.CreateAsync(project);
            if (!await _uow.SaveChangesAsync())
                throw new DbQueryResultNullException("Changes to projects weren't produced");

            return _mapper.Map<ProjectDto>(project);
        }

        public void Update(ProjectDto projectDto)
        {
            var project =  _uow.Projects.GetByIdAsync(projectDto.Id).Result;
            
            if (project == null)
                throw new DbQueryResultNullException("There isn't such projects in db");
            
            project = _mapper.Map<Project>(projectDto);
            
            _uow.Projects.Update(project);
            if (!_uow.SaveChangesAsync().Result)
                throw new DbQueryResultNullException("Changes to projects weren't produced");
        }

        public void AddUserToProject(AddUserToProjectDto addUserToProjectDto)
        {
            var project = _uow.Projects.GetByIdAsyncAsTracking(addUserToProjectDto.ProjectId).Result;
            
            if (project == null)
                throw new DbQueryResultNullException("Project doesn't exist");
            
            var user = _userManager.Users
                .FirstOrDefaultAsync(u => u.Id == addUserToProjectDto.UserId).Result;
            
            if (user == null)
                throw new DbQueryResultNullException("User doesn't exist");
            
            project.Users.Add(user);
            
            _uow.Projects.Update(project);
            
            if (!_uow.SaveChangesAsync().Result)
                throw new DbQueryResultNullException("Changes to projects weren't produced");            

        }

        public void Remove(int id)
        {
            var project = _uow.Projects.GetByIdAsync(id).Result;
            
            if (project == null)
                throw new DbQueryResultNullException("No record to remove from projects");

            _uow.Projects.Remove(project);
            if (!_uow.SaveChangesAsync().Result)
                throw new DbQueryResultNullException("Changes to projects weren't produced");
        }
    }
}