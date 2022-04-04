using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BookStore.APIDesktop
{
    public partial class Author
    {
        public Author()
        {
            Morebooks = new HashSet<Books>();
        }

        [Key]
        public int AuthId { get; set; }
        public string AuthName { get; set; }

        public virtual ICollection<Books> Morebooks { get; set; }
    }
}
