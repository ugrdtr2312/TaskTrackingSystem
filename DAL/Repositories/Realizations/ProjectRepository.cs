using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Realizations
{
    public class ProjectRepository: GenericRepositoryWithIncludes<Project>, IProjectRepository
    {
        public ProjectRepository(DbContext context) : base(context)
        {
        }

        protected override IQueryable<Project> DbSetWithAllProperties()
        {
            return DbSet
                .Include(p => p.Tasks)
                .Include(p => p.Users);
        }
        
        public async Task<IEnumerable<Project>> GetManyAsync(Expression<Func<Project, bool>> expression)
        {
            var pictures = DbSetWithAllProperties().Where(expression);
            return await pictures.ToListAsync();
        }
    }
}