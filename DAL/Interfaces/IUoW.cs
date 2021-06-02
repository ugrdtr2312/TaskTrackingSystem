using System;
using System.Threading.Tasks;
using DAL.Repositories.Interfaces;

namespace DAL.Interfaces
{
    public interface IUoW : IDisposable
    {
        IProjectRepository Projects { get; }
        ITaskPriorityRepository TaskPriorities { get; }
        ITaskRepository Tasks { get; }
        ITaskStatusRepository TaskStatuses { get; }

        Task<bool> SaveChangesAsync();
    }
}