using DAL.Configurations;
using DAL.DbSeeds;
using DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DAL.Contexts
{
    public class TaskTrackingSystemContext : IdentityDbContext<User, UserRole, int>
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        
        public TaskTrackingSystemContext(DbContextOptions<TaskTrackingSystemContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(CoreEventId.RowLimitingOperationWithoutOrderByWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TaskConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            
            BasicSeed.Seed(modelBuilder);
        }
    }
    
    public class TaskTrackingSystemContextFactory : IDesignTimeDbContextFactory<TaskTrackingSystemContext>
    {
        public TaskTrackingSystemContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TaskTrackingSystemContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-AB3OQES;Database=TaskTrackingSystemContext;Trusted_Connection=True;");

            return new TaskTrackingSystemContext(optionsBuilder.Options);
        }
    }
}