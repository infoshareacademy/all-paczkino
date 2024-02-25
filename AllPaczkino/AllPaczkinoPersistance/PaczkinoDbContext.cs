using AllPaczkino.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AllPaczkinoPersistance
{
    public class PaczkinoDbContext : IdentityDbContext<IdentityUser>
    {
        public PaczkinoDbContext(DbContextOptions<PaczkinoDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName="ADMIN", Id = Guid.NewGuid().ToString()},
                new IdentityRole { Name = "User", NormalizedName="USER", Id = Guid.NewGuid().ToString()}
                );
            modelBuilder.Entity<ParcelLockerDb>().HasData(
                   new ParcelLockerDb
                   {
                       Id = 1,
                       City = "Warszawa",
                       PostalCode = "00-001",
                       Address = "ul. Klonowa 1, ",
                       IsActive = true
                   },
                new ParcelLockerDb
                {
                    Id = 2,
                    City = "Kraków",
                    PostalCode = "30-001",
                    Address = "ul. Lipowa 2",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 3,
                    City = "Gdańsk",
                    PostalCode = "80-001",
                    Address = "ul. Brzozowa 3",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 4,
                    City = "Wrocław",
                    PostalCode = "50-001",
                    Address = "ul. Sosnowa 4",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 5,
                    City = "Poznań",
                    PostalCode = "60-001",
                    Address = "ul. Kasztanowa 5",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 6,
                    City = "Łódź",
                    PostalCode = "90-001",
                    Address = "ul. Dębowa 6",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 7,
                    City = "Szczecin",
                    PostalCode = "70-001",
                    Address = "ul. Topolowa 7",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 8,
                    City = "Katowice",
                    PostalCode = "40-001",
                    Address = "ul. Bukowa 8",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 9,
                    City = "Bydgoszcz",
                    PostalCode = "85-001",
                    Address = "ul. Świerkowa 9",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 10,
                    City = "Lublin",
                    PostalCode = "20-001",
                    Address = "ul. Cedrowa 10",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 11,
                    City = "Szczecinek",
                    PostalCode = "78-100",
                    Address = "ul. Brzeziny 11",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 12,
                    City = "Gdynia",
                    PostalCode = "81-100",
                    Address = "ul. Jesionowa 12",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 13,
                    City = "Kielce",
                    PostalCode = "25-100",
                    Address = "ul. Modrzewiowa 13",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 14,
                    City = "Białystok",
                    PostalCode = "15-100",
                    Address = "ul. Dąbrowa 14",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 15,
                    City = "Sopot",
                    PostalCode = "81-200",
                    Address = "ul. Cisowa 15",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 16,
                    City = "Toruń",
                    PostalCode = "87-100",
                    Address = "ul. Akacjowa 16",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 17,
                    City = "Olsztyn",
                    PostalCode = "10-100",
                    Address = "ul. Bukietowa 17",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 18,
                    City = "Rzeszów",
                    PostalCode = "35-100",
                    Address = "ul. Dalia 18",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 19,
                    City = "Legnica",
                    PostalCode = "59-100",
                    Address = "ul. Górczyńska 19",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 20,
                    City = "Opole",
                    PostalCode = "45-100",
                    Address = "ul. Kasztanowa 20",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 21,
                    City = "Częstochowa",
                    PostalCode = "42-100",
                    Address = "ul. Lipowa 21",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 22,
                    City = "Rybnik",
                    PostalCode = "44-100",
                    Address = "ul. Dębowa 22",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 23,
                    City = "Tarnów",
                    PostalCode = "33-100",
                    Address = "ul. Słoneczna 23",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 24,
                    City = "Zielona Góra",
                    PostalCode = "65-100",
                    Address = "ul. Brzozowa 24",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 25,
                    City = "Gliwice",
                    PostalCode = "44-100",
                    Address = "ul. Wierzbowy 25",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 26,
                    City = "Słupsk",
                    PostalCode = "76-200",
                    Address = "ul. Topolowa 26",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 27,
                    City = "Płock",
                    PostalCode = "09-100",
                    Address = "ul. Kasztanowa 27",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 28,
                    City = "Koszalin",
                    PostalCode = "75-100",
                    Address = "ul. Dębowa 28",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 29,
                    City = "Ostrów Wielkopolski",
                    PostalCode = "63-400",
                    Address = "ul. Brzozowa 29",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 30,
                    City = "Wałbrzych",
                    PostalCode = "58-100",
                    Address = "ul. Dąbrowa 30",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 31,
                    City = "Ełk",
                    PostalCode = "19-300",
                    Address = "ul. Lipowa 31",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 32,
                    City = "Świdnica",
                    PostalCode = "58-100",
                    Address = "ul. Topolowa 32",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 33,
                    City = "Mielec",
                    PostalCode = "39-300",
                    Address = "ul. Bukietowa 33",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 34,
                    City = "Kędzierzyn-Koźle",
                    PostalCode = "47-200",
                    Address = "ul. Sosnowa 34",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 35,
                    City = "Konin",
                    PostalCode = "62-500",
                    Address = "ul. Klonowa 35",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 36,
                    City = "Tychy",
                    PostalCode = "43-100",
                    Address = "ul. Jesionowa 36",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 37,
                    City = "Ruda Śląska",
                    PostalCode = "41-700",
                    Address = "ul. Modrzewiowa 37",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 38,
                    City = "Wejherowo",
                    PostalCode = "84-200",
                    Address = "ul. Cedrowa 38",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 39,
                    City = "Piekary Śląskie",
                    PostalCode = "41-940",
                    Address = "ul. Akacjowa 39",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 40,
                    City = "Głogów",
                    PostalCode = "67-200",
                    Address = "ul. Topolowa 40",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 41,
                    City = "Olkusz",
                    PostalCode = "32-300",
                    Address = "ul. Bukietowa 41",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 42,
                    City = "Puławy",
                    PostalCode = "24-100",
                    Address = "ul. Dąbrowa 42",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 43,
                    City = "Zamość",
                    PostalCode = "22-400",
                    Address = "ul. Kasztanowa 43",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 44,
                    City = "Pabianice",
                    PostalCode = "95-200",
                    Address = "ul. Lipowa 44",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 45,
                    City = "Legionowo",
                    PostalCode = "05-120",
                    Address = "ul. Brzozowa 45",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 46,
                    City = "Piotrków Trybunalski",
                    PostalCode = "97-300",
                    Address = "ul. Dębowa 46",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 47,
                    City = "Skierniewice",
                    PostalCode = "96-100",
                    Address = "ul. Jesionowa 47",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 48,
                    City = "Jastrzębie-Zdrój",
                    PostalCode = "44-330",
                    Address = "ul. Modrzewiowa 48",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 49,
                    City = "Sieradz",
                    PostalCode = "98-200",
                    Address = "ul. Cedrowa 49",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 50,
                    City = "Śrem",
                    PostalCode = "64-100",
                    Address = "ul. Akacjowa 50",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 51,
                    City = "Biała Podlaska",
                    PostalCode = "21-500",
                    Address = "ul. Topolowa 51",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 52,
                    City = "Gniezno",
                    PostalCode = "62-200",
                    Address = "ul. Klonowa 52",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 53,
                    City = "Jarosław",
                    PostalCode = "37-500",
                    Address = "ul. Lipowa 53",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 54,
                    City = "Zgierz",
                    PostalCode = "95-100",
                    Address = "ul. Brzozowa 54",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 55,
                    City = "Przemyśl",
                    PostalCode = "37-700",
                    Address = "ul. Dębowa 55",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 56,
                    City = "Lębork",
                    PostalCode = "84-300",
                    Address = "ul. Jesionowa 56",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 57,
                    City = "Tarnobrzeg",
                    PostalCode = "39-400",
                    Address = "ul. Modrzewiowa 57",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 58,
                    City = "Wodzisław Śląski",
                    PostalCode = "44-300",
                    Address = "ul. Cedrowa 58",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 59,
                    City = "Kołobrzeg",
                    PostalCode = "78-100",
                    Address = "ul. Akacjowa 59",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 60,
                    City = "Kwidzyn",
                    PostalCode = "82-500",
                    Address = "ul. Topolowa 60",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 61,
                    City = "Bielawa",
                    PostalCode = "58-260",
                    Address = "ul. Klonowa 61",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 62,
                    City = "Gostynin",
                    PostalCode = "09-500",
                    Address = "ul. Lipowa 62",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 63,
                    City = "Rawicz",
                    PostalCode = "63-100",
                    Address = "ul. Brzozowa 63",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 64,
                    City = "Głuchołazy",
                    PostalCode = "48-340",
                    Address = "ul. Dębowa 64",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 65,
                    City = "Łęczyca",
                    PostalCode = "99-100",
                    Address = "ul. Jesionowa 65",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 66,
                    City = "Lubin",
                    PostalCode = "59-300",
                    Address = "ul. Modrzewiowa 66",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 67,
                    City = "Żary",
                    PostalCode = "68-200",
                    Address = "ul. Cedrowa 67",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 68,
                    City = "Szczytno",
                    PostalCode = "12-100",
                    Address = "ul. Akacjowa 68",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 69,
                    City = "Inowrocław",
                    PostalCode = "88-100",
                    Address = "ul. Topolowa 69",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 70,
                    City = "Kościerzyna",
                    PostalCode = "83-400",
                    Address = "ul. Klonowa 70",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 71,
                    City = "Pszczyna",
                    PostalCode = "44-100",
                    Address = "ul. Lipowa 71",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 72,
                    City = "Trzebinia",
                    PostalCode = "32-540",
                    Address = "ul. Brzozowa 72",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 73,
                    City = "Ostróda",
                    PostalCode = "14-100",
                    Address = "ul. Dębowa 73",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 74,
                    City = "Nakło nad Notecią",
                    PostalCode = "89-100",
                    Address = "ul. Jesionowa 74",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 75,
                    City = "Dzierżoniów",
                    PostalCode = "58-200",
                    Address = "ul. Modrzewiowa 75",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 76,
                    City = "Kluczbork",
                    PostalCode = "46-200",
                    Address = "ul. Cedrowa 76",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 77,
                    City = "Mińsk Mazowiecki",
                    PostalCode = "05-300",
                    Address = "ul. Akacjowa 77",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 78,
                    City = "Mława",
                    PostalCode = "06-500",
                    Address = "ul. Topolowa 78",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 79,
                    City = "Oleśnica",
                    PostalCode = "56-400",
                    Address = "ul. Klonowa 79",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 80,
                    City = "Nowa Sól",
                    PostalCode = "67-100",
                    Address = "ul. Lipowa 80",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 81,
                    City = "Żagań",
                    PostalCode = "68-100",
                    Address = "ul. Brzozowa 81",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 82,
                    City = "Ostrów Mazowiecka",
                    PostalCode = "07-300",
                    Address = "ul. Dębowa 82",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 83,
                    City = "Sulechów",
                    PostalCode = "66-100",
                    Address = "ul. Jesionowa 83",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 84,
                    City = "Działdowo",
                    PostalCode = "13-200",
                    Address = "ul. Modrzewiowa 84",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 85,
                    City = "Będzin",
                    PostalCode = "42-500",
                    Address = "ul. Cedrowa 85",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 86,
                    City = "Mysłowice",
                    PostalCode = "41-400",
                    Address = "ul. Akacjowa 86",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 87,
                    City = "Chojnice",
                    PostalCode = "89-600",
                    Address = "ul. Topolowa 87",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 88,
                    City = "Tomaszów Mazowiecki",
                    PostalCode = "97-200",
                    Address = "ul. Klonowa 88",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 89,
                    City = "Łomża",
                    PostalCode = "18-400",
                    Address = "ul. Lipowa 89",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 90,
                    City = "Złotów",
                    PostalCode = "77-400",
                    Address = "ul. Brzozowa 90",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 91,
                    City = "Pruszcz Gdański",
                    PostalCode = "83-000",
                    Address = "ul. Dębowa 91",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 92,
                    City = "Krotoszyn",
                    PostalCode = "63-700",
                    Address = "ul. Jesionowa 92",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 93,
                    City = "Suwałki",
                    PostalCode = "16-400",
                    Address = "ul. Modrzewiowa 93",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 94,
                    City = "Koło",
                    PostalCode = "62-600",
                    Address = "ul. Cedrowa 94",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 95,
                    City = "Olkusz",
                    PostalCode = "32-300",
                    Address = "ul. Akacjowa 95",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 96,
                    City = "Słubice",
                    PostalCode = "69-100",
                    Address = "ul. Topolowa 96",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 97,
                    City = "Jarocin",
                    PostalCode = "63-200",
                    Address = "ul. Klonowa 97",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 98,
                    City = "Bochnia",
                    PostalCode = "32-700",
                    Address = "ul. Lipowa 98",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 99,
                    City = "Węgrów",
                    PostalCode = "07-100",
                    Address = "ul. Brzozowa 99",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 100,
                    City = "Bartoszyce",
                    PostalCode = "11-200",
                    Address = "ul. Dębowa 100",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 101,
                    City = "Gdańsk",
                    PostalCode = "80-500",
                    Address = "Łakowa 3",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 102,
                    City = "Gdańsk",
                    PostalCode = "80-500",
                    Address = "piotrkowska 1"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ParcelLockerDb> ParcelLockers { get; set; }
    }
}
