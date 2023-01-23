﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Shared.DataTransferObjects
{
    [ExcludeFromCodeCoverage]
    public record UserForAuthenticationDto
    {
        [Required(ErrorMessage = "User name is required!")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        public string? Password { get; set; }
    };
}
