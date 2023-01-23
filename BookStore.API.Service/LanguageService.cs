using AutoMapper;
using BookStore.API.Contracts;
using BookStore.API.Service.Contracts;
using BookStore.API.Shared.DataTransferObjects;

namespace BookStore.API.Service
{
    public class LanguageService : ILanguageService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public LanguageService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public Task<LanguageDto> CreateLanguageAsync(LanguageForCreationDto language)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLanguageAsync(Guid languageId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LanguageDto>> GetAllLanguagesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<LanguageDto> GetLanguageAsync(Guid languageId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLanguageAsync(Guid languageId, LanguageForUpdateDto languageForUpdate, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
