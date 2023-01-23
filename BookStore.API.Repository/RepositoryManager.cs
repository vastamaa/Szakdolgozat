using BookStore.API.Contracts;

namespace BookStore.API.Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IAuthorRepository> _authorRepository;
        private readonly Lazy<IBookRepository> _bookRepository;
        private readonly Lazy<IGenreRepository> _genreRepository;
        private readonly Lazy<ILanguageRepository> _languageRepository;
        private readonly Lazy<IPublisherRepository> _publisherRepository;
        private readonly Lazy<IProductRepository> _productRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _authorRepository = new Lazy<IAuthorRepository>(() => new AuthorRepository(repositoryContext));
            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(repositoryContext));
            _genreRepository = new Lazy<IGenreRepository>(() => new GenreRepository(repositoryContext));
            _languageRepository = new Lazy<ILanguageRepository>(() => new LanguageRepository(repositoryContext));
            _publisherRepository = new Lazy<IPublisherRepository>(() => new PublisherRepository(repositoryContext));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(repositoryContext));
        }

        IAuthorRepository IRepositoryManager.Author => _authorRepository.Value;
        IBookRepository IRepositoryManager.Book => _bookRepository.Value;
        IGenreRepository IRepositoryManager.Genre => _genreRepository.Value;
        ILanguageRepository IRepositoryManager.Language => _languageRepository.Value;
        IPublisherRepository IRepositoryManager.Publisher => _publisherRepository.Value;
        IProductRepository IRepositoryManager.Product => _productRepository.Value;

        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }
    }
}
