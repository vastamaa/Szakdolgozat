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
        private readonly IAccountService _accountService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMailService _mailService;

        public AccountsController(IAccountService accountService, UserManager<ApplicationUser> userManager, IMailService mailService)
        {
            _accountService = accountService;
            _userManager = userManager;
            _mailService = mailService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
            var result = await _accountService.RegisterAsync(registerModel);

            if (result is null) return Unauthorized(new ResponseModel { Status = "Error", Message = "User already exists!" });

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
                    protocol: Request.Scheme);

                await _mailService.SendEmailAsync(new MailStructureModel() { ToEmail = registerModel.Email, Subject = "Confirmation email link", Body = confirmationLink });

                return Ok(new ResponseModel { Status = "Success", Message = "User created successfully!" });
            }

            return Unauthorized(new ResponseModel { Status = "Error", Message = "User creation failed! Please check user details and try again." });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            var result = await _accountService.LoginAsync(loginModel);

            if (result is null) return Unauthorized(new ResponseModel { Status = "Error", Message = "Login failed! The username or password is incorrect." });

            return Ok(new
            {
                Token = result[0].Token,
                RefreshToken = result[0].RefreshToken,
                Expiration = result[0].Expiration
            });
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] PasswordResetModel passwordResetModel)
        {
            var result = _accountService.ResetPasswordAsync(passwordResetModel.Email);
            Console.WriteLine(result.Result);
            if (result.Result is not null)
            {
                await _mailService.SendEmailAsync(new MailStructureModel() { ToEmail = passwordResetModel.Email, Subject = "Your new password", Body = $"Your new password is: {result.Result}" });
                return Ok(new ResponseModel { Status = "Success", Message = "Password reset has been successful!" });
            } 

            return BadRequest(new ResponseModel { Status = "Error", Message = "Password reset has failed! Please try again later." });
        }
    }
}
