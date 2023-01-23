using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace BookStore.API.Entities.Models
{
    [ExcludeFromCodeCoverage]
    [Table("book")]
    public class Book
    {
        [Column("BookId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Book title is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Title is 30 characters.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Book description is a required field.")]
        [MaxLength(200, ErrorMessage = "Maximum length for the Description is 200 characters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Book description is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Description is 30 characters.")]
        public string? ISBN { get; set; }

        [Required(ErrorMessage = "Book image is required.")]
        public byte[]? ProductImage { get; set; }

        [Required(ErrorMessage = "Book page number is a required field.")]
        public int PageNumber { get; set; }

        [Required(ErrorMessage = "Book price is a required field.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Book publishing year is a required field.")]
        public int PublishingYear { get; set; }

        //Navigation Properties
        [ForeignKey(nameof(Publisher))]
        [JsonIgnore]
        public Guid PublisherId { get; set; }
        [JsonIgnore]
        public Publisher? Publisher { get; set; }
        [JsonIgnore]
        public ICollection<Product>? Products { get; set; }
    }
}
