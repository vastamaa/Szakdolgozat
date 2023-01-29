using BookStore.API.Models;

namespace BookStore.API.Repository.Seeder
{
    public class GenreSeeder : BaseSeeder
    {
        private readonly RepositoryContext _context;

        public GenreSeeder(RepositoryContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            var lines = this.ReadFromFile(SourceConstants.Genre);

            if (lines is null)
            {
                return;
            }

            foreach (var line in lines)
            {
                var Id = Guid.Parse(line[0]);
                var existing = _context?.Genres?.Find(Id);

                if (existing is null)
                {
                    _context?.Genres?.Add(new Genre() { GenreId = Id, Name = line[1] });
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
