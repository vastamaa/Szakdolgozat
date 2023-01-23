using BookStore.API.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Identity;

namespace BookStore.API.Service.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuthentication);
        Task<TokenDto> CreateToken(bool populateExpiration);
        Task<TokenDto> RefreshToken(TokenDto tokenDto);
    }
}
