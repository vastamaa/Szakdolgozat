using System.Collections.Generic;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.ViewModels;

namespace TestAPI.Services.Implementations
{
    public interface IPublishersService
    {
        Task<int> AddPublisherAsync(PublisherVM publisher);
        Task<int> DeletePublisherAsync(int publisherId);
        Task<IEnumerable<Publisher>> GetAllPublishersAsync();
        Task<Publisher> GetPublisherByIdAsync(int publisherId);
        Task<Publisher> UpdatePublisherAsync(int publisherId, PublisherVM publisher);
    }
}