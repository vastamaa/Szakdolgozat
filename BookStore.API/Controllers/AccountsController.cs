using BookStore.API.Models;
using BookStore.API.Repository;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountsController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
            var result = await _accountRepository.RegisterAsync(registerModel);

            if (result is null) return Unauthorized(new Response { Status = "Error", Message = "User already exists!" });

            if (result.Succeeded) return Ok(new Response { Status = "Success", Message = "User created successfully!" });

            return Unauthorized(new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            var result = await _accountRepository.LoginAsync(loginModel);

            if (result is null) return Unauthorized(new Response { Status = "Error", Message = "Login was unsuccessful! Please, try again later." });

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(result),
                expiration = result.ValidTo
            });
        }
    }
}
