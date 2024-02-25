﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Domain;

#nullable disable

namespace Shop.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240225080728_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shop.Domain.Entity.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8485db65-6fb2-426a-b400-2784f671ac3e"),
                            DataCreate = new DateTime(2024, 2, 11, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Name = "Category1"
                        },
                        new
                        {
                            Id = new Guid("82d1ef17-e11e-4960-ab2b-7ba01f76f251"),
                            DataCreate = new DateTime(2024, 2, 11, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Name = "Category2"
                        },
                        new
                        {
                            Id = new Guid("5b5e59ee-be34-4cd5-b2d8-12e0639a3a87"),
                            DataCreate = new DateTime(2024, 2, 11, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Name = "Category3"
                        },
                        new
                        {
                            Id = new Guid("71d390f6-07ab-4985-aa7b-7358079fcd88"),
                            CategoryId = new Guid("8485db65-6fb2-426a-b400-2784f671ac3e"),
                            DataCreate = new DateTime(2024, 2, 11, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Name = "Category4"
                        },
                        new
                        {
                            Id = new Guid("15981f9a-cacf-4816-930e-b13bd1ce7a0b"),
                            CategoryId = new Guid("8485db65-6fb2-426a-b400-2784f671ac3e"),
                            DataCreate = new DateTime(2024, 2, 11, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Name = "Category5"
                        });
                });

            modelBuilder.Entity("Shop.Domain.Entity.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
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

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9ab0de7e-592d-4160-a927-14c29f3a898b"),
                            CategoryId = new Guid("8485db65-6fb2-426a-b400-2784f671ac3e"),
                            DataCreate = new DateTime(2024, 2, 20, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 22, 18, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Description = "Burns for 10 hours",
                            Name = "Lamp",
                            Price = 11.11m,
                            UserId = new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc")
                        },
                        new
                        {
                            Id = new Guid("32d51141-9151-4a35-a60d-145abbb85c05"),
                            CategoryId = new Guid("5b5e59ee-be34-4cd5-b2d8-12e0639a3a87"),
                            DataCreate = new DateTime(2024, 2, 23, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 19, 23, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Description = "Rubber under your foot",
                            Name = "Slippers",
                            Price = 11.11m,
                            UserId = new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc")
                        },
                        new
                        {
                            Id = new Guid("291c5969-e0ff-4dfb-b4b1-dc4bd06a88de"),
                            CategoryId = new Guid("5b5e59ee-be34-4cd5-b2d8-12e0639a3a87"),
                            DataCreate = new DateTime(2024, 2, 24, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 24, 7, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Description = "Description1",
                            Name = "Name1",
                            Price = 1.99m,
                            UserId = new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc")
                        },
                        new
                        {
                            Id = new Guid("bb795085-8b82-4d1d-826d-e8c1e4de3827"),
                            CategoryId = new Guid("82d1ef17-e11e-4960-ab2b-7ba01f76f251"),
                            DataCreate = new DateTime(2024, 2, 23, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 23, 6, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Description = "Description2",
                            Name = "Name2",
                            Price = 2.99m,
                            UserId = new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc")
                        },
                        new
                        {
                            Id = new Guid("d670afdb-5f9c-48b8-be81-065a005c4eff"),
                            CategoryId = new Guid("8485db65-6fb2-426a-b400-2784f671ac3e"),
                            DataCreate = new DateTime(2024, 2, 22, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 22, 5, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Description = "Description3",
                            Name = "Name3",
                            Price = 3.99m,
                            UserId = new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc")
                        },
                        new
                        {
                            Id = new Guid("e79b1c2e-23c7-4b44-af63-0709a0327890"),
                            CategoryId = new Guid("5b5e59ee-be34-4cd5-b2d8-12e0639a3a87"),
                            DataCreate = new DateTime(2024, 2, 21, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 21, 4, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Description = "Description4",
                            Name = "Name4",
                            Price = 4.99m,
                            UserId = new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc")
                        },
                        new
                        {
                            Id = new Guid("2f18e4bd-9c6c-494d-b352-82a39cb88ff2"),
                            CategoryId = new Guid("82d1ef17-e11e-4960-ab2b-7ba01f76f251"),
                            DataCreate = new DateTime(2024, 2, 20, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 20, 3, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Description = "Description5",
                            Name = "Name5",
                            Price = 5.99m,
                            UserId = new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc")
                        },
                        new
                        {
                            Id = new Guid("0c62a3d1-8afb-440b-af85-fad9942de72f"),
                            CategoryId = new Guid("82d1ef17-e11e-4960-ab2b-7ba01f76f251"),
                            DataCreate = new DateTime(2024, 2, 19, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 19, 2, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Description = "Description6",
                            Name = "Name6",
                            Price = 6.99m,
                            UserId = new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc")
                        },
                        new
                        {
                            Id = new Guid("4a7dfd80-e3b4-405a-86dc-46172e094d55"),
                            CategoryId = new Guid("5b5e59ee-be34-4cd5-b2d8-12e0639a3a87"),
                            DataCreate = new DateTime(2024, 2, 18, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 18, 1, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Description = "Description7",
                            Name = "Name7",
                            Price = 7.99m,
                            UserId = new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc")
                        },
                        new
                        {
                            Id = new Guid("9d0f5582-d8a1-4871-8f10-3f29481b3ae6"),
                            CategoryId = new Guid("71d390f6-07ab-4985-aa7b-7358079fcd88"),
                            DataCreate = new DateTime(2024, 2, 17, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 19, 0, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Description = "Description8",
                            Name = "Name8",
                            Price = 8.99m,
                            UserId = new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc")
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
                            Id = new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc"),
                            DataCreate = new DateTime(2024, 2, 10, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            DataUpdate = new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045),
                            Email = "admin@admin.com",
                            FirstName = "Admin",
                            LastName = "Admin"
                        });
                });

            modelBuilder.Entity("Shop.Domain.Entity.Category", b =>
                {
                    b.HasOne("Shop.Domain.Entity.Category", null)
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Shop.Domain.Entity.Category", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
