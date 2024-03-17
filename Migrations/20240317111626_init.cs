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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("580e4680-fd28-48b8-b976-22f23c61a9cb"), null, new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Ноутбуки и компьютеры" },
                    { new Guid("f6f334d4-4ee3-4194-9aca-546dbef39f46"), null, new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Смартфоны, ТВ и Электроника" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Description", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("3c643819-34a6-4fc3-b49f-5880357a0a3f"), new Guid("b85e139d-f167-43bc-ba6e-c5e9d9efe384"), new DateTime(2024, 3, 11, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 11, 5, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Description6", "Name6", 6.99m, new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3") },
                    { new Guid("477dd1e4-6136-4369-b57b-fbba47918663"), new Guid("41a8bad2-7360-4b1f-9d64-148580a1a510"), new DateTime(2024, 3, 15, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 15, 9, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Description2", "Name2", 2.99m, new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3") },
                    { new Guid("5d2d5b90-5904-4653-b00d-3128343e1a68"), new Guid("861f5ba9-edb2-4d3b-a943-70e748f201ee"), new DateTime(2024, 3, 14, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 14, 8, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Description3", "Name3", 3.99m, new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3") },
                    { new Guid("6d99af76-1ae4-4b21-983c-9493ce0bd249"), new Guid("2d988ac2-746e-49f0-812c-ef1016dec01c"), new DateTime(2024, 3, 15, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 12, 2, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Rubber under your foot", "Slippers", 11.11m, new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3") },
                    { new Guid("8dbaec10-3332-4054-81dd-ffa73dcf9906"), new Guid("178323ff-3bd7-4951-b563-84798aa01f4b"), new DateTime(2024, 3, 16, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 16, 10, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Description1", "Name1", 1.99m, new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3") },
                    { new Guid("99e791c1-f34c-4915-816c-c754a3870056"), new Guid("acd402ca-a6d4-4676-a82d-b723671049cc"), new DateTime(2024, 3, 9, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 11, 3, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Description8", "Name8", 8.99m, new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3") },
                    { new Guid("bb869db5-e0f2-44d6-a09c-befc61a20195"), new Guid("acd402ca-a6d4-4676-a82d-b723671049cc"), new DateTime(2024, 3, 12, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 12, 6, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Description5", "Name5", 5.99m, new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3") },
                    { new Guid("c90e731b-6383-4653-8943-b4a588984bb8"), new Guid("861f5ba9-edb2-4d3b-a943-70e748f201ee"), new DateTime(2024, 3, 12, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 14, 21, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Burns for 10 hours", "Lamp", 11.11m, new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3") },
                    { new Guid("dff25cd8-cd03-443a-be83-1b783b1e1af5"), new Guid("178323ff-3bd7-4951-b563-84798aa01f4b"), new DateTime(2024, 3, 13, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 13, 7, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Description4", "Name4", 4.99m, new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3") },
                    { new Guid("f3790f41-87f5-4565-8bd2-e58598b0dcfd"), new Guid("2ccc3123-e24f-4ac1-ad53-cfc6c7639794"), new DateTime(2024, 3, 10, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 10, 4, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Description7", "Name7", 7.99m, new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3"), new DateTime(2024, 3, 2, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "admin@admin.com", "Admin", "Admin", "Afo2cQdXp2BHeyIptt2EJFl/hFM0M55n2F3IuHAMncU=", "2eEB+yL3s6IONik+IHlU3g==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("178323ff-3bd7-4951-b563-84798aa01f4b"), new Guid("f6f334d4-4ee3-4194-9aca-546dbef39f46"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Наушники и аксессуары" },
                    { new Guid("2ccc3123-e24f-4ac1-ad53-cfc6c7639794"), new Guid("f6f334d4-4ee3-4194-9aca-546dbef39f46"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Мобильные телефоны" },
                    { new Guid("41a8bad2-7360-4b1f-9d64-148580a1a510"), new Guid("580e4680-fd28-48b8-b976-22f23c61a9cb"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Планшеты" },
                    { new Guid("5ce876a7-20cb-4b48-bb35-56bd3d77b529"), new Guid("580e4680-fd28-48b8-b976-22f23c61a9cb"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Ноутбуки" },
                    { new Guid("861f5ba9-edb2-4d3b-a943-70e748f201ee"), new Guid("580e4680-fd28-48b8-b976-22f23c61a9cb"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Мониторы" },
                    { new Guid("acd402ca-a6d4-4676-a82d-b723671049cc"), new Guid("580e4680-fd28-48b8-b976-22f23c61a9cb"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Компьютерные комплектующие" },
                    { new Guid("d190b221-9b1a-4e26-8dd8-98d0d2d01414"), new Guid("f6f334d4-4ee3-4194-9aca-546dbef39f46"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Телевизоры" },
                    { new Guid("fd4f896d-fd54-4f01-8b5f-1aa90c4c5ebd"), new Guid("f6f334d4-4ee3-4194-9aca-546dbef39f46"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Носимые гаджеты" },
                    { new Guid("fe272257-138e-4ef7-9eb5-c870f766cad4"), new Guid("580e4680-fd28-48b8-b976-22f23c61a9cb"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Компьютеры" },
                    { new Guid("216c988c-c095-4f1e-b3c2-0baf5933c42e"), new Guid("fd4f896d-fd54-4f01-8b5f-1aa90c4c5ebd"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Фитнес-браслеты" },
                    { new Guid("2d988ac2-746e-49f0-812c-ef1016dec01c"), new Guid("fd4f896d-fd54-4f01-8b5f-1aa90c4c5ebd"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "3D и VR очки" },
                    { new Guid("39107a2b-5d47-48b6-b803-a1c28c9c486a"), new Guid("fd4f896d-fd54-4f01-8b5f-1aa90c4c5ebd"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Смарт-кольца" },
                    { new Guid("3b286d62-d045-48a1-890f-1352a2fd28c0"), new Guid("acd402ca-a6d4-4676-a82d-b723671049cc"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Видеокарты" },
                    { new Guid("452c43d2-9c51-4180-873d-c3382bbf8600"), new Guid("acd402ca-a6d4-4676-a82d-b723671049cc"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Оперативная память" },
                    { new Guid("698f95fb-4ee0-40ec-af69-db879f45f771"), new Guid("acd402ca-a6d4-4676-a82d-b723671049cc"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Жесткие диски" },
                    { new Guid("777c3b7d-7701-4956-a0ba-6f3774bd9afe"), new Guid("acd402ca-a6d4-4676-a82d-b723671049cc"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Процессоры" },
                    { new Guid("7a5bffd1-5a21-4317-a409-b2c007e3027c"), new Guid("acd402ca-a6d4-4676-a82d-b723671049cc"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Материнские платы" },
                    { new Guid("941cd916-5318-420b-96ea-cc87bd852501"), new Guid("acd402ca-a6d4-4676-a82d-b723671049cc"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Звуковые карты" },
                    { new Guid("b85e139d-f167-43bc-ba6e-c5e9d9efe384"), new Guid("fd4f896d-fd54-4f01-8b5f-1aa90c4c5ebd"), new DateTime(2024, 3, 3, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 7, 11, 16, 26, 12, DateTimeKind.Utc).AddTicks(8826), "Смарт-часы" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
