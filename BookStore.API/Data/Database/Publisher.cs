using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BookStore.API.Data.Database
{
    public partial class Publisher
    {
        public Publisher()
        {
            Morebooks = new HashSet<Morebook>();
        }

        [Key]
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }

        public virtual ICollection<Morebook> Morebooks { get; set; }
    }
}
