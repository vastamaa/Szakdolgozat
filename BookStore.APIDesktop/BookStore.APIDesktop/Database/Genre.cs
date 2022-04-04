using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BookStore.APIDesktop
{
    public partial class Genre
    {
        public Genre()
        {
            Morebooks = new HashSet<Books>();
        }

        [Key]
        public int GenreId { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<Books> Morebooks { get; set; }
    }
}
