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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CountViews = table.Column<long>(type: "bigint", nullable: false),
                    CountComments = table.Column<long>(type: "bigint", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "FileDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Order = table.Column<byte>(type: "tinyint", nullable: true),
                    DataCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileDetails_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileDetails_Products_ProductId",
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
                    { new Guid("3d46de99-2722-41c4-9fc3-03ed22704bdf"), null, new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Смартфоны, ТВ и Электроника" },
                    { new Guid("c93072b6-1b64-46f0-93fa-a5d469bcac3e"), null, new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Ноутбуки и компьютеры" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CountComments", "CountViews", "DataCreate", "DataUpdate", "Description", "Name", "Price", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("044ac488-3564-4201-8ddd-7e72c48ae515"), new Guid("5646833e-fdc3-4fd5-8574-76b4976a5489"), 0L, 0L, new DateTime(2024, 4, 7, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 9, 10, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Description8", "Name8", 8.99m, 0m, new Guid("04067cd2-c6e1-4f1d-9f96-71172e1498bf") },
                    { new Guid("15d774af-8c31-42d6-a72a-c7687d520980"), new Guid("0c51b1cb-5ea5-42e9-a77f-18a9d9770e01"), 0L, 0L, new DateTime(2024, 4, 13, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 10, 9, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Rubber under your foot", "Slippers", 11.11m, 0m, new Guid("04067cd2-c6e1-4f1d-9f96-71172e1498bf") },
                    { new Guid("5157fe09-bc8c-4074-99cb-d3381044b143"), new Guid("e4d20234-d778-482d-b225-062431f225f0"), 0L, 0L, new DateTime(2024, 4, 10, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 10, 13, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Description5", "Name5", 5.99m, 0m, new Guid("04067cd2-c6e1-4f1d-9f96-71172e1498bf") },
                    { new Guid("5202682a-9f27-4ec2-93a2-639c5a299933"), new Guid("32848577-ec7c-4f66-a565-d4f18bbe18c0"), 0L, 0L, new DateTime(2024, 4, 8, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 8, 11, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Description7", "Name7", 7.99m, 0m, new Guid("04067cd2-c6e1-4f1d-9f96-71172e1498bf") },
                    { new Guid("53c717f5-45ba-4e59-b6a8-c3ebd01435f5"), new Guid("50243bdd-d017-4819-8945-185903d7b9f3"), 0L, 0L, new DateTime(2024, 4, 14, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 14, 17, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Description1", "Name1", 1.99m, 0m, new Guid("04067cd2-c6e1-4f1d-9f96-71172e1498bf") },
                    { new Guid("5a3f2801-516c-45c8-8f16-c409352d82bc"), new Guid("2038d26f-5e75-47d4-a9d8-96c3ee65614e"), 0L, 0L, new DateTime(2024, 4, 9, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 9, 12, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Description6", "Name6", 6.99m, 0m, new Guid("04067cd2-c6e1-4f1d-9f96-71172e1498bf") },
                    { new Guid("9097036b-c172-44c1-9367-6b4ad714a22b"), new Guid("f45d39c1-e9ea-4220-a7d4-90222133bbaf"), 0L, 0L, new DateTime(2024, 4, 11, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 11, 14, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Description4", "Name4", 4.99m, 0m, new Guid("04067cd2-c6e1-4f1d-9f96-71172e1498bf") },
                    { new Guid("b2378bc7-1989-45f1-98db-f671b91e9b49"), new Guid("f0c52d78-3add-45a2-8160-211f6afbc79a"), 0L, 0L, new DateTime(2024, 4, 10, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 13, 4, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Burns for 10 hours", "Lamp", 11.11m, 0m, new Guid("04067cd2-c6e1-4f1d-9f96-71172e1498bf") },
                    { new Guid("c2235905-4240-49e1-9474-dab7662ba1b8"), new Guid("198008bb-ba9c-4d12-82ba-b1160396ed8e"), 0L, 0L, new DateTime(2024, 4, 13, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 13, 16, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Description2", "Name2", 2.99m, 0m, new Guid("04067cd2-c6e1-4f1d-9f96-71172e1498bf") },
                    { new Guid("d1f2999e-928d-4c07-af19-d0c592cd3ffb"), new Guid("f45d39c1-e9ea-4220-a7d4-90222133bbaf"), 0L, 0L, new DateTime(2024, 4, 12, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 12, 15, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Description3", "Name3", 3.99m, 0m, new Guid("04067cd2-c6e1-4f1d-9f96-71172e1498bf") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataCreate", "DataUpdate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("04067cd2-c6e1-4f1d-9f96-71172e1498bf"), new DateTime(2024, 3, 31, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "admin@admin.com", "Admin", "Admin", "wgB5A9ch/MTqSCLxGxuH7SCuUDVa6rhaxMpBO7fEQuc=", "rH8Kqo+A3QYrv+7JdFPj7g==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "DataCreate", "DataUpdate", "Name" },
                values: new object[,]
                {
                    { new Guid("2038d26f-5e75-47d4-a9d8-96c3ee65614e"), new Guid("c93072b6-1b64-46f0-93fa-a5d469bcac3e"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Ноутбуки" },
                    { new Guid("32848577-ec7c-4f66-a565-d4f18bbe18c0"), new Guid("c93072b6-1b64-46f0-93fa-a5d469bcac3e"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Компьютеры" },
                    { new Guid("50243bdd-d017-4819-8945-185903d7b9f3"), new Guid("c93072b6-1b64-46f0-93fa-a5d469bcac3e"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Планшеты" },
                    { new Guid("5963ee91-d82b-472c-b9e8-f7d9f130058b"), new Guid("c93072b6-1b64-46f0-93fa-a5d469bcac3e"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Мониторы" },
                    { new Guid("631a575d-f330-4506-8305-b130d646230d"), new Guid("3d46de99-2722-41c4-9fc3-03ed22704bdf"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Мобильные телефоны" },
                    { new Guid("766d1a76-2c19-45ca-af85-1e61e4d73710"), new Guid("3d46de99-2722-41c4-9fc3-03ed22704bdf"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Наушники и аксессуары" },
                    { new Guid("7d82a637-67ef-430c-b69b-34c963a4a676"), new Guid("c93072b6-1b64-46f0-93fa-a5d469bcac3e"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Компьютерные комплектующие" },
                    { new Guid("f0c52d78-3add-45a2-8160-211f6afbc79a"), new Guid("3d46de99-2722-41c4-9fc3-03ed22704bdf"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Телевизоры" },
                    { new Guid("f45d39c1-e9ea-4220-a7d4-90222133bbaf"), new Guid("3d46de99-2722-41c4-9fc3-03ed22704bdf"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Носимые гаджеты" },
                    { new Guid("0abb8879-1b37-470a-98b2-e76d16460ea1"), new Guid("7d82a637-67ef-430c-b69b-34c963a4a676"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Видеокарты" },
                    { new Guid("0c51b1cb-5ea5-42e9-a77f-18a9d9770e01"), new Guid("7d82a637-67ef-430c-b69b-34c963a4a676"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Жесткие диски" },
                    { new Guid("198008bb-ba9c-4d12-82ba-b1160396ed8e"), new Guid("f45d39c1-e9ea-4220-a7d4-90222133bbaf"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Смарт-часы" },
                    { new Guid("3a0c91d1-890f-481b-aa5a-591f534256fb"), new Guid("f45d39c1-e9ea-4220-a7d4-90222133bbaf"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Смарт-кольца" },
                    { new Guid("4085d12f-2c23-4e4b-bc3d-06bd8f608bc0"), new Guid("7d82a637-67ef-430c-b69b-34c963a4a676"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Процессоры" },
                    { new Guid("55dcf70f-747f-4af7-bed8-5d2d9f9a21b2"), new Guid("f45d39c1-e9ea-4220-a7d4-90222133bbaf"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Фитнес-браслеты" },
                    { new Guid("5646833e-fdc3-4fd5-8574-76b4976a5489"), new Guid("7d82a637-67ef-430c-b69b-34c963a4a676"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Оперативная память" },
                    { new Guid("df6a3929-fe6c-4c70-85cf-89f92ebb05c8"), new Guid("f45d39c1-e9ea-4220-a7d4-90222133bbaf"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "3D и VR очки" },
                    { new Guid("e4d20234-d778-482d-b225-062431f225f0"), new Guid("7d82a637-67ef-430c-b69b-34c963a4a676"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Материнские платы" },
                    { new Guid("ef9c08bb-a63e-477d-8fe8-f894f4b9a7be"), new Guid("7d82a637-67ef-430c-b69b-34c963a4a676"), new DateTime(2024, 4, 1, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 4, 5, 18, 44, 46, 682, DateTimeKind.Utc).AddTicks(3312), "Звуковые карты" }
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
                name: "IX_FileDetails_CategoryId",
                table: "FileDetails",
                column: "CategoryId",
                unique: true,
                filter: "[CategoryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FileDetails_ProductId",
                table: "FileDetails",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "FileDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
