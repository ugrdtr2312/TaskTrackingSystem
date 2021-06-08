using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Roles;

namespace API.Controllers
{
    // TODO: change comment below
    /// <summary>
    /// <c>ProjectsController</c> is a class.
    /// Contains all http methods for working with projects.
    /// </summary>
    /// <remarks>
    /// This class can get, create, remove, edit projects, add users to them, return statistics about tasks in project.
    /// </remarks>
    /// <response code="401">If token is invalid or it wasn't provided</response>
    /// <response code="403">If user doesn't have needed credentials</response>
    
    // api/tasks
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;
        private readonly IMailService _mailService;
        private readonly ILogger<TasksController> _logger;

        public TasksController(ITaskService taskService, IMailService mailService, ILogger<TasksController> logger)
        {
            _taskService = taskService;
            _mailService = mailService;
            _logger = logger;
        }

        
        /// <summary>
        /// This method returns tasks that has an inputted ProjectId property
        /// </summary>
        /// <response code="200">Returns tasks that has an inputted ProjectId property</response>
        /// <response code="400">Returns message if something had gone wrong</response>
        /// <response code="404">Returns message that nothing was found</response>

        //GET api/tasks/{id}
        [Authorize(Roles = RoleTypes.User+","+RoleTypes.Manager)]
        [HttpGet("{id:int}", Name = "GetTasksByProjectId")]
        public async Task<IActionResult> GetTasksByProjectId(int id)
        {
            var userId = Convert.ToInt32(User.FindFirstValue("UserId"));

            var tasks = await _taskService.GetAllTasksByProjectIdAsync(id, userId);

            if (!tasks.Any()) return NotFound();
            return Ok(tasks);
        }
        
        
        /// <summary>
        /// This method removes task
        /// </summary>
        /// <response code="204">Returns nothing, task was successfully removed</response>
        /// <response code="404">Returns message that task was not found</response>

        //DELETE api/tasks/{id}
        [Authorize(Roles = RoleTypes.Manager)]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        public async Task<IActionResult> RemoveTask(int id)
        {
            var userId = Convert.ToInt32(User.FindFirstValue("UserId"));
            _logger.LogInformation("Manager with Id {UserId} wants to remove project task id {TaskId}",
                userId, id);
            
            await _taskService.RemoveAsync(id, userId);
            _logger.LogInformation("Manager with Id {UserId} removed task with id {TaskId} and all its tasks successfully",
                userId, id);
                
            return NoContent();
        }
    }
}