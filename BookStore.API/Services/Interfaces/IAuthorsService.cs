using System.Collections.Generic;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.ViewModels;

namespace TestAPI.Services.Implementations
{
    public interface IAuthorsService
    {
        Task<int> AddAuthorAsync(AuthorVM author);
        Task DeleteAuthorAsync(int authorId);
        Task<IEnumerable<Author>> GetAllAuthorsAsync();
        Task<Author> GetAuthorByIdAsync(int authorId);
        Task<Author> UpdateAuthorAsync(int authorId, AuthorVM author);
    }
}