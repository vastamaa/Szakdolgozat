using BookStore.API.Models;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> RegisterAsync(RegisterModel registerModel);
        Task<JwtSecurityToken> LoginAsync(LoginModel loginModel);
        Task LogoutAsync();
    }
}
