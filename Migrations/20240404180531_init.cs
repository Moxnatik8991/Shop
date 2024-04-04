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
                    { new Guid("34b94ae4-9801-445a-aed6-b22986566e77"), null, new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Ноутбуки и компьютеры" },
                    { new Guid("ceed9c73-6fc2-44c9-8107-b49c04774c37"), null, new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Смартфоны, ТВ и Электроника" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Description", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("09dcf1d5-3278-4a8a-b6d8-1d5cb05c6825"), new Guid("3c7020c7-837f-42ff-9b78-e98488de73ba"), new DateTime(2024, 3, 29, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 29, 12, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Description6", "Name6", 6.99m, new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d") },
                    { new Guid("12a3908a-87c3-4efd-b106-e461ffc559b3"), new Guid("3daff5eb-68de-4ab6-9a16-bf03c1cca491"), new DateTime(2024, 3, 31, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 31, 14, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Description4", "Name4", 4.99m, new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d") },
                    { new Guid("1c4bdda9-15f7-479d-8caf-e6bdf3e0656f"), new Guid("80210cc8-e686-4a82-b1d9-85dad60f0a4c"), new DateTime(2024, 3, 28, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 28, 11, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Description7", "Name7", 7.99m, new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d") },
                    { new Guid("286528d6-9230-45de-9bdb-2222773ea79f"), new Guid("12816644-226d-4d09-b7c9-5eb22fbcef4b"), new DateTime(2024, 3, 27, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 29, 10, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Description8", "Name8", 8.99m, new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d") },
                    { new Guid("28b9823e-810c-40fb-ab83-1f7879acd0dd"), new Guid("3daff5eb-68de-4ab6-9a16-bf03c1cca491"), new DateTime(2024, 4, 2, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 30, 9, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Rubber under your foot", "Slippers", 11.11m, new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d") },
                    { new Guid("3578fb32-5fe9-4e69-9056-f367dc2f9f33"), new Guid("34bc641e-3e8a-44ba-9402-417e6af12d8e"), new DateTime(2024, 3, 30, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 4, 2, 4, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Burns for 10 hours", "Lamp", 11.11m, new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d") },
                    { new Guid("3930bc03-5406-4f30-b7ee-5c7d72d3235f"), new Guid("dc8130cd-b257-4738-92a3-0219728489b4"), new DateTime(2024, 4, 1, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 4, 1, 15, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Description3", "Name3", 3.99m, new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d") },
                    { new Guid("4d0d1d48-646a-461c-a653-26a2654e1b4d"), new Guid("53360d33-b29b-4537-9b54-6092ed007215"), new DateTime(2024, 4, 3, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 4, 3, 17, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Description1", "Name1", 1.99m, new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d") },
                    { new Guid("5c6e80f4-bc80-4a39-86f6-5c2c76e2d6ce"), new Guid("80210cc8-e686-4a82-b1d9-85dad60f0a4c"), new DateTime(2024, 4, 2, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 4, 2, 16, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Description2", "Name2", 2.99m, new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d") },
                    { new Guid("87991b3d-3a75-421e-acc7-a61c29c64b90"), new Guid("2d70da78-8914-429c-846d-f862449e707f"), new DateTime(2024, 3, 30, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 30, 13, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Description5", "Name5", 5.99m, new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d"), new DateTime(2024, 3, 20, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "admin@admin.com", "Admin", "Admin", "UubpeFG2udOsIY6Kj3U7FxupJ87XR7d4prQ70XdrkBE=", "NCLWfu26Zto5EOevHDZn/g==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("12816644-226d-4d09-b7c9-5eb22fbcef4b"), new Guid("ceed9c73-6fc2-44c9-8107-b49c04774c37"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Наушники и аксессуары" },
                    { new Guid("2d70da78-8914-429c-846d-f862449e707f"), new Guid("34b94ae4-9801-445a-aed6-b22986566e77"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Компьютеры" },
                    { new Guid("34bc641e-3e8a-44ba-9402-417e6af12d8e"), new Guid("ceed9c73-6fc2-44c9-8107-b49c04774c37"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Носимые гаджеты" },
                    { new Guid("3c7020c7-837f-42ff-9b78-e98488de73ba"), new Guid("ceed9c73-6fc2-44c9-8107-b49c04774c37"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Мобильные телефоны" },
                    { new Guid("53360d33-b29b-4537-9b54-6092ed007215"), new Guid("34b94ae4-9801-445a-aed6-b22986566e77"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Компьютерные комплектующие" },
                    { new Guid("5ac0739d-d6b6-46f0-b229-6860190917ce"), new Guid("34b94ae4-9801-445a-aed6-b22986566e77"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Планшеты" },
                    { new Guid("ad997198-40eb-49ec-8598-b0e9597a5896"), new Guid("ceed9c73-6fc2-44c9-8107-b49c04774c37"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Телевизоры" },
                    { new Guid("dc8130cd-b257-4738-92a3-0219728489b4"), new Guid("34b94ae4-9801-445a-aed6-b22986566e77"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Мониторы" },
                    { new Guid("f490b0ac-a979-43da-a528-0f21b63eef92"), new Guid("34b94ae4-9801-445a-aed6-b22986566e77"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Ноутбуки" },
                    { new Guid("0415ae8f-df2d-4bd8-9d9b-06e1ab5a80f9"), new Guid("53360d33-b29b-4537-9b54-6092ed007215"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Жесткие диски" },
                    { new Guid("0ccd4c3c-f2e6-468d-beb4-10a4f7820458"), new Guid("34bc641e-3e8a-44ba-9402-417e6af12d8e"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Смарт-часы" },
                    { new Guid("3daff5eb-68de-4ab6-9a16-bf03c1cca491"), new Guid("34bc641e-3e8a-44ba-9402-417e6af12d8e"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Смарт-кольца" },
                    { new Guid("560979c6-6bac-43da-b5d5-b66bcdd999cb"), new Guid("53360d33-b29b-4537-9b54-6092ed007215"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Звуковые карты" },
                    { new Guid("6f184ba8-b725-4c35-bb22-e18e7489d257"), new Guid("34bc641e-3e8a-44ba-9402-417e6af12d8e"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "3D и VR очки" },
                    { new Guid("80210cc8-e686-4a82-b1d9-85dad60f0a4c"), new Guid("53360d33-b29b-4537-9b54-6092ed007215"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Видеокарты" },
                    { new Guid("a806cb1f-3f4b-446a-8110-de75144d6569"), new Guid("53360d33-b29b-4537-9b54-6092ed007215"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Процессоры" },
                    { new Guid("ca550976-6ec3-45a3-87ea-6636d2a649fa"), new Guid("53360d33-b29b-4537-9b54-6092ed007215"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Материнские платы" },
                    { new Guid("cb202d74-b689-49a2-8c9c-397f8f6e693b"), new Guid("53360d33-b29b-4537-9b54-6092ed007215"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Оперативная память" },
                    { new Guid("f9548cc7-ea16-492f-88cb-c11c44c95cab"), new Guid("34bc641e-3e8a-44ba-9402-417e6af12d8e"), new DateTime(2024, 3, 21, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 25, 18, 5, 30, 862, DateTimeKind.Utc).AddTicks(8105), "Фитнес-браслеты" }
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
