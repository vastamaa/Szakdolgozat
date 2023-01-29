using BookStore.API.Models;

namespace BookStore.API.Entities.Models
{
    public class BookAuthor
    {
        public Guid AuthorId { get; set; }
        public Guid BookId { get; set; }

        // Navigation
        public Book? Book { get; set; }
        public Author? Author { get; set; }
    }
}
