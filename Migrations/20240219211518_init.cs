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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    { new Guid("2d89cfa2-f4f9-40a4-9db6-d656f6283ff4"), new DateTime(2024, 2, 14, 21, 15, 18, 333, DateTimeKind.Utc).AddTicks(8506), new DateTime(2024, 2, 17, 7, 15, 18, 333, DateTimeKind.Utc).AddTicks(8506), "Burns for 10 hours", "Lamp", 11.11m },
                    { new Guid("c3f97ab0-50ed-4810-81cf-0c3bd0db31ed"), new DateTime(2024, 2, 17, 21, 15, 18, 333, DateTimeKind.Utc).AddTicks(8506), new DateTime(2024, 2, 14, 12, 15, 18, 333, DateTimeKind.Utc).AddTicks(8506), "Rubber under your foot", "Slippers", 11.11m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[] { new Guid("9e0e9e41-22d2-4956-bab5-099ea3f5b736"), "admin@admin.com", "Admin", "Admin" });
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
