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
                    { new Guid("3d34d128-3ff6-4280-8dd8-a9cfdaccb7f3"), null, new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Ноутбуки и компьютеры" },
                    { new Guid("eff8c33a-a0b2-490d-88a9-49fd57f1d422"), null, new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Смартфоны, ТВ и Электроника" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Description", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("282a01e3-be1e-4d58-873f-217314cd8928"), new Guid("03d6d0ff-d9f0-436c-88ae-549b8346754e"), new DateTime(2024, 3, 14, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 14, 9, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Description1", "Name1", 1.99m, new Guid("e40a9986-9833-4843-9ad3-c872a1b97209") },
                    { new Guid("430ba877-ba8a-42c6-8556-113b2a07d821"), new Guid("7d2bff55-6d40-4c03-8a3a-6d9f5583767a"), new DateTime(2024, 3, 8, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 8, 3, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Description7", "Name7", 7.99m, new Guid("e40a9986-9833-4843-9ad3-c872a1b97209") },
                    { new Guid("5715b3f4-cb02-4a00-aa0a-d995c4497c1b"), new Guid("03d6d0ff-d9f0-436c-88ae-549b8346754e"), new DateTime(2024, 3, 9, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 9, 4, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Description6", "Name6", 6.99m, new Guid("e40a9986-9833-4843-9ad3-c872a1b97209") },
                    { new Guid("61ba9534-41d5-474b-b523-5568ee02f337"), new Guid("d7afe1e0-13cf-4b9d-8410-6c6e1439b3e6"), new DateTime(2024, 3, 10, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 10, 5, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Description5", "Name5", 5.99m, new Guid("e40a9986-9833-4843-9ad3-c872a1b97209") },
                    { new Guid("62839887-4ac4-44df-8b02-25ce7f98cc79"), new Guid("68306fc2-1e69-42a4-a043-6e64b293345c"), new DateTime(2024, 3, 12, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 12, 7, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Description3", "Name3", 3.99m, new Guid("e40a9986-9833-4843-9ad3-c872a1b97209") },
                    { new Guid("66063c38-e8d6-4108-857d-f2f014f33a6c"), new Guid("eff8c33a-a0b2-490d-88a9-49fd57f1d422"), new DateTime(2024, 3, 11, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 11, 6, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Description4", "Name4", 4.99m, new Guid("e40a9986-9833-4843-9ad3-c872a1b97209") },
                    { new Guid("708d62f2-bf21-40c9-9ea2-8631516d21c8"), new Guid("3cb2735a-226f-41fe-bd3f-d9ca413cabed"), new DateTime(2024, 3, 10, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 12, 20, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Burns for 10 hours", "Lamp", 11.11m, new Guid("e40a9986-9833-4843-9ad3-c872a1b97209") },
                    { new Guid("9c4c35b8-e151-4138-b1b7-563b9f805705"), new Guid("ddbe2feb-f3e1-4c1f-9fd9-fcbe9cc11142"), new DateTime(2024, 3, 7, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 9, 2, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Description8", "Name8", 8.99m, new Guid("e40a9986-9833-4843-9ad3-c872a1b97209") },
                    { new Guid("e7765126-29f1-4e3f-accd-c05df6e8843e"), new Guid("46108ce7-2458-4a8b-a4ef-ba3ee25b4fe3"), new DateTime(2024, 3, 13, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 13, 8, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Description2", "Name2", 2.99m, new Guid("e40a9986-9833-4843-9ad3-c872a1b97209") },
                    { new Guid("ff34c475-da6c-4e40-b769-c7d010385c42"), new Guid("1073b2eb-722e-4c1a-a9fb-008bd2b5de32"), new DateTime(2024, 3, 13, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 10, 1, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Rubber under your foot", "Slippers", 11.11m, new Guid("e40a9986-9833-4843-9ad3-c872a1b97209") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("e40a9986-9833-4843-9ad3-c872a1b97209"), new DateTime(2024, 2, 29, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "admin@admin.com", "Admin", "Admin", "gFaN4aLjaJzqrQgyXth1Quehr8taLoSpc6bJzKAFDhk=", "mPSDf1cGYaldhG0fcy+tlQ==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("03d6d0ff-d9f0-436c-88ae-549b8346754e"), new Guid("3d34d128-3ff6-4280-8dd8-a9cfdaccb7f3"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Мониторы" },
                    { new Guid("1073b2eb-722e-4c1a-a9fb-008bd2b5de32"), new Guid("eff8c33a-a0b2-490d-88a9-49fd57f1d422"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Носимые гаджеты" },
                    { new Guid("1da00885-1f7f-4b43-9827-f84bcb9fa8d9"), new Guid("3d34d128-3ff6-4280-8dd8-a9cfdaccb7f3"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Компьютерные комплектующие" },
                    { new Guid("3cb2735a-226f-41fe-bd3f-d9ca413cabed"), new Guid("3d34d128-3ff6-4280-8dd8-a9cfdaccb7f3"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Планшеты" },
                    { new Guid("79400f16-500a-4c05-a907-5679bfab39bb"), new Guid("3d34d128-3ff6-4280-8dd8-a9cfdaccb7f3"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Компьютеры" },
                    { new Guid("9ac0d850-4934-4282-b7ec-5f0d35d4f67e"), new Guid("eff8c33a-a0b2-490d-88a9-49fd57f1d422"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Наушники и аксессуары" },
                    { new Guid("c81f79a1-3031-4073-9694-76d6e3214f56"), new Guid("eff8c33a-a0b2-490d-88a9-49fd57f1d422"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Телевизоры" },
                    { new Guid("d7afe1e0-13cf-4b9d-8410-6c6e1439b3e6"), new Guid("3d34d128-3ff6-4280-8dd8-a9cfdaccb7f3"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Ноутбуки" },
                    { new Guid("e621fb61-37c1-4e5b-bc3d-78482293019e"), new Guid("eff8c33a-a0b2-490d-88a9-49fd57f1d422"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Мобильные телефоны" },
                    { new Guid("29dc6c88-419c-4bba-b46e-42aff6f93ffb"), new Guid("1da00885-1f7f-4b43-9827-f84bcb9fa8d9"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Жесткие диски" },
                    { new Guid("46108ce7-2458-4a8b-a4ef-ba3ee25b4fe3"), new Guid("1073b2eb-722e-4c1a-a9fb-008bd2b5de32"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Смарт-часы" },
                    { new Guid("68306fc2-1e69-42a4-a043-6e64b293345c"), new Guid("1073b2eb-722e-4c1a-a9fb-008bd2b5de32"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Фитнес-браслеты" },
                    { new Guid("7d2bff55-6d40-4c03-8a3a-6d9f5583767a"), new Guid("1da00885-1f7f-4b43-9827-f84bcb9fa8d9"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Оперативная память" },
                    { new Guid("7d7aba5c-d601-4ca1-8734-bd9e25dde351"), new Guid("1073b2eb-722e-4c1a-a9fb-008bd2b5de32"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Смарт-кольца" },
                    { new Guid("8243acf6-17a0-4bdc-a584-087e574af27b"), new Guid("1073b2eb-722e-4c1a-a9fb-008bd2b5de32"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "3D и VR очки" },
                    { new Guid("939095d0-a56b-4140-a05b-3dd448023571"), new Guid("1da00885-1f7f-4b43-9827-f84bcb9fa8d9"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Видеокарты" },
                    { new Guid("d1647e30-07f2-49cd-9d99-82e0346e6b99"), new Guid("1da00885-1f7f-4b43-9827-f84bcb9fa8d9"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Материнские платы" },
                    { new Guid("ddbe2feb-f3e1-4c1f-9fd9-fcbe9cc11142"), new Guid("1da00885-1f7f-4b43-9827-f84bcb9fa8d9"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Звуковые карты" },
                    { new Guid("e71b4595-09e5-4fd1-9ab2-be9c77e03aba"), new Guid("1da00885-1f7f-4b43-9827-f84bcb9fa8d9"), new DateTime(2024, 3, 1, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 3, 5, 10, 8, 49, 312, DateTimeKind.Utc).AddTicks(7035), "Процессоры" }
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
