using BookStore.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Web;

namespace BookStore.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public EmailsController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("")]
        public async Task<IActionResult> ConfirmEmail(string emailTokenHtmlVersion, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return NotFound(new Response { Status = "Error", Message = "An error occurred while processing your request!" });
            }

            //Invalid email confirmation token -- NEEDS FIXING!!!

            var result = await _userManager.ConfirmEmailAsync(user, emailTokenHtmlVersion);
            return Ok(result);
        }
    }
}
