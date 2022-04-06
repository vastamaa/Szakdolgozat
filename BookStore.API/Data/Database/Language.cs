using System.Collections.Generic;

namespace TestAPI.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Properties
        public List<Book_Author> Book_Authors { get; set; }
    }
}
