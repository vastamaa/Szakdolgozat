using BookStore.API.DTOs;
using BookStore.API.Models;
using BookStore.API.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> AddAuthor([FromBody] AuthorDto author)
        {
            var result = await _authorsService.AddAuthorAsync(author);

            if (result == 0)
            {
                return BadRequest(new ResponseModel { Status = "Error!", Message = "The database already contains an author with this name!" });
            }

            return Ok(new ResponseModel { Status = "Success!", Message = "The author has been successfully added to the database!" });
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateAuthorById(int id, [FromBody] AuthorDto author)
        {
            var result = await _authorsService.UpdateAuthorAsync(id, author);

            if (result is null)
            {
                return BadRequest(new ResponseModel { Status = "Error!", Message = "The author has not been updated!" });
            }

            return Ok(new ResponseModel { Status = "Success!", Message = "The author has been successfully updated!" });
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAuthorById(int id)
        {
            var result = await _authorsService.DeleteAuthorAsync(id);

            if (result > 0)
            {
                return Ok(new ResponseModel { Status = "Success!", Message = "The data has been successfully deleted!" });
            }

            return BadRequest(new ResponseModel { Status = "Error!", Message = "Nothing has been deleted!" });
        }
    }
}
