using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs.Task;
using BLL.Services.Interfaces;
using DAL.Interfaces;

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
        /// <returns>List of projects</returns>
        /// <exception cref="InvalidDataException">Throws when user id is invalid</exception>
        public Task<IEnumerable<TaskDto>> GetAllTasksByProjectIdAsync(int projectId, int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}