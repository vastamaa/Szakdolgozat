using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.API.Repository.Configuration
{
    internal class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData
            (
                new Language
                {
                    Id = new Guid("4d773a98-f023-4227-8354-53829d0699bd"),
                    Code = "EN",
                    Name = "Angol"
                },
                new Language
                {
                    Id = new Guid("12c18971-dd77-4971-86ca-9762ad0b3f34"),
                    Code = "BG",
                    Name = "Bolgár"
                },
                new Language
                {
                    Id = new Guid("bebc8e3b-7e60-4fe0-a200-0a734c245d60"),
                    Code = "ES",
                    Name = "Spanyol"
                },
                new Language
                {
                    Id = new Guid("ee7c86cb-e751-4834-8921-535e1f124add" +
                    ""),
                    Code = "CS",
                    Name = "Cseh"
                },
                new Language
                {
                    Id = new Guid("25616f2a-c46d-428d-9eba-5690cfcd562b"),
                    Code = "DA",
                    Name = "Dán"
                },
                new Language
                {
                    Id = new Guid("75b2f0fe-c540-44b6-859e-836bf40df697"),
                    Code = "DE",
                    Name = "Német"
                },
                new Language
                {
                    Id = new Guid("0efd9554-cac1-4ab7-829b-799e1ee9b40a"),
                    Code = "ET",
                    Name = "Észt"
                },
                new Language
                {
                    Id = new Guid("9e1b31ba-0c39-474c-994f-5f4f982b3d5c"),
                    Code = "EL",
                    Name = "Görög"
                },
                new Language
                {
                    Id = new Guid("5f652f38-4191-40dd-8ccb-a4138e080a65"),
                    Code = "FR",
                    Name = "Francia"
                },
                new Language
                {
                    Id = new Guid("e0084cc0-3e1c-48ab-8782-1ee401eca0fa"),
                    Code = "GA",
                    Name = "Ír"
                },
                new Language
                {
                    Id = new Guid("adfb2631-908d-4c8a-be81-645e73a3b748"),
                    Code = "HR",
                    Name = "Horvát"
                },
                new Language
                {
                    Id = new Guid("5b2cc597-ef6c-4eab-b070-d9f0d5dae697"),
                    Code = "IT",
                    Name = "Olasz"
                },
                new Language
                {
                    Id = new Guid("af330f08-51c1-4201-9700-6d976f1dc94e"),
                    Code = "LV",
                    Name = "Lett"
                },
                new Language
                {
                    Id = new Guid("08bec9df-df3f-4461-beb8-0d27ac27d534"),
                    Code = "LT",
                    Name = "Litván"
                },
                new Language
                {
                    Id = new Guid("2a8d7725-42c3-4b1c-ad2e-acd3a4ad59d1"),
                    Code = "HU",
                    Name = "Magyar"
                },
                new Language
                {
                    Id = new Guid("f6a21a84-ba61-41f4-8969-6710200abae8"),
                    Code = "MT",
                    Name = "Máltai"
                },
                new Language
                {
                    Id = new Guid("d8c486ec-42ef-4831-b252-b49f7de0e680"),
                    Code = "SV",
                    Name = "Svéd"
                },
                new Language
                {
                    Id = new Guid("7f3dbf92-b09a-4e22-bb57-4337fdb9491e"),
                    Code = "FI",
                    Name = "Finn"
                },
                new Language
                {
                    Id = new Guid("c629a3ca-edb7-4ab4-8946-6fbdfc15629c"),
                    Code = "SL",
                    Name = "Szlovén"
                },
                new Language
                {
                    Id = new Guid("c12c23c2-0903-47ec-84d1-a6c3394f0c90"),
                    Code = "SK",
                    Name = "Szlovák"
                },
                new Language
                {
                    Id = new Guid("87a53a1b-ec8b-479a-9b01-cff208f73a38"),
                    Code = "RO",
                    Name = "Román"
                },
                new Language
                {
                    Id = new Guid("e46a1c29-68f4-428b-ac0b-02d0c98a4595"),
                    Code = "PT",
                    Name = "Portugál"
                },
                new Language
                {
                    Id = new Guid("40649274-3ec2-446f-8ff2-8ccb326ab2f7"),
                    Code = "PL",
                    Name = "Lengyel"
                },
                new Language
                {
                    Id = new Guid("d199b58d-7fda-4917-8580-0fdf02e48054"),
                    Code = "NL",
                    Name = "Holland"
                },
                new Language
                {
                    Id = new Guid("7064e688-8eb1-49c0-bdc3-a207def4c384"),
                    Code = "UK",
                    Name = "Ukrán"
                },
                new Language
                {
                    Id = new Guid("d7def0d2-f86d-4375-929a-700865c9c419"),
                    Code = "TR",
                    Name = "Török"
                },
                new Language
                {
                    Id = new Guid("29ab6ea1-13eb-4de1-bfed-5c007f74837a"),
                    Code = "SR",
                    Name = "Szerb"
                }
            );
        }
    }
}
