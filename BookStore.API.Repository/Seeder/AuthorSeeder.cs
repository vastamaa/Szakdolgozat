using BookStore.API.Models;

namespace BookStore.API.Repository.Seeder
{
    public class AuthorSeeder : BaseSeeder
    {
        private readonly RepositoryContext _context;

        public AuthorSeeder(RepositoryContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            var lines = this.ReadFromFile(SourceConstants.Author);

            if (lines is null)
            {
                return;
            }

            foreach (var line in lines)
            {
                var Id = Guid.Parse(line[0]);
                var existing = _context?.Authors?.Find(Id);

                if (existing is null)
                {
                    _context?.Authors?.Add(new Author() { AuthorId = Id, FirstName = line[1], LastName = line[2] });
                }
                else
                {
                    existing.FirstName = line[1];
                    existing.LastName = line[2];
                }
            }
            _context?.SaveChanges();
        }
    }
}
