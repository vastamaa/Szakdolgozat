using BookStore.API.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.API.Models;

namespace BookStore.API.Services.Implementations
{
    public interface IAuthorsService
    {
        Task<int> AddAuthorAsync(AuthorDto author);
        Task<int> DeleteAuthorAsync(int authorId);
        Task<IEnumerable<Author>> GetAllAuthorsAsync();
        Task<Author> GetAuthorByIdAsync(int authorId);
        Task<Author> UpdateAuthorAsync(int authorId, AuthorDto author);
    }
}