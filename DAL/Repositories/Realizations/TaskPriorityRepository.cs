using System.Linq;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Realizations
{
    public class TaskPriorityRepository : GenericRepositoryWithIncludes<TaskPriority>, ITaskPriorityRepository
    {
        public TaskPriorityRepository(DbContext context) : base(context)
        {
        }

        protected override IQueryable<TaskPriority> DbSetWithAllProperties()
        {
            return DbSet.Include(tp => tp.Tasks);
        }
    }
}