using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieDatabase.Identity.Migrations
{
    /// <inheritdoc />
    public partial class AddSuperAdminRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c3d277a-9afe-4771-98dd-35d35ab4c282", null, "Moderator", "MODERATOR" },
                    { "b6826eea-fecf-4c97-8aff-0b3ec76c31ce", null, "SuperAdmin", "SUPERADMIN" },
                    { "cc1a9397-48fb-4340-85fc-082215d04103", null, "Admin", "ADMIN" },
                    { "d14b9c63-41ed-4ec9-bae7-4bc0e72a8460", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c3d277a-9afe-4771-98dd-35d35ab4c282");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6826eea-fecf-4c97-8aff-0b3ec76c31ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc1a9397-48fb-4340-85fc-082215d04103");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d14b9c63-41ed-4ec9-bae7-4bc0e72a8460");

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
    }
}
