﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.BackApp.Domain;

#nullable disable

namespace Shop.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240326134344_comment")]
    partial class comment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shop.BackApp.Domain.Entity.Category", b =>
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
                            Id = new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Ноутбуки и компьютеры"
                        },
                        new
                        {
                            Id = new Guid("c753efec-f8f2-4983-9209-21c8bffb130e"),
                            CategoryId = new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Ноутбуки"
                        },
                        new
                        {
                            Id = new Guid("16f5311f-3107-4046-a799-7ea4c404eb0f"),
                            CategoryId = new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Компьютеры"
                        },
                        new
                        {
                            Id = new Guid("b4dc1957-03d5-48f5-96a0-b8c0abe49e9d"),
                            CategoryId = new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Мониторы"
                        },
                        new
                        {
                            Id = new Guid("180133e6-ac4d-4b5f-9ada-f69beb2769f8"),
                            CategoryId = new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Планшеты"
                        },
                        new
                        {
                            Id = new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"),
                            CategoryId = new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Компьютерные комплектующие"
                        },
                        new
                        {
                            Id = new Guid("d92e36e1-6646-4916-814c-2cf485311b36"),
                            CategoryId = new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Материнские платы"
                        },
                        new
                        {
                            Id = new Guid("69df04e1-00fc-476c-88e2-a27899777bd9"),
                            CategoryId = new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Процессоры"
                        },
                        new
                        {
                            Id = new Guid("1ee1dd26-9258-463f-b193-f7bfdf51ad71"),
                            CategoryId = new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Оперативная память"
                        },
                        new
                        {
                            Id = new Guid("52d9062e-fe86-4e0e-8ab7-921b9eb58a85"),
                            CategoryId = new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Видеокарты"
                        },
                        new
                        {
                            Id = new Guid("492694a7-9cd4-4cd3-82e4-1e9187168fbf"),
                            CategoryId = new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Звуковые карты"
                        },
                        new
                        {
                            Id = new Guid("3f24ee6c-0e89-4d50-adad-94aa62ffb606"),
                            CategoryId = new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Жесткие диски"
                        },
                        new
                        {
                            Id = new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Смартфоны, ТВ и Электроника"
                        },
                        new
                        {
                            Id = new Guid("943a9ab8-d674-4964-9e7f-c1269ec6cdf3"),
                            CategoryId = new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Мобильные телефоны"
                        },
                        new
                        {
                            Id = new Guid("6a2f094e-846a-4e36-921d-5557dce9d1c6"),
                            CategoryId = new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Телевизоры"
                        },
                        new
                        {
                            Id = new Guid("5f9e563e-0874-453f-9329-1ff149de7b9e"),
                            CategoryId = new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Наушники и аксессуары"
                        },
                        new
                        {
                            Id = new Guid("91fa8947-ed26-46b2-a25f-e651d7ed7bb5"),
                            CategoryId = new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Носимые гаджеты"
                        },
                        new
                        {
                            Id = new Guid("08a7ade7-24c1-4e87-9ffe-e3895d540785"),
                            CategoryId = new Guid("91fa8947-ed26-46b2-a25f-e651d7ed7bb5"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Смарт-часы"
                        },
                        new
                        {
                            Id = new Guid("1e3bb498-cb17-4a41-915f-d4820db4c468"),
                            CategoryId = new Guid("91fa8947-ed26-46b2-a25f-e651d7ed7bb5"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "3D и VR очки"
                        },
                        new
                        {
                            Id = new Guid("af344ca8-4e8c-4679-8e24-4699a9608507"),
                            CategoryId = new Guid("91fa8947-ed26-46b2-a25f-e651d7ed7bb5"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Фитнес-браслеты"
                        },
                        new
                        {
                            Id = new Guid("f445ffea-b9f6-4c60-8517-ccb368e6a898"),
                            CategoryId = new Guid("91fa8947-ed26-46b2-a25f-e651d7ed7bb5"),
                            DataCreate = new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Name = "Смарт-кольца"
                        });
                });

            modelBuilder.Entity("Shop.BackApp.Domain.Entity.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Shop.BackApp.Domain.Entity.Product", b =>
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
                            Id = new Guid("698feb71-b863-4e5f-88c7-30acf5fb4b6a"),
                            CategoryId = new Guid("d92e36e1-6646-4916-814c-2cf485311b36"),
                            DataCreate = new DateTime(2024, 3, 21, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 23, 23, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Description = "Burns for 10 hours",
                            Name = "Lamp",
                            Price = 11.11m,
                            UserId = new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208")
                        },
                        new
                        {
                            Id = new Guid("d51013f7-0e66-4d21-9da9-eaaad2b73905"),
                            CategoryId = new Guid("943a9ab8-d674-4964-9e7f-c1269ec6cdf3"),
                            DataCreate = new DateTime(2024, 3, 24, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 21, 4, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Description = "Rubber under your foot",
                            Name = "Slippers",
                            Price = 11.11m,
                            UserId = new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208")
                        },
                        new
                        {
                            Id = new Guid("deee8ae5-e070-44ec-983b-e88e5bcc5dab"),
                            CategoryId = new Guid("943a9ab8-d674-4964-9e7f-c1269ec6cdf3"),
                            DataCreate = new DateTime(2024, 3, 25, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 25, 12, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Description = "Description1",
                            Name = "Name1",
                            Price = 1.99m,
                            UserId = new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208")
                        },
                        new
                        {
                            Id = new Guid("aa99e7d2-3dce-4d10-85dd-55d2f23ff04d"),
                            CategoryId = new Guid("3f24ee6c-0e89-4d50-adad-94aa62ffb606"),
                            DataCreate = new DateTime(2024, 3, 24, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 24, 11, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Description = "Description2",
                            Name = "Name2",
                            Price = 2.99m,
                            UserId = new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208")
                        },
                        new
                        {
                            Id = new Guid("19631ec7-e129-4125-9878-05fba5a79ed1"),
                            CategoryId = new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"),
                            DataCreate = new DateTime(2024, 3, 23, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 23, 10, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Description = "Description3",
                            Name = "Name3",
                            Price = 3.99m,
                            UserId = new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208")
                        },
                        new
                        {
                            Id = new Guid("443cf469-dbee-47f6-90c4-fe036b760244"),
                            CategoryId = new Guid("d92e36e1-6646-4916-814c-2cf485311b36"),
                            DataCreate = new DateTime(2024, 3, 22, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 22, 9, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Description = "Description4",
                            Name = "Name4",
                            Price = 4.99m,
                            UserId = new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208")
                        },
                        new
                        {
                            Id = new Guid("7e82d12f-c052-4ae2-9674-dfded9515369"),
                            CategoryId = new Guid("af344ca8-4e8c-4679-8e24-4699a9608507"),
                            DataCreate = new DateTime(2024, 3, 21, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 21, 8, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Description = "Description5",
                            Name = "Name5",
                            Price = 5.99m,
                            UserId = new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208")
                        },
                        new
                        {
                            Id = new Guid("e67743f3-5ecf-4afd-91ab-ca19b1ca8e35"),
                            CategoryId = new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"),
                            DataCreate = new DateTime(2024, 3, 20, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 20, 7, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Description = "Description6",
                            Name = "Name6",
                            Price = 6.99m,
                            UserId = new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208")
                        },
                        new
                        {
                            Id = new Guid("110e86a0-3e06-4fc8-a8af-18a0d1622f34"),
                            CategoryId = new Guid("16f5311f-3107-4046-a799-7ea4c404eb0f"),
                            DataCreate = new DateTime(2024, 3, 19, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 19, 6, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Description = "Description7",
                            Name = "Name7",
                            Price = 7.99m,
                            UserId = new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208")
                        },
                        new
                        {
                            Id = new Guid("89ba8422-fcab-459b-b62d-27d0fc442b35"),
                            CategoryId = new Guid("180133e6-ac4d-4b5f-9ada-f69beb2769f8"),
                            DataCreate = new DateTime(2024, 3, 18, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 20, 5, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Description = "Description8",
                            Name = "Name8",
                            Price = 8.99m,
                            UserId = new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208")
                        });
                });

            modelBuilder.Entity("Shop.BackApp.Domain.Entity.User", b =>
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

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208"),
                            DataCreate = new DateTime(2024, 3, 11, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            DataUpdate = new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141),
                            Email = "admin@admin.com",
                            FirstName = "Admin",
                            LastName = "Admin",
                            PasswordHash = "f2x+4rnI3Lx/HA33/N9u4BypVqqufh777mQlqr2q8T0=",
                            PasswordSalt = "c6GqkmGiZCR115kdxW4TeQ=="
                        });
                });

            modelBuilder.Entity("Shop.BackApp.Domain.Entity.Category", b =>
                {
                    b.HasOne("Shop.BackApp.Domain.Entity.Category", null)
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Shop.BackApp.Domain.Entity.Comment", b =>
                {
                    b.HasOne("Shop.BackApp.Domain.Entity.Product", null)
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop.BackApp.Domain.Entity.Category", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Shop.BackApp.Domain.Entity.Product", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
