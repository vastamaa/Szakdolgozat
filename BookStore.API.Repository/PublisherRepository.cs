using BookStore.API.Contracts;
using BookStore.API.Entities.Models;

namespace BookStore.API.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        public void CreatePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public void DeletePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Publisher>> GetAllPublishersAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Publisher> GetPublisherAsync(Guid publisherId, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
