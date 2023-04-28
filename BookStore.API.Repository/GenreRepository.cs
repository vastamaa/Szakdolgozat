using BookStore.API.Contracts;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Repository
{
    public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {
        public GenreRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreateGenre(Genre genre)
        {
            Create(genre);
        }

        public void DeleteGenre(Genre genre)
        {
            Delete(genre);
        }

        public async Task<IEnumerable<Genre>> GetAllGenresAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<Genre> GetGenreAsync(Guid id, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        }
    }
}
