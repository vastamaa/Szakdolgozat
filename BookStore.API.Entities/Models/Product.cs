using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace BookStore.API.Entities.Models
{
    [ExcludeFromCodeCoverage]
    [Table("product")]
    public class Product
    {
        [Column("ProductId")]
        public Guid Id { get; set; }


        //Navigation Properties
        [JsonIgnore]
        [ForeignKey(nameof(Book))]
        public Guid BookId { get; set; }
        public Book? Book { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(Author))]
        public Guid AuthorId { get; set; }
        public Author? Author { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(Genre))]
        public Guid GenreId { get; set; }
        public Genre? Genre { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(Language))]
        public Guid LanguageId { get; set; }
        public Language? Language { get; set; }
    }
}
