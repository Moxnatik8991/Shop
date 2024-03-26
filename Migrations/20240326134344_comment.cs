using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class comment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("178323ff-3bd7-4951-b563-84798aa01f4b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("216c988c-c095-4f1e-b3c2-0baf5933c42e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ccc3123-e24f-4ac1-ad53-cfc6c7639794"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d988ac2-746e-49f0-812c-ef1016dec01c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39107a2b-5d47-48b6-b803-a1c28c9c486a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3b286d62-d045-48a1-890f-1352a2fd28c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41a8bad2-7360-4b1f-9d64-148580a1a510"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("452c43d2-9c51-4180-873d-c3382bbf8600"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ce876a7-20cb-4b48-bb35-56bd3d77b529"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("698f95fb-4ee0-40ec-af69-db879f45f771"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("777c3b7d-7701-4956-a0ba-6f3774bd9afe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a5bffd1-5a21-4317-a409-b2c007e3027c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("861f5ba9-edb2-4d3b-a943-70e748f201ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("941cd916-5318-420b-96ea-cc87bd852501"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b85e139d-f167-43bc-ba6e-c5e9d9efe384"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d190b221-9b1a-4e26-8dd8-98d0d2d01414"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe272257-138e-4ef7-9eb5-c870f766cad4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c643819-34a6-4fc3-b49f-5880357a0a3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("477dd1e4-6136-4369-b57b-fbba47918663"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d2d5b90-5904-4653-b00d-3128343e1a68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d99af76-1ae4-4b21-983c-9493ce0bd249"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8dbaec10-3332-4054-81dd-ffa73dcf9906"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99e791c1-f34c-4915-816c-c754a3870056"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb869db5-e0f2-44d6-a09c-befc61a20195"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c90e731b-6383-4653-8943-b4a588984bb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dff25cd8-cd03-443a-be83-1b783b1e1af5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3790f41-87f5-4565-8bd2-e58598b0dcfd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76e52165-3a75-4e37-bc50-4b2d87a8fcd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("acd402ca-a6d4-4676-a82d-b723671049cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd4f896d-fd54-4f01-8b5f-1aa90c4c5ebd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("580e4680-fd28-48b8-b976-22f23c61a9cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6f334d4-4ee3-4194-9aca-546dbef39f46"));

            migrationBuilder.CreateTable(
                name: "Comment",
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
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Products_ProductId",
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
                    { new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"), null, new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Ноутбуки и компьютеры" },
                    { new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"), null, new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Смартфоны, ТВ и Электроника" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Description", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("110e86a0-3e06-4fc8-a8af-18a0d1622f34"), new Guid("16f5311f-3107-4046-a799-7ea4c404eb0f"), new DateTime(2024, 3, 19, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 19, 6, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Description7", "Name7", 7.99m, new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208") },
                    { new Guid("19631ec7-e129-4125-9878-05fba5a79ed1"), new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"), new DateTime(2024, 3, 23, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 23, 10, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Description3", "Name3", 3.99m, new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208") },
                    { new Guid("443cf469-dbee-47f6-90c4-fe036b760244"), new Guid("d92e36e1-6646-4916-814c-2cf485311b36"), new DateTime(2024, 3, 22, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 22, 9, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Description4", "Name4", 4.99m, new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208") },
                    { new Guid("698feb71-b863-4e5f-88c7-30acf5fb4b6a"), new Guid("d92e36e1-6646-4916-814c-2cf485311b36"), new DateTime(2024, 3, 21, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 23, 23, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Burns for 10 hours", "Lamp", 11.11m, new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208") },
                    { new Guid("7e82d12f-c052-4ae2-9674-dfded9515369"), new Guid("af344ca8-4e8c-4679-8e24-4699a9608507"), new DateTime(2024, 3, 21, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 21, 8, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Description5", "Name5", 5.99m, new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208") },
                    { new Guid("89ba8422-fcab-459b-b62d-27d0fc442b35"), new Guid("180133e6-ac4d-4b5f-9ada-f69beb2769f8"), new DateTime(2024, 3, 18, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 20, 5, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Description8", "Name8", 8.99m, new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208") },
                    { new Guid("aa99e7d2-3dce-4d10-85dd-55d2f23ff04d"), new Guid("3f24ee6c-0e89-4d50-adad-94aa62ffb606"), new DateTime(2024, 3, 24, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 24, 11, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Description2", "Name2", 2.99m, new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208") },
                    { new Guid("d51013f7-0e66-4d21-9da9-eaaad2b73905"), new Guid("943a9ab8-d674-4964-9e7f-c1269ec6cdf3"), new DateTime(2024, 3, 24, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 21, 4, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Rubber under your foot", "Slippers", 11.11m, new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208") },
                    { new Guid("deee8ae5-e070-44ec-983b-e88e5bcc5dab"), new Guid("943a9ab8-d674-4964-9e7f-c1269ec6cdf3"), new DateTime(2024, 3, 25, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 25, 12, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Description1", "Name1", 1.99m, new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208") },
                    { new Guid("e67743f3-5ecf-4afd-91ab-ca19b1ca8e35"), new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"), new DateTime(2024, 3, 20, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 20, 7, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Description6", "Name6", 6.99m, new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208"), new DateTime(2024, 3, 11, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "admin@admin.com", "Admin", "Admin", "f2x+4rnI3Lx/HA33/N9u4BypVqqufh777mQlqr2q8T0=", "c6GqkmGiZCR115kdxW4TeQ==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("16f5311f-3107-4046-a799-7ea4c404eb0f"), new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Компьютеры" },
                    { new Guid("180133e6-ac4d-4b5f-9ada-f69beb2769f8"), new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Планшеты" },
                    { new Guid("5f9e563e-0874-453f-9329-1ff149de7b9e"), new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Наушники и аксессуары" },
                    { new Guid("6a2f094e-846a-4e36-921d-5557dce9d1c6"), new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Телевизоры" },
                    { new Guid("91fa8947-ed26-46b2-a25f-e651d7ed7bb5"), new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Носимые гаджеты" },
                    { new Guid("943a9ab8-d674-4964-9e7f-c1269ec6cdf3"), new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Мобильные телефоны" },
                    { new Guid("b4dc1957-03d5-48f5-96a0-b8c0abe49e9d"), new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Мониторы" },
                    { new Guid("c753efec-f8f2-4983-9209-21c8bffb130e"), new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Ноутбуки" },
                    { new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"), new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Компьютерные комплектующие" },
                    { new Guid("08a7ade7-24c1-4e87-9ffe-e3895d540785"), new Guid("91fa8947-ed26-46b2-a25f-e651d7ed7bb5"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Смарт-часы" },
                    { new Guid("1e3bb498-cb17-4a41-915f-d4820db4c468"), new Guid("91fa8947-ed26-46b2-a25f-e651d7ed7bb5"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "3D и VR очки" },
                    { new Guid("1ee1dd26-9258-463f-b193-f7bfdf51ad71"), new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Оперативная память" },
                    { new Guid("3f24ee6c-0e89-4d50-adad-94aa62ffb606"), new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Жесткие диски" },
                    { new Guid("492694a7-9cd4-4cd3-82e4-1e9187168fbf"), new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Звуковые карты" },
                    { new Guid("52d9062e-fe86-4e0e-8ab7-921b9eb58a85"), new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Видеокарты" },
                    { new Guid("69df04e1-00fc-476c-88e2-a27899777bd9"), new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Процессоры" },
                    { new Guid("af344ca8-4e8c-4679-8e24-4699a9608507"), new Guid("91fa8947-ed26-46b2-a25f-e651d7ed7bb5"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Фитнес-браслеты" },
                    { new Guid("d92e36e1-6646-4916-814c-2cf485311b36"), new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Материнские платы" },
                    { new Guid("f445ffea-b9f6-4c60-8517-ccb368e6a898"), new Guid("91fa8947-ed26-46b2-a25f-e651d7ed7bb5"), new DateTime(2024, 3, 12, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 3, 16, 13, 43, 44, 475, DateTimeKind.Utc).AddTicks(4141), "Смарт-кольца" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProductId",
                table: "Comment",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08a7ade7-24c1-4e87-9ffe-e3895d540785"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16f5311f-3107-4046-a799-7ea4c404eb0f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("180133e6-ac4d-4b5f-9ada-f69beb2769f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e3bb498-cb17-4a41-915f-d4820db4c468"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ee1dd26-9258-463f-b193-f7bfdf51ad71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f24ee6c-0e89-4d50-adad-94aa62ffb606"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("492694a7-9cd4-4cd3-82e4-1e9187168fbf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52d9062e-fe86-4e0e-8ab7-921b9eb58a85"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f9e563e-0874-453f-9329-1ff149de7b9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("69df04e1-00fc-476c-88e2-a27899777bd9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a2f094e-846a-4e36-921d-5557dce9d1c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("943a9ab8-d674-4964-9e7f-c1269ec6cdf3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("af344ca8-4e8c-4679-8e24-4699a9608507"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4dc1957-03d5-48f5-96a0-b8c0abe49e9d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c753efec-f8f2-4983-9209-21c8bffb130e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d92e36e1-6646-4916-814c-2cf485311b36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f445ffea-b9f6-4c60-8517-ccb368e6a898"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("110e86a0-3e06-4fc8-a8af-18a0d1622f34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19631ec7-e129-4125-9878-05fba5a79ed1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("443cf469-dbee-47f6-90c4-fe036b760244"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("698feb71-b863-4e5f-88c7-30acf5fb4b6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e82d12f-c052-4ae2-9674-dfded9515369"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89ba8422-fcab-459b-b62d-27d0fc442b35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa99e7d2-3dce-4d10-85dd-55d2f23ff04d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d51013f7-0e66-4d21-9da9-eaaad2b73905"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("deee8ae5-e070-44ec-983b-e88e5bcc5dab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e67743f3-5ecf-4afd-91ab-ca19b1ca8e35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a8f63c7-8e7f-4f3d-9674-31b580060208"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91fa8947-ed26-46b2-a25f-e651d7ed7bb5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca4d946b-ba07-437a-a821-cf2932738ad0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f5455eb-424b-4dad-aa3f-c4b4f84bc6e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f1c333c-bb2d-409c-bc76-8fa6aea698d2"));

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
        }
    }
}
