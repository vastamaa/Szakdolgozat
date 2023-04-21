using BookStore.API.Entities.Models;

namespace BookStore.API.Models
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation
        public List<BookAuthor>? BookAuthors { get; set; }
    }
}
