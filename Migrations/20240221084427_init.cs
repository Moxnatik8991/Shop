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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                table: "Products",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("3b5aae66-235a-4268-a6ab-8fcd998e78a9"), new DateTime(2024, 2, 19, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 2, 15, 23, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), "Rubber under your foot", "Slippers", 11.11m },
                    { new Guid("4cd4cef0-1f24-4051-b2a4-bc2e47bd8125"), new DateTime(2024, 2, 16, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 2, 18, 18, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), "Burns for 10 hours", "Lamp", 11.11m },
                    { new Guid("77f02b6d-9101-46ed-ae09-14d9be4ae5ad"), new DateTime(2024, 2, 15, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 2, 15, 2, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), "Description6", "Name6", 6.99m },
                    { new Guid("9c8f5f4b-2125-4a9a-9888-271412b47720"), new DateTime(2024, 2, 19, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 2, 19, 6, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), "Description2", "Name2", 2.99m },
                    { new Guid("a9aad111-3502-4421-8d06-0170fd7a330a"), new DateTime(2024, 2, 18, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 2, 18, 5, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), "Description3", "Name3", 3.99m },
                    { new Guid("cafa09ff-0c99-475e-b171-ae90b090447e"), new DateTime(2024, 2, 16, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 2, 16, 3, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), "Description5", "Name5", 5.99m },
                    { new Guid("d0b0bebc-f12a-496e-9833-8ca8a693c774"), new DateTime(2024, 2, 20, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 2, 20, 7, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), "Description1", "Name1", 1.99m },
                    { new Guid("d1c6f982-479e-4dba-9b87-34900aefbab5"), new DateTime(2024, 2, 17, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 2, 17, 4, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), "Description4", "Name4", 4.99m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName" },
                values: new object[] { new Guid("05413efe-815f-4175-8924-fb76e4ea0678"), new DateTime(2024, 2, 16, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 2, 11, 8, 44, 27, 469, DateTimeKind.Utc).AddTicks(7027), "admin@admin.com", "Admin", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
