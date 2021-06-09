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
    /// <c>UsersController</c> is a class.
    /// Contains all http methods for working with users.
    /// </summary>
    /// <remarks>
    /// This class can get, create, remove, edit users.
    /// </remarks>
    /// <response code="400">Returns message if something had gone wrong</response>
    /// <response code="401">If token is invalid or it wasn't provided</response>
    /// <response code="403">If user doesn't have needed credentials</response>
    
    // api/users
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
        /// This method is to get all users to add and remove them from project later
        /// </summary>
        /// <response code="200">Returns users</response>
        
        // api/users/users-for-project
        [Authorize(Roles = RoleTypes.Manager)]
        [HttpGet("users-for-project/{projectId:int}")]
        public async Task<ActionResult> GetUsersForProject(int projectId)
        {
            var userId = Convert.ToInt32(User.FindFirstValue("UserId"));
            
            var users = await _userService.GetUsersForProjectUsersAsync(projectId, userId);

            return Ok(users);
        }
        
        
        /// <summary>
        /// This method to get all users of project
        /// </summary>
        /// <response code="200">Returns users</response>
        
        // api/users/users-of-project
        [Authorize(Roles = RoleTypes.Manager)]
        [HttpGet("users-of-project/{projectId:int}")]
        public async Task<ActionResult> GetUsersOfProject(int projectId)
        {
            var userId = Convert.ToInt32(User.FindFirstValue("UserId"));
            
            var users = await _userService.GetUsersOfProjectAsync(projectId, userId);

            return Ok(users);
        }
        
        
        /// <summary>
        /// This method to get all users that are in role of User or Manager
        /// </summary>
        /// <response code="200">Returns users</response>
        
        // api/users/users-and-managers
        [Authorize(Roles = RoleTypes.Admin)]
        [HttpGet("users-and-managers")]
        public async Task<ActionResult> GetUsersAndManagers()
        {
            var users = await _userService.GetUsersAndManagersAsync();

            return Ok(users);
        }
        
        
        /// <summary>
        /// This method returns user that has an inputted Id property
        /// </summary>
        /// <response code="200">Returns user that has an inputted Id property</response>

        //GET api/users/{id}
        [HttpGet("{id:int}", Name = "GetUserById")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetByIdAsync(id);

            return Ok(user);
        }
        
        
        /// <summary>
        /// This method changes user
        /// </summary>
        /// <response code="204">Returns nothing, user was successfully changed</response>

        //PUT api/users
        [HttpPut]
        [ProducesResponseType(204)]
        public async Task<IActionResult> UpdateUser(UserDto userDto)
        {
            var userId = Convert.ToInt32(User.FindFirstValue("UserId"));
            _logger.LogInformation("User with Id {UserId} wants to change its profile", userId);

            await _userService.UpdateAsync(userDto, userId);

            _logger.LogInformation("User with Id {UserId} changed its profile successfully", userId);

            return NoContent();
        }
        
        
        /// <summary>
        /// This method is for setting role to users
        /// </summary>
        /// <response code="204">Returns nothing, successfully changed</response>
        
        // api/users/set-user-role
        [Authorize(Roles = RoleTypes.Admin)]
        [HttpPost("set-user-role")]
        [ProducesResponseType(204)]
        public async Task<ActionResult> SetUserRole(UserRoleDto userRoleDto)
        {
            var userId = Convert.ToInt32(User.FindFirstValue("UserId"));
            _logger.LogInformation("Admin with Id {UserId} wants to change role of user with id {Id}", 
                userId, userRoleDto.Id);
            
            await _userService.SetUserRoleAsync(userRoleDto);
            
            _logger.LogInformation("Admin with Id {UserId} changed role of user with id {Id} to {Role}", 
                userId, userRoleDto.Id, userRoleDto.Role);
            await _mailService.SendEmailAboutRoleChangingAsync(userRoleDto);

            return NoContent();
        }
        
        
        /// <summary>
        /// This method removes user
        /// </summary>
        /// <response code="204">Returns nothing, user was successfully removed</response>

        //DELETE api/users/{id}
        [Authorize(Roles = RoleTypes.Admin)]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> RemoveUser(int id)
        {
            var userId = Convert.ToInt32(User.FindFirstValue("UserId"));
            _logger.LogInformation("Admin with Id {UserId} wants to remove user with id {Id}", userId, id);
            
            var user = await _userService.DeleteByIdAsync(id);
            
            _logger.LogInformation("Admin with Id {UserId} removed user with id {Id} successfully", userId, id);
            await _mailService.SendEmailAboutUserRemovingAsync(user);
            
            return NoContent();
        }
    }
}