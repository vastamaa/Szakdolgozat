namespace BookStore.API.DTOs
{
    public class BookWithEverythingDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string ImgLink { get; set; }
        public int PageNumber { get; set; }
        public int Price { get; set; }
        public int PublisherYear { get; set; }

        public string PublisherName { get; set; }
        public string LanguageName { get; set; }
        public string GenreName { get; set; }
        public string AuthorName { get; set; }
    }
}
