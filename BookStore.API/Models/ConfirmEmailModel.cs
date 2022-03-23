using Microsoft.AspNetCore.Identity;

namespace BookStore.API.Models
{
    public class ConfirmEmailModel
    {
        public string emailToken { get; set; }
        public IdentityResult result { get; set; }
    }
}
