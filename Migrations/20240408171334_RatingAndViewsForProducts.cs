using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class RatingAndViewsForProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0415ae8f-df2d-4bd8-9d9b-06e1ab5a80f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ccd4c3c-f2e6-468d-beb4-10a4f7820458"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12816644-226d-4d09-b7c9-5eb22fbcef4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d70da78-8914-429c-846d-f862449e707f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c7020c7-837f-42ff-9b78-e98488de73ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3daff5eb-68de-4ab6-9a16-bf03c1cca491"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("560979c6-6bac-43da-b5d5-b66bcdd999cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ac0739d-d6b6-46f0-b229-6860190917ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f184ba8-b725-4c35-bb22-e18e7489d257"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80210cc8-e686-4a82-b1d9-85dad60f0a4c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a806cb1f-3f4b-446a-8110-de75144d6569"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad997198-40eb-49ec-8598-b0e9597a5896"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca550976-6ec3-45a3-87ea-6636d2a649fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb202d74-b689-49a2-8c9c-397f8f6e693b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc8130cd-b257-4738-92a3-0219728489b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f490b0ac-a979-43da-a528-0f21b63eef92"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9548cc7-ea16-492f-88cb-c11c44c95cab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09dcf1d5-3278-4a8a-b6d8-1d5cb05c6825"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12a3908a-87c3-4efd-b106-e461ffc559b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c4bdda9-15f7-479d-8caf-e6bdf3e0656f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("286528d6-9230-45de-9bdb-2222773ea79f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28b9823e-810c-40fb-ab83-1f7879acd0dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3578fb32-5fe9-4e69-9056-f367dc2f9f33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3930bc03-5406-4f30-b7ee-5c7d72d3235f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d0d1d48-646a-461c-a653-26a2654e1b4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c6e80f4-bc80-4a39-86f6-5c2c76e2d6ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87991b3d-3a75-421e-acc7-a61c29c64b90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07389218-fb2d-4a0e-94e6-9e23b70bb14d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34bc641e-3e8a-44ba-9402-417e6af12d8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53360d33-b29b-4537-9b54-6092ed007215"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34b94ae4-9801-445a-aed6-b22986566e77"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ceed9c73-6fc2-44c9-8107-b49c04774c37"));

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "Views",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("0d12fa10-a331-4830-9991-3be965de771a"), null, new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Ноутбуки и компьютеры" },
                    { new Guid("f1127796-9ad1-406a-8cf7-cb9cc0df028d"), null, new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Смартфоны, ТВ и Электроника" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Description", "Name", "Price", "Rating", "UserId", "Views" },
                values: new object[,]
                {
                    { new Guid("09628500-b5ed-4b91-a1c9-76c2b38e33ed"), new Guid("0d12fa10-a331-4830-9991-3be965de771a"), new DateTime(2024, 3, 31, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 4, 2, 9, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Description8", "Name8", 8.99m, 0m, new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"), 0L },
                    { new Guid("10c4e485-6f9a-45e0-9cff-ea7371baa807"), new Guid("73090c57-f2e0-4243-af06-b33f88701e36"), new DateTime(2024, 4, 2, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 4, 2, 11, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Description6", "Name6", 6.99m, 0m, new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"), 0L },
                    { new Guid("542d04a2-c5e4-4ca8-84c0-9318a578d0af"), new Guid("befe882c-f59c-4359-9cea-3b056845b42d"), new DateTime(2024, 4, 1, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 4, 1, 10, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Description7", "Name7", 7.99m, 0m, new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"), 0L },
                    { new Guid("588981df-51fa-498e-a688-d38905db7620"), new Guid("73090c57-f2e0-4243-af06-b33f88701e36"), new DateTime(2024, 4, 4, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 4, 4, 13, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Description4", "Name4", 4.99m, 0m, new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"), 0L },
                    { new Guid("5e9dbf5e-edf7-4c70-b1ab-fb89fc9ceaec"), new Guid("4b32eb0f-3651-4b29-b185-37f830ae59ca"), new DateTime(2024, 4, 3, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 4, 3, 12, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Description5", "Name5", 5.99m, 0m, new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"), 0L },
                    { new Guid("80c373da-6036-4d86-b4ad-a5213e8b0015"), new Guid("6861b9f8-64d8-4083-bdac-06878534c978"), new DateTime(2024, 4, 6, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 4, 3, 8, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Rubber under your foot", "Slippers", 11.11m, 0m, new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"), 0L },
                    { new Guid("a1a0ef5b-7d24-46d6-9b6e-60b6b3bdc343"), new Guid("a5ac2baf-465f-45a3-b241-5598a67af1cd"), new DateTime(2024, 4, 6, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 4, 6, 15, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Description2", "Name2", 2.99m, 0m, new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"), 0L },
                    { new Guid("ac1986d8-075d-4d19-995f-dc9ed07d9514"), new Guid("3975a26e-0e2c-4342-b9e3-f60f306bba1d"), new DateTime(2024, 4, 5, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 4, 5, 14, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Description3", "Name3", 3.99m, 0m, new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"), 0L },
                    { new Guid("ae5e5e8b-4765-4c97-b5d9-689dc1451d11"), new Guid("094cb01e-61b7-429b-8aaf-cde202f2ba80"), new DateTime(2024, 4, 3, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 4, 6, 3, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Burns for 10 hours", "Lamp", 11.11m, 0m, new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"), 0L },
                    { new Guid("fde6974f-2ffa-408a-970b-62213a632707"), new Guid("3975a26e-0e2c-4342-b9e3-f60f306bba1d"), new DateTime(2024, 4, 7, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 4, 7, 16, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Description1", "Name1", 1.99m, 0m, new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"), 0L }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"), new DateTime(2024, 3, 24, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "admin@admin.com", "Admin", "Admin", "ghmZkf+TsVE2OOnjg1bJAjPSsy2G1RyTQFy0yq8Nc1g=", "KKLFHmL4/hfCgrfdCsrN1Q==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("094cb01e-61b7-429b-8aaf-cde202f2ba80"), new Guid("0d12fa10-a331-4830-9991-3be965de771a"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Компьютерные комплектующие" },
                    { new Guid("3020de21-8579-486c-bc4e-724391e1eb30"), new Guid("f1127796-9ad1-406a-8cf7-cb9cc0df028d"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Мобильные телефоны" },
                    { new Guid("4b32eb0f-3651-4b29-b185-37f830ae59ca"), new Guid("f1127796-9ad1-406a-8cf7-cb9cc0df028d"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Телевизоры" },
                    { new Guid("55c7b332-c964-4d12-a2c4-405716731491"), new Guid("f1127796-9ad1-406a-8cf7-cb9cc0df028d"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Наушники и аксессуары" },
                    { new Guid("6420b9b5-5a96-435e-9f4b-9cb00bf85963"), new Guid("0d12fa10-a331-4830-9991-3be965de771a"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Компьютеры" },
                    { new Guid("73090c57-f2e0-4243-af06-b33f88701e36"), new Guid("0d12fa10-a331-4830-9991-3be965de771a"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Ноутбуки" },
                    { new Guid("a2e3b6b9-bf11-48bd-a20d-3a5495b03644"), new Guid("0d12fa10-a331-4830-9991-3be965de771a"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Планшеты" },
                    { new Guid("befe882c-f59c-4359-9cea-3b056845b42d"), new Guid("f1127796-9ad1-406a-8cf7-cb9cc0df028d"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Носимые гаджеты" },
                    { new Guid("f2be7a27-a29e-46e4-8b04-8763653ffc5a"), new Guid("0d12fa10-a331-4830-9991-3be965de771a"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Мониторы" },
                    { new Guid("3975a26e-0e2c-4342-b9e3-f60f306bba1d"), new Guid("094cb01e-61b7-429b-8aaf-cde202f2ba80"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Жесткие диски" },
                    { new Guid("41383c13-24b5-4a12-b3eb-bf22bcda0c18"), new Guid("094cb01e-61b7-429b-8aaf-cde202f2ba80"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Видеокарты" },
                    { new Guid("41a9068c-419c-4408-a8a2-bfab020a55ca"), new Guid("befe882c-f59c-4359-9cea-3b056845b42d"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Смарт-часы" },
                    { new Guid("6861b9f8-64d8-4083-bdac-06878534c978"), new Guid("094cb01e-61b7-429b-8aaf-cde202f2ba80"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Оперативная память" },
                    { new Guid("72c6c691-ac3d-41f8-b147-5e19b86ebdf2"), new Guid("befe882c-f59c-4359-9cea-3b056845b42d"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Смарт-кольца" },
                    { new Guid("7eae1ba8-531c-4047-8066-52b79b89b8d4"), new Guid("094cb01e-61b7-429b-8aaf-cde202f2ba80"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Материнские платы" },
                    { new Guid("8d0d8a70-a42e-4164-8cbc-eef9dc6a247d"), new Guid("befe882c-f59c-4359-9cea-3b056845b42d"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Фитнес-браслеты" },
                    { new Guid("a5ac2baf-465f-45a3-b241-5598a67af1cd"), new Guid("befe882c-f59c-4359-9cea-3b056845b42d"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "3D и VR очки" },
                    { new Guid("af421121-80c4-49c2-9162-a9cc2511534e"), new Guid("094cb01e-61b7-429b-8aaf-cde202f2ba80"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Звуковые карты" },
                    { new Guid("cdf06acd-121b-4a64-8aca-57cb8016eca2"), new Guid("094cb01e-61b7-429b-8aaf-cde202f2ba80"), new DateTime(2024, 3, 25, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), new DateTime(2024, 3, 29, 17, 13, 34, 562, DateTimeKind.Utc).AddTicks(8687), "Процессоры" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3020de21-8579-486c-bc4e-724391e1eb30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3975a26e-0e2c-4342-b9e3-f60f306bba1d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41383c13-24b5-4a12-b3eb-bf22bcda0c18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41a9068c-419c-4408-a8a2-bfab020a55ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b32eb0f-3651-4b29-b185-37f830ae59ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("55c7b332-c964-4d12-a2c4-405716731491"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6420b9b5-5a96-435e-9f4b-9cb00bf85963"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6861b9f8-64d8-4083-bdac-06878534c978"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72c6c691-ac3d-41f8-b147-5e19b86ebdf2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73090c57-f2e0-4243-af06-b33f88701e36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7eae1ba8-531c-4047-8066-52b79b89b8d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d0d8a70-a42e-4164-8cbc-eef9dc6a247d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2e3b6b9-bf11-48bd-a20d-3a5495b03644"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5ac2baf-465f-45a3-b241-5598a67af1cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("af421121-80c4-49c2-9162-a9cc2511534e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdf06acd-121b-4a64-8aca-57cb8016eca2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2be7a27-a29e-46e4-8b04-8763653ffc5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09628500-b5ed-4b91-a1c9-76c2b38e33ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10c4e485-6f9a-45e0-9cff-ea7371baa807"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("542d04a2-c5e4-4ca8-84c0-9318a578d0af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("588981df-51fa-498e-a688-d38905db7620"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e9dbf5e-edf7-4c70-b1ab-fb89fc9ceaec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80c373da-6036-4d86-b4ad-a5213e8b0015"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1a0ef5b-7d24-46d6-9b6e-60b6b3bdc343"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac1986d8-075d-4d19-995f-dc9ed07d9514"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e5e8b-4765-4c97-b5d9-689dc1451d11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fde6974f-2ffa-408a-970b-62213a632707"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb5f0ac4-bd7c-4333-908d-2d2fbfd44d42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("094cb01e-61b7-429b-8aaf-cde202f2ba80"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("befe882c-f59c-4359-9cea-3b056845b42d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d12fa10-a331-4830-9991-3be965de771a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1127796-9ad1-406a-8cf7-cb9cc0df028d"));

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "Products");

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
        }
    }
}
