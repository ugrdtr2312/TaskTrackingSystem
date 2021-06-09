using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs.User;
using BLL.Exceptions;
using BLL.Services.Interfaces;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Roles;
using TaskStatus = Shared.Enums.TaskStatus;

namespace BLL.Services.Realizations
{
    public class UserService : IUserService
    {
        private readonly IUoW _uow;
        private readonly IMapper _mapper;

        public UserService(IUoW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }


        public async Task<IEnumerable<UserOfProjectDto>> GetUsersOfProjectAsync(int projectId, int userId)
        {
            var project = await _uow.Projects.GetByIdAsync(projectId);
            
            if (project == null)
                throw new DbQueryResultNullException("No project with this id");

            if (project.Users.All(user => user.Id != userId))
                throw new IdentityException("Only manager of this project can get them");

            return _mapper.Map<IEnumerable<UserOfProjectDto>>(project.Users);
        }

        public async Task<IEnumerable<UserIsInProjectDto>> GetUsersForProjectUsersAsync(int projectId, int userId)
        {
            var project = await _uow.Projects.GetByIdAsync(projectId);
            
            if (project == null)
                throw new DbQueryResultNullException("No project with this id");
            
            if (project.Users.All(user => user.Id != userId))
                throw new IdentityException("Only manager of this project can remove it");

            var usersInProject = await _uow.UserManager.Users
                .Where(u => u.Projects.Any(p => p.Id == projectId)).ToListAsync();

            var usersNotInProject = await _uow.UserManager.Users
                .Where(u => u.Projects.All(p => p.Id != projectId)).ToListAsync();

            var users = new List<UserIsInProjectDto>();

            foreach (var user in usersInProject)
            {
                if (await _uow.UserManager.IsInRoleAsync(user, RoleTypes.User))
                    users.Add(new UserIsInProjectDto()
                    {
                        UserId = user.Id,
                        FullName = user.FirstName + " " + user.Surname,
                        IsInProject = true,
                    });
            }
            
            foreach (var user in usersNotInProject)
            {
                if (await _uow.UserManager.IsInRoleAsync(user, RoleTypes.User))
                    users.Add(new UserIsInProjectDto()
                    {
                        UserId = user.Id,
                        FullName = user.FirstName + " " + user.Surname,
                        IsInProject = false,
                    });
            }

            return users.ToArray();
        }

        public async Task<IEnumerable<UserRoleDto>> GetUsersAndManagersAsync()
        {
            var users = await _uow.UserManager.Users.ToListAsync();
            var usersAndManagers = new List<UserRoleDto>();

            foreach (var user in users)
            {
                var roles = await _uow.UserManager.GetRolesAsync(user);
                if (roles[0] == RoleTypes.User || roles[0] == RoleTypes.Manager)
                    usersAndManagers.Add(new UserRoleDto()
                    {
                        FullName = $"{user.Surname} {user.FirstName}",
                        Id = user.Id,
                        Role = roles[0]
                    });
            }

            return usersAndManagers;
        }

        public async Task SetUserRoleAsync(UserRoleDto userRoleDto)
        {
            var user = await _uow.UserManager.Users.FirstOrDefaultAsync(u => u.Id == userRoleDto.Id);

            if (user == null)
                throw new DbQueryResultNullException("User doesn't exist");
            
            if (!string.Equals(userRoleDto.Role, RoleTypes.User) && !string.Equals(userRoleDto.Role, RoleTypes.Manager))
                throw new InvalidDataException("User role is invalid");

            if (await _uow.UserManager.IsInRoleAsync(user, userRoleDto.Role))
                throw new InvalidDataException("User is in this role already");

            var userRoles = await _uow.UserManager.GetRolesAsync(user);
            await _uow.UserManager.RemoveFromRolesAsync(user ,userRoles);
            await _uow.UserManager.AddToRoleAsync(user, userRoleDto.Role);

            await _uow.UserManager.UpdateAsync(user);
        }


        public Task UpdateUserAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var user = await _uow.UserManager.Users.Include(u => u.Tasks)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
                throw new DbQueryResultNullException("User doesn't exist");

            foreach (var task in user.Tasks)
            {
                task.UserId = null;
                if (task.TaskStatus == TaskStatus.InProgress)
                    task.TaskStatus = TaskStatus.Open;
            }

            await _uow.UserManager.DeleteAsync(user);
        }
    }
}