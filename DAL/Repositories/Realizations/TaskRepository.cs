﻿using System.Linq;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Realizations
{
    public class TaskRepository : GenericRepositoryWithIncludes<Task>, ITaskRepository
    {
        public TaskRepository(DbContext context) : base(context)
        {
        }

        protected override IQueryable<Task> DbSetWithAllProperties()
        {
            return DbSet
                .Include(t => t.TaskStatus)
                .Include(t => t.TaskPriority)
                .Include(t => t.Project)
                .Include(t => t.Employee);
        }
    }
}