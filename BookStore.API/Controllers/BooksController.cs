using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestAPI.Services.Implementations;
using TestAPI.ViewModels;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService bookService)
        {
            _booksService = bookService;
        }

        //GET: /api/books
        [HttpGet("")]
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(await _booksService.GetAllBooksAsync());
        }

        //GET: /api/books/genre
        [HttpGet("{genre}")]
        public async Task<IActionResult> GetBookByGenre([FromRoute] string genre)
        {
            var result = await _booksService.GetBooksByGenreAsync(genre);

            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        //POST: /api/books
        [HttpPost("")]
        public async Task<IActionResult> AddBook([FromBody] BookVM book)
        {
            var result = await _booksService.AddBookWithAuthorsAsync(book);

            if (result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateBookById(int id, [FromBody] BookVM book)
        {
            var result = await _booksService.UpdateBookAsync(id, book);

            if (result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteBookById(int id)
        {
            await _booksService.DeleteBookAsync(id);
            return Ok();
        }
    }
}
