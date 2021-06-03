using System;
using System.Security.Claims;
using System.Threading.Tasks;
using BLL.Helpers.MailHelper;
using BLL.Helpers.MailHelper.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IUoW _uoW;
        private readonly IMailService mailService;
        
        public TasksController(IUoW uoW, IMailService mailService)
        {
            _uoW = uoW;
            this.mailService = mailService;
        }
        
        //GET api/tasks
        [Authorize]
        [HttpGet]
        public IActionResult GetAllTasks()
        {
            return Ok(User.FindFirstValue(JwtRegisteredClaimNames.Sub));
        }
        
        [HttpPost("send")]
        public async Task<IActionResult> SendMail(MailRequest request)
        {
            await mailService.SendEmailAsync(request);
            return Ok();
        }
    }
}