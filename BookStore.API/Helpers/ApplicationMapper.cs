using AutoMapper;
using BookStore.API.Data;
using BookStore.API.Models;

namespace BookStore.API.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            //Mapping from Books to BookModel
            CreateMap<Book, BookModel>();

            //Changing the map direction -- CreateMap<Books, BookModel>().ReverseMap();
        }
    }
}
