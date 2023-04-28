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
    public class AuthorsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AuthorsController(IServiceManager service)
        {
            _service = service;
        }

        /// <summary>
        /// Endpoint to get all the authors from the database.
        /// </summary>
        /// <returns>Authors wrapped in an action result.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            return Ok(await _service.AuthorService.GetAllAuthorsAsync(trackChanges: false));
        }

        /// <summary>
        /// Endpoint to get a certain author from the database.
        /// </summary>
        /// <param name="authorId">The author's identifier.</param>
        /// <returns>Author wrapped in an action result.</returns>
        [HttpGet("{id:guid}", Name = "GetAuthor")]
        public async Task<IActionResult> GetAuthor(Guid authorId)
        {
            return Ok(await _service.AuthorService.GetAuthorAsync(authorId, trackChanges: false));
        }

        /// <summary>
        /// Endpoint to create a new author in the database.
        /// </summary>
        /// <param name="author">Information regarding the author creation.</param>
        /// <returns>201 -- Successfully created response.</returns>
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateAuthor([FromBody] AuthorForCreationDto author)
        {
            var authorToReturn = await _service.AuthorService.CreateAuthorAsync(author);

            return CreatedAtRoute(nameof(GetAuthor), new { id = authorToReturn.Id }, authorToReturn);
        }

        /// <summary>
        /// Endpoint to delete a certain resource from the database.
        /// </summary>
        /// <param name="id">The resource's identifier.</param>
        /// <returns>204 -- No content response.</returns>
        [HttpDelete]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteAuthor(Guid id)
        {
            await _service.AuthorService.DeleteAuthorAsync(id, trackChanges: false);

            return NoContent();
        }

        //PUT
        [HttpPut("{id:guid}")]
        [Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateAuthor(Guid id, [FromBody] AuthorForUpdateDto author)
        {
            await _service.AuthorService.UpdateAuthorAsync(id, author, trackChanges: false);

            return NoContent();
        }
    }
}
