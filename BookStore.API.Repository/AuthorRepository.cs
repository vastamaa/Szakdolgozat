using BookStore.API.Contracts;
using BookStore.API.Entities.Models;

namespace BookStore.API.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        public void CreateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Author>> GetAllAuthorsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetAuthorAsync(Guid authorId, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
