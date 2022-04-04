using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BookStore.APIDesktop
{
    public partial class Publisher
    {
        public Publisher()
        {
            Morebooks = new HashSet<Books>();
        }

        [Key]
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }

        public virtual ICollection<Books> Morebooks { get; set; }
    }
}
