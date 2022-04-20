using System.Collections.Generic;

namespace BookStore.API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string ImgLink { get; set; }
        public int PageNumber { get; set; }
        public int Price { get; set; }
        public int PublishingYear { get; set; }

        //Navigation Properties
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public List<Book_Author> Book_Authors { get; set; }
    }
}
