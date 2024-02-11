using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AllPaczkinoPersistance.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedParcelLocker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ParcelLocker",
                table: "ParcelLocker");

            migrationBuilder.RenameTable(
                name: "ParcelLocker",
                newName: "ParcelLockers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParcelLockers",
                table: "ParcelLockers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "ParcelLockers",
                columns: new[] { "Id", "Address", "City", "IsActive", "PostalCode" },
                values: new object[,]
                {
                    { 1, "ul. Klonowa 1", "Warszawa", true, "00-001" },
                    { 2, "ul. Klonowa 34", "Warszawa", true, "00-001" },
                    { 3, "ul. Brzozowa 3", "Gdańsk", false, "80-001" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ParcelLockers",
                table: "ParcelLockers");

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "ParcelLockers",
                newName: "ParcelLocker");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParcelLocker",
                table: "ParcelLocker",
                column: "Id");
        }
    }
}
