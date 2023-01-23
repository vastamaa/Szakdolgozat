using BookStore.API.Shared.DataTransferObjects;

namespace BookStore.API.Service.Contracts
{
    public interface IPublisherService
    {
        Task<IEnumerable<PublisherDto>> GetAllPublishersAsync(bool trackChanges);
        Task<PublisherDto> GetPublisherAsync(Guid publisherId, bool trackChanges);
        Task<PublisherDto> CreatePublisherAsync(PublisherForCreationDto genre);
        Task DeletePublisherAsync(Guid publisherId, bool trackChanges);
        Task UpdatePublisherAsync(Guid publisherId, PublisherForUpdateDto publisherForUpdate, bool trackChanges);
    }
}
