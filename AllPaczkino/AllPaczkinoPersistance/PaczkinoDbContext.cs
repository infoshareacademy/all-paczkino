using AllPaczkino.Models;
using Microsoft.EntityFrameworkCore;

namespace AllPaczkinoPersistance
{
    public class PaczkinoDbContext : DbContext
    {
        public PaczkinoDbContext(DbContextOptions<PaczkinoDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParcelLockerDb>().HasData(new ParcelLockerDb
            {
                Id = 1,
                City = "Warszawa",
                PostalCode = "00-001",
                Address = "ul. Klonowa 1",
                IsActive = true
            },
                new ParcelLockerDb
                {
                    Id = 2,
                    City = "Warszawa",
                    PostalCode = "00-001",
                    Address = "ul. Klonowa 34",
                    IsActive = true
                },
                new ParcelLockerDb
                {
                    Id = 3,
                    City = "Gdańsk",
                    PostalCode= "80-001",
                    Address= "ul. Brzozowa 3",
                    IsActive = false
                });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ParcelLockerDb> ParcelLockers { get; set; }
    }
}
