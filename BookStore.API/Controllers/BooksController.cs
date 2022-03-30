using BookStore.API.Models;
using BookStore.API.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BooksController : ControllerBase
    {
        private readonly IBookServices _bookServices;

        public BooksController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        //GET: /api/books/
        [HttpGet("")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookServices.GetAllBooksAsync();
            return Ok(books);
        }

        //GET: /api/books/id
        //[HttpGet("{id:int}")]
        //public async Task<IActionResult> GetBookById([FromRoute] int id)
        //{
        //    var book = await _bookRepository.GetBookByIdAsync(id);

        //    if (book is null) return NotFound();

        //    return Ok(book);
        //}

        [HttpGet("{name}")]
        public async Task<IActionResult> GetBookById([FromRoute] string name)
        {
            var book = await _bookServices.GetBookByNameAsync(name);

            if (book is null) return NotFound();

            return Ok(book);
        }

        //POST: /api/books/
        [HttpPost("")]
        public async Task<IActionResult> AddBook([FromBody] BookModel bookModel)
        {
            var id = await _bookServices.AddBookAsync(bookModel);

            return CreatedAtAction(nameof(GetBookById), new { id = id, controller = "books" }, id);
        }

        //PUT: /api/books/id
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook([FromBody] BookModel bookModel, [FromRoute] int id)
        {
            await _bookServices.UpdateBookAsync(id, bookModel);
            return Ok();
        }

        //PATCH: /api/books/id
        [HttpPatch("{id:int}")]
        public async Task<IActionResult> UpdateBookPatch([FromBody] JsonPatchDocument bookModel, [FromRoute] int id)
        {
            await _bookServices.UpdateBookPatchAsync(id, bookModel);
            return Ok();
        }

        //DELETE: /api/books/id
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            await _bookServices.DeleteBookAsync(id);
            return Ok();
        }
    }
}
