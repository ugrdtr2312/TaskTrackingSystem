using System.Threading.Tasks;
using BLL.DTOs.User;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    /// <summary>
    /// <c>AuthenticationController</c> is a class.
    /// Contains all http methods for working with authentication.
    /// </summary>
    /// <remarks>
    /// This class provides logging in and registration.
    /// </remarks>
    /// <response code="400">Returns message if something had gone wrong</response>
    
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

        
        /// <summary>
        /// This method for logging in
        /// </summary>
        /// <response code="200">Returns token</response>
        
        // api/authentication/login
        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginDto loginDto)
        {
            _logger.LogInformation("User with {UserName} trying to sign in", loginDto.UserName);
            
            var token = await _authenticationService.SignInAsync(loginDto);
            
            _logger.LogInformation("User with {UserName} signed in in successfully", loginDto.UserName);
            await _mailService.SendEmailAboutSigningInAsync(loginDto);
            
            return Ok(new { token });
        }

        
        /// <summary>
        /// This method for registration
        /// </summary>
        /// <response code="204">Returns nothing, registration was successful</response>
        
        // api/authentication/registration
        [HttpPost("registration")]
        [ProducesResponseType(204)]
        public async Task<ActionResult> Register(RegistrationDto registrationDto)
        {
            var signedInUser = await _authenticationService.SignUpAsync(registrationDto);
            
            _logger.LogInformation("User with {UserName} signed up successfully", signedInUser.UserName);
            await _mailService.SendEmailAboutSigningUpAsync(signedInUser.Id);

            return NoContent();
        }
    }
}