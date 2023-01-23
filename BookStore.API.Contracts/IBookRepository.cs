using BookStore.API.Entities.Models;

namespace BookStore.API.Contracts
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges);
        Task<Book> GetBookAsync(Guid bookId, bool trackChanges);
        void CreateBook(Book author);
        void DeleteBook(Book author);
    }
}
