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
                    { new Guid("5b5e59ee-be34-4cd5-b2d8-12e0639a3a87"), null, new DateTime(2024, 2, 11, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Category3" },
                    { new Guid("82d1ef17-e11e-4960-ab2b-7ba01f76f251"), null, new DateTime(2024, 2, 11, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Category2" },
                    { new Guid("8485db65-6fb2-426a-b400-2784f671ac3e"), null, new DateTime(2024, 2, 11, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Category1" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Description", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c62a3d1-8afb-440b-af85-fad9942de72f"), new Guid("82d1ef17-e11e-4960-ab2b-7ba01f76f251"), new DateTime(2024, 2, 19, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 19, 2, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Description6", "Name6", 6.99m, new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc") },
                    { new Guid("291c5969-e0ff-4dfb-b4b1-dc4bd06a88de"), new Guid("5b5e59ee-be34-4cd5-b2d8-12e0639a3a87"), new DateTime(2024, 2, 24, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 24, 7, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Description1", "Name1", 1.99m, new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc") },
                    { new Guid("2f18e4bd-9c6c-494d-b352-82a39cb88ff2"), new Guid("82d1ef17-e11e-4960-ab2b-7ba01f76f251"), new DateTime(2024, 2, 20, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 20, 3, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Description5", "Name5", 5.99m, new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc") },
                    { new Guid("32d51141-9151-4a35-a60d-145abbb85c05"), new Guid("5b5e59ee-be34-4cd5-b2d8-12e0639a3a87"), new DateTime(2024, 2, 23, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 19, 23, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Rubber under your foot", "Slippers", 11.11m, new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc") },
                    { new Guid("4a7dfd80-e3b4-405a-86dc-46172e094d55"), new Guid("5b5e59ee-be34-4cd5-b2d8-12e0639a3a87"), new DateTime(2024, 2, 18, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 18, 1, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Description7", "Name7", 7.99m, new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc") },
                    { new Guid("9ab0de7e-592d-4160-a927-14c29f3a898b"), new Guid("8485db65-6fb2-426a-b400-2784f671ac3e"), new DateTime(2024, 2, 20, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 22, 18, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Burns for 10 hours", "Lamp", 11.11m, new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc") },
                    { new Guid("9d0f5582-d8a1-4871-8f10-3f29481b3ae6"), new Guid("71d390f6-07ab-4985-aa7b-7358079fcd88"), new DateTime(2024, 2, 17, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 19, 0, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Description8", "Name8", 8.99m, new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc") },
                    { new Guid("bb795085-8b82-4d1d-826d-e8c1e4de3827"), new Guid("82d1ef17-e11e-4960-ab2b-7ba01f76f251"), new DateTime(2024, 2, 23, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 23, 6, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Description2", "Name2", 2.99m, new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc") },
                    { new Guid("d670afdb-5f9c-48b8-be81-065a005c4eff"), new Guid("8485db65-6fb2-426a-b400-2784f671ac3e"), new DateTime(2024, 2, 22, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 22, 5, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Description3", "Name3", 3.99m, new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc") },
                    { new Guid("e79b1c2e-23c7-4b44-af63-0709a0327890"), new Guid("5b5e59ee-be34-4cd5-b2d8-12e0639a3a87"), new DateTime(2024, 2, 21, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 21, 4, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Description4", "Name4", 4.99m, new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName" },
                values: new object[] { new Guid("bb4f1dc9-4068-48dd-aad2-1e447cce5fdc"), new DateTime(2024, 2, 10, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "admin@admin.com", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("15981f9a-cacf-4816-930e-b13bd1ce7a0b"), new Guid("8485db65-6fb2-426a-b400-2784f671ac3e"), new DateTime(2024, 2, 11, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Category5" },
                    { new Guid("71d390f6-07ab-4985-aa7b-7358079fcd88"), new Guid("8485db65-6fb2-426a-b400-2784f671ac3e"), new DateTime(2024, 2, 11, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 2, 15, 8, 7, 28, 396, DateTimeKind.Utc).AddTicks(8045), "Category4" }
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
