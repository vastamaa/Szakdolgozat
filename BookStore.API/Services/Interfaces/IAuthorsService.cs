using BookStore.API.DTOs;
using BookStore.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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