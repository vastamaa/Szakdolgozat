using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BookStore.API.Data.Database
{
    public partial class Language
    {
        public Language()
        {
            Morebooks = new HashSet<Morebook>();
        }

        [Key]
        public int LangId { get; set; }
        public string LangName { get; set; }

        public virtual ICollection<Morebook> Morebooks { get; set; }
    }
}
