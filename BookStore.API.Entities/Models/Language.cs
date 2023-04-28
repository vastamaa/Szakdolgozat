using BookStore.API.Entities.Models;

namespace BookStore.API.Models
{
    public class Language : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }

        //Navigation
        public List<Book>? Books { get; set; }
    }
}
