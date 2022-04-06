using BookStore.API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.ViewModels;

namespace TestAPI.Services.Implementations
{
    public class PublishersService : IPublishersService
    {
        private readonly AppDbContext _context;

        public PublishersService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Publisher>> GetAllPublishersAsync() => await _context.Publishers.ToListAsync();

        public async Task<Publisher> GetPublisherByIdAsync(int publisherId) => await _context.Publishers.Where(p => p.Id == publisherId).FirstOrDefaultAsync();

        public async Task<int> AddPublisherAsync(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };

            await _context.Publishers.AddAsync(_publisher);
            return await _context.SaveChangesAsync();
        }

        public async Task<Publisher> UpdatePublisherAsync(int publisherId, PublisherVM publisher)
        {
            var _publisher = await _context.Publishers.FirstOrDefaultAsync(p => p.Id == publisherId);

            if (_publisher is not null)
            {
                _publisher.Name = publisher.Name;

                await _context.SaveChangesAsync();
            }

            return _publisher;
        }

        public async Task DeletePublisherAsync(int publisherId)
        {
            var publisher = await _context.Publishers.FirstOrDefaultAsync(p => p.Id == publisherId);

            if (publisher is not null)
            {
                _context.Publishers.Remove(publisher);
                await _context.SaveChangesAsync();
            }
        }
    }
}
