using System;
using System.Collections.Generic;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;

namespace DAL.DbSeeds
{
    public static class BasicSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            #region Identity

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole() {Id = 1, Name = "Admin", NormalizedName = "ADMIN"},
                new UserRole() {Id = 2, Name = "Manager", NormalizedName = "MANAGER"},
                new UserRole() {Id = 3, Name = "User", NormalizedName = "USER"}
            );

            var passwordHasher = new PasswordHasher<User>();
            var users = new List<User>()
            {
                new()
                {
                    Id = 1,
                    UserName = "ugrdtr",
                    NormalizedUserName = "ugrdtr".ToUpper(),
                    FirstName = "Vladimir",
                    Surname = "Shengeliya",
                    Email = "vladimir231200@gmail.com",
                    NormalizedEmail = "vladimir231200@gmail.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "123Qwerty"),
                    SecurityStamp = Guid.NewGuid().ToString()
                },

                new()
                {
                    Id = 2,
                    UserName = "mxxnr1se",
                    NormalizedUserName = "mxxnr1se".ToUpper(),
                    FirstName = "Nikita",
                    Surname = "Sidorov",
                    Email = "ns18091@gmail.com",
                    NormalizedEmail = "ns18091@gmail.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "123Qwerty"),
                    SecurityStamp = Guid.NewGuid().ToString()
                },

                new()
                {
                    Id = 3,
                    UserName = "Aolan13",
                    NormalizedUserName = "Aolan13".ToUpper(),
                    FirstName = "Danila",
                    Surname = "Crazy",
                    Email = "kochka4real@gmail.com",
                    NormalizedEmail = "kochka4real@gmail.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "123Qwerty"),
                    SecurityStamp = Guid.NewGuid().ToString()
                },

                new()
                {
                    Id = 4,
                    UserName = "janglaide",
                    NormalizedUserName = "janglaide".ToUpper(),
                    FirstName = "Alison",
                    Surname = "Proshchenko",
                    Email = "janglaide@gmail.com",
                    NormalizedEmail = "janglaide@gmail.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "123Qwerty"),
                    SecurityStamp = Guid.NewGuid().ToString()
                }
            };
            modelBuilder.Entity<User>().HasData(users);

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int> {UserId = 1, RoleId = 3},
                new IdentityUserRole<int> {UserId = 2, RoleId = 3},
                new IdentityUserRole<int> {UserId = 3, RoleId = 2},
                new IdentityUserRole<int> {UserId = 4, RoleId = 1}
            );

            #endregion

            modelBuilder.Entity<Project>().HasData(
                new Project() { Id = 1, Name = "Web project 1", Description = "Web project 1 description" },
                new Project() { Id = 2, Name = "Web project 2", Description = "Web project 2 description" },
                new Project() { Id = 3, Name = "Web project 3", Description = "Web project 3 description" }
            );

            modelBuilder.Entity<Task>().HasData(
                new Task()
                {
                    Id = 1, Name = "Task1", Description = "Task1 description", Deadline = DateTime.Now.AddDays(3),
                    TaskStatus = TaskStatus.Open, TaskPriority = TaskPriority.Medium, ProjectId = 1, UserId = 1
                },
                new Task()
                {
                    Id = 2, Name = "Task2", Description = "Task2 description", Deadline = DateTime.Now.AddDays(4),
                    TaskStatus = TaskStatus.InProgress, TaskPriority = TaskPriority.Low, ProjectId = 1, UserId = 1
                },
                new Task()
                {
                    Id = 3, Name = "Task3", Description = "Task3 description", Deadline = DateTime.Now.AddDays(1),
                    TaskStatus = TaskStatus.Completed, TaskPriority = TaskPriority.High, ProjectId = 1, UserId = 1
                },
                new Task()
                {
                    Id = 4, Name = "Task4", Description = "Task4 description", Deadline = DateTime.Now.AddDays(6),
                    TaskStatus = TaskStatus.InProgress,TaskPriority = TaskPriority.Medium, ProjectId = 1, UserId = 1
                },
                new Task()
                {
                    Id = 5, Name = "Task5", Description = "Task5 description", Deadline = DateTime.Now.AddDays(2),
                    TaskStatus = TaskStatus.Open,TaskPriority = TaskPriority.Low, ProjectId = 1, UserId = 2
                },
                new Task()
                {
                    Id = 6, Name = "Task6", Description = "Task6 description", Deadline = DateTime.Now.AddDays(4),
                    TaskStatus = TaskStatus.Completed, TaskPriority = TaskPriority.High, ProjectId = 1, UserId = 2
                },
                new Task()
                {
                    Id = 7, Name = "Task7", Description = "Task7 description", Deadline = DateTime.Now.AddDays(3),
                    TaskStatus = TaskStatus.Open, TaskPriority = TaskPriority.Medium, ProjectId = 1, UserId = 1
                },
                new Task()
                {
                    Id = 8, Name = "Task8", Description = "Task8 description", Deadline = DateTime.Now.AddDays(5),
                    TaskStatus = TaskStatus.Open, TaskPriority = TaskPriority.Critical, ProjectId = 1, UserId = 2
                },
                new Task()
                {
                    Id = 9, Name = "Task9", Description = "Task9 description", Deadline = DateTime.Now.AddDays(1),
                    TaskStatus = TaskStatus.InProgress, TaskPriority = TaskPriority.Critical, ProjectId = 1, UserId = 2
                },
                new Task()
                {
                    Id = 10, Name = "Task10", Description = "Task10 description", Deadline = DateTime.Now.AddDays(3),
                    TaskStatus = TaskStatus.OnHold, TaskPriority = TaskPriority.Low, ProjectId = 1, UserId = 1
                },
                new Task()
                {
                    Id = 11, Name = "Task11", Description = "Task11 description", Deadline = DateTime.Now.AddDays(6),
                    TaskStatus = TaskStatus.Cancelled, TaskPriority = TaskPriority.Medium, ProjectId = 1, UserId = 2
                },
                new Task()
                {
                    Id = 12, Name = "Task12", Description = "Task12 description", Deadline = DateTime.Now.AddDays(4),
                    TaskStatus = TaskStatus.InProgress, TaskPriority = TaskPriority.High, ProjectId = 1, UserId = 1
                }
            );
        }
    }
}