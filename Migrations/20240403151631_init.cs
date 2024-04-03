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
                name: "FileRelations",
                columns: table => new
                {
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileRelations", x => new { x.FileId, x.EntityId });
                    table.ForeignKey(
                        name: "FK_FileRelations_Categories_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileRelations_FileDetails_FileId",
                        column: x => x.FileId,
                        principalTable: "FileDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("0e77c278-a1b1-4d98-8188-8e5aca90fdd6"), null, new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Ноутбуки и компьютеры" },
                    { new Guid("426588c3-54d5-4f3f-bd0a-f00d5f1b22f0"), null, new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Смартфоны, ТВ и Электроника" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Description", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("0949b2e8-e02d-44fb-b00e-62239f9cf053"), new Guid("7e646336-328c-4204-93c2-93027bc84d0b"), new DateTime(2024, 4, 2, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 4, 2, 14, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Description1", "Name1", 1.99m, new Guid("bbcf295f-ebba-4e57-b41d-c77a2607d7e7") },
                    { new Guid("2c6ce290-3b87-44c6-b1bc-9b53b8565451"), new Guid("77c0f4d9-4704-41c2-8f44-da829efa5309"), new DateTime(2024, 4, 1, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 29, 6, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Rubber under your foot", "Slippers", 11.11m, new Guid("bbcf295f-ebba-4e57-b41d-c77a2607d7e7") },
                    { new Guid("41729ee1-0b72-4807-b0ae-82a1ed635f60"), new Guid("426588c3-54d5-4f3f-bd0a-f00d5f1b22f0"), new DateTime(2024, 3, 29, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 4, 1, 1, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Burns for 10 hours", "Lamp", 11.11m, new Guid("bbcf295f-ebba-4e57-b41d-c77a2607d7e7") },
                    { new Guid("47ea64e0-79df-4f0b-a270-712ac448dec5"), new Guid("bd77f010-5ba6-4187-90cd-a75b233e8aa8"), new DateTime(2024, 4, 1, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 4, 1, 13, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Description2", "Name2", 2.99m, new Guid("bbcf295f-ebba-4e57-b41d-c77a2607d7e7") },
                    { new Guid("589ee5fb-cc68-4244-9fa4-a09fa634ea8a"), new Guid("bdeff659-0989-4645-ab95-b4f3bf13ae60"), new DateTime(2024, 3, 31, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 31, 12, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Description3", "Name3", 3.99m, new Guid("bbcf295f-ebba-4e57-b41d-c77a2607d7e7") },
                    { new Guid("650cc7b4-ce5e-4949-8664-962492d41ab6"), new Guid("ea35a1a6-d9be-4b94-a3bd-940e298c09ec"), new DateTime(2024, 3, 29, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 29, 10, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Description5", "Name5", 5.99m, new Guid("bbcf295f-ebba-4e57-b41d-c77a2607d7e7") },
                    { new Guid("891008b7-89a3-4074-a9a2-e7b70c0e0e57"), new Guid("bd77f010-5ba6-4187-90cd-a75b233e8aa8"), new DateTime(2024, 3, 26, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 28, 7, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Description8", "Name8", 8.99m, new Guid("bbcf295f-ebba-4e57-b41d-c77a2607d7e7") },
                    { new Guid("a61678a6-b42a-49a3-b9af-286e031c988f"), new Guid("b01ec4e4-df15-4dc4-8186-ef8649694b91"), new DateTime(2024, 3, 30, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 30, 11, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Description4", "Name4", 4.99m, new Guid("bbcf295f-ebba-4e57-b41d-c77a2607d7e7") },
                    { new Guid("a6220b24-d1a8-4eb3-b874-2ad5c5272316"), new Guid("ea35a1a6-d9be-4b94-a3bd-940e298c09ec"), new DateTime(2024, 3, 28, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 28, 9, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Description6", "Name6", 6.99m, new Guid("bbcf295f-ebba-4e57-b41d-c77a2607d7e7") },
                    { new Guid("ae2e4f22-40f8-4ad1-abac-c4311a287628"), new Guid("ea35a1a6-d9be-4b94-a3bd-940e298c09ec"), new DateTime(2024, 3, 27, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 27, 8, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Description7", "Name7", 7.99m, new Guid("bbcf295f-ebba-4e57-b41d-c77a2607d7e7") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("bbcf295f-ebba-4e57-b41d-c77a2607d7e7"), new DateTime(2024, 3, 19, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "admin@admin.com", "Admin", "Admin", "/4Ghb972aE6OHL5FqCR+TSJwigk7+5nQpJL+mbTa+Ho=", "joloXR6SCEcCQIcGx/RXOg==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("260d6846-798d-41e5-9f58-a65c01e961d1"), new Guid("0e77c278-a1b1-4d98-8188-8e5aca90fdd6"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Мониторы" },
                    { new Guid("4e4df7fd-bdea-45ff-b141-ef8f44cdf4a1"), new Guid("0e77c278-a1b1-4d98-8188-8e5aca90fdd6"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Планшеты" },
                    { new Guid("55e977e6-93d4-4f46-8cb0-29a9698eec33"), new Guid("426588c3-54d5-4f3f-bd0a-f00d5f1b22f0"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Телевизоры" },
                    { new Guid("7c45d5bc-a0ec-4826-b4e0-5bad631b1d30"), new Guid("0e77c278-a1b1-4d98-8188-8e5aca90fdd6"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Компьютерные комплектующие" },
                    { new Guid("7e646336-328c-4204-93c2-93027bc84d0b"), new Guid("426588c3-54d5-4f3f-bd0a-f00d5f1b22f0"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Мобильные телефоны" },
                    { new Guid("9c552630-9d4d-4f40-a12f-0ea97aa29bd6"), new Guid("0e77c278-a1b1-4d98-8188-8e5aca90fdd6"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Ноутбуки" },
                    { new Guid("a8cdecde-ac08-4dae-9ce7-f1436f77bbd1"), new Guid("0e77c278-a1b1-4d98-8188-8e5aca90fdd6"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Компьютеры" },
                    { new Guid("bd77f010-5ba6-4187-90cd-a75b233e8aa8"), new Guid("426588c3-54d5-4f3f-bd0a-f00d5f1b22f0"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Носимые гаджеты" },
                    { new Guid("bdeff659-0989-4645-ab95-b4f3bf13ae60"), new Guid("426588c3-54d5-4f3f-bd0a-f00d5f1b22f0"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Наушники и аксессуары" },
                    { new Guid("1e3ddb94-4c97-460a-96f3-c71f2ba5c29c"), new Guid("bd77f010-5ba6-4187-90cd-a75b233e8aa8"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "3D и VR очки" },
                    { new Guid("4427575d-f65d-455f-bcca-b57a1bcd8356"), new Guid("7c45d5bc-a0ec-4826-b4e0-5bad631b1d30"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Процессоры" },
                    { new Guid("52b09263-d1d5-4a50-aff1-8f266a9a5c8f"), new Guid("bd77f010-5ba6-4187-90cd-a75b233e8aa8"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Смарт-часы" },
                    { new Guid("77c0f4d9-4704-41c2-8f44-da829efa5309"), new Guid("7c45d5bc-a0ec-4826-b4e0-5bad631b1d30"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Материнские платы" },
                    { new Guid("80b2173f-3f7a-4573-9553-055f4810d1ad"), new Guid("bd77f010-5ba6-4187-90cd-a75b233e8aa8"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Фитнес-браслеты" },
                    { new Guid("b01ec4e4-df15-4dc4-8186-ef8649694b91"), new Guid("7c45d5bc-a0ec-4826-b4e0-5bad631b1d30"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Звуковые карты" },
                    { new Guid("c98f71c2-785a-4f2c-8a16-239f4779711c"), new Guid("bd77f010-5ba6-4187-90cd-a75b233e8aa8"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Смарт-кольца" },
                    { new Guid("dea980bd-fa31-4e75-97a3-ec955a428475"), new Guid("7c45d5bc-a0ec-4826-b4e0-5bad631b1d30"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Видеокарты" },
                    { new Guid("ea35a1a6-d9be-4b94-a3bd-940e298c09ec"), new Guid("7c45d5bc-a0ec-4826-b4e0-5bad631b1d30"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Жесткие диски" },
                    { new Guid("f032e4d0-4237-4102-8d5f-a73b3be48770"), new Guid("7c45d5bc-a0ec-4826-b4e0-5bad631b1d30"), new DateTime(2024, 3, 20, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 3, 24, 15, 16, 30, 830, DateTimeKind.Utc).AddTicks(3923), "Оперативная память" }
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
                name: "IX_FileRelations_EntityId",
                table: "FileRelations",
                column: "EntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "FileRelations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "FileDetails");
        }
    }
}
