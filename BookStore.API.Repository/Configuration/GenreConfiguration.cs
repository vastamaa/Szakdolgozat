using BookStore.API.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Repository.Configuration
{
    [ExcludeFromCodeCoverage]
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData
            (
                new Genre
                {
                    Id = new Guid("dd4d92eb-fdb4-4962-931e-c86f52d1db61"),
                    Name = "Comics"
                },
                new Genre
                {
                    Id = new Guid("83561d61-3c4f-4ea6-8660-812c51057195"),
                    Name = "History"
                },
                new Genre
                {
                    Id = new Guid("1906e5d6-ded5-45de-b705-b96d60e8f360"),
                    Name = "Literature"
                },
                new Genre
                {
                    Id = new Guid("7689e60f-a9b9-4134-ac05-708778f0cd9d"),
                    Name = "Gastronomy"
                },
                new Genre
                {
                    Id = new Guid("fa74f9e6-a390-45c3-85f3-82b5863a9ed1"),
                    Name = "Lifestyle"
                },
                new Genre
                {
                    Id = new Guid("8fb27588-8344-4f29-b32e-3ee4fc435297"),
                    Name = "Childrens-fiction"
                }
            );
        }
    }
}
