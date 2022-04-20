using System.Collections.Generic;

namespace BookStore.API.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Properties
        public List<Book_Author> Book_Authors { get; set; }
    }
}
