using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AllPaczkinoPersistance.Migrations
{
    /// <inheritdoc />
    public partial class parcelsdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08e70bd8-61d8-4709-903e-47895bd087cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ee3eb60-efc6-45af-b813-6ac8e02973d6");

            migrationBuilder.AlterColumn<string>(
                name: "ParcelNumber",
                table: "Parcels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4bed6bbe-d376-4ba6-b1c9-3be18fa0020f", null, "User", "USER" },
                    { "73e3691e-24e1-42b9-b5c4-7d407565fd0c", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bed6bbe-d376-4ba6-b1c9-3be18fa0020f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73e3691e-24e1-42b9-b5c4-7d407565fd0c");

            migrationBuilder.AlterColumn<string>(
                name: "ParcelNumber",
                table: "Parcels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08e70bd8-61d8-4709-903e-47895bd087cb", null, "Admin", "ADMIN" },
                    { "3ee3eb60-efc6-45af-b813-6ac8e02973d6", null, "User", "USER" }
                });
        }
    }
}
