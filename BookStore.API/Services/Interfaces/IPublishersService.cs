using BookStore.API.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.API.Models;

namespace BookStore.API.Services.Implementations
{
    public interface IPublishersService
    {
        Task<int> AddPublisherAsync(PublisherDto publisher);
        Task<int> DeletePublisherAsync(int publisherId);
        Task<IEnumerable<Publisher>> GetAllPublishersAsync();
        Task<Publisher> GetPublisherByIdAsync(int publisherId);
        Task<Publisher> UpdatePublisherAsync(int publisherId, PublisherDto publisher);
    }
}