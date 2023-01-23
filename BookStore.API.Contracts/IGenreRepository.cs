using BookStore.API.Entities.Models;

namespace BookStore.API.Contracts
{
    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> GetAllGenresAsync(bool trackChanges);
        Task<Genre> GetGenreAsync(Guid genreId, bool trackChanges);
        void CreateGenre(Genre genre);
        void DeleteGenre(Genre genre);
    }
}
