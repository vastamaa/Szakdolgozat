using BookStore.API.Shared.DataTransferObjects;

namespace BookStore.API.Service.Contracts
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync(bool trackChanges);
        Task<AuthorDto> GetAuthorAsync(Guid authorId, bool trackChanges);
        Task<AuthorDto> CreateAuthorAsync(AuthorForCreationDto author);
        Task DeleteAuthorAsync(Guid authorId, bool trackChanges);
        Task UpdateAuthorAsync(Guid authorId, AuthorForUpdateDto authorForUpdate, bool trackChanges);
    }
}
