using BookStore.API.Entities.Models;

namespace BookStore.API.Models
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public int Pages { get; set; }
        public Guid GenreId { get; set; }
        public Guid LanguageId { get; set; }
        public Guid PublisherId { get; set; }
        public Guid AuthorId { get; set; }

        // Navigation
        public Genre? Genre { get; set; }
        public Publisher? Publisher { get; set; }
        public Language? Language { get; set; }
        public Author? Author { get; set; }
    }
}
