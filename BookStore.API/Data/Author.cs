using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BookStore.API.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Properties
        [JsonIgnore]
        public List<Book_Author> Book_Authors { get; set; }
    }
}
