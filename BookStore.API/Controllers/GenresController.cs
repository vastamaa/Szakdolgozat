using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestAPI.Services.Implementations;
using TestAPI.ViewModels;

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

        [HttpGet("get-all-fucking-genres")]
        public async Task<IActionResult> GetAllStudents()
        {
            return Ok(await _genresService.GetAllGenresAsync());
        }

        [HttpGet("get-a-fuckig-genre/{id:int}")]
        public async Task<IActionResult> GetGenresById(int id) { return Ok(await _genresService.GetGenreByIdAsync(id)); }

        [HttpPost("add-genre")]
        public async Task<IActionResult> AddBook([FromBody] GenreVM genre)
        {
            var result = await _genresService.AddGenreAsync(genre);

            if (result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut("update-genre-by-id/{id:int}")]
        public async Task<IActionResult> UpdateGenreById(int id, [FromBody] GenreVM genre)
        {
            var result = await _genresService.UpdateGenreAsync(id, genre);

            if (result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpDelete("delete-genre-by-id/{id:int}")]
        public async Task<IActionResult> DeleteGenreById(int id)
        {
            await _genresService.DeleteGenreAsync(id);
            return Ok();
        }
    }
}
