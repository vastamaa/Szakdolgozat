using BookStore.API.Data.Database;
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

            _modelbuilder.Entity<Genre>().HasData(

                new Genre()
                {
                    GenreId = 1,
                    GenreName = "Action"
                },

                new Genre()
                {
                    GenreId = 2,
                    GenreName = "Horror"
                },

                new Genre()
                {
                    GenreId = 3,
                    GenreName = "Fantasy"
                }
            );

            _modelbuilder.Entity<Publisher>().HasData(

                new Publisher()
                {
                    PublisherId = 1,
                    PublisherName = "FromSoftware"
                },

                new Publisher()
                {
                    PublisherId = 2,
                    PublisherName = "Valve"
                },

                new Publisher()
                {
                    PublisherId = 3,
                    PublisherName = "Ubisoft"
                }
            );

            _modelbuilder.Entity<Language>().HasData(

                new Language()
                {
                    LangId = 1,
                    LangName = "Hungarian"
                },

                new Language()
                {
                    LangId = 2,
                    LangName = "Slovak"
                },

                new Language()
                {
                    LangId = 3,
                    LangName = "Romanian"
                }
            );

            _modelbuilder.Entity<Author>().HasData(

                new Author()
                {
                    AuthId = 1,
                    AuthName = "Gabe Newell"
                },

                new Author()
                {
                    AuthId = 2,
                    AuthName = "Steve Jobs"
                },

                new Author()
                {
                    AuthId = 3,
                    AuthName = "Hidetaka Miyazaki"
                }
            );
        }
    }
}