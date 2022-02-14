using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data
{
    public class BookDataSeeder
    {
        private readonly ModelBuilder _modelbuilder;

        public BookDataSeeder(ModelBuilder modelbuilder)
        {
            _modelbuilder = modelbuilder;
        }

        public void Seed()
        {
            _modelbuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = 1,
                    Title = "Prince's Legacy",
                    Description = "Let's fight for our kingdom."
                },

                new Book()
                {
                    Id = 2,
                    Title = "The Cursed Wolf",
                    Description = "The Moon is it's greatest enemy."
                },

                new Book()
                {
                    Id = 3,
                    Title = "C#",
                    Description = "We all love it! Of course!"
                },

                new Book()
                {
                    Id = 4,
                    Title = "Avada Kedavra",
                    Description = "The Killer Curse!"
                },

                new Book()
                {
                    Id = 5,
                    Title = "Python",
                    Description = "Programming language, and animal."
                },

                new Book()
                {
                    Id = 6,
                    Title = "Test",
                    Description = "Tester."
                }
            );
        }
    }
}