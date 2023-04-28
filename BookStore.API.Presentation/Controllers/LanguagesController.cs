using BookStore.API.Presentation.ActionFilters;
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
    public class LanguagesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public LanguagesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        /// <summary>
        /// Endpoint to get all the languages from the database.
        /// </summary>
        /// <returns>Languages wrapped in an action result.</returns>
        [HttpGet]
        public async Task<IActionResult> GetLanguages()
        {
            return Ok(await _serviceManager.LanguageService.GetAllLanguagesAsync(trackChanges: false));
        }

        /// <summary>
        /// Endpoint to get a certain language from the database.
        /// </summary>
        /// <param name="id">The language's identifier.</param>
        /// <returns>A language wrapped in an action result.</returns>
        [HttpGet("{id:guid}", Name = "GetLanguage")]
        public async Task<IActionResult> GetLanguage(Guid id)
        {
            return Ok(await _serviceManager.LanguageService.GetLanguageAsync(id, trackChanges: false));
        }

        /// <summary>
        /// Endpoint to create a new language in the database.
        /// </summary>
        /// <param name="language">The DTO that contains all the needed information regarding the language creation.</param>
        /// <returns>201 -- Successfully created response.</returns>
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateLanguage([FromBody] LanguageForCreationDto language)
        {
            var languageToReturn = await _serviceManager.LanguageService.CreateLanguageAsync(language);

            return CreatedAtRoute(nameof(GetLanguage), new { id = languageToReturn.Id }, languageToReturn);
        }

        /// <summary>
        /// Endpoint to delete a certain language from the database.
        /// </summary>
        /// <param name="id">The language's identifier.</param>
        /// <returns>204 -- No content response.</returns>
        [HttpDelete]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteLanguage(Guid id)
        {
            await _serviceManager.LanguageService.DeleteLanguageAsync(id, trackChanges: false);

            return NoContent();
        }

        /// <summary>
        /// Endpoint to update a certain language in the database.
        /// </summary>
        /// <param name="id">The language's identifier.</param>
        /// <param name="language">The changes, which need to be applied on the resource.</param>
        /// <returns>204 -- No content response.</returns>
        [HttpPut("{id:guid}")]
        [Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateLanguage(Guid id, [FromBody] LanguageForUpdateDto language)
        {
            await _serviceManager.LanguageService.UpdateLanguageAsync(id, language, trackChanges: false);

            return NoContent();
        }
    }
}
