using AutoMapper;
using BookStore.API.Data;
using BookStore.API.Data.Database;
using BookStore.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _applicationMapper;

        public BookService(AppDbContext context, IMapper applicationMapper)
        {
            _context = context;
            _applicationMapper = applicationMapper;
        }

        public async Task<List<Morebook>> GetAllBooksAsync()
        {
            //Régi megoldásaim
            //var records = await _context.Books.Select(x => new Morebook()
            //{
            //    Id = x.Id,
            //    Title = x.Title,
            //    Description = x.Description
            //}
            //).ToListAsync();
            //return records;

            //var record = await _context.Morebooks.ToListAsync();
            //return _applicationMapper.Map<List<Morebook>>(record);

            var record = await (from m in _context.Morebooks
                                join a in _context.Authors on m.AuthId equals a.AuthId
                                join p in _context.Publishers on m.PublisherId equals p.PublisherId
                                join g in _context.Genres on m.GenreId equals g.GenreId
                                join l in _context.Languages on m.LangId equals l.LangId
                                select new Morebook
                                {
                                    Id = m.Id,
                                    Title = m.Title,
                                    AuthorName = a.AuthName,
                                    GenreName = g.GenreName,
                                    Pagenumber = m.Pagenumber,
                                    LanguageName = l.LangName,
                                    Isbn = m.Isbn,
                                    Description = m.Description,
                                    ImgLink = m.ImgLink,
                                    PublisherName = p.PublisherName,
                                    Price = m.Price,
                                    PublishingYear = m.PublishingYear

                                }).ToListAsync();

            return _applicationMapper.Map<List<Morebook>>(record);
        }

        //public async Task<BookModel> GetBookByIdAsync(int bookId)
        //{
        //    //Régi megoldásom
        //    //var record = await _context.Books.Where(x => x.Id == bookId).Select(x => new BookModel()
        //    //{
        //    //    Id = x.Id,
        //    //    Title = x.Title,
        //    //    Description = x.Description
        //    //}
        //    //).FirstOrDefaultAsync();
        //    //return record;

        //    var book = await _context.Books.FindAsync(bookId);
        //    return _applicationMapper.Map<BookModel>(book);
        //}

        public async Task<Morebook> GetBookByNameAsync(string bookName)
        {
            //var record = await _context.Books.Where(x => x.Title == bookName).Select(x => new BookModel()
            //{
            //    Id = x.Id,
            //    Title = x.Title,
            //    Description = x.Description
            //}
            //).FirstOrDefaultAsync();
            //return record;

            var record = await (from m in _context.Morebooks
                                join a in _context.Authors on m.AuthId equals a.AuthId
                                join p in _context.Publishers on m.PublisherId equals p.PublisherId
                                join g in _context.Genres on m.GenreId equals g.GenreId
                                join l in _context.Languages on m.LangId equals l.LangId
                                where m.Title == bookName
                                select new Morebook
                                {
                                    Id = m.Id,
                                    Title = m.Title,
                                    AuthorName = a.AuthName,
                                    GenreName = g.GenreName,
                                    Pagenumber = m.Pagenumber,
                                    LanguageName = l.LangName,
                                    Isbn = m.Isbn,
                                    Description = m.Description,
                                    ImgLink = m.ImgLink,
                                    PublisherName = p.PublisherName,
                                    Price = m.Price,
                                    PublishingYear = m.PublishingYear

                                }).FirstOrDefaultAsync();
            return record;
        }

        public async Task<int> AddBookAsync(BookModel bookModel)
        {
            var book = new Book()
            {
                Title = bookModel.Title,
                Description = bookModel.Description
            };

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return book.Id;
        }

        public async Task UpdateBookAsync(int bookId, BookModel bookModel)
        {
            var book = await _context.Books.FindAsync(bookId);

            if (book is not null)
            {
                book.Title = bookModel.Title;
                book.Description = bookModel.Description;

                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateBookPatchAsync(int bookId, JsonPatchDocument bookModel)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book is not null)
            {
                bookModel.ApplyTo(book);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteBookAsync(int bookId)
        {
            var book = new Book() { Id = bookId };
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}
