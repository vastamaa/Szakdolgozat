using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BookStore.API.Repository.Interfaces
{
    public interface ITokenRepository
    {
        JwtSecurityToken GetToken(List<Claim> authClaims);
    }
}
