﻿using BookStore.API.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> RegisterAsync(RegisterModel registerModel);
        Task<object> LoginAsync(LoginModel loginModel);
        object GenerateToken(LoginModel loginModel);
    }
}
