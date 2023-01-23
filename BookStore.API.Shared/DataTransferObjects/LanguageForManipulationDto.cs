using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Shared.DataTransferObjects
{
    [ExcludeFromCodeCoverage]
    public abstract record LanguageForManipulationDto
    {
        [Required(ErrorMessage = "Name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the name is 30 characters.")]
        public string? Name { get; set; }
    }
}