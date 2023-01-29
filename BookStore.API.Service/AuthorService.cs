using AutoMapper;
using BookStore.API.Contracts;
using BookStore.API.Entities.Exceptions;
using BookStore.API.Models;
using BookStore.API.Service.Contracts;
using BookStore.API.Shared.DataTransferObjects;

namespace BookStore.API.Service
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AuthorService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync(bool trackChanges)
        {
            var authorsFromDb = await _repository.Author.GetAllAuthorsAsync(trackChanges);

            return _mapper.Map<IEnumerable<AuthorDto>>(authorsFromDb);
        }

        public async Task<AuthorDto> GetAuthorAsync(Guid authorId, bool trackChanges)
        {
            var authorFromDb = await GetAuthorAndCheckIfItExists(authorId, trackChanges);

            return _mapper.Map<AuthorDto>(authorFromDb);
        }

        public async Task<AuthorDto> CreateAuthorAsync(AuthorForCreationDto author)
        {
            var authorEntity = _mapper.Map<Author>(author);

            _repository.Author.CreateAuthor(authorEntity);
            await _repository.SaveAsync();

            return _mapper.Map<AuthorDto>(authorEntity);
        }

        public async Task DeleteAuthorAsync(Guid authorId, bool trackChanges)
        {
            var authorForCompany = await GetAuthorAndCheckIfItExists(authorId, trackChanges);

            _repository.Author.DeleteAuthor(authorForCompany);
            await _repository.SaveAsync();
        }

        public async Task UpdateAuthorAsync(Guid authorId, AuthorForUpdateDto authorForUpdate, bool trackChanges)
        {
            await CheckIfAuthorExists(authorId, trackChanges);

            var authorEntity = await GetAuthorAndCheckIfItExists(authorId, trackChanges);

            _mapper.Map(authorForUpdate, authorEntity);
            await _repository.SaveAsync();
        }

        public async Task<(AuthorForUpdateDto authorToPatch, Author authorEntity)> GetAuthorForPatchAsync(Guid authorId, bool trackChanges)
        {
            await CheckIfAuthorExists(authorId, trackChanges);

            var authorEntity = await GetAuthorAndCheckIfItExists(authorId, trackChanges);

            var authorToPatch = _mapper.Map<AuthorForUpdateDto>(authorEntity);

            return (authorToPatch: authorToPatch, authorEntity: authorEntity);
        }

        public async Task SaveChangesForPatchAsync(AuthorForUpdateDto authorToPatch, Author authorEntity)
        {
            _mapper.Map(authorToPatch, authorEntity);
            await _repository.SaveAsync();
        }

        private async Task<Author> GetAuthorAndCheckIfItExists(Guid authorId, bool trackChanges)
        {
            var author = await _repository.Author.GetAuthorAsync(authorId, trackChanges);

            if (author is null)
            {
                throw new AuthorNotFoundException(authorId);
            }

#pragma warning disable CS8603 // Possible null reference return.
            return author;
#pragma warning restore CS8603 // Possible null reference return.
        }

        private async Task CheckIfAuthorExists(Guid authorId, bool trackChanges)
        {
            var author = await _repository.Author.GetAuthorAsync(authorId, trackChanges);

            if (author is null)
            {
                throw new AuthorNotFoundException(authorId);
            }
        }
    }
}
