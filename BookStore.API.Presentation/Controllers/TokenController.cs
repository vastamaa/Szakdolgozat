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
    public class TokenController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public TokenController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost("refresh")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto)
        {
            return Ok(await _serviceManager.AuthenticationService.RefreshToken(tokenDto));
        }
    }
}
