using BookStore.API.Contracts;
using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Repository
{
    public class PublisherRepository : RepositoryBase<Publisher>, IPublisherRepository
    {
        public PublisherRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreatePublisher(Publisher publisher)
        {
            Create(publisher);
        }

        public void DeletePublisher(Publisher publisher)
        {
            Delete(publisher);
        }

        public async Task<IEnumerable<Publisher>> GetAllPublishersAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<Publisher> GetPublisherAsync(Guid publisherId, bool trackChanges)
        {
            return await FindByCondition(c => c.PublisherId.Equals(publisherId), trackChanges).SingleOrDefaultAsync();
        }
    }
}
