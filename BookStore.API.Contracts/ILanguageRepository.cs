using BookStore.API.Models;

namespace BookStore.API.Contracts
{
    public interface ILanguageRepository
    {
        Task<IEnumerable<Language>> GetAllLanguagesAsync(bool trackChanges);
        Task<Language> GetLanguageAsync(Guid languageId, bool trackChanges);
        void CreateLanguage(Language language);
        void DeleteLanguage(Language language);
    }
}
