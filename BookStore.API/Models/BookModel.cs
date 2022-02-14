using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please add 'Title' property.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please add 'Description' property.")]
        public string Description { get; set; }
    }
}
