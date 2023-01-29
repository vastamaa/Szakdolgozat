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

            _repository.Genre.CreateGenre(genreEntity);
            await _repository.SaveAsync();

            return _mapper.Map<GenreDto>(genreEntity);
        }

        public async Task DeleteGenreAsync(Guid genreId, bool trackChanges)
        {
            var genreForCompany = await GetGenreAndCheckIfItExists(genreId, trackChanges);

            _repository.Genre.DeleteGenre(genreForCompany);
            await _repository.SaveAsync();
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
            await _repository.SaveAsync();
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
            await _repository.SaveAsync();
        }

        private async Task<Genre> GetGenreAndCheckIfItExists(Guid genreId, bool trackChanges)
        {
            var genre = await _repository.Genre.GetGenreAsync(genreId, trackChanges);

            if (genre is null)
            {
                throw new GenreNotFoundException(genreId);
            }

#pragma warning disable CS8603 // Possible null reference return.
            return genre;
#pragma warning restore CS8603 // Possible null reference return.
        }

        private async Task CheckIfGenreExists(Guid genreId, bool trackChanges)
        {
            var genre = await _repository.Genre.GetGenreAsync(genreId, trackChanges);

            if (genre is null)
            {
                throw new GenreNotFoundException(genreId);
            }
        }
    }
}
