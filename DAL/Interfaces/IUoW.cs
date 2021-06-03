using System;
using System.Threading.Tasks;
using DAL.Repositories.Interfaces;

namespace DAL.Interfaces
{
    public interface IUoW : IDisposable
    {
        IProjectRepository Projects { get; }
        ITaskRepository Tasks { get; }

        Task<bool> SaveChangesAsync();
    }
}