using System.Collections.Generic;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.ViewModels;

namespace TestAPI.Services.Implementations
{
    public interface ILanguagesService
    {
        Task<int> AddLanguageAsync(LanguageVM language);
        Task<int> DeleteLanguageAsync(int languageId);
        Task<IEnumerable<Language>> GetAllLanguagesAsync();
        Task<Language> GetLanguageByIdAsync(int languageId);
        Task<Language> UpdateLanguageAsync(int languageId, LanguageVM language);
    }
}