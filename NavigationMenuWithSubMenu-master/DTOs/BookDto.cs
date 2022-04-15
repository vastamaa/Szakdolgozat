namespace MenuWithSubMenu.ViewModels
{
    public class BookDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string ImgLink { get; set; }
        public int PageNumber { get; set; }
        public int Price { get; set; }
        public int PublishingYear { get; set; }

        public int PublisherId { get; set; }
    }
}
