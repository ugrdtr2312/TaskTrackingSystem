using AutoMapper;
using BLL.Helpers.MailHelper;
using BLL.HelpModels;
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
            
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}