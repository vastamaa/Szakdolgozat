using System;

namespace BookStore.API.Models
{
    public class TokenServiceModel
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiration { get; set; }
    }
}
