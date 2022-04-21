using BookStore.API.DTOs;
using BookStore.API.Models;
using BookStore.API.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Books_AuthorsController : ControllerBase
    {
        private readonly IBook_AuthorService _book_AuthorsService;

        public Books_AuthorsController(IBook_AuthorService book_AuthorsService) => _book_AuthorsService = book_AuthorsService;

        [HttpGet("")]
        public async Task<IActionResult> GetAllData() => Ok(await _book_AuthorsService.GetAllDataAsync());

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDataById(int id) => Ok(await _book_AuthorsService.GetDataByIdAsync(id));

        [HttpPost("")]
        public async Task<IActionResult> AddData([FromBody] Book_AuthorDto data)
        {
            var result = await _book_AuthorsService.AddDataAsync(data);

            if (result == 0)
            {
                return BadRequest(new ResponseModel { Status = "Error!", Message = "The database already contains this type of genre!" });
            }

            return Ok(new ResponseModel { Status = "Success!", Message = "The data has been successfully added to the database!" });
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateDataById(int id, [FromBody] Book_AuthorDto data)
        {
            var result = await _book_AuthorsService.UpdateDataAsync(id, data);

            if (result is null)
            {
                return BadRequest(new ResponseModel { Status = "Error!", Message = "The data has not been updated!" });
            }

            return Ok(new ResponseModel { Status = "Success!", Message = "The data has been successfully updated!" });
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteDataById(int id)
        {
            var result = await _book_AuthorsService.DeleteDataAsync(id);

            if (result > 0)
            {
                return Ok(new ResponseModel { Status = "Success!", Message = "The data has been successfully deleted!" });
            }

            return BadRequest(new ResponseModel { Status = "Error!", Message = "Nothing has been deleted!" });
        }
    }
}
