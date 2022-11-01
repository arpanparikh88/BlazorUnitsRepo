﻿// <auto-generated />
using BlazorUnitsApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorUnitsApp.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221101145403_UnitsTableSeeding")]
    partial class UnitsTableSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorUnitsApp.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The original, first radio series comes from a proposal called \"The Ends of the Earth\": six self-contained episodes, all ending with Earth being destroyed in a different way. While writing the first episode, Adams realised that he needed someone on the planet who was an alien to provide some context, and that this alien needed a reason to be there. Adams finally settled on making the alien a roving researcher for a \"wholly remarkable book\" named The Hitchhiker's Guide to the Galaxy.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Price = 9.99m,
                            Title = "The HitchHikers Guide To The Galaxy"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Sorrento asks mercenary i-R0k to learn Wade's true identity, intending to bribe him to win the contest on IOI's behalf. Wade and Art3mis discover from the Journals that Halliday once dated Morrow's wife Karen \"Kira\" Underwood. ",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                            Price = 5.55m,
                            Title = "Ready Player One"
                        });
                });

            modelBuilder.Entity("BlazorUnitsApp.Shared.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ip_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ip_Address = "162.191.107.130",
                            Latitude = 33.551769999999998,
                            Longitude = -112.13500000000001,
                            Name = "Unit One"
                        },
                        new
                        {
                            Id = 2,
                            Ip_Address = "162.191.107.130",
                            Latitude = 33.551740000000002,
                            Longitude = -112.1135,
                            Name = "Unit Two"
                        },
                        new
                        {
                            Id = 3,
                            Ip_Address = "162.191.107.130",
                            Latitude = 33.551729999999999,
                            Longitude = -112.1134,
                            Name = "Unit Three"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
