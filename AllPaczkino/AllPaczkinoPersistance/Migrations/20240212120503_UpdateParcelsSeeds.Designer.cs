﻿// <auto-generated />
using AllPaczkinoPersistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AllPaczkinoPersistance.Migrations
{
    [DbContext(typeof(PaczkinoDbContext))]
    [Migration("20240212120503_UpdateParcelsSeeds")]
    partial class UpdateParcelsSeeds
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AllPaczkino.Models.ParcelLockerDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ParcelLockers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "ul. Klonowa 1, ",
                            City = "Warszawa",
                            IsActive = true,
                            PostalCode = "00-001"
                        },
                        new
                        {
                            Id = 2,
                            Address = "ul. Lipowa 2",
                            City = "Kraków",
                            IsActive = true,
                            PostalCode = "30-001"
                        },
                        new
                        {
                            Id = 3,
                            Address = "ul. Brzozowa 3",
                            City = "Gdańsk",
                            IsActive = true,
                            PostalCode = "80-001"
                        },
                        new
                        {
                            Id = 4,
                            Address = "ul. Sosnowa 4",
                            City = "Wrocław",
                            IsActive = true,
                            PostalCode = "50-001"
                        },
                        new
                        {
                            Id = 5,
                            Address = "ul. Kasztanowa 5",
                            City = "Poznań",
                            IsActive = true,
                            PostalCode = "60-001"
                        },
                        new
                        {
                            Id = 6,
                            Address = "ul. Dębowa 6",
                            City = "Łódź",
                            IsActive = true,
                            PostalCode = "90-001"
                        },
                        new
                        {
                            Id = 7,
                            Address = "ul. Topolowa 7",
                            City = "Szczecin",
                            IsActive = true,
                            PostalCode = "70-001"
                        },
                        new
                        {
                            Id = 8,
                            Address = "ul. Bukowa 8",
                            City = "Katowice",
                            IsActive = true,
                            PostalCode = "40-001"
                        },
                        new
                        {
                            Id = 9,
                            Address = "ul. Świerkowa 9",
                            City = "Bydgoszcz",
                            IsActive = true,
                            PostalCode = "85-001"
                        },
                        new
                        {
                            Id = 10,
                            Address = "ul. Cedrowa 10",
                            City = "Lublin",
                            IsActive = true,
                            PostalCode = "20-001"
                        },
                        new
                        {
                            Id = 11,
                            Address = "ul. Brzeziny 11",
                            City = "Szczecinek",
                            IsActive = true,
                            PostalCode = "78-100"
                        },
                        new
                        {
                            Id = 12,
                            Address = "ul. Jesionowa 12",
                            City = "Gdynia",
                            IsActive = true,
                            PostalCode = "81-100"
                        },
                        new
                        {
                            Id = 13,
                            Address = "ul. Modrzewiowa 13",
                            City = "Kielce",
                            IsActive = true,
                            PostalCode = "25-100"
                        },
                        new
                        {
                            Id = 14,
                            Address = "ul. Dąbrowa 14",
                            City = "Białystok",
                            IsActive = true,
                            PostalCode = "15-100"
                        },
                        new
                        {
                            Id = 15,
                            Address = "ul. Cisowa 15",
                            City = "Sopot",
                            IsActive = true,
                            PostalCode = "81-200"
                        },
                        new
                        {
                            Id = 16,
                            Address = "ul. Akacjowa 16",
                            City = "Toruń",
                            IsActive = true,
                            PostalCode = "87-100"
                        },
                        new
                        {
                            Id = 17,
                            Address = "ul. Bukietowa 17",
                            City = "Olsztyn",
                            IsActive = true,
                            PostalCode = "10-100"
                        },
                        new
                        {
                            Id = 18,
                            Address = "ul. Dalia 18",
                            City = "Rzeszów",
                            IsActive = true,
                            PostalCode = "35-100"
                        },
                        new
                        {
                            Id = 19,
                            Address = "ul. Górczyńska 19",
                            City = "Legnica",
                            IsActive = true,
                            PostalCode = "59-100"
                        },
                        new
                        {
                            Id = 20,
                            Address = "ul. Kasztanowa 20",
                            City = "Opole",
                            IsActive = true,
                            PostalCode = "45-100"
                        },
                        new
                        {
                            Id = 21,
                            Address = "ul. Lipowa 21",
                            City = "Częstochowa",
                            IsActive = true,
                            PostalCode = "42-100"
                        },
                        new
                        {
                            Id = 22,
                            Address = "ul. Dębowa 22",
                            City = "Rybnik",
                            IsActive = true,
                            PostalCode = "44-100"
                        },
                        new
                        {
                            Id = 23,
                            Address = "ul. Słoneczna 23",
                            City = "Tarnów",
                            IsActive = true,
                            PostalCode = "33-100"
                        },
                        new
                        {
                            Id = 24,
                            Address = "ul. Brzozowa 24",
                            City = "Zielona Góra",
                            IsActive = true,
                            PostalCode = "65-100"
                        },
                        new
                        {
                            Id = 25,
                            Address = "ul. Wierzbowy 25",
                            City = "Gliwice",
                            IsActive = true,
                            PostalCode = "44-100"
                        },
                        new
                        {
                            Id = 26,
                            Address = "ul. Topolowa 26",
                            City = "Słupsk",
                            IsActive = true,
                            PostalCode = "76-200"
                        },
                        new
                        {
                            Id = 27,
                            Address = "ul. Kasztanowa 27",
                            City = "Płock",
                            IsActive = true,
                            PostalCode = "09-100"
                        },
                        new
                        {
                            Id = 28,
                            Address = "ul. Dębowa 28",
                            City = "Koszalin",
                            IsActive = true,
                            PostalCode = "75-100"
                        },
                        new
                        {
                            Id = 29,
                            Address = "ul. Brzozowa 29",
                            City = "Ostrów Wielkopolski",
                            IsActive = true,
                            PostalCode = "63-400"
                        },
                        new
                        {
                            Id = 30,
                            Address = "ul. Dąbrowa 30",
                            City = "Wałbrzych",
                            IsActive = true,
                            PostalCode = "58-100"
                        },
                        new
                        {
                            Id = 31,
                            Address = "ul. Lipowa 31",
                            City = "Ełk",
                            IsActive = true,
                            PostalCode = "19-300"
                        },
                        new
                        {
                            Id = 32,
                            Address = "ul. Topolowa 32",
                            City = "Świdnica",
                            IsActive = true,
                            PostalCode = "58-100"
                        },
                        new
                        {
                            Id = 33,
                            Address = "ul. Bukietowa 33",
                            City = "Mielec",
                            IsActive = true,
                            PostalCode = "39-300"
                        },
                        new
                        {
                            Id = 34,
                            Address = "ul. Sosnowa 34",
                            City = "Kędzierzyn-Koźle",
                            IsActive = true,
                            PostalCode = "47-200"
                        },
                        new
                        {
                            Id = 35,
                            Address = "ul. Klonowa 35",
                            City = "Konin",
                            IsActive = true,
                            PostalCode = "62-500"
                        },
                        new
                        {
                            Id = 36,
                            Address = "ul. Jesionowa 36",
                            City = "Tychy",
                            IsActive = true,
                            PostalCode = "43-100"
                        },
                        new
                        {
                            Id = 37,
                            Address = "ul. Modrzewiowa 37",
                            City = "Ruda Śląska",
                            IsActive = true,
                            PostalCode = "41-700"
                        },
                        new
                        {
                            Id = 38,
                            Address = "ul. Cedrowa 38",
                            City = "Wejherowo",
                            IsActive = true,
                            PostalCode = "84-200"
                        },
                        new
                        {
                            Id = 39,
                            Address = "ul. Akacjowa 39",
                            City = "Piekary Śląskie",
                            IsActive = true,
                            PostalCode = "41-940"
                        },
                        new
                        {
                            Id = 40,
                            Address = "ul. Topolowa 40",
                            City = "Głogów",
                            IsActive = true,
                            PostalCode = "67-200"
                        },
                        new
                        {
                            Id = 41,
                            Address = "ul. Bukietowa 41",
                            City = "Olkusz",
                            IsActive = true,
                            PostalCode = "32-300"
                        },
                        new
                        {
                            Id = 42,
                            Address = "ul. Dąbrowa 42",
                            City = "Puławy",
                            IsActive = true,
                            PostalCode = "24-100"
                        },
                        new
                        {
                            Id = 43,
                            Address = "ul. Kasztanowa 43",
                            City = "Zamość",
                            IsActive = true,
                            PostalCode = "22-400"
                        },
                        new
                        {
                            Id = 44,
                            Address = "ul. Lipowa 44",
                            City = "Pabianice",
                            IsActive = true,
                            PostalCode = "95-200"
                        },
                        new
                        {
                            Id = 45,
                            Address = "ul. Brzozowa 45",
                            City = "Legionowo",
                            IsActive = true,
                            PostalCode = "05-120"
                        },
                        new
                        {
                            Id = 46,
                            Address = "ul. Dębowa 46",
                            City = "Piotrków Trybunalski",
                            IsActive = true,
                            PostalCode = "97-300"
                        },
                        new
                        {
                            Id = 47,
                            Address = "ul. Jesionowa 47",
                            City = "Skierniewice",
                            IsActive = true,
                            PostalCode = "96-100"
                        },
                        new
                        {
                            Id = 48,
                            Address = "ul. Modrzewiowa 48",
                            City = "Jastrzębie-Zdrój",
                            IsActive = true,
                            PostalCode = "44-330"
                        },
                        new
                        {
                            Id = 49,
                            Address = "ul. Cedrowa 49",
                            City = "Sieradz",
                            IsActive = true,
                            PostalCode = "98-200"
                        },
                        new
                        {
                            Id = 50,
                            Address = "ul. Akacjowa 50",
                            City = "Śrem",
                            IsActive = true,
                            PostalCode = "64-100"
                        },
                        new
                        {
                            Id = 51,
                            Address = "ul. Topolowa 51",
                            City = "Biała Podlaska",
                            IsActive = true,
                            PostalCode = "21-500"
                        },
                        new
                        {
                            Id = 52,
                            Address = "ul. Klonowa 52",
                            City = "Gniezno",
                            IsActive = true,
                            PostalCode = "62-200"
                        },
                        new
                        {
                            Id = 53,
                            Address = "ul. Lipowa 53",
                            City = "Jarosław",
                            IsActive = true,
                            PostalCode = "37-500"
                        },
                        new
                        {
                            Id = 54,
                            Address = "ul. Brzozowa 54",
                            City = "Zgierz",
                            IsActive = true,
                            PostalCode = "95-100"
                        },
                        new
                        {
                            Id = 55,
                            Address = "ul. Dębowa 55",
                            City = "Przemyśl",
                            IsActive = true,
                            PostalCode = "37-700"
                        },
                        new
                        {
                            Id = 56,
                            Address = "ul. Jesionowa 56",
                            City = "Lębork",
                            IsActive = true,
                            PostalCode = "84-300"
                        },
                        new
                        {
                            Id = 57,
                            Address = "ul. Modrzewiowa 57",
                            City = "Tarnobrzeg",
                            IsActive = true,
                            PostalCode = "39-400"
                        },
                        new
                        {
                            Id = 58,
                            Address = "ul. Cedrowa 58",
                            City = "Wodzisław Śląski",
                            IsActive = true,
                            PostalCode = "44-300"
                        },
                        new
                        {
                            Id = 59,
                            Address = "ul. Akacjowa 59",
                            City = "Kołobrzeg",
                            IsActive = true,
                            PostalCode = "78-100"
                        },
                        new
                        {
                            Id = 60,
                            Address = "ul. Topolowa 60",
                            City = "Kwidzyn",
                            IsActive = true,
                            PostalCode = "82-500"
                        },
                        new
                        {
                            Id = 61,
                            Address = "ul. Klonowa 61",
                            City = "Bielawa",
                            IsActive = true,
                            PostalCode = "58-260"
                        },
                        new
                        {
                            Id = 62,
                            Address = "ul. Lipowa 62",
                            City = "Gostynin",
                            IsActive = true,
                            PostalCode = "09-500"
                        },
                        new
                        {
                            Id = 63,
                            Address = "ul. Brzozowa 63",
                            City = "Rawicz",
                            IsActive = true,
                            PostalCode = "63-100"
                        },
                        new
                        {
                            Id = 64,
                            Address = "ul. Dębowa 64",
                            City = "Głuchołazy",
                            IsActive = true,
                            PostalCode = "48-340"
                        },
                        new
                        {
                            Id = 65,
                            Address = "ul. Jesionowa 65",
                            City = "Łęczyca",
                            IsActive = true,
                            PostalCode = "99-100"
                        },
                        new
                        {
                            Id = 66,
                            Address = "ul. Modrzewiowa 66",
                            City = "Lubin",
                            IsActive = true,
                            PostalCode = "59-300"
                        },
                        new
                        {
                            Id = 67,
                            Address = "ul. Cedrowa 67",
                            City = "Żary",
                            IsActive = true,
                            PostalCode = "68-200"
                        },
                        new
                        {
                            Id = 68,
                            Address = "ul. Akacjowa 68",
                            City = "Szczytno",
                            IsActive = true,
                            PostalCode = "12-100"
                        },
                        new
                        {
                            Id = 69,
                            Address = "ul. Topolowa 69",
                            City = "Inowrocław",
                            IsActive = true,
                            PostalCode = "88-100"
                        },
                        new
                        {
                            Id = 70,
                            Address = "ul. Klonowa 70",
                            City = "Kościerzyna",
                            IsActive = true,
                            PostalCode = "83-400"
                        },
                        new
                        {
                            Id = 71,
                            Address = "ul. Lipowa 71",
                            City = "Pszczyna",
                            IsActive = true,
                            PostalCode = "44-100"
                        },
                        new
                        {
                            Id = 72,
                            Address = "ul. Brzozowa 72",
                            City = "Trzebinia",
                            IsActive = true,
                            PostalCode = "32-540"
                        },
                        new
                        {
                            Id = 73,
                            Address = "ul. Dębowa 73",
                            City = "Ostróda",
                            IsActive = true,
                            PostalCode = "14-100"
                        },
                        new
                        {
                            Id = 74,
                            Address = "ul. Jesionowa 74",
                            City = "Nakło nad Notecią",
                            IsActive = true,
                            PostalCode = "89-100"
                        },
                        new
                        {
                            Id = 75,
                            Address = "ul. Modrzewiowa 75",
                            City = "Dzierżoniów",
                            IsActive = true,
                            PostalCode = "58-200"
                        },
                        new
                        {
                            Id = 76,
                            Address = "ul. Cedrowa 76",
                            City = "Kluczbork",
                            IsActive = true,
                            PostalCode = "46-200"
                        },
                        new
                        {
                            Id = 77,
                            Address = "ul. Akacjowa 77",
                            City = "Mińsk Mazowiecki",
                            IsActive = true,
                            PostalCode = "05-300"
                        },
                        new
                        {
                            Id = 78,
                            Address = "ul. Topolowa 78",
                            City = "Mława",
                            IsActive = true,
                            PostalCode = "06-500"
                        },
                        new
                        {
                            Id = 79,
                            Address = "ul. Klonowa 79",
                            City = "Oleśnica",
                            IsActive = true,
                            PostalCode = "56-400"
                        },
                        new
                        {
                            Id = 80,
                            Address = "ul. Lipowa 80",
                            City = "Nowa Sól",
                            IsActive = true,
                            PostalCode = "67-100"
                        },
                        new
                        {
                            Id = 81,
                            Address = "ul. Brzozowa 81",
                            City = "Żagań",
                            IsActive = true,
                            PostalCode = "68-100"
                        },
                        new
                        {
                            Id = 82,
                            Address = "ul. Dębowa 82",
                            City = "Ostrów Mazowiecka",
                            IsActive = true,
                            PostalCode = "07-300"
                        },
                        new
                        {
                            Id = 83,
                            Address = "ul. Jesionowa 83",
                            City = "Sulechów",
                            IsActive = true,
                            PostalCode = "66-100"
                        },
                        new
                        {
                            Id = 84,
                            Address = "ul. Modrzewiowa 84",
                            City = "Działdowo",
                            IsActive = true,
                            PostalCode = "13-200"
                        },
                        new
                        {
                            Id = 85,
                            Address = "ul. Cedrowa 85",
                            City = "Będzin",
                            IsActive = true,
                            PostalCode = "42-500"
                        },
                        new
                        {
                            Id = 86,
                            Address = "ul. Akacjowa 86",
                            City = "Mysłowice",
                            IsActive = true,
                            PostalCode = "41-400"
                        },
                        new
                        {
                            Id = 87,
                            Address = "ul. Topolowa 87",
                            City = "Chojnice",
                            IsActive = true,
                            PostalCode = "89-600"
                        },
                        new
                        {
                            Id = 88,
                            Address = "ul. Klonowa 88",
                            City = "Tomaszów Mazowiecki",
                            IsActive = true,
                            PostalCode = "97-200"
                        },
                        new
                        {
                            Id = 89,
                            Address = "ul. Lipowa 89",
                            City = "Łomża",
                            IsActive = true,
                            PostalCode = "18-400"
                        },
                        new
                        {
                            Id = 90,
                            Address = "ul. Brzozowa 90",
                            City = "Złotów",
                            IsActive = true,
                            PostalCode = "77-400"
                        },
                        new
                        {
                            Id = 91,
                            Address = "ul. Dębowa 91",
                            City = "Pruszcz Gdański",
                            IsActive = true,
                            PostalCode = "83-000"
                        },
                        new
                        {
                            Id = 92,
                            Address = "ul. Jesionowa 92",
                            City = "Krotoszyn",
                            IsActive = true,
                            PostalCode = "63-700"
                        },
                        new
                        {
                            Id = 93,
                            Address = "ul. Modrzewiowa 93",
                            City = "Suwałki",
                            IsActive = true,
                            PostalCode = "16-400"
                        },
                        new
                        {
                            Id = 94,
                            Address = "ul. Cedrowa 94",
                            City = "Koło",
                            IsActive = true,
                            PostalCode = "62-600"
                        },
                        new
                        {
                            Id = 95,
                            Address = "ul. Akacjowa 95",
                            City = "Olkusz",
                            IsActive = true,
                            PostalCode = "32-300"
                        },
                        new
                        {
                            Id = 96,
                            Address = "ul. Topolowa 96",
                            City = "Słubice",
                            IsActive = true,
                            PostalCode = "69-100"
                        },
                        new
                        {
                            Id = 97,
                            Address = "ul. Klonowa 97",
                            City = "Jarocin",
                            IsActive = true,
                            PostalCode = "63-200"
                        },
                        new
                        {
                            Id = 98,
                            Address = "ul. Lipowa 98",
                            City = "Bochnia",
                            IsActive = true,
                            PostalCode = "32-700"
                        },
                        new
                        {
                            Id = 99,
                            Address = "ul. Brzozowa 99",
                            City = "Węgrów",
                            IsActive = true,
                            PostalCode = "07-100"
                        },
                        new
                        {
                            Id = 100,
                            Address = "ul. Dębowa 100",
                            City = "Bartoszyce",
                            IsActive = true,
                            PostalCode = "11-200"
                        },
                        new
                        {
                            Id = 101,
                            Address = "Łakowa 3",
                            City = "Gdańsk",
                            IsActive = true,
                            PostalCode = "80-500"
                        },
                        new
                        {
                            Id = 102,
                            Address = "piotrkowska 1",
                            City = "Gdańsk",
                            IsActive = false,
                            PostalCode = "80-500"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
