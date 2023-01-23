using BookStore.API.Contracts;
using BookStore.API.Entities.Models;

namespace BookStore.API.Repository
{
    public class GenreRepository : IGenreRepository
    {
        public void CreateGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public void DeleteGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Genre>> GetAllGenresAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> GetGenreAsync(Guid genreId, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
