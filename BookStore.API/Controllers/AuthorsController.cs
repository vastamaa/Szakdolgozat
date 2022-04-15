using BookStore.API.Models;
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

        [HttpGet("")]
        public async Task<IActionResult> GetAllAuthors()
        {
            return Ok(await _authorsService.GetAllAuthorsAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAuthorById(int id) { return Ok(await _authorsService.GetAuthorByIdAsync(id)); }

        [HttpPost("")]
        public async Task<IActionResult> AddAuthor([FromBody] AuthorVM author)
        {
            var result = await _authorsService.AddAuthorAsync(author);

            if (result == 0)
            {
                return BadRequest(new ResponseModel { Status = "Error!", Message = "The database already contains an author with this name!" });
            }

            return Ok(new ResponseModel { Status = "Success!", Message = "The author has been successfully added to the database!" });
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateAuthorById(int id, [FromBody] AuthorVM author)
        {
            var result = await _authorsService.UpdateAuthorAsync(id, author);

            if (result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAuthorById(int id)
        {
            var result = await _authorsService.DeleteAuthorAsync(id);

            if (result > 0)
            {
                return Ok(new ResponseModel { Status = "Success!", Message = "The author has been successfully added to the database!" });
            }

            return BadRequest(new ResponseModel { Status = "Error!", Message = "The database already contains an author with this name!" });
        }
    }
}
