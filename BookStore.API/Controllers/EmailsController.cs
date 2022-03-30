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
        private readonly UserManager<ApplicationUserModel> _userManager;

        public EmailsController(UserManager<ApplicationUserModel> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("")]
        public async Task<IActionResult> ConfirmEmail(string emailTokenHtmlVersion, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            var decodedToken = HttpUtility.UrlDecode(emailTokenHtmlVersion);

            if (user == null)
            {
                return NotFound(new ResponseModel { Status = "Error", Message = "An error occurred while processing your request!" });
            }

            var result = await _userManager.ConfirmEmailAsync(user, decodedToken);
            return Ok(result);
        }
    }
}
