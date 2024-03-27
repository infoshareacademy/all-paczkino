using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AllPaczkinoPersistance.Migrations
{
    /// <inheritdoc />
    public partial class UpdateParcelsSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "ul. Klonowa 1, ");

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "PostalCode" },
                values: new object[] { "ul. Lipowa 2", "Kraków", "30-001" });

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.InsertData(
                table: "ParcelLockers",
                columns: new[] { "Id", "Address", "City", "IsActive", "PostalCode" },
                values: new object[,]
                {
                    { 4, "ul. Sosnowa 4", "Wrocław", true, "50-001" },
                    { 5, "ul. Kasztanowa 5", "Poznań", true, "60-001" },
                    { 6, "ul. Dębowa 6", "Łódź", true, "90-001" },
                    { 7, "ul. Topolowa 7", "Szczecin", true, "70-001" },
                    { 8, "ul. Bukowa 8", "Katowice", true, "40-001" },
                    { 9, "ul. Świerkowa 9", "Bydgoszcz", true, "85-001" },
                    { 10, "ul. Cedrowa 10", "Lublin", true, "20-001" },
                    { 11, "ul. Brzeziny 11", "Szczecinek", true, "78-100" },
                    { 12, "ul. Jesionowa 12", "Gdynia", true, "81-100" },
                    { 13, "ul. Modrzewiowa 13", "Kielce", true, "25-100" },
                    { 14, "ul. Dąbrowa 14", "Białystok", true, "15-100" },
                    { 15, "ul. Cisowa 15", "Sopot", true, "81-200" },
                    { 16, "ul. Akacjowa 16", "Toruń", true, "87-100" },
                    { 17, "ul. Bukietowa 17", "Olsztyn", true, "10-100" },
                    { 18, "ul. Dalia 18", "Rzeszów", true, "35-100" },
                    { 19, "ul. Górczyńska 19", "Legnica", true, "59-100" },
                    { 20, "ul. Kasztanowa 20", "Opole", true, "45-100" },
                    { 21, "ul. Lipowa 21", "Częstochowa", true, "42-100" },
                    { 22, "ul. Dębowa 22", "Rybnik", true, "44-100" },
                    { 23, "ul. Słoneczna 23", "Tarnów", true, "33-100" },
                    { 24, "ul. Brzozowa 24", "Zielona Góra", true, "65-100" },
                    { 25, "ul. Wierzbowy 25", "Gliwice", true, "44-100" },
                    { 26, "ul. Topolowa 26", "Słupsk", true, "76-200" },
                    { 27, "ul. Kasztanowa 27", "Płock", true, "09-100" },
                    { 28, "ul. Dębowa 28", "Koszalin", true, "75-100" },
                    { 29, "ul. Brzozowa 29", "Ostrów Wielkopolski", true, "63-400" },
                    { 30, "ul. Dąbrowa 30", "Wałbrzych", true, "58-100" },
                    { 31, "ul. Lipowa 31", "Ełk", true, "19-300" },
                    { 32, "ul. Topolowa 32", "Świdnica", true, "58-100" },
                    { 33, "ul. Bukietowa 33", "Mielec", true, "39-300" },
                    { 34, "ul. Sosnowa 34", "Kędzierzyn-Koźle", true, "47-200" },
                    { 35, "ul. Klonowa 35", "Konin", true, "62-500" },
                    { 36, "ul. Jesionowa 36", "Tychy", true, "43-100" },
                    { 37, "ul. Modrzewiowa 37", "Ruda Śląska", true, "41-700" },
                    { 38, "ul. Cedrowa 38", "Wejherowo", true, "84-200" },
                    { 39, "ul. Akacjowa 39", "Piekary Śląskie", true, "41-940" },
                    { 40, "ul. Topolowa 40", "Głogów", true, "67-200" },
                    { 41, "ul. Bukietowa 41", "Olkusz", true, "32-300" },
                    { 42, "ul. Dąbrowa 42", "Puławy", true, "24-100" },
                    { 43, "ul. Kasztanowa 43", "Zamość", true, "22-400" },
                    { 44, "ul. Lipowa 44", "Pabianice", true, "95-200" },
                    { 45, "ul. Brzozowa 45", "Legionowo", true, "05-120" },
                    { 46, "ul. Dębowa 46", "Piotrków Trybunalski", true, "97-300" },
                    { 47, "ul. Jesionowa 47", "Skierniewice", true, "96-100" },
                    { 48, "ul. Modrzewiowa 48", "Jastrzębie-Zdrój", true, "44-330" },
                    { 49, "ul. Cedrowa 49", "Sieradz", true, "98-200" },
                    { 50, "ul. Akacjowa 50", "Śrem", true, "64-100" },
                    { 51, "ul. Topolowa 51", "Biała Podlaska", true, "21-500" },
                    { 52, "ul. Klonowa 52", "Gniezno", true, "62-200" },
                    { 53, "ul. Lipowa 53", "Jarosław", true, "37-500" },
                    { 54, "ul. Brzozowa 54", "Zgierz", true, "95-100" },
                    { 55, "ul. Dębowa 55", "Przemyśl", true, "37-700" },
                    { 56, "ul. Jesionowa 56", "Lębork", true, "84-300" },
                    { 57, "ul. Modrzewiowa 57", "Tarnobrzeg", true, "39-400" },
                    { 58, "ul. Cedrowa 58", "Wodzisław Śląski", true, "44-300" },
                    { 59, "ul. Akacjowa 59", "Kołobrzeg", true, "78-100" },
                    { 60, "ul. Topolowa 60", "Kwidzyn", true, "82-500" },
                    { 61, "ul. Klonowa 61", "Bielawa", true, "58-260" },
                    { 62, "ul. Lipowa 62", "Gostynin", true, "09-500" },
                    { 63, "ul. Brzozowa 63", "Rawicz", true, "63-100" },
                    { 64, "ul. Dębowa 64", "Głuchołazy", true, "48-340" },
                    { 65, "ul. Jesionowa 65", "Łęczyca", true, "99-100" },
                    { 66, "ul. Modrzewiowa 66", "Lubin", true, "59-300" },
                    { 67, "ul. Cedrowa 67", "Żary", true, "68-200" },
                    { 68, "ul. Akacjowa 68", "Szczytno", true, "12-100" },
                    { 69, "ul. Topolowa 69", "Inowrocław", true, "88-100" },
                    { 70, "ul. Klonowa 70", "Kościerzyna", true, "83-400" },
                    { 71, "ul. Lipowa 71", "Pszczyna", true, "44-100" },
                    { 72, "ul. Brzozowa 72", "Trzebinia", true, "32-540" },
                    { 73, "ul. Dębowa 73", "Ostróda", true, "14-100" },
                    { 74, "ul. Jesionowa 74", "Nakło nad Notecią", true, "89-100" },
                    { 75, "ul. Modrzewiowa 75", "Dzierżoniów", true, "58-200" },
                    { 76, "ul. Cedrowa 76", "Kluczbork", true, "46-200" },
                    { 77, "ul. Akacjowa 77", "Mińsk Mazowiecki", true, "05-300" },
                    { 78, "ul. Topolowa 78", "Mława", true, "06-500" },
                    { 79, "ul. Klonowa 79", "Oleśnica", true, "56-400" },
                    { 80, "ul. Lipowa 80", "Nowa Sól", true, "67-100" },
                    { 81, "ul. Brzozowa 81", "Żagań", true, "68-100" },
                    { 82, "ul. Dębowa 82", "Ostrów Mazowiecka", true, "07-300" },
                    { 83, "ul. Jesionowa 83", "Sulechów", true, "66-100" },
                    { 84, "ul. Modrzewiowa 84", "Działdowo", true, "13-200" },
                    { 85, "ul. Cedrowa 85", "Będzin", true, "42-500" },
                    { 86, "ul. Akacjowa 86", "Mysłowice", true, "41-400" },
                    { 87, "ul. Topolowa 87", "Chojnice", true, "89-600" },
                    { 88, "ul. Klonowa 88", "Tomaszów Mazowiecki", true, "97-200" },
                    { 89, "ul. Lipowa 89", "Łomża", true, "18-400" },
                    { 90, "ul. Brzozowa 90", "Złotów", true, "77-400" },
                    { 91, "ul. Dębowa 91", "Pruszcz Gdański", true, "83-000" },
                    { 92, "ul. Jesionowa 92", "Krotoszyn", true, "63-700" },
                    { 93, "ul. Modrzewiowa 93", "Suwałki", true, "16-400" },
                    { 94, "ul. Cedrowa 94", "Koło", true, "62-600" },
                    { 95, "ul. Akacjowa 95", "Olkusz", true, "32-300" },
                    { 96, "ul. Topolowa 96", "Słubice", true, "69-100" },
                    { 97, "ul. Klonowa 97", "Jarocin", true, "63-200" },
                    { 98, "ul. Lipowa 98", "Bochnia", true, "32-700" },
                    { 99, "ul. Brzozowa 99", "Węgrów", true, "07-100" },
                    { 100, "ul. Dębowa 100", "Bartoszyce", true, "11-200" },
                    { 101, "Łakowa 3", "Gdańsk", true, "80-500" },
                    { 102, "piotrkowska 1", "Gdańsk", false, "80-500" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "ul. Klonowa 1");

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "PostalCode" },
                values: new object[] { "ul. Klonowa 34", "Warszawa", "00-001" });

            migrationBuilder.UpdateData(
                table: "ParcelLockers",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: false);
        }
    }
}
