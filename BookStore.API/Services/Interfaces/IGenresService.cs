using BookStore.API.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.API.Models;

namespace BookStore.API.Services.Implementations
{
    public interface IGenresService
    {
        Task<int> AddGenreAsync(GenreDto genre);
        Task<int> DeleteGenreAsync(int genreId);
        Task<IEnumerable<Genre>> GetAllGenresAsync();
        Task<Genre> GetGenreByIdAsync(int genreId);
        Task<Genre> UpdateGenreAsync(int genreId, GenreDto genre);
    }
}