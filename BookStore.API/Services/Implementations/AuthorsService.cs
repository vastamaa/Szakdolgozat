using BookStore.API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.ViewModels;

namespace TestAPI.Services.Implementations
{
    public class AuthorsService : IAuthorsService
    {
        private readonly AppDbContext _context;

        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Author>> GetAllAuthorsAsync() => await _context.Authors.ToListAsync();

        public async Task<Author> GetAuthorByIdAsync(int authorId) => await _context.Authors.Where(a => a.Id == authorId).FirstOrDefaultAsync();

        public async Task<int> AddAuthorAsync(AuthorVM author)
        {
            var _author = new Author()
            {
                Name = author.Name
            };

            await _context.Authors.AddAsync(_author);
            return await _context.SaveChangesAsync();
        }

        public async Task<Author> UpdateAuthorAsync(int authorId, AuthorVM author)
        {
            var _author = await _context.Authors.FirstOrDefaultAsync(a => a.Id == authorId);

            if (_author is not null)
            {
                _author.Name = author.Name;

                await _context.SaveChangesAsync();
            }

            return _author;
        }

        public async Task DeleteAuthorAsync(int authorId)
        {
            var author = await _context.Authors.FirstOrDefaultAsync(a => a.Id == authorId);

            if (author is not null)
            {
                _context.Authors.Remove(author);
                await _context.SaveChangesAsync();
            }
        }
    }
}
