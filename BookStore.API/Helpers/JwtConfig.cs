namespace BookStore.API.Helpers
{
    public class JwtConfig
    {
        public const string Name = "JWT";

        public string ValidAudience { get; set; }
        public string ValidIssuer { get; set; }
        public string Secret { get; set; }
        public string TokenValidityInMinutes { get; set; }
        public string RefreshTokenValidityInDays { get; set; }
    }
}
