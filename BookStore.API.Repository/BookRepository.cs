using BookStore.API.Contracts;
using BookStore.API.Entities.Models;

namespace BookStore.API.Repository
{
    public class BookRepository : IBookRepository
    {
        public void CreateBook(Book author)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Book author)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookAsync(Guid bookId, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
