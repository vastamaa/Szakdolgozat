﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Shared.DataTransferObjects
{
    [ExcludeFromCodeCoverage]
    public class UserForRegistrationDto
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; init; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; init; }
        [Required(ErrorMessage = "Email address is required")]
        public string Email { get; init; }
        public string? PhoneNumber { get; init; }
        public ICollection<string>? Roles { get; init; }
    }
}
