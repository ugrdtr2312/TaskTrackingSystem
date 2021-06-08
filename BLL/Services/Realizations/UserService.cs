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
        
        public Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            throw new System.NotImplementedException();
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