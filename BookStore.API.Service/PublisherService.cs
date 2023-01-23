using AutoMapper;
using BookStore.API.Contracts;
using BookStore.API.Service.Contracts;
using BookStore.API.Shared.DataTransferObjects;

namespace BookStore.API.Service
{
    public class PublisherService : IPublisherService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PublisherService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public Task<PublisherDto> CreatePublisherAsync(PublisherForCreationDto genre)
        {
            throw new NotImplementedException();
        }

        public Task DeletePublisherAsync(Guid publisherId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PublisherDto>> GetAllPublishersAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<PublisherDto> GetPublisherAsync(Guid publisherId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePublisherAsync(Guid publisherId, PublisherForUpdateDto publisherForUpdate, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
