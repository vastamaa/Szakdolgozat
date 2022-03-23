using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.API.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Morebooks",
                columns: new[] { "Id", "AuthId", "AuthorName", "Description", "GenreId", "GenreName", "ImgLink", "Isbn", "LangId", "LanguageName", "Pagenumber", "Price", "PublisherId", "PublisherName", "PublishingYear", "Title" },
                values: new object[] { 1, 1, null, "Bestest thing ever!", 1, null, "https://www.gamer365.hu/~fs/article/00/18/iv/elden-ring.jpg", "1111-111-111", 1, null, 11, 600, 1, null, 2022, "Elden ring" });

            migrationBuilder.InsertData(
                table: "Morebooks",
                columns: new[] { "Id", "AuthId", "AuthorName", "Description", "GenreId", "GenreName", "ImgLink", "Isbn", "LangId", "LanguageName", "Pagenumber", "Price", "PublisherId", "PublisherName", "PublishingYear", "Title" },
                values: new object[] { 2, 2, null, "Second best thing ever!", 3, null, "https://steamuserimages-a.akamaihd.net/ugc/779607575830347483/4B6B585BD8C2F4D2F93F360B60CA46B1B7E2A536/?imw=637&imh=358&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=true", "2222-222-222", 2, null, 22, 1200, 2, null, 2003, "Titty lovers' club!" });

            migrationBuilder.InsertData(
                table: "Morebooks",
                columns: new[] { "Id", "AuthId", "AuthorName", "Description", "GenreId", "GenreName", "ImgLink", "Isbn", "LangId", "LanguageName", "Pagenumber", "Price", "PublisherId", "PublisherName", "PublishingYear", "Title" },
                values: new object[] { 3, 3, null, "Strong one", 3, null, "https://testepitek.hu/wp-content/uploads/2012/01/kai-greene.jpg", "3333-333-333", 3, null, 33, 500, 3, null, 2010, "Kai Green" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Morebooks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Morebooks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Morebooks",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
