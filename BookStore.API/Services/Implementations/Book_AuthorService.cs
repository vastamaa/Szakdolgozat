using BookStore.API.Data;
using BookStore.API.DTOs;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Services.Implementations
{
    public class Book_AuthorService : IBook_AuthorService
    {
        private readonly AppDbContext _context;

        public Book_AuthorService(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Book_Author>> GetAllDataAsync() => await _context.Book_Author.ToListAsync();

        public async Task<Book_Author> GetDataByIdAsync(int id) => await _context.Book_Author.Where(d => d.Id == id).Select(data => new Book_Author()
        {
            Id = data.Id,
            BookId = data.BookId,
            AuthorId = data.AuthorId,
            GenreId = data.GenreId,
            LanguageId = data.LanguageId
        }).FirstOrDefaultAsync();

        public async Task<int> AddDataAsync(Book_AuthorDto books_AuthorsDto)
        {
            var _data = new Book_Author()
            {
                BookId = books_AuthorsDto.BookId,
                AuthorId = books_AuthorsDto.AuthorId,
                GenreId = books_AuthorsDto.GenreId,
                LanguageId = books_AuthorsDto.LanguageId
            };

            await _context.Book_Author.AddAsync(_data);
            return await _context.SaveChangesAsync();
        }

        public async Task<Book_Author> UpdateDataAsync(int id, Book_AuthorDto book_AuthorDto)
        {
            var _data = await _context.Book_Author.FirstOrDefaultAsync(d => d.Id == id);

            if (_data is not null)
            {
               if(string.IsNullOrEmpty(book_AuthorDto.BookId.ToString()))  _data.BookId = book_AuthorDto.BookId;
               if (string.IsNullOrEmpty(book_AuthorDto.AuthorId.ToString())) _data.AuthorId = book_AuthorDto.AuthorId;
               if (string.IsNullOrEmpty(book_AuthorDto.GenreId.ToString())) _data.GenreId = book_AuthorDto.GenreId;
               if (string.IsNullOrEmpty(book_AuthorDto.LanguageId.ToString())) _data.LanguageId = book_AuthorDto.LanguageId;
            }

            return _data;
        }

        public async Task<int> DeleteDataAsync(int id)
        {
            var data = await _context.Book_Author.FirstOrDefaultAsync(l => l.Id == id);

            if (data is not null)
            {
                _context.Book_Author.Remove(data);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
