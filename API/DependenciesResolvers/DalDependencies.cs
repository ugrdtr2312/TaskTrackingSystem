using DAL.Contexts;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories.Interfaces;
using DAL.Repositories.Realizations;
using DAL.UoWs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.DependenciesResolvers
{
    public static class DalDependencies
    {
        public static void DalDependenciesResolver(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TaskTrackingSystemContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default")));
 
            services.AddIdentity<User, UserRole>()
                .AddEntityFrameworkStores<TaskTrackingSystemContext>();

            services.AddScoped<DbContext, TaskTrackingSystemContext>();
            services.AddScoped<IUoW, EfUoW>();

            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ITaskPriorityRepository, TaskPriorityRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<ITaskStatusRepository, TaskStatusRepository>();
        }
    }
}