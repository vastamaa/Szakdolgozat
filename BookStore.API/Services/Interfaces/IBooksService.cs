using System.Collections.Generic;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.ViewModels;

namespace TestAPI.Services.Implementations
{
    public interface IBooksService
    {
        Task<IEnumerable<BookWithEverythingVM>> GetAllBooksAsync();
        Task<List<BookWithEverythingVM>> GetBooksByGenreAsync(string genreName);
        Task<int> AddBookWithAuthorsAsync(BookVM book);
        Task<Book> UpdateBookAsync(int bookId, BookVM book);
        Task DeleteBookAsync(int bookId);
    }
}