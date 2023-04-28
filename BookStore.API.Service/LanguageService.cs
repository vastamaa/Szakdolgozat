using AutoMapper;
using BookStore.API.Contracts;
using BookStore.API.Entities.Exceptions;
using BookStore.API.Models;
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

        public async Task<LanguageDto> CreateLanguageAsync(LanguageForCreationDto language)
        {
            var languageEntity = _mapper.Map<Language>(language);

            _logger.LogInfo($"Creating language (ID: {languageEntity.Id}).");
            _repository.Language.CreateLanguage(languageEntity);

            await SaveChangesAsync();

            return _mapper.Map<LanguageDto>(languageEntity);
        }

        public async Task DeleteLanguageAsync(Guid languageId, bool trackChanges)
        {
            var languageForBook = await GetLanguageAndCheckIfItExists(languageId, trackChanges);

            _logger.LogInfo($"Getting language with ID: {languageId}).");
            _repository.Language.DeleteLanguage(languageForBook);
            await SaveChangesAsync();
        }

        public async Task<IEnumerable<LanguageDto>> GetAllLanguagesAsync(bool trackChanges)
        {
            _logger.LogInfo($"Getting all languages!");
            var languagesFromDb = await _repository.Language.GetAllLanguagesAsync(trackChanges);

            return _mapper.Map<IEnumerable<LanguageDto>>(languagesFromDb);
        }

        public async Task<LanguageDto> GetLanguageAsync(Guid languageId, bool trackChanges)
        {
            _logger.LogInfo($"Getting language with ID: {languageId}");
            var languageFromDb = await GetLanguageAndCheckIfItExists(languageId, trackChanges);

            return _mapper.Map<LanguageDto>(languageFromDb);
        }

        public async Task UpdateLanguageAsync(Guid languageId, LanguageForUpdateDto languageForUpdate, bool trackChanges)
        {
            await CheckIfLanguageExists(languageId, trackChanges);

            var languageEntity = await GetLanguageAndCheckIfItExists(languageId, trackChanges);

            _mapper.Map(languageForUpdate, languageEntity);
            await SaveChangesAsync();
        }

        public async Task<(LanguageForUpdateDto languageToPatch, Language languageEntity)> GetLanguageForPatchAsync(Guid languageId, bool trackChanges)
        {
            await CheckIfLanguageExists(languageId, trackChanges);

            var languageEntity = await GetLanguageAndCheckIfItExists(languageId, trackChanges);

            var languageToPatch = _mapper.Map<LanguageForUpdateDto>(languageEntity);

            return (languageToPatch: languageToPatch, languageEntity: languageEntity);
        }

        public async Task SaveChangesForPatchAsync(LanguageForUpdateDto languageToPatch, Language languageEntity)
        {
            _mapper.Map(languageToPatch, languageEntity);
            await SaveChangesAsync();
        }

        private async Task<Language> GetLanguageAndCheckIfItExists(Guid languageId, bool trackChanges)
        {
            _logger.LogInfo($"Getting language with ID: {languageId}.");
            var language = await _repository.Language.GetLanguageAsync(languageId, trackChanges);

            if (language is null)
            {
                _logger.LogError($"Error: Genre with ID: {languageId} NOT FOUND!");
                throw new LanguageNotFoundException(languageId);
            }

            return language;
        }

        private async Task CheckIfLanguageExists(Guid languageId, bool trackChanges)
        {
            _logger.LogInfo($"Checking if genre with ID: {languageId} exists.");
            var language = await _repository.Genre.GetGenreAsync(languageId, trackChanges);

            if (language is null)
            {
                _logger.LogError($"Error: Genre with ID: {languageId} NOT FOUND!");
                throw new LanguageNotFoundException(languageId);
            }
        }

        private async Task SaveChangesAsync()
        {
            _logger.LogInfo($"{this} is under saving!");
            await _repository.SaveAsync();
        }
    }
}
