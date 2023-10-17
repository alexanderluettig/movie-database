using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieDatabase.Identity.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4dfd6b81-17d7-4ccc-aa2e-0445a21eb506", null, "Moderator", "MODERATOR" },
                    { "f107d686-8900-4195-8964-95836410099e", null, "Admin", "ADMIN" },
                    { "ff6bde3e-b662-42ec-ab95-798aa4540544", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dfd6b81-17d7-4ccc-aa2e-0445a21eb506");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f107d686-8900-4195-8964-95836410099e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff6bde3e-b662-42ec-ab95-798aa4540544");
        }
    }
}
