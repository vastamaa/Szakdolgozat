using BookStore.API.Presentation.ActionFilters;
using BookStore.API.Service.Contracts;
using BookStore.API.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Presentation.Controllers
{
    [ExcludeFromCodeCoverage]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public AuthenticationController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost("register")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            var result = await _serviceManager.AuthenticationService.RegisterUser(userForRegistration);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }

        [HttpPost("login")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> AuthenticateUser([FromBody] UserForAuthenticationDto userForAuthentication)
        {
            if (!await _serviceManager.AuthenticationService.ValidateUser(userForAuthentication))
            {
                return Unauthorized();
            }

            var tokenDto = await _serviceManager.AuthenticationService.CreateToken(populateExpiration: true);

            return Ok(tokenDto);
        }
    }
}
