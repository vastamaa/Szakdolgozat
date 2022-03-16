using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BookStore.API.Data.Database
{
    public partial class Author
    {
        public Author()
        {
            Morebooks = new HashSet<Morebook>();
        }

        [Key]
        public int AuthId { get; set; }
        public string AuthName { get; set; }

        public virtual ICollection<Morebook> Morebooks { get; set; }
    }
}
