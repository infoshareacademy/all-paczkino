using AllPaczkino.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkinoLogic.Models.DataContext
{
    public class AllPaczkinoDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=AllPaczkino;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<ParcelLocker> ParcelLockers { get; set; }
    }
}
