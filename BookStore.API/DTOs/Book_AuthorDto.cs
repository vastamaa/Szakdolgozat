namespace BookStore.API.DTOs
{
    public class Book_AuthorDto
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public int LanguageId { get; set; }
    }
}
