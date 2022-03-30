using BookStore.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IAccountService
    {
        Task<ConfirmEmailModel> RegisterAsync(RegisterModel registerModel);
        Task<List<TokenServiceModel>> LoginAsync(LoginModel loginModel);
        Task<string> ResetPasswordAsync(string email);
    }
}
