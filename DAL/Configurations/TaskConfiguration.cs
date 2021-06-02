using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder
                .Property(t => t.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(t => t.Description)
                .HasMaxLength(500)
                .IsRequired();

            builder
                .Property(t => t.CreationDate)
                .HasDefaultValueSql("getdate()");
            
            builder
                .Property(t => t.Deadline)
                .IsRequired();
            
            builder
                .HasOne(t => t.TaskStatus)
                .WithMany(ts => ts.Tasks)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder
                .HasOne(t => t.TaskPriority)
                .WithMany(tp => tp.Tasks)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder
                .HasOne(t => t.Project)
                .WithMany(p => p.Tasks)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder
                .HasOne(t => t.Employee)
                .WithMany(u => u.Tasks)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}