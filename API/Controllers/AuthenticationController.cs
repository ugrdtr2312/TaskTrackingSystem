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
        private readonly ILogger<AuthenticationController> _logger;

        public AuthenticationController(ILogger<AuthenticationController> logger, IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
            _logger = logger;
        }

        [HttpPost("login")]
        public async Task<ActionResult<SignedInUserDto>> Login(LoginDto loginDto)
        {
            
            var signedInUser = await _authenticationService.SignInAsync(loginDto);

            return Ok(signedInUser);
        }

        [HttpPost("registration")]
        public async Task<ActionResult<SignedInUserDto>> Register(RegistrationDto registrationDto)
        {
            var signedInUser = await _authenticationService.SignUpAsync(registrationDto);

            return Ok(signedInUser);
        }
    }
}