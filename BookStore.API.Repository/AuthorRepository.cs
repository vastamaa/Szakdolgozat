using BookStore.API.Contracts;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Repository
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreateAuthor(Author author)
        {
            Create(author);
        }

        public void DeleteAuthor(Author author)
        {
            Delete(author);
        }

        public async Task<IEnumerable<Author>> GetAllAuthorsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(a => a).ToListAsync();
        }

        public async Task<Author> GetAuthorAsync(Guid id, bool trackChanges)
        {
            return await FindByCondition(a => a.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
        }
    }
}
