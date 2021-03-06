﻿// <auto-generated />
using JustWorkForGodsSake.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfCoreSeed.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20210217173406_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("JustWorkForGodsSake.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HomeTown")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UserGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Jack",
                            HomeTown = "Varna",
                            LastName = "Smith",
                            UserGroupId = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Simo",
                            HomeTown = "Sofia",
                            LastName = "Petrov",
                            UserGroupId = 1
                        });
                });

            modelBuilder.Entity("JustWorkForGodsSake.Models.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Memebers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("UserGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Memebers = 226,
                            Name = "SoftServe"
                        },
                        new
                        {
                            Id = 2,
                            Memebers = 150,
                            Name = "IKEA"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
