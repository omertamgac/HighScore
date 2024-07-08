using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HightScore.Entities.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CategoryDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "varchar(800)", maxLength: 800, nullable: false),
                    RelaseDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserAverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MediaAverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MediaName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    MediaLogo = table.Column<byte>(type: "tinyint unsigned", nullable: true),
                    TaxIdNumber = table.Column<string>(type: "varchar(255)", nullable: false),
                    Country = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    phone = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Fax = table.Column<string>(type: "longtext", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PlatformName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Logo = table.Column<byte>(type: "tinyint unsigned", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false),
                    Role = table.Column<string>(type: "longtext", nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    NickName = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoryItem",
                columns: table => new
                {
                    CategroiesId = table.Column<int>(type: "int", nullable: false),
                    itemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryItem", x => new { x.CategroiesId, x.itemsId });
                    table.ForeignKey(
                        name: "FK_CategoryItem_Categories_CategroiesId",
                        column: x => x.CategroiesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryItem_Items_itemsId",
                        column: x => x.itemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MediaReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "longtext", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaReviews_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaReviews_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemPlatform",
                columns: table => new
                {
                    PlatformsId = table.Column<int>(type: "int", nullable: false),
                    itemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPlatform", x => new { x.PlatformsId, x.itemsId });
                    table.ForeignKey(
                        name: "FK_ItemPlatform_Items_itemsId",
                        column: x => x.itemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPlatform_Platforms_PlatformsId",
                        column: x => x.PlatformsId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AdminActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    adminIdId = table.Column<int>(type: "int", nullable: false),
                    ActionType = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminActions_Users_adminIdId",
                        column: x => x.adminIdId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserRating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "longtext", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReviews_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CategoryName", "CreatedTime" },
                values: new object[,]
                {
                    { 1, "Games that emphasize physical challenges, including hand-eye coordination and reaction-time.", "Action", new DateTime(2024, 7, 7, 22, 41, 54, 287, DateTimeKind.Local).AddTicks(4010) },
                    { 2, "Games focused on story-driven gameplay and exploration of a virtual world.", "Adventure", new DateTime(2024, 7, 7, 22, 41, 54, 287, DateTimeKind.Local).AddTicks(4023) },
                    { 3, "Games where players assume the roles of characters in a fictional setting and take control over many of those characters' actions.", "Role-Playing (RPG)", new DateTime(2024, 7, 7, 22, 41, 54, 287, DateTimeKind.Local).AddTicks(4025) },
                    { 4, "Games designed to simulate real-world activities and scenarios as closely as possible.", "Simulation", new DateTime(2024, 7, 7, 22, 41, 54, 287, DateTimeKind.Local).AddTicks(4026) },
                    { 5, "Games that focus on careful planning and skillful thinking to achieve victory.", "Strategy", new DateTime(2024, 7, 7, 22, 41, 54, 287, DateTimeKind.Local).AddTicks(4027) },
                    { 6, "Games that simulate the practice of sports, including team sports, track and field, and extreme sports.", "Sports", new DateTime(2024, 7, 7, 22, 41, 54, 287, DateTimeKind.Local).AddTicks(4028) },
                    { 7, "Games that emphasize solving puzzles as the main gameplay element.", "Puzzle", new DateTime(2024, 7, 7, 22, 41, 54, 287, DateTimeKind.Local).AddTicks(4029) },
                    { 8, "Games designed to scare the player, often through a combination of atmosphere, storytelling, and shock elements.", "Horror", new DateTime(2024, 7, 7, 22, 41, 54, 287, DateTimeKind.Local).AddTicks(4030) },
                    { 9, "Games where the primary objective is to race against opponents or the clock.", "Racing", new DateTime(2024, 7, 7, 22, 41, 54, 287, DateTimeKind.Local).AddTicks(4031) },
                    { 10, "Games that support large numbers of players interacting with each other in a persistent virtual world.", "MMO (Massively Multiplayer Online)", new DateTime(2024, 7, 7, 22, 41, 54, 287, DateTimeKind.Local).AddTicks(4032) }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "CreatedTime", "Logo", "PlatformName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7076), null, "PlayStation 5" },
                    { 2, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7081), null, "Xbox Series X" },
                    { 3, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7082), null, "Nintendo Switch" },
                    { 4, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7083), null, "PlayStation 4" },
                    { 5, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7084), null, "Xbox One" },
                    { 6, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7085), null, "PC" },
                    { 7, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7086), null, "PlayStation Vita" },
                    { 8, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7088), null, "Nintendo 3DS" },
                    { 9, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7131), null, "Stadia" },
                    { 10, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7132), null, "Oculus Quest 2" },
                    { 11, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7133), null, "Nintendo Wii U" },
                    { 12, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7134), null, "PlayStation 3" },
                    { 13, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7135), null, "Xbox 360" },
                    { 14, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7136), null, "Nintendo Wii" },
                    { 15, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7137), null, "PlayStation Portable (PSP)" },
                    { 16, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7138), null, "Game Boy Advance" },
                    { 17, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7139), null, "Sega Dreamcast" },
                    { 18, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7140), null, "Super Nintendo Entertainment System (SNES)" },
                    { 19, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7141), null, "Sega Genesis" },
                    { 20, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7142), null, "Atari 2600" },
                    { 21, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7143), null, "PlayStation 2" },
                    { 22, new DateTime(2024, 7, 7, 22, 41, 54, 288, DateTimeKind.Local).AddTicks(7144), null, "PlayStation 1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminActions_adminIdId",
                table: "AdminActions",
                column: "adminIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryItem_itemsId",
                table: "CategoryItem",
                column: "itemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPlatform_itemsId",
                table: "ItemPlatform",
                column: "itemsId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaReviews_ItemId",
                table: "MediaReviews",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaReviews_MediaId",
                table: "MediaReviews",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medias_Email",
                table: "Medias",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medias_MediaName",
                table: "Medias",
                column: "MediaName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medias_phone",
                table: "Medias",
                column: "phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medias_TaxIdNumber",
                table: "Medias",
                column: "TaxIdNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medias_UserName",
                table: "Medias",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_PlatformName",
                table: "Platforms",
                column: "PlatformName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_ItemId",
                table: "UserReviews",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_UserId",
                table: "UserReviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_NickName",
                table: "Users",
                column: "NickName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminActions");

            migrationBuilder.DropTable(
                name: "CategoryItem");

            migrationBuilder.DropTable(
                name: "ItemPlatform");

            migrationBuilder.DropTable(
                name: "MediaReviews");

            migrationBuilder.DropTable(
                name: "UserReviews");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
