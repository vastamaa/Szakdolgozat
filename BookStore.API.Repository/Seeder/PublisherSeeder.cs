using BookStore.API.Models;

namespace BookStore.API.Repository.Seeder
{
    public class PublisherSeeder : BaseSeeder
    {
        private readonly RepositoryContext _context;

        public PublisherSeeder(RepositoryContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            var lines = this.ReadFromFile(SourceConstants.Publisher);

            if (lines is null)
            {
                return;
            }

            foreach (var line in lines)
            {
                var Id = Guid.Parse(line[0]);
                var existing = _context?.Publishers?.Find(Id);

                if (existing is null)
                {
                    _context?.Publishers?.Add(new Publisher() { PublisherId = Id, Name = line[1] });
                }
                else
                {
                    existing.Name = line[1];
                }
            }
            _context?.SaveChanges();
        }
    }
}
