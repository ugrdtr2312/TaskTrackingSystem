using System.Threading.Tasks;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IUoW _uoW;
        
        public TasksController(IUoW uoW)
        {
            _uoW = uoW;
        }
        
        //GET api/tasks
        [HttpGet]
        public async Task<IActionResult> GetAllTasks()
        {
            var brands = await _uoW.Tasks.GetAllAsync();
            return Ok(brands);
        }
    }
}