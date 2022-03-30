using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BookStore.API.Repository.Interfaces
{
    public interface ITokenService
    {
        JwtSecurityToken GetToken(List<Claim> authClaims);
        string GenerateRefreshToken();
#nullable enable
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
    }
}
