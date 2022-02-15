using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public class SignUpModel
    {
        [Required(ErrorMessage = "A mező kitöltése kötelező!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A mező kitöltése kötelező!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "A mező kitöltése kötelező!"), EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "A mező kitöltése kötelező!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "A mező kitöltése kötelező!"), Compare("Password", ErrorMessage = "A két jelszó nem egyezik!")]
        public string ConfirmPassword { get; set; }
    }
}
