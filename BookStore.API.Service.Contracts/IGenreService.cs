using BookStore.API.Shared.DataTransferObjects;

namespace BookStore.API.Service.Contracts
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreDto>> GetAllGenresAsync(bool trackChanges);
        Task<GenreDto> GetGenreAsync(Guid genreId, bool trackChanges);
        Task<GenreDto> CreateGenreAsync(GenreForCreationDto genre);
        Task DeleteGenreAsync(Guid genreId, bool trackChanges);
        Task UpdateGenreAsync(Guid genreId, GenreForUpdateDto genreForUpdate, bool trackChanges);
    }
}
