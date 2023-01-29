using BookStore.API.Entities.Models;
using BookStore.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Repository
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<BookAuthor>().HasKey(ba => new { ba.AuthorId, ba.BookId });

            builder.Entity<BookAuthor>()
            .HasOne(ba => ba.Book)
            .WithMany(b => b.BookAuthors)
            .HasForeignKey(ba => ba.BookId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<BookAuthor>()
            .HasOne(ba => ba.Author)
            .WithMany(b => b.BookAuthors)
            .HasForeignKey(ba => ba.AuthorId)
            .OnDelete(DeleteBehavior.Restrict);
        }


        public DbSet<Author>? Authors { get; set; }
        public DbSet<Book>? Books { get; set; }
        public DbSet<Genre>? Genres { get; set; }
        public DbSet<Language>? Languages { get; set; }
        public DbSet<BookAuthor>? BookAuthors { get; set; }
        public DbSet<Publisher>? Publishers { get; set; }
    }
}
