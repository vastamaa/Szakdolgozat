using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestAPI.Services.Implementations;
using TestAPI.ViewModels;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguagesService _languagesService;

        public LanguagesController(ILanguagesService languagesService)
        {
            _languagesService = languagesService;
        }

        [HttpGet("get-all-fucking-language")]
        public async Task<IActionResult> GetAllLanguages()
        {
            return Ok(await _languagesService.GetAllLanguagesAsync());
        }

        [HttpGet("get-a-fucking-language/{id:int}")]
        public async Task<IActionResult> GetLanguageById(int id) { return Ok(await _languagesService.GetLanguageByIdAsync(id)); }

        [HttpPost("add-language")]
        public async Task<IActionResult> AddLanguage([FromBody] LanguageVM language)
        {
            var result = await _languagesService.AddLanguageAsync(language);

            if (result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut("update-language-by-id/{id:int}")]
        public async Task<IActionResult> UpdateLanguageById(int id, [FromBody] LanguageVM language)
        {
            var result = await _languagesService.UpdateLanguageAsync(id, language);

            if (result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpDelete("delete-language-by-id/{id:int}")]
        public async Task<IActionResult> DeleteLanguageById(int id)
        {
            await _languagesService.DeleteLanguageAsync(id);
            return Ok();
        }
    }
}
