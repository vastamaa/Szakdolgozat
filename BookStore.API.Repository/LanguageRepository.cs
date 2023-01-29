using BookStore.API.Contracts;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Repository
{
    public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository
    {
        public LanguageRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreateLanguage(Language language)
        {
            Create(language);
        }

        public void DeleteLanguage(Language language)
        {
            Delete(language);
        }

        public async Task<IEnumerable<Language>> GetAllLanguagesAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<Language> GetLanguageAsync(Guid languageId, bool trackChanges)
        {
            return await FindByCondition(c => c.LanguageId.Equals(languageId), trackChanges).SingleOrDefaultAsync();

        }
    }
}
