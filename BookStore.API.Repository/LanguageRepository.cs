using BookStore.API.Contracts;
using BookStore.API.Entities.Models;

namespace BookStore.API.Repository
{
    public class LanguageRepository : ILanguageRepository
    {
        public void CreateLanguage(Language language)
        {
            throw new NotImplementedException();
        }

        public void DeleteLanguage(Language language)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Language>> GetAllLanguagesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetLanguageAsync(Guid languageId, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
