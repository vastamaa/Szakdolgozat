using BookStore.API.DTOs;
using BookStore.API.Models;
using BookStore.API.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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

        [HttpGet("")]
        public async Task<IActionResult> GetAllLanguages()
        {
            return Ok(await _languagesService.GetAllLanguagesAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetLanguageById(int id) { return Ok(await _languagesService.GetLanguageByIdAsync(id)); }

        [HttpPost("")]
        public async Task<IActionResult> AddLanguage([FromBody] LanguageDto language)
        {
            var result = await _languagesService.AddLanguageAsync(language);

            if (result == 0)
            {
                return BadRequest(new ResponseModel { Status = "Error!", Message = "The database already contains a language with this name!" });
            }

            return Ok(new ResponseModel { Status = "Success!", Message = "The language has been successfully added to the database!" });
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateLanguageById(int id, [FromBody] LanguageDto language)
        {
            var result = await _languagesService.UpdateLanguageAsync(id, language);

            if (result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteLanguageById(int id)
        {
            var result = await _languagesService.DeleteLanguageAsync(id);

            if (result > 0)
            {
                return Ok(new ResponseModel { Status = "Success!", Message = "The language has been successfully deleted from the database!" });
            }

            return BadRequest(new ResponseModel { Status = "Error!", Message = "The language has not been deleted from the database!" });
        }
    }
}
