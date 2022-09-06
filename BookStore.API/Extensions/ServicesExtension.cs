using BookStore.API.Repository.Implementations;
using BookStore.API.Repository.Interfaces;
using BookStore.API.Repository;
using BookStore.API.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;
using BookStore.API.Services.Interfaces;
using BookStore.API.Data;
using BookStore.API.Models;
using Microsoft.AspNetCore.Identity;
using BookStore.API.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace BookStore.API.Extensions
{
    public static class ServicesExtension
    {
        public static void CustomServicesConfiguration(this IServiceCollection services)
        {
            //My custom services.
            services.AddTransient<IBooksService, BooksService>();
            services.AddTransient<IPublishersService, PublishersService>();
            services.AddTransient<IAuthorsService, AuthorsService>();
            services.AddTransient<IGenresService, GenresService>();
            services.AddTransient<ILanguagesService, LanguagesService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IBook_AuthorService, Book_AuthorService>();
            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<IMailService, MailService>();
        }

        public static void CorsConfiguration(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
        }

        public static void IdentityConfiguration(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationUserModel, IdentityRole>(opt =>
            {
                opt.Password.RequiredLength = 6;
                opt.Password.RequireDigit = true;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireUppercase = true;

                opt.User.RequireUniqueEmail = true;

                opt.SignIn.RequireConfirmedEmail = true;
            })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
        }
        public static void AuthenticationConfiguration(this IServiceCollection services, IConfiguration configuration) 
        {
            var jwtConfig = new JwtConfig();
            configuration.GetSection(JwtConfig.Name).Bind(jwtConfig);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(o =>
            {
                o.SaveToken = true;
                o.RequireHttpsMetadata = false;
                o.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidAudience = jwtConfig.ValidAudience,
                    ValidIssuer = jwtConfig.ValidIssuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig.Secret)),
                    ClockSkew = TimeSpan.Zero
                };
            });
        }
    }
}
