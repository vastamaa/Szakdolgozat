using Microsoft.AspNetCore.Identity;

namespace BookStore.API.Repository.Seeder
{
    internal class RoleSeeder
    {
        private readonly RepositoryContext _context;

        public RoleSeeder(RepositoryContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            var roles = new List<IdentityRole>
            {
                new IdentityRole() { Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                new IdentityRole() { Name = "Manager", NormalizedName = "MANAGER" }
            };

            _context?.Roles?.AddRange(roles);

            _context?.SaveChanges();
        }
    }
}
