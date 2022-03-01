using Microsoft.AspNetCore.Identity;
using System;

namespace BookStore.API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfJoining{ get; set; }
    }
}
