using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BookStore.API.Data.Database
{
    public partial class Genre
    {
        public Genre()
        {
            Morebooks = new HashSet<Morebook>();
        }

        [Key]
        public int GenreId { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<Morebook> Morebooks { get; set; }
    }
}
