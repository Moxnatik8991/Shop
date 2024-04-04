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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "FileDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Order = table.Column<byte>(type: "tinyint", nullable: true),
                    DataCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileDetails_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileDetails_Products_ProductId",
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
                    { new Guid("6afd4706-6cd6-419b-8a56-7e8986339a5b"), null, new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Ноутбуки и компьютеры" },
                    { new Guid("c4268fe7-1b53-4431-85ee-c701b89be5cb"), null, new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Смартфоны, ТВ и Электроника" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Description", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("07ccc501-34b4-487b-a0d0-cc6ed7bb5e2f"), new Guid("3b0eb85c-1881-43c2-a1df-eb3b7054f063"), new DateTime(2024, 3, 30, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 4, 2, 1, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Burns for 10 hours", "Lamp", 11.11m, new Guid("3c156047-cb90-4063-9bfb-a63d5877c306") },
                    { new Guid("0af5969f-f3aa-48b6-95d9-87c98de7d4a1"), new Guid("9c5d20af-ceab-4d57-9643-af5e259c37d9"), new DateTime(2024, 3, 30, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 30, 10, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Description5", "Name5", 5.99m, new Guid("3c156047-cb90-4063-9bfb-a63d5877c306") },
                    { new Guid("1fee9896-7177-4807-b4d2-c8d309b88abf"), new Guid("6afd4706-6cd6-419b-8a56-7e8986339a5b"), new DateTime(2024, 3, 31, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 31, 11, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Description4", "Name4", 4.99m, new Guid("3c156047-cb90-4063-9bfb-a63d5877c306") },
                    { new Guid("33d69cca-3a72-4dfa-aa2b-4ebb52daa1bc"), new Guid("269fe930-0708-4335-bf2a-4683e3982045"), new DateTime(2024, 3, 27, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 29, 7, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Description8", "Name8", 8.99m, new Guid("3c156047-cb90-4063-9bfb-a63d5877c306") },
                    { new Guid("6c0b08c9-5de6-4d75-8835-4f64a6570ff0"), new Guid("4e85c7a5-ad1c-4717-81e3-0ba5a9b467ef"), new DateTime(2024, 4, 1, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 4, 1, 12, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Description3", "Name3", 3.99m, new Guid("3c156047-cb90-4063-9bfb-a63d5877c306") },
                    { new Guid("7527660d-90c8-4fec-932b-35d0407fbd25"), new Guid("3b0eb85c-1881-43c2-a1df-eb3b7054f063"), new DateTime(2024, 4, 2, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 4, 2, 13, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Description2", "Name2", 2.99m, new Guid("3c156047-cb90-4063-9bfb-a63d5877c306") },
                    { new Guid("86090135-979d-48f4-955a-89e574e782d1"), new Guid("9c5d20af-ceab-4d57-9643-af5e259c37d9"), new DateTime(2024, 3, 28, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 28, 8, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Description7", "Name7", 7.99m, new Guid("3c156047-cb90-4063-9bfb-a63d5877c306") },
                    { new Guid("bb0adcea-28a3-4b2f-b05b-05a53b30b29f"), new Guid("122c1210-02bd-4a26-a847-7d6a13f2789f"), new DateTime(2024, 4, 3, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 4, 3, 14, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Description1", "Name1", 1.99m, new Guid("3c156047-cb90-4063-9bfb-a63d5877c306") },
                    { new Guid("e5d76e6a-1e3a-4507-85db-39c0d7189fcb"), new Guid("b69aaf33-c276-4bcf-9e03-bf46116a03e3"), new DateTime(2024, 4, 2, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 30, 6, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Rubber under your foot", "Slippers", 11.11m, new Guid("3c156047-cb90-4063-9bfb-a63d5877c306") },
                    { new Guid("fce98e16-6837-4489-8b7b-e0385a772abf"), new Guid("3b0eb85c-1881-43c2-a1df-eb3b7054f063"), new DateTime(2024, 3, 29, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 29, 9, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Description6", "Name6", 6.99m, new Guid("3c156047-cb90-4063-9bfb-a63d5877c306") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("3c156047-cb90-4063-9bfb-a63d5877c306"), new DateTime(2024, 3, 20, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "admin@admin.com", "Admin", "Admin", "7cZOJ3nZdi5JwNerwfAUsRE0tTkuMc7s8/MT/aX8k50=", "DH+Zw+xih0R1To6pniGu2A==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("122c1210-02bd-4a26-a847-7d6a13f2789f"), new Guid("6afd4706-6cd6-419b-8a56-7e8986339a5b"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Компьютерные комплектующие" },
                    { new Guid("29742df9-ca1b-4151-967d-144732bd8a31"), new Guid("c4268fe7-1b53-4431-85ee-c701b89be5cb"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Наушники и аксессуары" },
                    { new Guid("2ab81582-bc0b-4c4b-bb90-3907a832cb41"), new Guid("c4268fe7-1b53-4431-85ee-c701b89be5cb"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Носимые гаджеты" },
                    { new Guid("679fae86-6bcc-434a-a50b-78baa1c90ed0"), new Guid("c4268fe7-1b53-4431-85ee-c701b89be5cb"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Мобильные телефоны" },
                    { new Guid("b2a308e0-1254-4d09-9da6-faedf917b966"), new Guid("6afd4706-6cd6-419b-8a56-7e8986339a5b"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Планшеты" },
                    { new Guid("b4718b50-4cdb-4ffe-864d-bd877c973b50"), new Guid("6afd4706-6cd6-419b-8a56-7e8986339a5b"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Компьютеры" },
                    { new Guid("bb7fe3ea-3ec4-4a8e-9663-6a7a6badef9e"), new Guid("6afd4706-6cd6-419b-8a56-7e8986339a5b"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Мониторы" },
                    { new Guid("c542ba13-6610-4e03-94c5-2273c4a6ed12"), new Guid("c4268fe7-1b53-4431-85ee-c701b89be5cb"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Телевизоры" },
                    { new Guid("d33937dd-5aaa-4c42-b82f-bf41d6c49f55"), new Guid("6afd4706-6cd6-419b-8a56-7e8986339a5b"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Ноутбуки" },
                    { new Guid("269fe930-0708-4335-bf2a-4683e3982045"), new Guid("2ab81582-bc0b-4c4b-bb90-3907a832cb41"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Фитнес-браслеты" },
                    { new Guid("3b0eb85c-1881-43c2-a1df-eb3b7054f063"), new Guid("122c1210-02bd-4a26-a847-7d6a13f2789f"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Видеокарты" },
                    { new Guid("4e85c7a5-ad1c-4717-81e3-0ba5a9b467ef"), new Guid("2ab81582-bc0b-4c4b-bb90-3907a832cb41"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Смарт-часы" },
                    { new Guid("4fee6413-a4ef-4a2c-924e-423290594197"), new Guid("122c1210-02bd-4a26-a847-7d6a13f2789f"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Процессоры" },
                    { new Guid("75c1a818-e0ba-4384-8ca8-728f2c99ecdd"), new Guid("2ab81582-bc0b-4c4b-bb90-3907a832cb41"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Смарт-кольца" },
                    { new Guid("9c5d20af-ceab-4d57-9643-af5e259c37d9"), new Guid("122c1210-02bd-4a26-a847-7d6a13f2789f"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Оперативная память" },
                    { new Guid("b69aaf33-c276-4bcf-9e03-bf46116a03e3"), new Guid("122c1210-02bd-4a26-a847-7d6a13f2789f"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Звуковые карты" },
                    { new Guid("c52e5928-ac2d-477c-80fc-a9287c12e583"), new Guid("122c1210-02bd-4a26-a847-7d6a13f2789f"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Материнские платы" },
                    { new Guid("c96718ba-4407-48ea-8604-641d420a3a16"), new Guid("2ab81582-bc0b-4c4b-bb90-3907a832cb41"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "3D и VR очки" },
                    { new Guid("ec8ec436-694b-47ae-b0d9-2c826f1137d5"), new Guid("122c1210-02bd-4a26-a847-7d6a13f2789f"), new DateTime(2024, 3, 21, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 3, 25, 15, 5, 56, 468, DateTimeKind.Utc).AddTicks(5462), "Жесткие диски" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDetails_CategoryId",
                table: "FileDetails",
                column: "CategoryId",
                unique: true,
                filter: "[CategoryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FileDetails_ProductId",
                table: "FileDetails",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "FileDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
