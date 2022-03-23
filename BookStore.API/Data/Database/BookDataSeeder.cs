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

            _modelbuilder.Entity<Morebook>().HasData(
                new Morebook()
                {
                    Id = 1,
                    Title = "Elden ring",
                    AuthId = 1,
                    GenreId = 1,
                    Pagenumber = 11,
                    LangId = 1,
                    Isbn = "1111-111-111",
                    Description = "Bestest thing ever!",
                    ImgLink = "https://www.gamer365.hu/~fs/article/00/18/iv/elden-ring.jpg",
                    PublisherId = 1,
                    Price = 600,
                    PublishingYear = 2022
                },
                new Morebook()
                {
                    Id = 2,
                    Title = "Titty lovers' club!",
                    AuthId = 2,
                    GenreId = 3,
                    Pagenumber = 22,
                    LangId = 2,
                    Isbn = "2222-222-222",
                    Description = "Second best thing ever!",
                    ImgLink = "https://steamuserimages-a.akamaihd.net/ugc/779607575830347483/4B6B585BD8C2F4D2F93F360B60CA46B1B7E2A536/?imw=637&imh=358&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=true",
                    PublisherId = 2,
                    Price = 1200,
                    PublishingYear = 2003
                },
                new Morebook()
                {
                    Id = 3,
                    Title = "Kai Green",
                    AuthId = 3,
                    GenreId = 3,
                    Pagenumber = 33,
                    LangId = 3,
                    Isbn = "3333-333-333",
                    Description = "Strong one",
                    ImgLink = "https://testepitek.hu/wp-content/uploads/2012/01/kai-greene.jpg",
                    PublisherId = 3,
                    Price = 500,
                    PublishingYear = 2010
                }
            );
        }
    }
}