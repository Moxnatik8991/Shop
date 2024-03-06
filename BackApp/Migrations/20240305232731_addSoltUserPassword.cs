using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class addSoltUserPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25a28334-238a-4130-ba37-3118318f264c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3737017f-955c-4935-a358-201e760eecb2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc32089e-ce20-4687-9634-8a01594979f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("043c008b-c8d9-43db-8d2a-3319433c774d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f17821f-f271-4da7-89e9-0f4730e40ddd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b52a61d-c404-49fe-834d-9ac8423a1b23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("617b47ce-cfe6-4e1d-8d80-ac6ead1cfd2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a12d90d-a0cc-41b0-9b2f-fe4c5ef362be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c39da73-d323-4f99-a6b2-3f8a491825a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fba70de-0948-4f2b-bdfe-1cece9b13cfb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac1baca8-ea79-47c4-b8e0-9a62683cfb90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c24806a8-ad36-4368-893b-ab8ab8665f3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0208b36-ba13-4b82-8af2-9ad65649b98d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("983efc4b-93e9-4814-bdce-3245204f1dbc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53dae8a2-dc28-4a10-8861-1bc246d6a993"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40ec11f6-298d-436b-a388-58012771d7b2"));

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PasswordSalt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("2315de19-70c6-43f1-b845-171f3acaa609"), null, new DateTime(2024, 2, 20, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 2, 24, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Category3" },
                    { new Guid("494a1eda-dc67-46d1-be1e-603ff9300078"), null, new DateTime(2024, 2, 20, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 2, 24, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Category1" },
                    { new Guid("81402a0d-5d0a-4945-b0c6-828e649b1ead"), null, new DateTime(2024, 2, 20, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 2, 24, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Category2" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Description", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("03d30802-1729-4fdd-9fbe-1c15a3366112"), new Guid("494a1eda-dc67-46d1-be1e-603ff9300078"), new DateTime(2024, 3, 4, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 3, 4, 22, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Description1", "Name1", 1.99m, new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11") },
                    { new Guid("0f844933-a168-468c-ac39-e0f1cb9d7488"), new Guid("81402a0d-5d0a-4945-b0c6-828e649b1ead"), new DateTime(2024, 3, 2, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 3, 2, 20, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Description3", "Name3", 3.99m, new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11") },
                    { new Guid("2352f267-1bd1-45a0-8843-6fffc3616c88"), new Guid("81402a0d-5d0a-4945-b0c6-828e649b1ead"), new DateTime(2024, 2, 29, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 2, 29, 18, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Description5", "Name5", 5.99m, new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11") },
                    { new Guid("27ecbd06-d10c-4398-9af5-827b2cf092a3"), new Guid("81402a0d-5d0a-4945-b0c6-828e649b1ead"), new DateTime(2024, 3, 1, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 3, 1, 19, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Description4", "Name4", 4.99m, new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11") },
                    { new Guid("2dc4ff7f-9297-4e90-9b5b-25bc5c66a382"), new Guid("81402a0d-5d0a-4945-b0c6-828e649b1ead"), new DateTime(2024, 2, 26, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 2, 28, 15, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Description8", "Name8", 8.99m, new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11") },
                    { new Guid("2fe6a181-5d33-4902-8990-e764330c451f"), new Guid("81402a0d-5d0a-4945-b0c6-828e649b1ead"), new DateTime(2024, 2, 27, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 2, 27, 16, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Description7", "Name7", 7.99m, new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11") },
                    { new Guid("355f327b-77f9-47a3-945a-3a931dfab0d5"), new Guid("2315de19-70c6-43f1-b845-171f3acaa609"), new DateTime(2024, 3, 3, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 2, 29, 14, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Rubber under your foot", "Slippers", 11.11m, new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11") },
                    { new Guid("3c760b5a-c932-46d1-b644-6421a90cc5bc"), new Guid("59b99baa-e1d0-44f6-9c73-959bc26ff33a"), new DateTime(2024, 2, 29, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 3, 3, 9, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Burns for 10 hours", "Lamp", 11.11m, new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11") },
                    { new Guid("9a6eb998-b038-43e0-a44c-69c195b0a294"), new Guid("531b4dfc-8372-48f9-92bf-56132faaab4b"), new DateTime(2024, 2, 28, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 2, 28, 17, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Description6", "Name6", 6.99m, new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11") },
                    { new Guid("fce0c66a-d178-4f96-9372-ede93134ca5b"), new Guid("81402a0d-5d0a-4945-b0c6-828e649b1ead"), new DateTime(2024, 3, 3, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 3, 3, 21, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Description2", "Name2", 2.99m, new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11"), new DateTime(2024, 2, 19, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 2, 24, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "admin@admin.com", "Admin", "Admin", "eBeztJdRYQgfaYk47pPS59MJmHfqx40KowgYJ4OBx4M=", "MtJZfRGlZgXM0Kda8OGLlw==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("531b4dfc-8372-48f9-92bf-56132faaab4b"), new Guid("494a1eda-dc67-46d1-be1e-603ff9300078"), new DateTime(2024, 2, 20, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 2, 24, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Category4" },
                    { new Guid("59b99baa-e1d0-44f6-9c73-959bc26ff33a"), new Guid("531b4dfc-8372-48f9-92bf-56132faaab4b"), new DateTime(2024, 2, 20, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), new DateTime(2024, 2, 24, 23, 27, 31, 31, DateTimeKind.Utc).AddTicks(5385), "Category5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2315de19-70c6-43f1-b845-171f3acaa609"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59b99baa-e1d0-44f6-9c73-959bc26ff33a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81402a0d-5d0a-4945-b0c6-828e649b1ead"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03d30802-1729-4fdd-9fbe-1c15a3366112"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f844933-a168-468c-ac39-e0f1cb9d7488"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2352f267-1bd1-45a0-8843-6fffc3616c88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27ecbd06-d10c-4398-9af5-827b2cf092a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2dc4ff7f-9297-4e90-9b5b-25bc5c66a382"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2fe6a181-5d33-4902-8990-e764330c451f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("355f327b-77f9-47a3-945a-3a931dfab0d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c760b5a-c932-46d1-b644-6421a90cc5bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a6eb998-b038-43e0-a44c-69c195b0a294"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fce0c66a-d178-4f96-9372-ede93134ca5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc7b21e3-fa55-40c3-8ba5-dd36b1acbb11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("531b4dfc-8372-48f9-92bf-56132faaab4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("494a1eda-dc67-46d1-be1e-603ff9300078"));

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

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
        }
    }
}
