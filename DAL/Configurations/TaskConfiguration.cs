using System;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shared.Enums;

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
                .Property(t => t.LastUpdate)
                .HasDefaultValueSql("getdate()");
            
            builder
                .Property(t => t.Deadline)
                .IsRequired();
            
            builder
                .Property(c => c.TaskStatus)
                .HasConversion<int>()
                .IsRequired();
            
            builder
                .Property(c => c.TaskPriority)
                .HasConversion<int>()
                .IsRequired();
            
            builder
                .HasOne(t => t.Project)
                .WithMany(p => p.Tasks);
            
            builder
                .HasOne(t => t.User)
                .WithMany(u => u.Tasks)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}