using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FileDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("2ec6fa8d-e0ed-4d10-bc9f-0cadc042a988"), null, new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Смартфоны, ТВ и Электроника" },
                    { new Guid("5866edfd-2157-48fa-bef7-8e3ac1c071cc"), null, new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Ноутбуки и компьютеры" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Description", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("34558ab9-da66-4526-bc42-ebcbff45d5f5"), new Guid("2fdafd78-7343-487f-9c40-d395bdcafcb9"), new DateTime(2024, 3, 23, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 23, 5, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Description6", "Name6", 6.99m, new Guid("e4767940-3a87-46d6-a372-a5c3c89c2d56") },
                    { new Guid("76b3e76e-3adc-4c85-8c73-cd6e791c3244"), new Guid("84fb64ff-5829-4dc6-b88e-43498aba1642"), new DateTime(2024, 3, 26, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 26, 8, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Description3", "Name3", 3.99m, new Guid("e4767940-3a87-46d6-a372-a5c3c89c2d56") },
                    { new Guid("7e693838-f30a-4169-8256-495b1ae71dc2"), new Guid("84fb64ff-5829-4dc6-b88e-43498aba1642"), new DateTime(2024, 3, 21, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 23, 3, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Description8", "Name8", 8.99m, new Guid("e4767940-3a87-46d6-a372-a5c3c89c2d56") },
                    { new Guid("946c82cd-502d-4814-b409-70837e5d32be"), new Guid("bfde0964-1dbf-41a6-90e3-bb9462137143"), new DateTime(2024, 3, 24, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 24, 6, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Description5", "Name5", 5.99m, new Guid("e4767940-3a87-46d6-a372-a5c3c89c2d56") },
                    { new Guid("a5e4e961-fabe-4af7-a7ab-128072f6b035"), new Guid("cb3b2704-40d8-4676-b50b-4fbd60c0b229"), new DateTime(2024, 3, 27, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 24, 2, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Rubber under your foot", "Slippers", 11.11m, new Guid("e4767940-3a87-46d6-a372-a5c3c89c2d56") },
                    { new Guid("aa3789b9-5f10-4a3a-b3a8-e7a3bd5c052f"), new Guid("444ddeff-90d1-476f-802c-ac608ea2110e"), new DateTime(2024, 3, 28, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 28, 10, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Description1", "Name1", 1.99m, new Guid("e4767940-3a87-46d6-a372-a5c3c89c2d56") },
                    { new Guid("b05792ca-e217-4517-847a-66a23809f453"), new Guid("25380da2-95e4-40cf-99fe-025d0a2d9771"), new DateTime(2024, 3, 27, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 27, 9, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Description2", "Name2", 2.99m, new Guid("e4767940-3a87-46d6-a372-a5c3c89c2d56") },
                    { new Guid("e19dab58-c233-4df4-b903-08df13dc9782"), new Guid("d593759c-9fa3-467c-90a2-d5e60b15631c"), new DateTime(2024, 3, 25, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 25, 7, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Description4", "Name4", 4.99m, new Guid("e4767940-3a87-46d6-a372-a5c3c89c2d56") },
                    { new Guid("f125865f-6a8f-4091-ad7d-be0fd786e6c4"), new Guid("5a24d018-2c71-40a8-9bef-e9cd9d725cfc"), new DateTime(2024, 3, 22, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 22, 4, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Description7", "Name7", 7.99m, new Guid("e4767940-3a87-46d6-a372-a5c3c89c2d56") },
                    { new Guid("f70fb8fc-30da-4a00-8133-46ff5eb00e70"), new Guid("d593759c-9fa3-467c-90a2-d5e60b15631c"), new DateTime(2024, 3, 24, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 26, 21, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Burns for 10 hours", "Lamp", 11.11m, new Guid("e4767940-3a87-46d6-a372-a5c3c89c2d56") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("e4767940-3a87-46d6-a372-a5c3c89c2d56"), new DateTime(2024, 3, 14, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "admin@admin.com", "Admin", "Admin", "I1b+5SiyaNUzgTLCS+zZFos/kHiMCgyT/RSKDRBLKZI=", "z6CIYjBQpIS6Z8Y3vcNA6A==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("078d6342-03f8-48d7-83a8-84706f4da297"), new Guid("5866edfd-2157-48fa-bef7-8e3ac1c071cc"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Ноутбуки" },
                    { new Guid("17a37ec7-22c1-4b02-a3e8-4124c98d1323"), new Guid("2ec6fa8d-e0ed-4d10-bc9f-0cadc042a988"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Мобильные телефоны" },
                    { new Guid("25380da2-95e4-40cf-99fe-025d0a2d9771"), new Guid("5866edfd-2157-48fa-bef7-8e3ac1c071cc"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Компьютерные комплектующие" },
                    { new Guid("416fd219-2593-41dc-a70e-136403122301"), new Guid("5866edfd-2157-48fa-bef7-8e3ac1c071cc"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Мониторы" },
                    { new Guid("68ef4b77-ce5f-48ef-82fb-ac32dae06f29"), new Guid("5866edfd-2157-48fa-bef7-8e3ac1c071cc"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Компьютеры" },
                    { new Guid("a7310cb0-cf7b-4110-950e-2a6be384f682"), new Guid("2ec6fa8d-e0ed-4d10-bc9f-0cadc042a988"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Наушники и аксессуары" },
                    { new Guid("a7c338b8-aefe-4885-a263-0b2ff055cb60"), new Guid("2ec6fa8d-e0ed-4d10-bc9f-0cadc042a988"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Носимые гаджеты" },
                    { new Guid("b9428003-b047-470d-927a-6eb909cc5c37"), new Guid("2ec6fa8d-e0ed-4d10-bc9f-0cadc042a988"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Телевизоры" },
                    { new Guid("d593759c-9fa3-467c-90a2-d5e60b15631c"), new Guid("5866edfd-2157-48fa-bef7-8e3ac1c071cc"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Планшеты" },
                    { new Guid("2fdafd78-7343-487f-9c40-d395bdcafcb9"), new Guid("25380da2-95e4-40cf-99fe-025d0a2d9771"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Процессоры" },
                    { new Guid("444ddeff-90d1-476f-802c-ac608ea2110e"), new Guid("25380da2-95e4-40cf-99fe-025d0a2d9771"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Видеокарты" },
                    { new Guid("5a24d018-2c71-40a8-9bef-e9cd9d725cfc"), new Guid("a7c338b8-aefe-4885-a263-0b2ff055cb60"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Смарт-кольца" },
                    { new Guid("84fb64ff-5829-4dc6-b88e-43498aba1642"), new Guid("25380da2-95e4-40cf-99fe-025d0a2d9771"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Материнские платы" },
                    { new Guid("87d5e27f-79c9-4e26-9b8f-3825355e826d"), new Guid("a7c338b8-aefe-4885-a263-0b2ff055cb60"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "3D и VR очки" },
                    { new Guid("a3348a9a-4af1-47de-90d0-046036481d46"), new Guid("25380da2-95e4-40cf-99fe-025d0a2d9771"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Звуковые карты" },
                    { new Guid("abce9944-ef10-4c05-823c-04bb8d0dc683"), new Guid("25380da2-95e4-40cf-99fe-025d0a2d9771"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Жесткие диски" },
                    { new Guid("b44dd965-0de4-47ec-ac60-b69b2cbda873"), new Guid("a7c338b8-aefe-4885-a263-0b2ff055cb60"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Фитнес-браслеты" },
                    { new Guid("bfde0964-1dbf-41a6-90e3-bb9462137143"), new Guid("25380da2-95e4-40cf-99fe-025d0a2d9771"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Оперативная память" },
                    { new Guid("cb3b2704-40d8-4676-b50b-4fbd60c0b229"), new Guid("a7c338b8-aefe-4885-a263-0b2ff055cb60"), new DateTime(2024, 3, 15, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 19, 11, 11, 29, 319, DateTimeKind.Utc).AddTicks(2020), "Смарт-часы" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "FileDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
