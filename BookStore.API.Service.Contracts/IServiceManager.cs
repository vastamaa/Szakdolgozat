namespace BookStore.API.Service.Contracts
{
    public interface IServiceManager
    {
        IAuthorService AuthorService { get; }
        IGenreService GenreService { get; }
        ILanguageService LanguageService { get; }
        IPublisherService PublisherService { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
