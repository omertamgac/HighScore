using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HightScore.Entities.Migrations
{
    /// <inheritdoc />
    public partial class firstDB : Migration
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
                    ActionType = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminActions_Users_AdminId",
                        column: x => x.AdminId,
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
                    { 1, "Games that emphasize physical challenges, including hand-eye coordination and reaction-time.", "Action", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5536) },
                    { 2, "Games focused on story-driven gameplay and exploration of a virtual world.", "Adventure", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5540) },
                    { 3, "Games where players assume the roles of characters in a fictional setting and take control over many of those characters' actions.", "Role-Playing (RPG)", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5542) },
                    { 4, "Games designed to simulate real-world activities and scenarios as closely as possible.", "Simulation", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5543) },
                    { 5, "Games that focus on careful planning and skillful thinking to achieve victory.", "Strategy", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5544) },
                    { 6, "Games that simulate the practice of sports, including team sports, track and field, and extreme sports.", "Sports", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5545) },
                    { 7, "Games that emphasize solving puzzles as the main gameplay element.", "Puzzle", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5546) },
                    { 8, "Games designed to scare the player, often through a combination of atmosphere, storytelling, and shock elements.", "Horror", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5548) },
                    { 9, "Games where the primary objective is to race against opponents or the clock.", "Racing", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5550) },
                    { 10, "Games that support large numbers of players interacting with each other in a persistent virtual world.", "MMO (Massively Multiplayer Online)", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5551) }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedTime", "Description", "MediaAverageRating", "RelaseDate", "Title", "UpdatedAt", "UserAverageRating" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6413), "An action-adventure game developed and published by Nintendo.", 9.8m, new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6425), 9.5m },
                    { 2, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6428), "A platform game developed and published by Nintendo for the Nintendo Switch.", 9.7m, new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super Mario Odyssey", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6430), 9.3m },
                    { 3, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6431), "An action-adventure game developed and published by Rockstar Games.", 9.8m, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6433), 9.6m },
                    { 4, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6434), "An action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.", 9.6m, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6436), 9.4m },
                    { 5, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6437), "An action role-playing game developed and published by CD Projekt.", 9.9m, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6439), 9.7m },
                    { 6, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6440), "An action role-playing game developed and published by CD Projekt.", 8.9m, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6443), 8.5m },
                    { 7, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6444), "A sandbox video game developed by Mojang.", 9.5m, new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6445), 9.2m },
                    { 8, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6446), "An online video game developed by Epic Games.", 9.0m, new DateTime(2017, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6447), 8.8m },
                    { 9, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6448), "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.", 9.7m, new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6450), 9.4m },
                    { 10, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6450), "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.", 9.5m, new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Zero Dawn", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6452), 9.3m },
                    { 11, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6453), "An action role-playing game developed and published by Square Enix.", 8.8m, new DateTime(2016, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Fantasy XV", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6454), 8.6m },
                    { 12, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6455), "A role-playing video game developed by Atlus.", 9.6m, new DateTime(2016, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persona 5", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6457), 9.5m },
                    { 13, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6457), "An action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.", 9.3m, new DateTime(2016, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Souls III", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6460), 9.1m },
                    { 14, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6461), "An action role-playing game developed by FromSoftware and published by Sony Computer Entertainment.", 9.4m, new DateTime(2015, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloodborne", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6462), 9.3m },
                    { 15, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6463), "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.", 9.1m, new DateTime(2016, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6464), 8.9m },
                    { 16, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6465), "An action-adventure game developed by FromSoftware and published by Activision.", 9.5m, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekiro: Shadows Die Twice", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6466), 9.2m },
                    { 17, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6467), "An action role-playing game developed by Team Ninja and published by Koei Tecmo.", 8.9m, new DateTime(2017, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nioh", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6469), 8.7m },
                    { 18, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6476), "An action role-playing game developed and published by Capcom.", 9.2m, new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monster Hunter: World", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6478), 9.0m },
                    { 19, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6479), "A survival horror game developed and published by Capcom.", 9.5m, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 2", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6480), 9.3m },
                    { 20, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6481), "An action-adventure game developed by Sucker Punch Productions and published by Sony Interactive Entertainment.", 9.5m, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost of Tsushima", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6482), 9.4m },
                    { 21, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6483), "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.", 9.0m, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6486), 8.8m },
                    { 22, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6486), "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.", 9.8m, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6488), 9.6m },
                    { 23, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6488), "An action-adventure game developed by Remedy Entertainment and published by 505 Games.", 9.1m, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6490), 8.9m },
                    { 24, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6491), "A roguelike action dungeon crawler video game developed and published by Supergiant Games.", 9.7m, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hades", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6492), 9.5m },
                    { 25, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6493), "A first-person shooter game developed by id Software and published by Bethesda Softworks.", 9.3m, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doom Eternal", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6494), 9.1m },
                    { 26, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6495), "An action role-playing game developed and published by miHoYo.", 8.8m, new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genshin Impact", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6496), 8.6m },
                    { 27, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6497), "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.", 8.9m, new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Stranding", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6499), 8.7m },
                    { 28, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6500), "An action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment.", 9.3m, new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6502), 9.2m },
                    { 29, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6502), "A virtual reality first-person shooter developed and published by Valve.", 9.6m, new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life: Alyx", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6504), 9.4m },
                    { 30, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6505), "An action role-playing game developed and published by TaleWorlds Entertainment. Bannerlord is a prequel to Mount & Blade: Warband, a stand-alone expansion pack for the 2008 game Mount & Blade.", 8.7m, new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mount and Blade II: Bannerlord", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6506), 8.5m }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "City", "Country", "CreatedTime", "Email", "Fax", "MediaLogo", "MediaName", "Password", "TaxIdNumber", "UserName", "phone" },
                values: new object[,]
                {
                    { 1, "San Francisco", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8592), "contact@ign.com", "123-456-7891", null, "IGN", "password123", "123456789", "ign_user", "123-456-7890" },
                    { 2, "New York", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8601), "contact@gamespot.com", "987-654-3211", null, "GameSpot", "password456", "987654321", "gamespot_user", "987-654-3210" },
                    { 3, "Atlanta", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8604), "contact@polygon.com", "456-789-1231", null, "Polygon", "password789", "456789123", "polygon_user", "456-789-1230" },
                    { 4, "Los Angeles", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8606), "contact@kotaku.com", "654-321-9871", null, "Kotaku", "password321", "654321987", "kotaku_user", "654-321-9870" },
                    { 5, "Brighton", "UK", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8609), "contact@eurogamer.net", "321-987-6541", null, "Eurogamer", "password654", "321987654", "eurogamer_user", "321-987-6540" },
                    { 6, "Minneapolis", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8611), "contact@gameinformer.com", "789-123-4561", null, "Game Informer", "password987", "789123456", "gameinformer_user", "789-123-4560" },
                    { 7, "Bath", "UK", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8613), "contact@pcgamer.com", "111-222-3331", null, "PC Gamer", "password111", "111222333", "pcgamer_user", "111-222-3330" },
                    { 8, "London", "UK", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8615), "contact@rockpapershotgun.com", "222-333-4441", null, "Rock Paper Shotgun", "password222", "222333444", "rps_user", "222-333-4440" },
                    { 9, "San Francisco", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8617), "contact@destructoid.com", "333-444-5551", null, "Destructoid", "password333", "333444555", "destructoid_user", "333-444-5550" },
                    { 10, "San Francisco", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8619), "contact@giantbomb.com", "444-555-6661", null, "Giant Bomb", "password444", "444555666", "giantbomb_user", "444-555-6660" },
                    { 11, "New York", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8621), "contact@theverge.com", "555-666-7771", null, "The Verge", "password555", "555666777", "theverge_user", "555-666-7770" },
                    { 12, "San Francisco", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8623), "contact@venturebeat.com", "666-777-8881", null, "VentureBeat", "password666", "666777888", "venturebeat_user", "666-777-8880" },
                    { 13, "San Francisco", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8625), "contact@techcrunch.com", "777-888-9991", null, "TechCrunch", "password777", "777888999", "techcrunch_user", "777-888-9990" },
                    { 14, "New York", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8627), "contact@wired.com", "888-999-0001", null, "Wired", "password888", "888999000", "wired_user", "888-999-0000" },
                    { 15, "New York", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8629), "contact@mashable.com", "999-000-1111", null, "Mashable", "password999", "999000111", "mashable_user", "999-000-1110" },
                    { 16, "San Francisco", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8631), "contact@cnet.com", "000-111-2221", null, "CNET", "password000", "000111222", "cnet_user", "000-111-2220" },
                    { 17, "New York", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8633), "contact@arstechnica.com", "aaa-111-bbb1", null, "Ars Technica", "passwordaaa", "aaa111bbb", "arstechnica_user", "aaa-111-bbb0" },
                    { 18, "New York", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8635), "contact@gizmodo.com", "bbb-222-ccc1", null, "Gizmodo", "passwordbbb", "bbb222ccc", "gizmodo_user", "bbb-222-ccc0" },
                    { 19, "Portland", "USA", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8637), "contact@digitaltrends.com", "ccc-333-ddd1", null, "Digital Trends", "passwordccc", "ccc333ddd", "digitaltrends_user", "ccc-333-ddd0" },
                    { 20, "Bath", "UK", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8639), "contact@techradar.com", "ddd-444-eee1", null, "TechRadar", "passwordddd", "ddd444eee", "techradar_user", "ddd-444-eee0" },
                    { 21, "İstanbul", "Türkiye", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8641), "contact@level.com.tr", "+90-212-123-4568", null, "Level", "level_password", "TR1234567890", "level_user", "+90-212-123-4567" },
                    { 22, "Ankara", "Türkiye", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8643), "contact@oyungezer.com.tr", "+90-312-987-6544", null, "Oyungezer", "oyungezer_password", "TR0987654321", "oyungezer_user", "+90-312-987-6543" },
                    { 23, "İstanbul", "Türkiye", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8645), "contact@merlininkazani.com", "+90-212-567-8902", null, "Merlin'in Kazanı", "merlin_password", "TR5678901234", "merlin_user", "+90-212-567-8901" },
                    { 24, "İzmir", "Türkiye", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8647), "contact@turunculevye.com", "+90-232-345-6790", null, "Turuncu Levye", "turunculevye_password", "TR3456789012", "turunculevye_user", "+90-232-345-6789" },
                    { 25, "Bursa", "Türkiye", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8649), "contact@multiplayer.com.tr", "+90-224-456-7891", null, "Multiplayer", "multiplayer_password", "TR4567890123", "multiplayer_user", "+90-224-456-7890" },
                    { 26, "Antalya", "Türkiye", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8651), "contact@tamindir.com", "+90-242-678-9013", null, "Tamindir", "tamindir_password", "TR6789012345", "tamindir_user", "+90-242-678-9012" },
                    { 27, "İstanbul", "Türkiye", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8653), "contact@donanimhaber.com", "+90-212-789-0124", null, "Donanım Haber", "donanimhaber_password", "TR7890123456", "donanimhaber_user", "+90-212-789-0123" },
                    { 28, "İstanbul", "Türkiye", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8654), "contact@technopat.net", "+90-212-890-1235", null, "Technopat", "technopat_password", "TR8901234567", "technopat_user", "+90-212-890-1234" },
                    { 29, "İstanbul", "Türkiye", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8657), "contact@shiftdelete.net", "+90-212-901-2346", null, "ShiftDelete.Net", "shiftdelete_password", "TR9012345678", "shiftdelete_user", "+90-212-901-2345" },
                    { 30, "İstanbul", "Türkiye", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8659), "contact@webtekno.com", "+90-212-012-3457", null, "Webtekno", "webtekno_password", "TR0123456789", "webtekno_user", "+90-212-012-3456" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "CreatedTime", "Logo", "PlatformName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(35), null, "PlayStation 5" },
                    { 2, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(38), null, "Xbox Series X" },
                    { 3, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(39), null, "Nintendo Switch" },
                    { 4, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(42), null, "PlayStation 4" },
                    { 5, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(43), null, "Xbox One" },
                    { 6, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(44), null, "PC" },
                    { 7, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(45), null, "PlayStation Vita" },
                    { 8, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(46), null, "Nintendo 3DS" },
                    { 9, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(47), null, "Stadia" },
                    { 10, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(48), null, "Oculus Quest 2" },
                    { 11, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(49), null, "Nintendo Wii U" },
                    { 12, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(50), null, "PlayStation 3" },
                    { 13, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(50), null, "Xbox 360" },
                    { 14, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(51), null, "Nintendo Wii" },
                    { 15, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(52), null, "PlayStation Portable (PSP)" },
                    { 16, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(53), null, "Game Boy Advance" },
                    { 17, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(54), null, "Sega Dreamcast" },
                    { 18, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(55), null, "Super Nintendo Entertainment System (SNES)" },
                    { 19, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(56), null, "Sega Genesis" },
                    { 20, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(57), null, "Atari 2600" },
                    { 21, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(57), null, "PlayStation 2" },
                    { 22, new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(58), null, "PlayStation 1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedTime", "Email", "NickName", "Password", "Phone", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(206), "admin1@example.com", "AdminOne", "admin1_password", "+90-555-000-0001", "Admin", "admin1" },
                    { 2, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(215), "admin2@example.com", "AdminTwo", "admin2_password", "+90-555-000-0002", "Admin", "admin2" },
                    { 3, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(217), "editor1@example.com", "EditorOne", "editor1_password", "+90-555-000-0003", "Editor", "editor1" },
                    { 4, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(218), "editor2@example.com", "EditorTwo", "editor2_password", "+90-555-000-0004", "Editor", "editor2" },
                    { 5, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(221), "editor3@example.com", "EditorThree", "editor3_password", "+90-555-000-0005", "Editor", "editor3" },
                    { 6, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(222), "editor4@example.com", "EditorFour", "editor4_password", "+90-555-000-0006", "Editor", "editor4" },
                    { 7, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(224), "editor5@example.com", "EditorFive", "editor5_password", "+90-555-000-0007", "Editor", "editor5" },
                    { 8, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(225), "user1@example.com", "UserOne", "user1_password", "+90-555-000-0008", "User", "user1" },
                    { 9, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(227), "user2@example.com", "UserTwo", "user2_password", "+90-555-000-0009", "User", "user2" },
                    { 10, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(228), "user3@example.com", "UserThree", "user3_password", "+90-555-000-0010", "User", "user3" },
                    { 11, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(230), "user4@example.com", "UserFour", "user4_password", "+90-555-000-0011", "User", "user4" },
                    { 12, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(231), "user5@example.com", "UserFive", "user5_password", "+90-555-000-0012", "User", "user5" },
                    { 13, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(233), "user6@example.com", "UserSix", "user6_password", "+90-555-000-0013", "User", "user6" },
                    { 14, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(234), "user7@example.com", "UserSeven", "user7_password", "+90-555-000-0014", "User", "user7" },
                    { 15, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(235), "user8@example.com", "UserEight", "user8_password", "+90-555-000-0015", "User", "user8" },
                    { 16, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(237), "user9@example.com", "UserNine", "user9_password", "+90-555-000-0016", "User", "user9" },
                    { 17, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(238), "user10@example.com", "UserTen", "user10_password", "+90-555-000-0017", "User", "user10" },
                    { 18, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(240), "user11@example.com", "UserEleven", "user11_password", "+90-555-000-0018", "User", "user11" },
                    { 19, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(241), "user12@example.com", "UserTwelve", "user12_password", "+90-555-000-0019", "User", "user12" },
                    { 20, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(242), "user13@example.com", "UserThirteen", "user13_password", "+90-555-000-0020", "User", "user13" },
                    { 21, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(245), "user14@example.com", "UserFourteen", "user14_password", "+90-555-000-0021", "User", "user14" },
                    { 22, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(246), "user15@example.com", "UserFifteen", "user15_password", "+90-555-000-0022", "User", "user15" },
                    { 23, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(257), "user16@example.com", "UserSixteen", "user16_password", "+90-555-000-0023", "User", "user16" },
                    { 24, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(259), "user17@example.com", "UserSeventeen", "user17_password", "+90-555-000-0024", "User", "user17" },
                    { 25, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(260), "user18@example.com", "UserEighteen", "user18_password", "+90-555-000-0025", "User", "user18" },
                    { 26, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(261), "user19@example.com", "UserNineteen", "user19_password", "+90-555-000-0026", "User", "user19" },
                    { 27, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(263), "user20@example.com", "UserTwenty", "user20_password", "+90-555-000-0027", "User", "user20" },
                    { 28, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(264), "user21@example.com", "UserTwentyOne", "user21_password", "+90-555-000-0028", "User", "user21" },
                    { 29, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(266), "user22@example.com", "UserTwentyTwo", "user22_password", "+90-555-000-0029", "User", "user22" },
                    { 30, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(267), "user23@example.com", "UserTwentyThree", "user23_password", "+90-555-000-0030", "User", "user23" },
                    { 31, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(268), "user24@example.com", "UserTwentyFour", "user24_password", "+90-555-000-0031", "User", "user24" },
                    { 32, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(270), "user25@example.com", "UserTwentyFive", "user25_password", "+90-555-000-0032", "User", "user25" },
                    { 33, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(271), "user26@example.com", "UserTwentySix", "user26_password", "+90-555-000-0033", "User", "user26" },
                    { 34, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(273), "user27@example.com", "UserTwentySeven", "user27_password", "+90-555-000-0034", "User", "user27" },
                    { 35, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(279), "user28@example.com", "UserTwentyEight", "user28_password", "+90-555-000-0035", "User", "user28" },
                    { 36, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(281), "user29@example.com", "UserTwentyNine", "user29_password", "+90-555-000-0036", "User", "user29" },
                    { 37, new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(282), "user30@example.com", "UserThirty", "user30_password", "+90-555-000-0037", "User", "user30" }
                });

            migrationBuilder.InsertData(
                table: "AdminActions",
                columns: new[] { "Id", "ActionType", "AdminId", "CreatedTime", "Description" },
                values: new object[,]
                {
                    { 1, "User Management", 1, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(4585), "Created new user roles." },
                    { 2, "Content Management", 2, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(4598), "Published new articles." },
                    { 3, "System Maintenance", 3, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(4600), "Performed database backup." },
                    { 4, "User Management", 1, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(4601), "Updated user permissions." },
                    { 5, "Content Management", 2, new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(4602), "Reviewed and edited user-submitted content." }
                });

            migrationBuilder.InsertData(
                table: "MediaReviews",
                columns: new[] { "Id", "Comment", "CreatedTime", "ItemId", "MediaId", "Rating" },
                values: new object[,]
                {
                    { 1, "Great game with stunning graphics and engaging gameplay.", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9408), 1, 21, 85 },
                    { 2, "Interesting storyline but could improve on the controls.", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9414), 2, 22, 70 },
                    { 3, "Fantastic multiplayer experience, highly recommended!", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9415), 3, 23, 95 },
                    { 4, "Average game, had high expectations but it fell short.", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9417), 4, 24, 60 },
                    { 5, "Good game overall, but needs some bug fixes.", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9418), 5, 25, 75 },
                    { 6, "Very enjoyable game with lots of content.", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9419), 6, 26, 80 },
                    { 7, "One of the best games I've played this year!", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9420), 7, 27, 90 },
                    { 8, "Decent game but lacks depth in some areas.", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9422), 8, 28, 65 },
                    { 9, "Solid game with good mechanics and storyline.", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9423), 9, 29, 78 },
                    { 10, "Great game, would recommend to all RPG fans.", new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9424), 10, 30, 88 }
                });

            migrationBuilder.InsertData(
                table: "UserReviews",
                columns: new[] { "Id", "Comment", "CreatedTime", "ItemId", "UserId", "UserRating" },
                values: new object[,]
                {
                    { 1, "Great game, enjoyed playing it!", new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(583), 1, 8, 8 },
                    { 2, "Interesting game but needs better controls.", new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(587), 2, 9, 7 },
                    { 3, "Absolutely loved this game, couldn't stop playing.", new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(589), 3, 10, 9 },
                    { 4, "Decent game, but could use more content.", new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(590), 4, 11, 6 },
                    { 5, "Good game overall, enjoyed the storyline.", new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(591), 5, 12, 7 },
                    { 6, "Very immersive experience, would recommend.", new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(593), 6, 13, 8 },
                    { 7, "One of my favorite games, highly recommended.", new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(594), 7, 14, 9 },
                    { 8, "Liked the game, but could be more challenging.", new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(595), 8, 15, 6 },
                    { 9, "Solid gameplay mechanics, enjoyable experience.", new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(596), 9, 16, 7 },
                    { 10, "Great RPG game, loved the customization options.", new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(597), 10, 17, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminActions_AdminId",
                table: "AdminActions",
                column: "AdminId");

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
