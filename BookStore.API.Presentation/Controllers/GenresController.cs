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
    public class GenresController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public GenresController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        /// <summary>
        /// Endpoint to get all the genres from the database.
        /// </summary>
        /// <returns>Genres wrapped in an action result.</returns>
        [HttpGet]
        public async Task<IActionResult> GetGenres()
        {
            return Ok(await _serviceManager.GenreService.GetAllGenresAsync(trackChanges: false));
        }

        /// <summary>
        /// Endpoint to get a certain genre from the database.
        /// </summary>
        /// <param name="genreId">The genre's identifier.</param>
        /// <returns>A genre wrapped in an action result.</returns>
        [HttpGet("{id:guid}", Name = "GetGenre")]
        public async Task<IActionResult> GetGenre(Guid genreId)
        {
            return Ok(await _serviceManager.GenreService.GetGenreAsync(genreId, trackChanges: false));
        }

        /// <summary>
        /// Endpoint to create a new genre in the database.
        /// </summary>
        /// <param name="genre">Information regarding the genre creation.</param>
        /// <returns>201 -- Successfully created response.</returns>
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateGenre([FromBody] GenreForCreationDto genre)
        {
            var genreToReturn = await _serviceManager.GenreService.CreateGenreAsync(genre);

            return CreatedAtRoute(nameof(GetGenre), new { id = genreToReturn.Id }, genreToReturn);
        }

        /// <summary>
        /// Endpoint to delete a certain genre from the database.
        /// </summary>
        /// <param name="genreId">The genre's identifier.</param>
        /// <returns>204 -- No content response.</returns>
        [HttpDelete]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteGenre(Guid genreId)
        {
            await _serviceManager.GenreService.DeleteGenreAsync(genreId, trackChanges: false);

            return NoContent();
        }

        /// <summary>
        /// Endpoint to update a certain genre in the database.
        /// </summary>
        /// <param name="genreId">The genre's identifier.</param>
        /// <param name="genre">The changes, which need to be applied on the resource.</param>
        /// <returns>204 -- No content response.</returns>
        [HttpPut("{id:guid}")]
        [Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateGenre(Guid genreId, [FromBody] GenreForUpdateDto genre)
        {
            await _serviceManager.GenreService.UpdateGenreAsync(genreId, genre, trackChanges: false);

            return NoContent();
        }
    }
}
