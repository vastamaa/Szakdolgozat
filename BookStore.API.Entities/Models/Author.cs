using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Entities.Models
{
    [ExcludeFromCodeCoverage]
    [Table("author")]
    public class Author : BaseEntity
    {
        //Navigation Properties
        public ICollection<Product>? Products { get; set; }
    }
}
