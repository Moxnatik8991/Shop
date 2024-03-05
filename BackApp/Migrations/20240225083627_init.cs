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
                    { new Guid("25a28334-238a-4130-ba37-3118318f264c"), null, new DateTime(2024, 2, 11, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 15, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Category3" },
                    { new Guid("3737017f-955c-4935-a358-201e760eecb2"), null, new DateTime(2024, 2, 11, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 15, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Category2" },
                    { new Guid("40ec11f6-298d-436b-a388-58012771d7b2"), null, new DateTime(2024, 2, 11, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 15, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Category1" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Description", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("043c008b-c8d9-43db-8d2a-3319433c774d"), new Guid("53dae8a2-dc28-4a10-8861-1bc246d6a993"), new DateTime(2024, 2, 23, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 23, 6, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Description2", "Name2", 2.99m, new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc") },
                    { new Guid("0f17821f-f271-4da7-89e9-0f4730e40ddd"), new Guid("25a28334-238a-4130-ba37-3118318f264c"), new DateTime(2024, 2, 22, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 22, 5, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Description3", "Name3", 3.99m, new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc") },
                    { new Guid("2b52a61d-c404-49fe-834d-9ac8423a1b23"), new Guid("3737017f-955c-4935-a358-201e760eecb2"), new DateTime(2024, 2, 21, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 21, 4, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Description4", "Name4", 4.99m, new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc") },
                    { new Guid("617b47ce-cfe6-4e1d-8d80-ac6ead1cfd2d"), new Guid("53dae8a2-dc28-4a10-8861-1bc246d6a993"), new DateTime(2024, 2, 20, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 20, 3, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Description5", "Name5", 5.99m, new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc") },
                    { new Guid("7a12d90d-a0cc-41b0-9b2f-fe4c5ef362be"), new Guid("3737017f-955c-4935-a358-201e760eecb2"), new DateTime(2024, 2, 23, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 19, 23, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Rubber under your foot", "Slippers", 11.11m, new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc") },
                    { new Guid("8c39da73-d323-4f99-a6b2-3f8a491825a9"), new Guid("40ec11f6-298d-436b-a388-58012771d7b2"), new DateTime(2024, 2, 17, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 19, 0, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Description8", "Name8", 8.99m, new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc") },
                    { new Guid("8fba70de-0948-4f2b-bdfe-1cece9b13cfb"), new Guid("25a28334-238a-4130-ba37-3118318f264c"), new DateTime(2024, 2, 24, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 24, 7, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Description1", "Name1", 1.99m, new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc") },
                    { new Guid("ac1baca8-ea79-47c4-b8e0-9a62683cfb90"), new Guid("53dae8a2-dc28-4a10-8861-1bc246d6a993"), new DateTime(2024, 2, 18, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 18, 1, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Description7", "Name7", 7.99m, new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc") },
                    { new Guid("c24806a8-ad36-4368-893b-ab8ab8665f3a"), new Guid("53dae8a2-dc28-4a10-8861-1bc246d6a993"), new DateTime(2024, 2, 20, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 22, 18, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Burns for 10 hours", "Lamp", 11.11m, new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc") },
                    { new Guid("f0208b36-ba13-4b82-8af2-9ad65649b98d"), new Guid("53dae8a2-dc28-4a10-8861-1bc246d6a993"), new DateTime(2024, 2, 19, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 19, 2, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Description6", "Name6", 6.99m, new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName" },
                values: new object[] { new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc"), new DateTime(2024, 2, 10, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 15, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "admin@admin.com", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("53dae8a2-dc28-4a10-8861-1bc246d6a993"), new Guid("40ec11f6-298d-436b-a388-58012771d7b2"), new DateTime(2024, 2, 11, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 15, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Category4" },
                    { new Guid("cc32089e-ce20-4687-9634-8a01594979f2"), new Guid("53dae8a2-dc28-4a10-8861-1bc246d6a993"), new DateTime(2024, 2, 11, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 2, 15, 8, 36, 26, 762, DateTimeKind.Utc).AddTicks(2621), "Category5" }
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
