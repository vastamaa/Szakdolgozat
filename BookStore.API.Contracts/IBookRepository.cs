using BookStore.API.Models;

namespace BookStore.API.Contracts
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges);
        Task<Book> GetBookAsync(Guid bookId, bool trackChanges);
        void CreateBook(Book book);
        void DeleteBook(Book book);
    }
}
