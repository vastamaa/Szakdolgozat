using BookStore.API.Entities.Models;

namespace BookStore.API.Models
{
    public class Author : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation
        public List<Book>? Books { get; set; }
    }
}
