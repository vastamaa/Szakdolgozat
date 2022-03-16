﻿using AutoMapper;
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
    public class BookServices : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _applicationMapper;

        public BookServices(ApplicationDbContext context, IMapper applicationMapper)
        {
            _context = context;
            _applicationMapper = applicationMapper;
        }

        public async Task<List<Morebook>> GetAllBooksAsync()
        {
            //Régi megoldásom
            //var records = await _context.Books.Select(x => new BookModel()
            //{
            //    Id = x.Id,
            //    Title = x.Title,
            //    Description = x.Description
            //}
            //).ToListAsync();
            //return records;

            var record = await _context.Morebooks.ToListAsync();
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

        public async Task<BookModel> GetBookByNameAsync(string bookName)
        {
            var record = await _context.Books.Where(x => x.Title == bookName).Select(x => new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description
            }
            ).FirstOrDefaultAsync();
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