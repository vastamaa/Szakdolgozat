using BookStore.API.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IAccountService
    {
        Task<ConfirmEmailModel> RegisterAsync(RegisterModel registerModel);
        Task<List<TokenServiceModel>> LoginAsync(LoginModel loginModel);
        Task<List<TokenServiceModel>> AdminLoginAsync(LoginModel loginModel);
        Task<string> ResetPasswordAsync(string email);
        Task<IdentityResult> ChangePasswordAsync(string password, string email);
    }
}
