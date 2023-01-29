using BookStore.API.Models;

namespace BookStore.API.Contracts
{
    public interface IPublisherRepository
    {
        Task<IEnumerable<Publisher>> GetAllPublishersAsync(bool trackChanges);
        Task<Publisher> GetPublisherAsync(Guid publisherId, bool trackChanges);
        void CreatePublisher(Publisher publisher);
        void DeletePublisher(Publisher publisher);
    }
}
