using System.Collections.Generic;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.ViewModels;

namespace TestAPI.Services.Implementations
{
    public interface IGenresService
    {
        Task<int> AddGenreAsync(GenreVM genre);
        Task<int> DeleteGenreAsync(int genreId);
        Task<IEnumerable<Genre>> GetAllGenresAsync();
        Task<Genre> GetGenreByIdAsync(int genreId);
        Task<Genre> UpdateGenreAsync(int genreId, GenreVM genre);
    }
}