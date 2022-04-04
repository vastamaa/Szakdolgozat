using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BookStore.APIDesktop
{
    public partial class Language
    {
        public Language()
        {
            Morebooks = new HashSet<Books>();
        }

        [Key]
        public int LangId { get; set; }
        public string LangName { get; set; }

        public virtual ICollection<Books> Morebooks { get; set; }
    }
}
