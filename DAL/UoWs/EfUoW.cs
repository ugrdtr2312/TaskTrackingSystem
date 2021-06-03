using System;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.UoWs
{
    public sealed class EfUoW : IUoW
    {
        private readonly DbContext _context;

        public EfUoW(DbContext context, IProjectRepository projectRepository, ITaskRepository taskRepository)
        {
            _context = context;
            Tasks = taskRepository;
            Projects = projectRepository;
        }
       
        public ITaskRepository Tasks { get; }
        public IProjectRepository Projects { get; }
        
        private bool _disposed;

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }
    }
}