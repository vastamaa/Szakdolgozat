using BookStore.API.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.API.Models;

namespace BookStore.API.Services.Implementations
{
    public interface ILanguagesService
    {
        Task<int> AddLanguageAsync(LanguageDto language);
        Task<int> DeleteLanguageAsync(int languageId);
        Task<IEnumerable<Language>> GetAllLanguagesAsync();
        Task<Language> GetLanguageByIdAsync(int languageId);
        Task<Language> UpdateLanguageAsync(int languageId, LanguageDto language);
    }
}