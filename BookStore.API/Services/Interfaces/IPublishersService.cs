using BookStore.API.DTOs;
using BookStore.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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