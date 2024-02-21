﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Domain;

#nullable disable

namespace Shop.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shop.Domain.Entity.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4cd4cef0-1f24-4051-b2a4-bc2e47bd8125"),
                            DataCreate = new DateTime(2024, 2, 16, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            DataUpdate = new DateTime(2024, 2, 18, 18, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            Description = "Burns for 10 hours",
                            Name = "Lamp",
                            Price = 11.11m
                        },
                        new
                        {
                            Id = new Guid("3b5aae66-235a-4268-a6ab-8fcd998e78a9"),
                            DataCreate = new DateTime(2024, 2, 19, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            DataUpdate = new DateTime(2024, 2, 15, 23, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            Description = "Rubber under your foot",
                            Name = "Slippers",
                            Price = 11.11m
                        },
                        new
                        {
                            Id = new Guid("d0b0bebc-f12a-496e-9833-8ca8a693c774"),
                            DataCreate = new DateTime(2024, 2, 20, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            DataUpdate = new DateTime(2024, 2, 20, 7, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            Description = "Description1",
                            Name = "Name1",
                            Price = 1.99m
                        },
                        new
                        {
                            Id = new Guid("9c8f5f4b-2125-4a9a-9888-271412b47720"),
                            DataCreate = new DateTime(2024, 2, 19, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            DataUpdate = new DateTime(2024, 2, 19, 6, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            Description = "Description2",
                            Name = "Name2",
                            Price = 2.99m
                        },
                        new
                        {
                            Id = new Guid("a9aad111-3502-4421-8d06-0170fd7a330a"),
                            DataCreate = new DateTime(2024, 2, 18, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            DataUpdate = new DateTime(2024, 2, 18, 5, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            Description = "Description3",
                            Name = "Name3",
                            Price = 3.99m
                        },
                        new
                        {
                            Id = new Guid("d1c6f982-479e-4dba-9b87-34900aefbab5"),
                            DataCreate = new DateTime(2024, 2, 17, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            DataUpdate = new DateTime(2024, 2, 17, 4, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            Description = "Description4",
                            Name = "Name4",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = new Guid("cafa09ff-0c99-475e-b171-ae90b090447e"),
                            DataCreate = new DateTime(2024, 2, 16, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            DataUpdate = new DateTime(2024, 2, 16, 3, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            Description = "Description5",
                            Name = "Name5",
                            Price = 5.99m
                        },
                        new
                        {
                            Id = new Guid("77f02b6d-9101-46ed-ae09-14d9be4ae5ad"),
                            DataCreate = new DateTime(2024, 2, 15, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            DataUpdate = new DateTime(2024, 2, 15, 2, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            Description = "Description6",
                            Name = "Name6",
                            Price = 6.99m
                        });
                });

            modelBuilder.Entity("Shop.Domain.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("05413efe-815f-4175-8924-fb76e4ea0678"),
                            DataCreate = new DateTime(2024, 2, 16, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            DataUpdate = new DateTime(2024, 2, 11, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027),
                            Email = "admin@admin.com",
                            FirstName = "Admin",
                            LastName = "Admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
