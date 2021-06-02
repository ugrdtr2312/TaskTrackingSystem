using System.Linq;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Realizations
{
    public class TaskStatusRepository : GenericRepositoryWithIncludes<TaskStatus>, ITaskStatusRepository
    {
        public TaskStatusRepository(DbContext context) : base(context)
        {
        }

        protected override IQueryable<TaskStatus> DbSetWithAllProperties()
        {
            return DbSet.Include(ts => ts.Tasks);
        }
    }
}