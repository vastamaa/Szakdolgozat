using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.API.Migrations
{
    public partial class OneNewBookAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 6, "Tester.", "Test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
