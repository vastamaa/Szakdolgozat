using BookStore.API.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Repository.Configuration
{
    [ExcludeFromCodeCoverage]
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData
            (
                new Language
                {
                    Id = new Guid("544b5877-669f-4b5b-8eac-fbccd62da566"),
                    Name = "Hungarian"
                },
                new Language
                {
                    Id = new Guid("83902e1c-8335-4798-ad4d-2f90afca4e61"),
                    Name = "Deutsch"
                },
                new Language
                {
                    Id = new Guid("ef345bad-498f-47f7-810d-ad30326a7bef"),
                    Name = "English"
                }
            );
        }
    }
}
