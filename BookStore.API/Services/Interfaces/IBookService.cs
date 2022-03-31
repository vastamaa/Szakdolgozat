﻿using BookStore.API.Data.Database;
using BookStore.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IBookService
    {
        Task<List<Morebook>> GetAllBooksAsync();
        Task<Morebook> GetBookByNameAsync(string bookName);
        Task<int> AddBookAsync(BookModel bookModel);
        Task UpdateBookAsync(int bookId, BookModel bookModel);
        Task UpdateBookPatchAsync(int bookId, JsonPatchDocument bookModel);
        Task DeleteBookAsync(int bookId);
    }
}