using AutoMapper;
using BLL.Injections.HelpModels;
using BLL.Services.Interfaces;
using BLL.Services.Realizations;
using DAL.Injections;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Injections
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDalDependencies(configuration.GetConnectionString("Default"));
            
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new BllAutoMapperProfiles());
            });
            
            services.AddSingleton(mapperConfig.CreateMapper());
            
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.Configure<TokensSettings>(configuration.GetSection("TokensSettings"));
            
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<IMailService, MailService>();
        }
    }
}