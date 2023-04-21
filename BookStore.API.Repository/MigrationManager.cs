using BookStore.API.Repository.Seeder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookStore.API.Repository
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<RepositoryContext>())
                {
                    if (context.Database.EnsureCreated())
                    {
                        context.Database.Migrate();
                        new RoleSeeder(context).Seed();
                    }
                }
            }
            return host;
        }
    }
}
