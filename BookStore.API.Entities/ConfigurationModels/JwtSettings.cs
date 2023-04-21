using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Entities.ConfigurationModels
{
    [ExcludeFromCodeCoverage]
    public class JwtSettings
    {
        public string Section { get; set; }
        public string ValidIssuer { get; set; }
        public string ValidAudience { get; set; }
        public string Expires { get; set; }
    }
}
