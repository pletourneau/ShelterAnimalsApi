﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShelterAnimalsApi.Models;

#nullable disable

namespace ShelterAnimalsApi.Migrations
{
    [DbContext(typeof(ShelterAnimalsApiContext))]
    [Migration("20231027223915_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ShelterAnimalsApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 7,
                            Breed = "Bichon",
                            Name = "Matilda",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 10,
                            Breed = "Boxer",
                            Name = "Rexie",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Breed = "Persian",
                            Name = "Matilda",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Breed = "American Short-Hair",
                            Name = "Pip",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 12,
                            Breed = "Calico",
                            Name = "Bartholomew",
                            Species = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
