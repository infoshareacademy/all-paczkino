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
    [Migration("20240211111654_AddSeedParcelLocker")]
    partial class AddSeedParcelLocker
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
                            Address = "ul. Klonowa 1",
                            City = "Warszawa",
                            IsActive = true,
                            PostalCode = "00-001"
                        },
                        new
                        {
                            Id = 2,
                            Address = "ul. Klonowa 34",
                            City = "Warszawa",
                            IsActive = true,
                            PostalCode = "00-001"
                        },
                        new
                        {
                            Id = 3,
                            Address = "ul. Brzozowa 3",
                            City = "Gdańsk",
                            IsActive = false,
                            PostalCode = "80-001"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
