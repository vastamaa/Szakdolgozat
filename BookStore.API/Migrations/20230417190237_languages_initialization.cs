using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.API.Migrations
{
    public partial class languages_initialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("08bec9df-df3f-4461-beb8-0d27ac27d534"), "LT", "Litván" },
                    { new Guid("0efd9554-cac1-4ab7-829b-799e1ee9b40a"), "ET", "Észt" },
                    { new Guid("12c18971-dd77-4971-86ca-9762ad0b3f34"), "BG", "Bolgár" },
                    { new Guid("25616f2a-c46d-428d-9eba-5690cfcd562b"), "DA", "Dán" },
                    { new Guid("29ab6ea1-13eb-4de1-bfed-5c007f74837a"), "SR", "Szerb" },
                    { new Guid("2a8d7725-42c3-4b1c-ad2e-acd3a4ad59d1"), "HU", "Magyar" },
                    { new Guid("40649274-3ec2-446f-8ff2-8ccb326ab2f7"), "PL", "Lengyel" },
                    { new Guid("4d773a98-f023-4227-8354-53829d0699bd"), "EN", "Angol" },
                    { new Guid("5b2cc597-ef6c-4eab-b070-d9f0d5dae697"), "IT", "Olasz" },
                    { new Guid("5f652f38-4191-40dd-8ccb-a4138e080a65"), "FR", "Francia" },
                    { new Guid("7064e688-8eb1-49c0-bdc3-a207def4c384"), "UK", "Ukrán" },
                    { new Guid("75b2f0fe-c540-44b6-859e-836bf40df697"), "DE", "Német" },
                    { new Guid("7f3dbf92-b09a-4e22-bb57-4337fdb9491e"), "FI", "Finn" },
                    { new Guid("87a53a1b-ec8b-479a-9b01-cff208f73a38"), "RO", "Román" },
                    { new Guid("9e1b31ba-0c39-474c-994f-5f4f982b3d5c"), "EL", "Görög" },
                    { new Guid("adfb2631-908d-4c8a-be81-645e73a3b748"), "HR", "Horvát" },
                    { new Guid("af330f08-51c1-4201-9700-6d976f1dc94e"), "LV", "Lett" },
                    { new Guid("bebc8e3b-7e60-4fe0-a200-0a734c245d60"), "ES", "Spanyol" },
                    { new Guid("c12c23c2-0903-47ec-84d1-a6c3394f0c90"), "SK", "Szlovák" },
                    { new Guid("c629a3ca-edb7-4ab4-8946-6fbdfc15629c"), "SL", "Szlovén" },
                    { new Guid("d199b58d-7fda-4917-8580-0fdf02e48054"), "NL", "Holland" },
                    { new Guid("d7def0d2-f86d-4375-929a-700865c9c419"), "TR", "Török" },
                    { new Guid("d8c486ec-42ef-4831-b252-b49f7de0e680"), "SV", "Svéd" },
                    { new Guid("e0084cc0-3e1c-48ab-8782-1ee401eca0fa"), "GA", "Ír" },
                    { new Guid("e46a1c29-68f4-428b-ac0b-02d0c98a4595"), "PT", "Portugál" },
                    { new Guid("ee7c86cb-e751-4834-8921-535e1f124add"), "CS", "Cseh" },
                    { new Guid("f6a21a84-ba61-41f4-8969-6710200abae8"), "MT", "Máltai" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("08bec9df-df3f-4461-beb8-0d27ac27d534"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("0efd9554-cac1-4ab7-829b-799e1ee9b40a"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("12c18971-dd77-4971-86ca-9762ad0b3f34"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("25616f2a-c46d-428d-9eba-5690cfcd562b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("29ab6ea1-13eb-4de1-bfed-5c007f74837a"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("2a8d7725-42c3-4b1c-ad2e-acd3a4ad59d1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("40649274-3ec2-446f-8ff2-8ccb326ab2f7"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("4d773a98-f023-4227-8354-53829d0699bd"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("5b2cc597-ef6c-4eab-b070-d9f0d5dae697"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("5f652f38-4191-40dd-8ccb-a4138e080a65"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("7064e688-8eb1-49c0-bdc3-a207def4c384"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("75b2f0fe-c540-44b6-859e-836bf40df697"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("7f3dbf92-b09a-4e22-bb57-4337fdb9491e"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("87a53a1b-ec8b-479a-9b01-cff208f73a38"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("9e1b31ba-0c39-474c-994f-5f4f982b3d5c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("adfb2631-908d-4c8a-be81-645e73a3b748"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("af330f08-51c1-4201-9700-6d976f1dc94e"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("bebc8e3b-7e60-4fe0-a200-0a734c245d60"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c12c23c2-0903-47ec-84d1-a6c3394f0c90"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c629a3ca-edb7-4ab4-8946-6fbdfc15629c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d199b58d-7fda-4917-8580-0fdf02e48054"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d7def0d2-f86d-4375-929a-700865c9c419"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d8c486ec-42ef-4831-b252-b49f7de0e680"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e0084cc0-3e1c-48ab-8782-1ee401eca0fa"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e46a1c29-68f4-428b-ac0b-02d0c98a4595"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("ee7c86cb-e751-4834-8921-535e1f124add"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("f6a21a84-ba61-41f4-8969-6710200abae8"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
