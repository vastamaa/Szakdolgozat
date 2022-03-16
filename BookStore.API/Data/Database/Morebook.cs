#nullable disable

namespace BookStore.API.Data.Database
{
    public partial class Morebook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthId { get; set; }
        public int GenreId { get; set; }
        public int Pagenumber { get; set; }
        public int LangId { get; set; }
        public string Isbn { get; set; }
        public string Description { get; set; }
        public string ImgLink { get; set; }
        public int PublisherId { get; set; }
        public int Price { get; set; }
        public int PublishingYear { get; set; }

        public virtual Author Auth { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Language Lang { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
