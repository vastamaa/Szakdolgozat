namespace BookStore.API.Models
{
#nullable enable
    public class TokenStructureModel
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
