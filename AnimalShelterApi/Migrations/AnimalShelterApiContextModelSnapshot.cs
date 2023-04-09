﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    partial class AnimalShelterApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 7,
                            Name = "Rex",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 10,
                            Name = "Dogtor",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Name = "Johnny",
                            Species = "Shark"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Name = "Pip",
                            Species = "Owl"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 22,
                            Name = "Maxwell",
                            Species = "Rhino"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 24,
                            Name = "Tony",
                            Species = "Rhino"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
