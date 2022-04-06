using BookStore.API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.ViewModels;

namespace TestAPI.Services.Implementations
{
    public class LanguagesService : ILanguagesService
    {
        private readonly AppDbContext _context;

        public LanguagesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Language>> GetAllLanguagesAsync() => await _context.Languages.ToListAsync();

        public async Task<Language> GetLanguageByIdAsync(int languageId) => await _context.Languages.Where(l => l.Id == languageId).FirstOrDefaultAsync();

        public async Task<int> AddLanguageAsync(LanguageVM language)
        {
            var _language = new Language()
            {
                Name = language.Name
            };

            await _context.Languages.AddAsync(_language);
            return await _context.SaveChangesAsync();
        }

        public async Task<Language> UpdateLanguageAsync(int languageId, LanguageVM language)
        {
            var _language = await _context.Languages.FirstOrDefaultAsync(l => l.Id == languageId);

            if (_language is not null)
            {
                _language.Name = language.Name;

                await _context.SaveChangesAsync();
            }

            return _language;
        }

        public async Task DeleteLanguageAsync(int languageId)
        {
            var language = await _context.Languages.FirstOrDefaultAsync(l => l.Id == languageId);

            if (language is not null)
            {
                _context.Languages.Remove(language);
                await _context.SaveChangesAsync();
            }
        }
    }
}
