namespace BookStore.API.Contracts
{
    public interface IRepositoryManager
    {
        IAuthorRepository Author { get; }
        IBookRepository Book { get; }
        IGenreRepository Genre { get; }
        ILanguageRepository Language { get; }
        IPublisherRepository Publisher { get; }
        Task SaveAsync();
    }
}
