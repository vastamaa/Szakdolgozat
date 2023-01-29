namespace BookStore.API.Models
{
    public class Genre
    {
        public Guid GenreId { get; set; }
        public string? Name { get; set; }

        //Navigation
        public List<Book>? Books { get; set; }
    }
}
