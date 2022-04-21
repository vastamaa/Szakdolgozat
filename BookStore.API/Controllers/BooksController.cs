using BookStore.API.DTOs;
using BookStore.API.Models;
using BookStore.API.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> AddBook([FromBody] BookDto book)
        {
            var result = await _booksService.AddBookWithAuthorsAsync(book);

            if (result == 0)
            {
                return BadRequest(new ResponseModel { Status = "Error!", Message = "The database already contains a book with this name!" });
            }

            return Ok(new ResponseModel { Status = "Success!", Message = "The book has been successfully added to the database!" });
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateBookById(int id, [FromBody] BookDto book)
        {
            var result = await _booksService.UpdateBookAsync(id, book);

            if (result is null)
            {
                return BadRequest(new ResponseModel { Status = "Error!", Message = "The book has not been updated!" });
            }

            return Ok(new ResponseModel { Status = "Success!", Message = "The book has been successfully updated!" });
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteBookById(int id)
        {
            var result = await _booksService.DeleteBookAsync(id);

            if (result > 0)
            {
                return Ok(new ResponseModel { Status = "Success!", Message = "The data is successfully deleted!" });
            }

            return BadRequest(new ResponseModel { Status = "Error!", Message = "Could not delete the data!" });
        }
    }
}
