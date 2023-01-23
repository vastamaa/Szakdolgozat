using BookStore.API.Entities.Models;

namespace BookStore.API.Contracts
{
    public interface ILanguageRepository
    {
        Task<IEnumerable<Language>> GetAllLanguagesAsync(bool trackChanges);
        Task<Author> GetLanguageAsync(Guid languageId, bool trackChanges);
        void CreateLanguage(Language language);
        void DeleteLanguage(Language language);
    }
}
