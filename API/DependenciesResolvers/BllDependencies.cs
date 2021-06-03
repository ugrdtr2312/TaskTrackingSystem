using AutoMapper.Configuration;
using BLL.Helpers.MailHelper;
using BLL.Helpers.MailHelper.Entities;
using BLL.Services.Interfaces;
using BLL.Services.Realizations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.DependenciesResolvers
{
    public static class BllDependencies
    {
        public static void BllDependenciesResolver(this IServiceCollection services,  IConfigurationSection configurationSection)
        {
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IUserService, UserService>();
            
            services.Configure<MailSettings>(configurationSection);
            services.AddTransient<IMailService, MailService>();
        }
    }
}