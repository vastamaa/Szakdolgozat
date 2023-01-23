using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Shared.DataTransferObjects
{
    [ExcludeFromCodeCoverage]
    public record TokenDto(string AccessToken, string RefreshToken);
}
