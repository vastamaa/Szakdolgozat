using BookStore.API.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IAccountService
    {
        Task<ConfirmEmailModel> RegisterAsync(RegisterModel registerModel);
        Task<List<TokenReturnedByRepoModel>> LoginAsync(LoginModel loginModel);
        Task<string> ResetPasswordAsync(string email);
    }
}
