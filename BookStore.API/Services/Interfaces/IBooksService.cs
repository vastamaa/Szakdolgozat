using BookStore.API.DTOs;
using BookStore.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.API.Services.Implementations
{
    public interface IBooksService
    {
        Task<IEnumerable<BookWithEverythingDto>> GetAllBooksAsync();
        Task<List<BookWithEverythingDto>> GetBooksByGenreAsync(string genreName);
        Task<int> AddBookWithAuthorsAsync(BookDto book);
        Task<Book> UpdateBookAsync(int bookId, BookDto book);
        Task<int> DeleteBookAsync(int bookId);
    }
}