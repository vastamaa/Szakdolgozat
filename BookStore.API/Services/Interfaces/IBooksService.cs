using BookStore.API.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.API.Models;

namespace BookStore.API.Services.Implementations
{
    public interface IBooksService
    {
        Task<IEnumerable<BookWithEverythingDto>> GetAllBooksAsync();
        Task<List<BookWithEverythingDto>> GetBooksByGenreAsync(string genreName);
        Task<int> AddBookWithAuthorsAsync(BookDto book);
        Task<Book> UpdateBookAsync(int bookId, BookDto book);
        Task DeleteBookAsync(int bookId);
    }
}