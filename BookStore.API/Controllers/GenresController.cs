using BookStore.API.DTOs;
using BookStore.API.Models;
using BookStore.API.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenresService _genresService;

        public GenresController(IGenresService genresService)
        {
            _genresService = genresService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllStudents()
        {
            return Ok(await _genresService.GetAllGenresAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetGenresById(int id) { return Ok(await _genresService.GetGenreByIdAsync(id)); }

        [HttpPost("")]
        public async Task<IActionResult> AddGenre([FromBody] GenreDto genre)
        {
            var result = await _genresService.AddGenreAsync(genre);

            if (result == 0)
            {
                return BadRequest(new ResponseModel { Status = "Error!", Message = "The database already contains this type of genre!" });
            }

            return Ok(new ResponseModel { Status = "Success!", Message = "The genre has been successfully added to the database!" });
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateGenreById(int id, [FromBody] GenreDto genre)
        {
            var result = await _genresService.UpdateGenreAsync(id, genre);

            if (result is null)
            {
                return BadRequest(new ResponseModel { Status = "Error!", Message = "The genre has not been updated!" });
            }

            return Ok(new ResponseModel { Status = "Success!", Message = "The genre has been successfully updated!" });
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteGenreById(int id)
        {
            var result = await _genresService.DeleteGenreAsync(id);

            if (result > 0)
            {
                return Ok(new ResponseModel { Status = "Success!", Message = "The data has been successfully deleted!" });
            }

            return BadRequest(new ResponseModel { Status = "Error!", Message = "Nothing has been deleted!" });
        }
    }
}
