using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new BookDataSeeder(modelBuilder).Seed();
        }

        public DbSet<Book> Books { get; set; }
    }
}
