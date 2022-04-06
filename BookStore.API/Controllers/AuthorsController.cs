using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestAPI.Services.Implementations;
using TestAPI.ViewModels;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorsService _authorsService;

        public AuthorsController(IAuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpGet("get-all-fucking-authors")]
        public async Task<IActionResult> GetAllAuthors()
        {
            return Ok(await _authorsService.GetAllAuthorsAsync());
        }

        [HttpGet("get-a-fucking-author/{id:int}")]
        public async Task<IActionResult> GetAuthorById(int id) { return Ok(await _authorsService.GetAuthorByIdAsync(id)); }

        [HttpPost("add-author")]
        public async Task<IActionResult> AddAuthor([FromBody] AuthorVM author)
        {
            var result = await _authorsService.AddAuthorAsync(author);

            if (result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut("update-author-by-id/{id:int}")]
        public async Task<IActionResult> UpdateAuthorById(int id, [FromBody] AuthorVM author)
        {
            var result = await _authorsService.UpdateAuthorAsync(id, author);

            if (result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpDelete("delete-author-by-id/{id:int}")]
        public async Task<IActionResult> DeleteAuthorById(int id)
        {
            await _authorsService.DeleteAuthorAsync(id);
            return Ok();
        }
    }
}
