using System.Threading.Tasks;
using BLL.DTOs.User;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
    
    // api/authentication
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMailService _mailService;
        private readonly ILogger<AuthenticationController> _logger;

        public AuthenticationController(ILogger<AuthenticationController> logger, IAuthenticationService authenticationService, IMailService mailService)
        {
            _authenticationService = authenticationService;
            _mailService = mailService;
            _logger = logger;
        }

        [HttpPost("login")]
        public async Task<ActionResult<SignedInUserDto>> Login(LoginDto loginDto)
        {
            _logger.LogInformation("User with {UserName} trying to sign in", loginDto.UserName);
            
            var signedInUser = await _authenticationService.SignInAsync(loginDto);
            
            _logger.LogInformation("User with {UserName} signed in in successfully", loginDto.UserName);
            await _mailService.SendEmailAboutSigningInAsync(loginDto);
            
            return Ok(signedInUser);
        }

        [HttpPost("registration")]
        public async Task<ActionResult<SignedInUserDto>> Register(RegistrationDto registrationDto)
        {
            var signedInUser = await _authenticationService.SignUpAsync(registrationDto);
            
            _logger.LogInformation("User with {UserName} signed up successfully", signedInUser.User.UserName);
            await _mailService.SendEmailAboutSigningUpAsync(signedInUser.User.Id);

            return Ok(signedInUser);
        }
    }
}