﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToyLibrary.Models;

namespace ToyLibrary.Migrations
{
    [DbContext(typeof(ToyLibraryContext))]
    [Migration("20220905044407_UserAgeMaxAndMinimum")]
    partial class UserAgeMaxAndMinimum
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ToyLibrary.Models.Toy", b =>
                {
                    b.Property<int>("ToyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UserAgeMaximum")
                        .HasColumnType("int");

                    b.Property<int>("UserAgeMinimum")
                        .HasColumnType("int");

                    b.HasKey("ToyId");

                    b.ToTable("Toys");
                });
#pragma warning restore 612, 618
        }
    }
}