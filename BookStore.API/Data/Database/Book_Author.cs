using System.Text.Json.Serialization;

namespace TestAPI.Models
{
    public class Book_Author
    {
        public int Id { get; set; }


        //Navigation Properties
        [JsonIgnore]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [JsonIgnore]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        [JsonIgnore]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        [JsonIgnore]
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
