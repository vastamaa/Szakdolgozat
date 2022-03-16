using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.API.Migrations
{
    public partial class SeedFillUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Morebooks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GenreName",
                table: "Morebooks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LanguageName",
                table: "Morebooks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublisherName",
                table: "Morebooks",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthId", "AuthName" },
                values: new object[,]
                {
                    { 1, "Gabe Newell" },
                    { 2, "Steve Jobs" },
                    { 3, "Hidetaka Miyazaki" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Horror" },
                    { 3, "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LangId", "LangName" },
                values: new object[,]
                {
                    { 1, "Hungarian" },
                    { 2, "Slovak" },
                    { 3, "Romanian" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "PublisherName" },
                values: new object[,]
                {
                    { 1, "FromSoftware" },
                    { 2, "Valve" },
                    { 3, "Ubisoft" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LangId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LangId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LangId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Morebooks");

            migrationBuilder.DropColumn(
                name: "GenreName",
                table: "Morebooks");

            migrationBuilder.DropColumn(
                name: "LanguageName",
                table: "Morebooks");

            migrationBuilder.DropColumn(
                name: "PublisherName",
                table: "Morebooks");
        }
    }
}
