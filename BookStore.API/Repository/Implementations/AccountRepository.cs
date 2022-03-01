using BookStore.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public async Task<IdentityResult> RegisterAsync(RegisterModel registerModel)
        {
            var user = new ApplicationUser()
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                Email = registerModel.Email,
                UserName = registerModel.Email
            };

            return await _userManager.CreateAsync(user, registerModel.Password);
        }

        public async Task<object> LoginAsync(LoginModel loginModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, false, false);

            if (!result.Succeeded)
            {
                return null;
            }

            return GenerateToken(loginModel);
        }

        public object GenerateToken(LoginModel loginModel)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var authClaims = new[]
            {
                new Claim(ClaimTypes.Email, loginModel.Email)
            };

            var expiresAt = DateTime.Now.AddMinutes(10);

            var jwt = new JwtSecurityToken(
                claims: authClaims,
                notBefore: DateTime.UtcNow,
                expires: expiresAt,
                signingCredentials: credentials
                );

            return new 
            { 
                access_token = new JwtSecurityTokenHandler().WriteToken(jwt),
                expires_at = expiresAt
            };
        }
    }
}
