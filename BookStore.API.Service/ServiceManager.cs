using AutoMapper;
using BookStore.API.Contracts;
using BookStore.API.Entities.ConfigurationModels;
using BookStore.API.Entities.Models;
using BookStore.API.Service.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Service
{
    [ExcludeFromCodeCoverage]
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthorService> _authorService;
        private readonly Lazy<ILanguageService> _languageService;
        private readonly Lazy<IGenreService> _genreService;
        private readonly Lazy<IPublisherService> _publisherService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IOptions<JwtSettings> configuration)
        {
            _authorService = new Lazy<IAuthorService>(() => new AuthorService(repository, logger, mapper));
            _languageService = new Lazy<ILanguageService>(() => new LanguageService(repository, logger, mapper));
            _genreService = new Lazy<IGenreService>(() => new GenreService(repository, logger, mapper));
            _publisherService = new Lazy<IPublisherService>(() => new PublisherService(repository, logger, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
        }

        public IAuthorService AuthorService => _authorService.Value;
        public ILanguageService LanguageService => _languageService.Value;
        public IGenreService GenreService => _genreService.Value;
        public IPublisherService PublisherService => _publisherService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
