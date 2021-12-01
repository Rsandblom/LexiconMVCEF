﻿// <auto-generated />
using LexiconMVCData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LexiconMVCData.Migrations
{
    [DbContext(typeof(LexiconMVCDbContext))]
    [Migration("20211130095653_assignment2-1")]
    partial class assignment21
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LexiconMVCData.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Göteborg"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Malmö"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            Name = "Stockholm"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            Name = "Oslo"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 2,
                            Name = "Bergen"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 2,
                            Name = "Trondheim"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 3,
                            Name = "Köpenhamn"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 3,
                            Name = "Ålborg"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 3,
                            Name = "Helsingör"
                        });
                });

            modelBuilder.Entity("LexiconMVCData.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sverige"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Norge"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Danmark"
                        });
                });

            modelBuilder.Entity("LexiconMVCData.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Adam Adamsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            Name = "Bertil Bertilsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 3,
                            Name = "Carl Carlsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 1,
                            Name = "Dan Danielsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 2,
                            Name = "Erik Eriksson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            Name = "Frans Fransson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 1,
                            Name = "Gustav Gustavsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 2,
                            Name = "Henrik Henriksson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 3,
                            Name = "Ivar Ivarsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 1,
                            Name = "Jan Jansson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 2,
                            Name = "Karl Karlsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 12,
                            CityId = 3,
                            Name = "Lars Larsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 13,
                            CityId = 4,
                            Name = "Ole Bramserud",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 14,
                            CityId = 5,
                            Name = "Petter Northug",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 15,
                            CityId = 6,
                            Name = "Theres Johaug",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 16,
                            CityId = 4,
                            Name = "Gunn-Rita Dahle Flesjå",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 17,
                            CityId = 5,
                            Name = "Fleksnes",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 18,
                            CityId = 6,
                            Name = "Max manus",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 19,
                            CityId = 7,
                            Name = "Nikolaj Coster-Waldau",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 20,
                            CityId = 8,
                            Name = "Iben Hjejle",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 21,
                            CityId = 9,
                            Name = "Mads Mikkelsen",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 22,
                            CityId = 7,
                            Name = "Kristian Tyrann",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 23,
                            CityId = 8,
                            Name = "Kim Larsen",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 24,
                            CityId = 9,
                            Name = "Tycho Brahe",
                            PhoneNumber = "031-123456"
                        });
                });

            modelBuilder.Entity("LexiconMVCData.Models.City", b =>
                {
                    b.HasOne("LexiconMVCData.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LexiconMVCData.Models.Person", b =>
                {
                    b.HasOne("LexiconMVCData.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
