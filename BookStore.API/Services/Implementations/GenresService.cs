using BookStore.API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.ViewModels;

namespace TestAPI.Services.Implementations
{
    public class GenresService : IGenresService
    {
        private readonly AppDbContext _context;

        public GenresService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Genre>> GetAllGenresAsync() => await _context.Genres.ToListAsync();

        public async Task<Genre> GetGenreByIdAsync(int genreId) => await _context.Genres.Where(g => g.Id == genreId).FirstOrDefaultAsync();

        public async Task<int> AddGenreAsync(GenreVM genre)
        {
            var result = await _context.Genres.Where(g => g.Name == genre.Name).FirstOrDefaultAsync();

            if (result is null)
            {
                var _genre = new Genre()
                {
                    Name = genre.Name
                };

                await _context.Genres.AddAsync(_genre);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<Genre> UpdateGenreAsync(int genreId, GenreVM genre)
        {
            var _genre = await _context.Genres.FirstOrDefaultAsync(b => b.Id == genreId);

            if (_genre is not null)
            {
                _genre.Name = genre.Name;

                await _context.SaveChangesAsync();
            }

            return _genre;
        }

        public async Task<int> DeleteGenreAsync(int genreId)
        {
            var genre = await _context.Genres.FirstOrDefaultAsync(b => b.Id == genreId);

            if (genre is not null)
            {
                _context.Genres.Remove(genre);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
