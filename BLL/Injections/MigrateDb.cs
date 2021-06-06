using DAL.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Injections
{
    public static class MigrateDb
    {
        public static void Migrate(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            
            if (serviceScope == null) return;
            var context = serviceScope.ServiceProvider.GetRequiredService<TaskTrackingSystemContext>();
            context.Database.Migrate();
        }
    }
}