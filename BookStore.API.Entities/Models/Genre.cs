using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Entities.Models
{
    [ExcludeFromCodeCoverage]
    [Table("genre")]
    public class Genre : BaseEntity
    {
        //Navigation Properties
        public ICollection<Product>? Products { get; set; }
    }
}
