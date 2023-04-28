using AutoMapper;
using BookStore.API.Contracts;
using BookStore.API.Entities.Exceptions;
using BookStore.API.Models;
using BookStore.API.Service.Contracts;
using BookStore.API.Shared.DataTransferObjects;

namespace BookStore.API.Service
{
    public class GenreService : IGenreService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public GenreService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<GenreDto> CreateGenreAsync(GenreForCreationDto genre)
        {
            var genreEntity = _mapper.Map<Genre>(genre);

            _logger.LogInfo($"Creating genre (ID: {genreEntity.Id}).");
            _repository.Genre.CreateGenre(genreEntity);
            await SaveChangesAsync();

            return _mapper.Map<GenreDto>(genreEntity);
        }

        public async Task DeleteGenreAsync(Guid genreId, bool trackChanges)
        {
            var genreForBook = await GetGenreAndCheckIfItExists(genreId, trackChanges);

            _logger.LogInfo($"Deleting genre (ID: {genreId}).");
            _repository.Genre.DeleteGenre(genreForBook);
            await SaveChangesAsync();
        }

        public async Task<IEnumerable<GenreDto>> GetAllGenresAsync(bool trackChanges)
        {
            var genresFromDb = await _repository.Genre.GetAllGenresAsync(trackChanges);

            return _mapper.Map<IEnumerable<GenreDto>>(genresFromDb);
        }

        public async Task<GenreDto> GetGenreAsync(Guid genreId, bool trackChanges)
        {
            var genreFromDb = await GetGenreAndCheckIfItExists(genreId, trackChanges);

            return _mapper.Map<GenreDto>(genreFromDb);
        }

        public async Task UpdateGenreAsync(Guid genreId, GenreForUpdateDto genreForUpdate, bool trackChanges)
        {
            await CheckIfGenreExists(genreId, trackChanges);

            var genreEntity = await GetGenreAndCheckIfItExists(genreId, trackChanges);

            _mapper.Map(genreForUpdate, genreEntity);
            await SaveChangesAsync();
        }

        public async Task<(GenreForUpdateDto genreToPatch, Genre genreEntity)> GetGenreForPatchAsync(Guid genreId, bool trackChanges)
        {
            await CheckIfGenreExists(genreId, trackChanges);

            var genreEntity = await GetGenreAndCheckIfItExists(genreId, trackChanges);

            var genreToPatch = _mapper.Map<GenreForUpdateDto>(genreEntity);

            return (genreToPatch: genreToPatch, genreEntity: genreEntity);
        }

        public async Task SaveChangesForPatchAsync(GenreForUpdateDto genreToPatch, Genre genreEntity)
        {
            _mapper.Map(genreToPatch, genreEntity);
            await SaveChangesAsync();
        }

        private async Task<Genre> GetGenreAndCheckIfItExists(Guid genreId, bool trackChanges)
        {
            _logger.LogInfo($"Getting genre with ID: {genreId}.");
            var genre = await _repository.Genre.GetGenreAsync(genreId, trackChanges);

            if (genre is null)
            {
                _logger.LogError($"Error: Genre with ID: {genreId} NOT FOUND!");
                throw new GenreNotFoundException(genreId);
            }

            return genre;
        }

        private async Task CheckIfGenreExists(Guid genreId, bool trackChanges)
        {
            _logger.LogInfo($"Checking if genre with ID: {genreId} exists.");
            var genre = await _repository.Genre.GetGenreAsync(genreId, trackChanges);

            if (genre is null)
            {
                _logger.LogError($"Error: Genre with ID: {genreId} NOT FOUND!");
                throw new GenreNotFoundException(genreId);
            }
        }

        private async Task SaveChangesAsync()
        {
            _logger.LogInfo($"{this} is under saving!");
            await _repository.SaveAsync();
        }
    }
}
