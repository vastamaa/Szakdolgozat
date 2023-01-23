using BookStore.API.Shared.DataTransferObjects;

namespace BookStore.API.Service.Contracts
{
    public interface ILanguageService
    {
        Task<IEnumerable<LanguageDto>> GetAllLanguagesAsync(bool trackChanges);
        Task<LanguageDto> GetLanguageAsync(Guid languageId, bool trackChanges);
        Task<LanguageDto> CreateLanguageAsync(LanguageForCreationDto language);
        Task DeleteLanguageAsync(Guid languageId, bool trackChanges);
        Task UpdateLanguageAsync(Guid languageId, LanguageForUpdateDto languageForUpdate, bool trackChanges);
    }
}
