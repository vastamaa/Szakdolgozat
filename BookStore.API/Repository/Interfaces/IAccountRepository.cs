using BookStore.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> RegisterAsync(RegisterModel registerModel);
        Task<string> LoginAsync(LoginModel loginModel);
        string GenerateJSONWebToken(LoginModel loginModel);
    }
}
