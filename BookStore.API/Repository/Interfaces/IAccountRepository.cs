using BookStore.API.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> RegisterAsync(RegisterModel registerModel);
        Task<List<TokenReturnedByRepoModel>> LoginAsync(LoginModel loginModel);
    }
}
