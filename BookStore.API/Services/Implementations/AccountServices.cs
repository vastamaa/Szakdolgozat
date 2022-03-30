using BookStore.API.Helpers;
using BookStore.API.Models;
using BookStore.API.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public class AccountRepository : IAccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITokenService _tokenRepository;
        private readonly JwtConfig _jwtConfig;

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ITokenService tokenRepository, IOptions<JwtConfig> options)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenRepository = tokenRepository;
            _jwtConfig = options.Value;
        }

        public async Task<ConfirmEmailModel> RegisterAsync(RegisterModel registerModel)
        {
            if (await _userManager.FindByNameAsync(registerModel.UserName) is not null) return null;

            var user = new ApplicationUser()
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                Email = registerModel.Email,
                UserName = registerModel.UserName,
                DateOfJoining = DateTime.UtcNow
            };
            var result = await _userManager.CreateAsync(user, registerModel.Password);
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            return new ConfirmEmailModel() { emailToken = token, result = result };
        }

        public async Task<List<TokenReturnedByRepoModel>> LoginAsync(LoginModel loginModel)
        {
            var user = await _userManager.FindByNameAsync(loginModel.UserName);
            var result = await _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, false, false);

            if (user is not null && result.Succeeded)
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var token = _tokenRepository.GetToken(authClaims);
                var refreshToken = _tokenRepository.GenerateRefreshToken();

                _ = int.TryParse(_jwtConfig.RefreshTokenValidityInDays, out int refreshTokenValidityInDays);

                user.RefreshToken = refreshToken;
                user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);

                await _userManager.UpdateAsync(user);

                return new List<TokenReturnedByRepoModel>()
                {
                    new TokenReturnedByRepoModel
                    {
                        Token = new JwtSecurityTokenHandler().WriteToken(token),
                        RefreshToken = refreshToken,
                        Expiration = token.ValidTo
                    }
                };
            }
            return null;
        }

        public async Task<string> ResetPasswordAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user is not null)
            {
                var password = CreatePassword(2);
                string token = await _userManager.GeneratePasswordResetTokenAsync(user);
                await _userManager.ResetPasswordAsync(user, token, password);
                return password;
            }
            return null;
        }

        public string CreatePassword(int length)
        {
            const string lowerCase = "abcedfghijklmnopqrstuvwxyz";
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string nonAlphaChars = "!+-.$&#|/?";

            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(lowerCase[rnd.Next(lowerCase.Length)]);
                res.Append(numbers[rnd.Next(numbers.Length)]);
                res.Append(upperCase[rnd.Next(upperCase.Length)]);
                res.Append(nonAlphaChars[rnd.Next(nonAlphaChars.Length)]);
            }
            return res.ToString();
        }
    }
}
