using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AllPaczkinoPersistance.Migrations
{
    /// <inheritdoc />
    public partial class parcelsdbinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8035481d-670d-4bab-84c4-df50afa730f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1329759-5142-4a5b-8e63-cf14b4b083bf");

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParcelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderLockerId = table.Column<int>(type: "int", nullable: false),
                    ReceiverLockerId = table.Column<int>(type: "int", nullable: false),
                    SendTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ParcelStatus = table.Column<int>(type: "int", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ParcelSize_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Parcels_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parcels_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parcels_ParcelLockers_ReceiverLockerId",
                        column: x => x.ReceiverLockerId,
                        principalTable: "ParcelLockers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Parcels_ParcelLockers_SenderLockerId",
                        column: x => x.SenderLockerId,
                        principalTable: "ParcelLockers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08e70bd8-61d8-4709-903e-47895bd087cb", null, "Admin", "ADMIN" },
                    { "3ee3eb60-efc6-45af-b813-6ac8e02973d6", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_ReceiverId",
                table: "Parcels",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_ReceiverLockerId",
                table: "Parcels",
                column: "ReceiverLockerId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_SenderId",
                table: "Parcels",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_SenderLockerId",
                table: "Parcels",
                column: "SenderLockerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08e70bd8-61d8-4709-903e-47895bd087cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ee3eb60-efc6-45af-b813-6ac8e02973d6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8035481d-670d-4bab-84c4-df50afa730f1", null, "Admin", "ADMIN" },
                    { "d1329759-5142-4a5b-8e63-cf14b4b083bf", null, "User", "USER" }
                });
        }
    }
}
