﻿// <auto-generated />
using System;
using CineVerse.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231212230142_AddPMediaAndMovieAndSerieTables")]
    partial class AddPMediaAndMovieAndSerieTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CineVerse.API.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CineVerse.API.Models.PhysicalMedia", b =>
                {
                    b.Property<int>("PhysicalMediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhysicalMediaId"));

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalTitle")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("PosterPath")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Premiere")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Runtime")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Synopsis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("PhysicalMediaId");

                    b.ToTable("PhysicalMedia");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PhysicalMedia");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("CineVerse.API.Models.Movie", b =>
                {
                    b.HasBaseType("CineVerse.API.Models.PhysicalMedia");

                    b.Property<bool>("BasedOnBooks")
                        .HasColumnType("bit");

                    b.Property<bool>("BasedOnRealFacts")
                        .HasColumnType("bit");

                    b.Property<bool>("Dubbed")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Movie");
                });

            modelBuilder.Entity("CineVerse.API.Models.Serie", b =>
                {
                    b.HasBaseType("CineVerse.API.Models.PhysicalMedia");

                    b.Property<bool>("Awarded")
                        .HasColumnType("bit");

                    b.Property<string>("Episodes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seasons")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Serie");
                });
#pragma warning restore 612, 618
        }
    }
}
