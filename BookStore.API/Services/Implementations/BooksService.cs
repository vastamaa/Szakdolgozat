using BookStore.API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.ViewModels;

namespace TestAPI.Services.Implementations
{
    public class BooksService : IBooksService
    {
        private readonly AppDbContext _context;

        public BooksService(AppDbContext context)
        {
            _context = context;
            _context.ChangeTracker.LazyLoadingEnabled = false;
        }

        public async Task<IEnumerable<BookWithEverythingVM>> GetAllBooksAsync()
        {
            var _books = await _context.Books.Select(book => new BookWithEverythingVM()
            {
                Title = book.Title,
                Description = book.Description,
                ISBN = book.ISBN,
                ImgLink = book.ImgLink,
                PageNumber = book.PageNumber,
                Price = book.Price,
                PublisherYear = book.PublishingYear,
                PublisherName = book.Publisher.Name,
                GenreName = book.Book_Authors.Select(n => n.Genre.Name).FirstOrDefault(),
                LanguageName = book.Book_Authors.Select(n => n.Language.Name).FirstOrDefault(),
                AuthorName = book.Book_Authors.Select(n => n.Author.Name).FirstOrDefault()
            }).ToListAsync();

            return _books;
        }

        public async Task<List<BookWithEverythingVM>> GetBooksByGenreAsync(string genreName)
        {
            var _bookWithAuthors = await _context.Books.Where(b => b.Book_Authors.Select(n => n.Genre.Name).FirstOrDefault() == genreName).Select(book => new BookWithEverythingVM()
            {
                Title = book.Title,
                Description = book.Description,
                ISBN = book.ISBN,
                ImgLink = book.ImgLink,
                PageNumber = book.PageNumber,
                Price = book.Price,
                PublisherYear = book.PublishingYear,
                PublisherName = book.Publisher.Name,
                GenreName = book.Book_Authors.Select(n => n.Genre.Name).FirstOrDefault(),
                LanguageName = book.Book_Authors.Select(n => n.Language.Name).FirstOrDefault(),
                AuthorName = book.Book_Authors.Select(n => n.Author.Name).FirstOrDefault()
            }).ToListAsync();

            return _bookWithAuthors;
        }

        public async Task<int> AddBookWithAuthorsAsync(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                ISBN = book.ISBN,
                ImgLink = book.ImgLink,
                PageNumber = book.PageNumber,
                Price = book.Price,
                PublishingYear = book.PublishingYear,
                PublisherId = book.PublisherId
            };

            await _context.Books.AddAsync(_book);
            return await _context.SaveChangesAsync();
        }

        public async Task<Book> UpdateBookAsync(int bookId, BookVM book)
        {
            var _book = await _context.Books.FirstOrDefaultAsync(b => b.Id == bookId);

            if (_book is not null)
            {
                _book.Title = book.Title;
                _book.Description = book.Description;
                _book.ISBN = book.ISBN;
                _book.ImgLink = book.ImgLink;
                _book.PageNumber = book.PageNumber;
                _book.Price = book.Price;
                _book.PublishingYear = book.PublishingYear;

                await _context.SaveChangesAsync();
            }

            return _book;
        }

        public async Task DeleteBookAsync(int bookId)
        {
            var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == bookId);

            if (book is not null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }
    }
}
