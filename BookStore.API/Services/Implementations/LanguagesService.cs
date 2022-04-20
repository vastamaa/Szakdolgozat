using BookStore.API.Data;
using BookStore.API.DTOs;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Services.Implementations
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

        public async Task<int> AddLanguageAsync(LanguageDto language)
        {
            var result = await _context.Languages.Where(l => l.Name == language.Name).FirstOrDefaultAsync();

            if (result is null)
            {
                var _language = new Language()
                {
                    Name = language.Name
                };

                await _context.Languages.AddAsync(_language);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<Language> UpdateLanguageAsync(int languageId, LanguageDto language)
        {
            var _language = await _context.Languages.FirstOrDefaultAsync(l => l.Id == languageId);

            if (_language is not null)
            {
                _language.Name = language.Name;

                await _context.SaveChangesAsync();
            }

            return _language;
        }

        public async Task<int> DeleteLanguageAsync(int languageId)
        {
            var language = await _context.Languages.FirstOrDefaultAsync(l => l.Id == languageId);

            if (language is not null)
            {
                _context.Languages.Remove(language);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
