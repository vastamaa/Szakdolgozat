using BookStore.API.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Repository.Configuration
{
    [ExcludeFromCodeCoverage]
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData
            (
                new Publisher
                {
                    Id = new Guid("865caf02-35e3-4f1b-848d-bad270e0bafb"),
                    Name = "Szukits Könvykiadó és Könyvker"
                },
                new Publisher
                {
                    Id = new Guid("a1281f4a-ebd2-4457-82c8-847b12fbfd77"),
                    Name = "Vad Virágok Kiadó Kft."
                },
                new Publisher
                {
                    Id = new Guid("4808e6eb-a046-43b3-8051-c5e8d044e38f"),
                    Name = "Fumax Kft"
                },
                new Publisher
                {
                    Id = new Guid("3c53fede-e815-4f13-afad-1e951ffaab3c"),
                    Name = "Libri Könyvkiadó Kft."
                },
                new Publisher
                {
                    Id = new Guid("9a884f76-e3cc-4a82-95a2-160e6d678391"),
                    Name = "Penguin Books LTD"
                },
                new Publisher
                {
                    Id = new Guid("7156fcf2-b197-48f8-bb98-e5b1af7aa0f5"),
                    Name = "Athenaeum Kiadó Kft."
                },
                new Publisher
                {
                    Id = new Guid("8f54745b-ed21-469c-9a19-7dc9860caa03"),
                    Name = "Libub Group Kft."
                },
                new Publisher
                {
                    Id = new Guid("ff2fc995-dec3-4add-b0fa-aa32cfa6fe1e"),
                    Name = "GOLDMANN"
                },
                new Publisher
                {
                    Id = new Guid("7a21758e-8061-483c-aaf5-8e121f9c543f"),
                    Name = "Peko Kiadó"
                },
                new Publisher
                {
                    Id = new Guid("31fc18a8-c828-4a68-9c58-db9bf3c9874d"),
                    Name = "Smaragd Kiadó"
                },
                new Publisher
                {
                    Id = new Guid("8f19114f-7cfe-4727-bd95-80172b214308"),
                    Name = "Bölcsészettudományi Kutatóközp."
                },
                new Publisher
                {
                    Id = new Guid("7c1f78be-ad14-4f6c-b1bf-d1edc2fc21a0"),
                    Name = "Kossuth Kiadó Zrt."
                },
                new Publisher
                {
                    Id = new Guid("49233a40-5467-4ef7-8a26-05944db12b47"),
                    Name = "Püski Kiadó Kft."
                },
                new Publisher
                {
                    Id = new Guid("53345d93-877d-4426-b31a-e3d1c41bf3a1"),
                    Name = "Alexandra Könyvesház Kft."
                },
                new Publisher
                {
                    Id = new Guid("587148ba-7ecc-43dc-8eea-238d63992ad2"),
                    Name = "DELEJ"
                },
                new Publisher
                {
                    Id = new Guid("120bfaa5-7af7-40d2-86cd-af0537bfccb0"),
                    Name = "Könyvmolyképző Kiadó Kft."
                },
                new Publisher
                {
                    Id = new Guid("3f27a762-def1-4518-9744-88bde6c0e31f"),
                    Name = "General Press Kiadó"
                },
                new Publisher
                {
                    Id = new Guid("3f6033c5-db75-4bcf-a6b2-fb3a6e5624a1"),
                    Name = "Könyv Guru"
                },
                new Publisher
                {
                    Id = new Guid("322d3ed9-51ae-46e2-b28e-c4ab14254d90"),
                    Name = "Álomgyár Kiadó"
                },
                new Publisher
                {
                    Id = new Guid("392b19fe-4ada-4e5a-9424-6745058c24e4"),
                    Name = "Magánkiadás"
                },
                new Publisher
                {
                    Id = new Guid("aa00bf0a-cf66-4f82-aa8c-81f5dda53ed5"),
                    Name = "Attraktor Könyvkiadó Kft."
                },
                new Publisher
                {
                    Id = new Guid("299df9d9-c709-4fff-b6ce-c84776fb7f70"),
                    Name = "Csengőkert Kiadó"
                },
                new Publisher
                {
                    Id = new Guid("4b015207-7e0b-4cbb-a839-882e4902c368"),
                    Name = "Atlantic Press"
                },
                new Publisher
                {
                    Id = new Guid("baa614ab-ae2e-4eaf-8cd6-d2a8ea41dbb5"),
                    Name = "Lampion Könyvek"
                },
                new Publisher
                {
                    Id = new Guid("497b796c-aa14-465a-ade0-c704b6d783bf"),
                    Name = "Citera Kft."
                },
                new Publisher
                {
                    Id = new Guid("2e7ef815-4e9e-49a5-a96f-daaab63889ce"),
                    Name = "Menő Könyvek"
                },
                new Publisher
                {
                    Id = new Guid("4692ec05-e10a-4ad4-bfcf-c56935b93df0"),
                    Name = "Animus Kiadó"
                },
                new Publisher
                {
                    Id = new Guid("d5676c00-ddff-43e1-85f8-584f01032546"),
                    Name = "Móra Ferenc Ifjúsági Könyvkiadó Zrt."
                },
                new Publisher
                {
                    Id = new Guid("d32c0f75-a70d-41f5-b9df-0f28e02f6b34"),
                    Name = "Pozsonyi Pagony Kft"
                },
                new Publisher
                {
                    Id = new Guid("7a8c101b-1f2e-4899-96cc-e4da61c0718c"),
                    Name = "Manó Könyvek"
                },
                new Publisher
                {
                    Id = new Guid("1989db93-bd36-490b-83d5-f65f81c0a812"),
                    Name = "Scolar Kiadó Kft."
                },
                new Publisher
                {
                    Id = new Guid("87b05223-fb4d-42e3-b6d2-7620b3771be9"),
                    Name = "Édesvíz Kiadó"
                },
                new Publisher
                {
                    Id = new Guid("dfa716cc-b09f-4019-84d9-536082bf3cf3"),
                    Name = "Reménygyógyulás Kft."
                },
                new Publisher
                {
                    Id = new Guid("d5b8fa4c-62a1-49a3-ac10-bd8312d82409"),
                    Name = "21. Század Kiadó"
                },
                new Publisher
                {
                    Id = new Guid("f825a918-74a2-484c-b41c-d443773458c7"),
                    Name = "Magnólia"
                },
                new Publisher
                {
                    Id = new Guid("84b0d411-49ee-424f-a63c-06493f3dbf97"),
                    Name = "Marysol könyvkiadó"
                },
                new Publisher
                {
                    Id = new Guid("6628821e-67d6-4d0d-a386-41791362e392"),
                    Name = "Titokfejtő Könyvkiadó"
                },
                new Publisher
                {
                    Id = new Guid("5012fade-cda5-4aff-9b19-5cf8549235e3"),
                    Name = "Európa Könyvkiadó Kft."
                },
                new Publisher
                {
                    Id = new Guid("cdaa5a1d-6ec8-465b-943b-0a68b66d6d16"),
                    Name = "Akadémiai Kiadó Zrt."
                },
                new Publisher
                {
                    Id = new Guid("3f35835d-80f1-4408-8458-6f7b5b787edd"),
                    Name = "Park Könyvkiadó Kft."
                },
                new Publisher
                {
                    Id = new Guid("a77a8ce6-b956-41a4-a126-24d0718f2d11"),
                    Name = "Csipet kiadó"
                },
                new Publisher
                {
                    Id = new Guid("91458c80-abf7-4385-9162-561e5d7f248e"),
                    Name = "Harmat Kiadói Alapítvány"
                },
                new Publisher
                {
                    Id = new Guid("6ee8866e-829e-491a-833c-db591f795552"),
                    Name = "Nemzeti Örökség"
                },
                new Publisher
                {
                    Id = new Guid("81724d5c-a36e-448d-8ae2-daf88ff4ab13"),
                    Name = "Business Publishing Services Kft."
                },
                new Publisher
                {
                    Id = new Guid("cace8b36-f91b-40c7-a4a9-9c51710abfe8"),
                    Name = "Lingea Kft."
                },
                new Publisher
                {
                    Id = new Guid("1485fecd-39c8-4e77-8f27-7dadcabdb362"),
                    Name = "Optart AG"
                },
                new Publisher
                {
                    Id = new Guid("b3d99c58-925c-4c7c-8241-07c751c800fc"),
                    Name = "Open Books"
                },
                new Publisher
                {
                    Id = new Guid("afc4ce02-ccfe-4a3a-82da-550b3f4e054f"),
                    Name = "Boook Kiadó Kft."
                }
            );
        }
    }
}
