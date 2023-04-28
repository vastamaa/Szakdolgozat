using BookStore.API.Presentation.ActionFilters;
using BookStore.API.Service.Contracts;
using BookStore.API.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Presentation.Controllers
{
    [ExcludeFromCodeCoverage]
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public PublishersController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        /// <summary>
        /// Endpoint to get all the publishers from the database.
        /// </summary>
        /// <returns>Publishers wrapped in an action result.</returns>
        [HttpGet]
        public async Task<IActionResult> GetPublishers()
        {
            return Ok(await _serviceManager.PublisherService.GetAllPublishersAsync(trackChanges: false));
        }

        /// <summary>
        /// Endpoint to get a certain publisher from the database.
        /// </summary>
        /// <param name="genreId">The publisher's identifier.</param>
        /// <returns>A publisher wrapped in an action result.</returns>
        [HttpGet("{id:guid}", Name = "GetPublisher")]
        public async Task<IActionResult> GetPublisher(Guid publisherId)
        {
            return Ok(await _serviceManager.PublisherService.GetPublisherAsync(publisherId, trackChanges: false));
        }

        /// <summary>
        /// Endpoint to create a new publisher in the database.
        /// </summary>
        /// <param name="publisher">The DTO that contains all the needed information regarding the publisher creation.</param>
        /// <returns>201 -- Successfully created response.</returns>
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreatePublisher([FromBody] PublisherForCreationDto publisher)
        {
            var publisherToReturn = await _serviceManager.PublisherService.CreatePublisherAsync(publisher);

            return CreatedAtRoute(nameof(GetPublisher), new { id = publisherToReturn.Id }, publisherToReturn);
        }

        /// <summary>
        /// Endpoint to delete a certain publisher from the database.
        /// </summary>
        /// <param name="publisherId">The publisher's identifier.</param>
        /// <returns>204 -- No content response.</returns>
        [HttpDelete]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeletePublisher(Guid publisherId)
        {
            await _serviceManager.PublisherService.DeletePublisherAsync(publisherId, trackChanges: false);

            return NoContent();
        }

        /// <summary>
        /// Endpoint to update a certain publisher in the database.
        /// </summary>
        /// <param name="publisherId">The publisher's identifier.</param>
        /// <param name="publisher">The changes, which need to be applied on the resource.</param>
        /// <returns>204 -- No content response.</returns>
        [HttpPut("{id:guid}")]
        [Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdatePublisher(Guid publisherId, [FromBody] PublisherForUpdateDto publisher)
        {
            await _serviceManager.PublisherService.UpdatePublisherAsync(publisherId, publisher, trackChanges: false);

            return NoContent();
        }
    }
}
