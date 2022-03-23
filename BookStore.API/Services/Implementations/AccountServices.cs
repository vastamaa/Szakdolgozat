using BookStore.API.Helpers;
using BookStore.API.Models;
using BookStore.API.Repository.Interfaces;
using BookStore.API.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITokenRepository _tokenRepository;
        private readonly JwtConfig _jwtConfig;

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ITokenRepository tokenRepository, IOptions<JwtConfig> options)
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
    }
}
