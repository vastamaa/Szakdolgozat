using BookStore.API.Data;
using BookStore.API.DTOs;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Services.Implementations
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

        public async Task<int> AddPublisherAsync(PublisherDto publisher)
        {
            var result = await _context.Publishers.Where(p => p.Name == publisher.Name).FirstOrDefaultAsync();

            if (result is null)
            {
                var _publisher = new Publisher()
                {
                    Name = publisher.Name
                };

                await _context.Publishers.AddAsync(_publisher);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<Publisher> UpdatePublisherAsync(int publisherId, PublisherDto publisher)
        {
            var _publisher = await _context.Publishers.FirstOrDefaultAsync(p => p.Id == publisherId);
            var contains = await _context.Publishers.FirstOrDefaultAsync(p => p.Name == publisher.Name);

            if (contains is null)
            {
                if (_publisher is not null)
                {
                    _publisher.Name = publisher.Name;

                    await _context.SaveChangesAsync();
                }

                return null;
            }

            return _publisher;
        }

        public async Task<int> DeletePublisherAsync(int publisherId)
        {
            var publisher = await _context.Publishers.FirstOrDefaultAsync(p => p.Id == publisherId);

            if (publisher is not null)
            {
                _context.Publishers.Remove(publisher);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
