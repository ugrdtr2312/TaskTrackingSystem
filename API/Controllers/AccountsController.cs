using System;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs.User;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AccountController(IUserService userService, IMapper mapper, IConfiguration configuration)
        {
            _userService = userService;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<ActionResult<SignedInUserDto>> Login(LoginDto loginDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                var signedInUser = await _userService.SignInAsync(loginDto, _configuration["TokensSettings:Key"],
                    int.Parse(_configuration["TokensSettings:ExpiryMinutes"]));

                return Ok(signedInUser);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        
        [HttpPost("registration")]
        public async Task<ActionResult<SignedInUserDto>> Register(RegistrationDto registrationDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                var signedInUser = await _userService.SignUpAsync(registrationDto, _configuration["TokensSettings:Key"],
                    int.Parse(_configuration["TokensSettings:ExpiryMinutes"]));

                return Ok(signedInUser);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        
        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await _userService.SignOutAsync();

            return Ok();
        }
    }
}