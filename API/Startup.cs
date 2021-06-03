using API.DependenciesResolvers;
using API.Infrastructure;
using API.Infrastructure.Logging;
using BLL.Helpers.MailHelper;
using DAL.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            
            services.DalDependenciesResolver(Configuration);
            services.BllDependenciesResolver(Configuration.GetSection("MailSettings"));
            
            services.AddSingleton(AutoMapperConfigure.CreateMapper());

            services.ConfigureIdentityPasswordSettings();
            services.JwtAuthorizationConfiguration(Configuration);
           
            services.AddSingleton<ILog, MyLogger>();
            
            services.SwaggerConfigure();
            
            /*// In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "../TaskTrackingApp/dist";
            });*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILog logger)
        {
            app.ConfigureExceptionHandler(logger);
            
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope())
            {
                if (serviceScope != null)
                {
                    var context = serviceScope.ServiceProvider.GetRequiredService<TaskTrackingSystemContext>();
                    context.Database.Migrate();
                }
            }
            
            //app.UseSpaStaticFiles();

            app.UseAuthentication();
           
            app.UseSwagger(c => {c.SerializeAsV2 = true;});
            
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TaskTrackingAPI");
                c.RoutePrefix = string.Empty;
            });
            
            app.UseRouting();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
            
            /*app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "../TaskTrackingApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });*/
        }
    }
}