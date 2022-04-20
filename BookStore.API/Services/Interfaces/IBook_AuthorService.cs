using BookStore.API.DTOs;
using BookStore.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.API.Services.Implementations
{
    public interface IBook_AuthorService
    {
        Task<int> AddDataAsync(Book_AuthorDto books_AuthorsDto);
        Task<int> DeleteDataAsync(int id);
        Task<IEnumerable<Book_Author>> GetAllDataAsync();
        Task<Book_Author> GetDataByIdAsync(int id);
        Task<Book_Author> UpdateDataAsync(int id, Book_AuthorDto book_AuthorDto);
    }
}