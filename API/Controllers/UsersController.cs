using System;
using System.Security.Claims;
using System.Threading.Tasks;
using BLL.DTOs.User;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Roles;

namespace API.Controllers
{
    /// <summary>
    /// <c>AuthenticationController</c> is a class.
    /// Contains all http methods for working with authentication.
    /// </summary>
    /// <remarks>
    /// This class avoid to logging in ang registration.
    /// </remarks>
    
    // api/authentication
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMailService _mailService;
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger, IMailService mailService, IUserService userService)
        {
            _mailService = mailService;
            _userService = userService;
            _logger = logger;
        }

        
        /// <summary>
        /// This method to get all users to add and remove them from project later
        /// </summary>
        /// <response code="200">Returns users</response>
        /// <response code="400">Returns message if something had gone wrong</response>
        
        // api/authentication/users-for-project
        [Authorize(Roles = RoleTypes.Manager)]
        [HttpGet("users-for-project/{projectId:int}")]
        public async Task<ActionResult> GetUsersForProject(int projectId)
        {
            var userId = Convert.ToInt32(User.FindFirstValue("UserId"));
            
            var users = await _userService.GetUsersForProjectUsersAsync(projectId, userId);

            return Ok(users);
        }
        
    }
}