using AutoMapper;
using BookStore.API.Entities.Models;
using BookStore.API.Models;
using BookStore.API.Shared.DataTransferObjects;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API
{
    [ExcludeFromCodeCoverage]
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AuthorForUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorForCreationDto, Author>().ReverseMap();
            CreateMap<AuthorDto, Author>().ReverseMap();

            CreateMap<LanguageForUpdateDto, Language>().ReverseMap();
            CreateMap<LanguageForCreationDto, Language>().ReverseMap();
            CreateMap<LanguageDto, Language>().ReverseMap();

            CreateMap<PublisherForUpdateDto, Publisher>().ReverseMap();
            CreateMap<PublisherForCreationDto, Publisher>().ReverseMap();
            CreateMap<PublisherDto, Publisher>().ReverseMap();

            CreateMap<GenreForUpdateDto, Genre>().ReverseMap();
            CreateMap<GenreForCreationDto, Genre>().ReverseMap();
            CreateMap<GenreDto, Genre>().ReverseMap();

            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
