using BookStore.API.Entities.Models;

namespace BookStore.API.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public int Pages { get; set; }
        public Guid GenreId { get; set; }
        public Guid LanguageId { get; set; }
        public Guid PublisherId { get; set; }

        // Navigation
        public Genre? Genre { get; set; }
        public Publisher? Publisher { get; set; }
        public Language? Language { get; set; }
        public List<BookAuthor>? BookAuthors { get; set; }
    }
}
