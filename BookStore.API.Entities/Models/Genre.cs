using BookStore.API.Entities.Models;

namespace BookStore.API.Models
{
    public class Genre : Entity
    {
        public string Name { get; set; }

        //Navigation
        public List<Book>? Books { get; set; }
    }
}
