using BookStore.API.Models;

namespace BookStore.API.Repository.Seeder
{
    public class LanguageSeeder : BaseSeeder
    {
        private readonly RepositoryContext _context;

        public LanguageSeeder(RepositoryContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            List<string[]>? lines = this.ReadFromFile(SourceConstants.Language);

            if (lines is null)
            {
                return;
            }

            foreach (var line in lines)
            {
                var Id = Guid.Parse(line[0]);
                var existing = _context?.Languages?.Find(Id);

                if (existing is null)
                {
                    _context?.Languages?.Add(new Language() { LanguageId = Id, Code = line[1], Name = line[2] });
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
