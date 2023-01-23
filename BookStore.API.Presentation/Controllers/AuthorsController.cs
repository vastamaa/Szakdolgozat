using BookStore.API.Presentation.ActionFIlters;
using BookStore.API.Service.Contracts;
using BookStore.API.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Presentation.Controllers
{
    [ExcludeFromCodeCoverage]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AuthorsController(IServiceManager service)
        {
            _service = service;
        }

        //GET ALL
        [HttpGet]
        public async Task<IActionResult> GetLanguages()
        {
            return Ok(await _service.LanguageService.GetAllLanguagesAsync(trackChanges: false));
        }

        //GET BY ID
        [HttpGet("{id:guid}", Name = "GetLanguage")]
        public async Task<IActionResult> GetLanguage(Guid languageId)
        {
            return Ok(await _service.LanguageService.GetLanguageAsync(languageId, trackChanges: false));
        }

        //POST
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateLanguage([FromBody] LanguageForCreationDto language)
        {
            var languageToReturn = await _service.LanguageService.CreateLanguageAsync(language);

            return CreatedAtRoute(nameof(GetLanguage), new { id = languageToReturn.Id }, languageToReturn);
        }

        //DELETE
        [HttpDelete]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteLanguage(Guid id)
        {
            await _service.LanguageService.DeleteLanguageAsync(id, trackChanges: false);

            return NoContent();
        }

        //PUT
        [HttpPut("{id:guid}")]
        [Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateLanguage(Guid id, [FromBody] LanguageForUpdateDto language)
        {
            await _service.LanguageService.UpdateLanguageAsync(id, language, trackChanges: false);

            return NoContent();
        }
    }
}
