using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestAPI.Services.Implementations;
using TestAPI.ViewModels;

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

        [HttpGet("get-all-fucking-publishers")]
        public async Task<IActionResult> GetAllPublishers()
        {
            return Ok(await _publishersService.GetAllPublishersAsync());
        }

        [HttpGet("get-a-fucking-publisher/{id:int}")]
        public async Task<IActionResult> GetPublisherById(int id) { return Ok(await _publishersService.GetPublisherByIdAsync(id)); }

        [HttpPost("add-publisher")]
        public async Task<IActionResult> AddPublisher([FromBody] PublisherVM publisher)
        {
            var result = await _publishersService.AddPublisherAsync(publisher);

            if (result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut("update-publisher-by-id/{id:int}")]
        public async Task<IActionResult> UpdatePublisherById(int id, [FromBody] PublisherVM publisher)
        {
            var result = await _publishersService.UpdatePublisherAsync(id, publisher);

            if (result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpDelete("delete-publisher-by-id/{id:int}")]
        public async Task<IActionResult> DeletePublisherById(int id)
        {
            await _publishersService.DeletePublisherAsync(id);
            return Ok();
        }
    }
}
