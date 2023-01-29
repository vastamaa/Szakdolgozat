using BookStore.API.Contracts;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Repository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreateBook(Book book)
        {
            Create(book);
        }

        public void DeleteBook(Book book)
        {
            Delete(book);
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(b => b.Title).ToListAsync();
        }

        public async Task<Book> GetBookAsync(Guid bookId, bool trackChanges)
        {
            return await FindByCondition(b => b.BookId.Equals(bookId), trackChanges).SingleOrDefaultAsync();
        }
    }
}
