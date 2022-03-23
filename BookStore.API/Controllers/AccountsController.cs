using BookStore.API.Models;
using BookStore.API.Repository;
using BookStore.API.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Web;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMailService _mailService;

        public AccountsController(IAccountRepository accountRepository, UserManager<ApplicationUser> userManager, IMailService mailService)
        {
            _accountRepository = accountRepository;
            _userManager = userManager;
            _mailService = mailService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
            var result = await _accountRepository.RegisterAsync(registerModel);

            if (result is null) return Unauthorized(new Response { Status = "Error", Message = "User already exists!" });

            if (result.result.Succeeded)
            {
                var controllerName = nameof(EmailsController);
                var controller = controllerName.Remove(
                    controllerName.LastIndexOf(
                        "Controller",
                        StringComparison.Ordinal));
                var emailTokenHtmlVersion = HttpUtility.UrlEncode(result.emailToken);

                var confirmationLink = Url.Action(
                    nameof(EmailsController.ConfirmEmail),
                    controller,
                    new { emailTokenHtmlVersion, email = registerModel.Email },
                    Request.Scheme);

                await _mailService.SendEmailAsync(new MailStructure() { ToEmail = registerModel.Email, Subject = "Confirmation email link", Body = confirmationLink });

                return Ok(new Response { Status = "Success", Message = "User created successfully!" });
            }

            return Unauthorized(new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            var result = await _accountRepository.LoginAsync(loginModel);

            if (result is null) return Unauthorized(new Response { Status = "Error", Message = "Login failed! The username or password is incorrect." });

            return Ok(new
            {
                Token = result[0].Token,
                RefreshToken = result[0].RefreshToken,
                Expiration = result[0].Expiration
            });
        }
    }
}
