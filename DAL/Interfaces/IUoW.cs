﻿using System;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DAL.Interfaces
{
    public interface IUoW : IDisposable
    {
        UserManager<User> UserManager { get; }
        RoleManager<UserRole> RoleManager { get; }
        IProjectRepository Projects { get; }
        ITaskRepository Tasks { get; }
        Task<bool> SaveChangesAsync();
    }
}