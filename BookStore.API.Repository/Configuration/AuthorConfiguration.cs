using BookStore.API.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Repository.Configuration
{
    [ExcludeFromCodeCoverage]
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData
            (
                new Author
                {
                    Id = new Guid("ed93b4b6-1cc4-435f-8217-0736cfdffd56"),
                    Name = "Jody Houser"
                },
                new Author
                {
                    Id = new Guid("74dc85b9-f3c1-4536-af32-3dea9e323c20"),
                    Name = "Matthew K. Manning"
                },
                new Author
                {
                    Id = new Guid("907f4a0d-902d-43ce-afe0-996b1f91639d"),
                    Name = "Santiago García"
                },
                new Author
                {
                    Id = new Guid("4d19c3f6-9ae7-4336-804d-0bdf00705808"),
                    Name = "Scott Snyder"
                },
                new Author
                {
                    Id = new Guid("7ccbd8fb-5b31-4d65-a772-e8816c840a74"),
                    Name = "Art Spiegelman"
                },
                new Author
                {
                    Id = new Guid("1b17d71c-a0c0-4d9f-940e-723cdb82bbe2"),
                    Name = "Randall Munroe"
                },
                new Author
                {
                    Id = new Guid("7c0db471-3b05-46c1-a2cc-5459f2af47cf"),
                    Name = "Robert E. Howard"
                },
                new Author
                {
                    Id = new Guid("8153868f-cc8c-4466-aa7e-e473aaf49837"),
                    Name = "Marjorie Liu"
                },
                new Author
                {
                    Id = new Guid("0a82c391-2fa3-4de5-80e9-ba1e4245a457"),
                    Name = "Rick Remender"
                },
                new Author
                {
                    Id = new Guid("00c3bb96-0150-4192-9d57-8d466968210e"),
                    Name = "Jeff Smith"
                },
                new Author
                {
                    Id = new Guid("95c7e8f7-5d86-440a-83e8-5968b3686b60"),
                    Name = "Ed Brubaker"
                },
                new Author
                {
                    Id = new Guid("3d0c5689-2aca-441d-bcc0-ea217f58b778"),
                    Name = "Bartosz Sztybor"
                },
                new Author
                {
                    Id = new Guid("1e0df1c9-fcc4-46a9-a140-fbf780e74d73"),
                    Name = "Charles Soule"
                },
                new Author
                {
                    Id = new Guid("5d33cfee-7485-46ad-ba16-9262b9e03982"),
                    Name = "Howard Phillips Lovecraft"
                },
                new Author
                {
                    Id = new Guid("acc87e5e-98ad-4579-8281-981a35fb270e"),
                    Name = "Walter Simonson"
                },
                new Author
                {
                    Id = new Guid("85f34614-38e9-4839-8ab0-583a3cdfaaa7"),
                    Name = "Andrew Uffindell"
                },
                new Author
                {
                    Id = new Guid("34607d6a-80a1-4dcb-9f2c-04df59e7ff08"),
                    Name = "Gombos László"
                },
                new Author
                {
                    Id = new Guid("36b1c23e-ed7a-46a4-8f94-8b6c52d314e4"),
                    Name = "Tuvja Raviv"
                },
                new Author
                {
                    Id = new Guid("82e3ff15-bb67-4d0f-8b44-082f2e0469a6"),
                    Name = "Zsoldos Attila"
                },
                new Author
                {
                    Id = new Guid("e1489adc-798b-42b9-bcba-685ada8e0a41"),
                    Name = "Somos Zsuzsanna"
                },
                new Author
                {
                    Id = new Guid("c9c30c0a-ae6b-4cfa-85c4-4875f9b2636d"),
                    Name = "Ben Machell"
                },
                new Author
                {
                    Id = new Guid("c9ce53d4-484e-4e1d-843f-b4ab439efdd8"),
                    Name = "Wilbur Smith"
                },
                new Author
                {
                    Id = new Guid("2efeb3c3-926c-446f-830b-7dfaea521f30"),
                    Name = "Manon Fargetton"
                },
                new Author
                {
                    Id = new Guid("b88836d5-5a8f-467f-b618-87802bc15b51"),
                    Name = "Jeffrey Archer"
                },
                new Author
                {
                    Id = new Guid("7c9f6a33-32d5-4f82-9a69-62ffd4718e06"),
                    Name = "Kenéz Péter"
                },
                new Author
                {
                    Id = new Guid("46bd607e-be6a-434a-92f9-0c070b219fde"),
                    Name = "Bihary Péter"
                },
                new Author
                {
                    Id = new Guid("cac64ea5-64eb-444a-94dd-e461fefd825c"),
                    Name = "Kőműves Tamás"
                },
                new Author
                {
                    Id = new Guid("559008bc-535a-4467-87e0-247395387774"),
                    Name = "Algernon Blackwood"
                },
                new Author
                {
                    Id = new Guid("6be172c3-4394-4a10-b6d5-c5ff560e57a0"),
                    Name = "Rejtő Jenő"
                },
                new Author
                {
                    Id = new Guid("c5f0a9fd-4053-49ce-a680-f0bde3a45f85"),
                    Name = "Bokor Pál"
                },
                new Author
                {
                    Id = new Guid("929d153e-55d9-4bd6-8093-e9d30d77aed4"),
                    Name = "Oliver Bowden"
                },
                new Author
                {
                    Id = new Guid("a6abbfbd-befc-45e6-9ab8-bb4935679a98"),
                    Name = "Jennifer Lynn Barnes"
                },
                new Author
                {
                    Id = new Guid("2ffd34a3-ae32-4a4c-9ed8-f43247b4d290"),
                    Name = "Bartos Erika"
                },
                new Author
                {
                    Id = new Guid("e1d520d1-7af3-4a38-89f1-d89a88dcc1cc"),
                    Name = "Adam Silvera"
                },
                new Author
                {
                    Id = new Guid("7f3e96b5-a429-4c33-a909-238416d3b4ab"),
                    Name = "J. K. Rowling"
                },
                new Author
                {
                    Id = new Guid("5588c099-f566-4c17-a32e-46aa9045cf3a"),
                    Name = "Fazekas Anna"
                },
                new Author
                {
                    Id = new Guid("a46ad823-5d0f-448c-b620-1805cd3cec87"),
                    Name = "Julia Donaldson"
                },
                new Author
                {
                    Id = new Guid("02fa2c43-e4c2-477d-a11a-53ef9122f7f1"),
                    Name = "Louisa May Alcott"
                },
                new Author
                {
                    Id = new Guid("e3925fd9-6bdf-4f90-aa7e-ed71ae26493b"),
                    Name = "Richard Scarry"
                },
                new Author
                {
                    Id = new Guid("64fd4397-24cd-4938-b065-281bdd99b499"),
                    Name = "Beth Kempton"
                },
                new Author
                {
                    Id = new Guid("d8e84f02-d832-435a-a5a3-5f17506d5c78"),
                    Name = "Yutaka Yazawa"
                },
                new Author
                {
                    Id = new Guid("5f2cb1bf-733b-447e-a481-bb13984da0d3"),
                    Name = "Dr. Paul Conti MD"
                },
                new Author
                {
                    Id = new Guid("32abfe8e-f1db-43ad-9fd1-35a0359cdfa6"),
                    Name = "Eckhart Tolle"
                },
                new Author
                {
                    Id = new Guid("eb0809a7-c12b-4b34-bcd7-4f9b82600c32"),
                    Name = "Kovács József"
                },
                new Author
                {
                    Id = new Guid("12e32c78-7b5f-4227-a100-a0c65b174153"),
                    Name = "Stéphane Garnier"
                },
                new Author
                {
                    Id = new Guid("7c84aac5-59da-445c-afc6-4bd954dab31a"),
                    Name = "Shunmyo Masuno"
                },
                new Author
                {
                    Id = new Guid("fd8be475-d2ce-47ba-818e-78a166332774"),
                    Name = "Dr. Julie Smith"
                },
                new Author
                {
                    Id = new Guid("c0028cdb-311c-4e10-b3e2-8e2ed05615c8"),
                    Name = "Dr. Mike Dow"
                },
                new Author
                {
                    Id = new Guid("7ce5d916-cf4e-419d-a16c-7cb70de48092"),
                    Name = "Jan Andersen"
                },
                new Author
                {
                    Id = new Guid("f05ddc60-0655-462d-b3b0-4231644d5c1c"),
                    Name = "Andrea Owen"
                },
                new Author
                {
                    Id = new Guid("790f8551-da53-4ac2-a79b-1d7c6fe7dd53"),
                    Name = "Sol Rayond"
                },
                new Author
                {
                    Id = new Guid("34cd18ae-ad9d-49ab-8a6c-d28044e3f202"),
                    Name = "Grandpierre K. Endre"
                },
                new Author
                {
                    Id = new Guid("f74336a3-40ea-4278-9372-ba21b04e255b"),
                    Name = "Arthur Brand"
                },
                new Author
                {
                    Id = new Guid("e5616a9b-5451-41df-bcba-ad037fde4d10"),
                    Name = "Kollai István"
                },
                new Author
                {
                    Id = new Guid("388798ce-61f1-40b3-87f9-8078dcb227a2"),
                    Name = "Samin Nosrat"
                },
                new Author
                {
                    Id = new Guid("840a47b8-673a-4a6a-9a3c-f95528b0e062"),
                    Name = "Tóthné Libor Mária"
                },
                new Author
                {
                    Id = new Guid("1eb5b334-f5c0-4139-8df1-a465629c88b1"),
                    Name = "Wichmann Anna"
                },
                new Author
                {
                    Id = new Guid("a21b3e50-8311-4ec2-bd43-e8347ab5b544"),
                    Name = "Rézi néni"
                },
                new Author
                {
                    Id = new Guid("ca3d121f-b5cc-4fc3-9f9c-6515e58be3b5"),
                    Name = "Tanja Dusy"
                },
                new Author
                {
                    Id = new Guid("8c2564cc-2fb9-4667-9080-3da12bd75756"),
                    Name = "Radvánszky Béla"
                },
                new Author
                {
                    Id = new Guid("2b491140-2ab8-45ad-b444-c2dcde93dd83"),
                    Name = "Gaál Bence"
                },
                new Author
                {
                    Id = new Guid("c0bfd2a8-bad8-4599-b036-4353c83ba797"),
                    Name = "Karen Edwards"
                },
                new Author
                {
                    Id = new Guid("b88f1d64-f29d-4f76-a405-aaf1432b2ed4"),
                    Name = "Dirk Wallenburg"
                },
                new Author
                {
                    Id = new Guid("6e58036d-82c3-4c66-bd05-b6297adb92f3"),
                    Name = "Bud Spencer"
                },
                new Author
                {
                    Id = new Guid("8b17122d-e3d6-48a2-b18c-f6edb43f46bb"),
                    Name = "Gáspár Bea"
                },
                new Author
                {
                    Id = new Guid("3fcfbe41-3505-415d-9c21-ba2f3c9cf511"),
                    Name = "Vida József"
                }
            );
        }
    }
}
