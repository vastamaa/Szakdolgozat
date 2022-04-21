using BookStore.API.Data;
using BookStore.API.DTOs;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Services.Implementations
{
    public class AuthorsService : IAuthorsService
    {
        private readonly AppDbContext _context;

        public AuthorsService(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Author>> GetAllAuthorsAsync() => await _context.Authors.ToListAsync();

        public async Task<Author> GetAuthorByIdAsync(int authorId) => await _context.Authors.Where(a => a.Id == authorId).FirstOrDefaultAsync();

        public async Task<int> AddAuthorAsync(AuthorDto author)
        {
            var result = await _context.Authors.Where(a => a.Name == author.Name).FirstOrDefaultAsync();

            if (result is null)
            {
                var _author = new Author()
                {
                    Name = author.Name
                };

                await _context.Authors.AddAsync(_author);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<Author> UpdateAuthorAsync(int authorId, AuthorDto author)
        {
            var contains = await _context.Authors.FirstOrDefaultAsync(b => b.Name == author.Name);

            if (contains is null)
            {
                var _author = await _context.Authors.FirstOrDefaultAsync(b => b.Id == authorId);

                if (_author is not null)
                {
                    _author.Name = author.Name;

                    await _context.SaveChangesAsync();
                }
                return _author;
            }
            return null;
        }

        public async Task<int> DeleteAuthorAsync(int authorId)
        {
            var author = await _context.Authors.FirstOrDefaultAsync(a => a.Id == authorId);

            if (author is not null)
            {
                _context.Authors.Remove(author);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
