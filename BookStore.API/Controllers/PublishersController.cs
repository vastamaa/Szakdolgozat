using BookStore.API.DTOs;
using BookStore.API.Models;
using BookStore.API.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly IPublishersService _publishersService;

        public PublishersController(IPublishersService publishersService)
        {
            _publishersService = publishersService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllPublishers()
        {
            return Ok(await _publishersService.GetAllPublishersAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPublisherById(int id) { return Ok(await _publishersService.GetPublisherByIdAsync(id)); }

        [HttpPost("")]
        public async Task<IActionResult> AddPublisher([FromBody] PublisherDto publisher)
        {
            var result = await _publishersService.AddPublisherAsync(publisher);

            if (result == 0)
            {
                return BadRequest(new ResponseModel { Status = "Error!", Message = "The database already contains a publisher with this name!" });
            }

            return Ok(new ResponseModel { Status = "Success!", Message = "The publisher has been successfully added to the database!" });
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdatePublisherById(int id, [FromBody] PublisherDto publisher)
        {
            var result = await _publishersService.UpdatePublisherAsync(id, publisher);

            if (result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletePublisherById(int id)
        {
            var result = await _publishersService.DeletePublisherAsync(id);

            if (result > 0)
            {
                return Ok(new ResponseModel { Status = "Success!", Message = "The publisher has been successfully deleted from the database!" });
            }

            return BadRequest(new ResponseModel { Status = "Error!", Message = "The publisher has not been deleted from the database!" });
        }
    }
}
