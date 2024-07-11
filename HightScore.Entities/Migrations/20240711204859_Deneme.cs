using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HightScore.Entities.Migrations
{
    /// <inheritdoc />
    public partial class Deneme : Migration
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
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Roles = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
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
                name: "ItemCategories",
                columns: table => new
                {
                    itemId = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => new { x.itemId, x.categoryId });
                    table.ForeignKey(
                        name: "FK_ItemCategories_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCategories_Items_itemId",
                        column: x => x.itemId,
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
                name: "ItemPlatforms",
                columns: table => new
                {
                    itemId = table.Column<int>(type: "int", nullable: false),
                    platformId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPlatforms", x => new { x.itemId, x.platformId });
                    table.ForeignKey(
                        name: "FK_ItemPlatforms_Items_itemId",
                        column: x => x.itemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPlatforms_Platforms_platformId",
                        column: x => x.platformId,
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
                    Comment = table.Column<string>(type: "varchar(800)", maxLength: 800, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
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
                    { 1, "Games that emphasize physical challenges, including hand-eye coordination and reaction-time.", "Action", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6010) },
                    { 2, "Narrative-focused games that often involve exploration and puzzle-solving.", "Adventure", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6013) },
                    { 3, "Games that allow players to assume the roles of characters in a fictional setting.", "Role-Playing", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6015) },
                    { 4, "Games that require careful planning and decision-making.", "Strategy", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6017) },
                    { 5, "Games that replicate real-world activities or systems.", "Simulation", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6019) },
                    { 6, "Games based on real or fictional sports.", "Sports", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6020) },
                    { 7, "Games centered around competitive or non-competitive racing.", "Racing", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6023) },
                    { 8, "Games focused on hand-to-hand combat between characters.", "Fighting", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6024) },
                    { 9, "Games designed to scare or unsettle players.", "Horror", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6026) },
                    { 10, "Games that challenge problem-solving skills.", "Puzzle", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6028) },
                    { 11, "Games characterized by jumping between platforms and overcoming obstacles.", "Platformer", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6030) },
                    { 12, "Games focused on shooting enemies or targets.", "Shooter", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6032) },
                    { 13, "Games where the player must survive in a hostile environment.", "Survival", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6034) },
                    { 14, "Games that allow players to roam freely through a virtual world.", "Open World", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6035) },
                    { 15, "Massively multiplayer online role-playing games.", "MMORPG", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6037) },
                    { 16, "Games designed for cooperative multiplayer gameplay.", "Co-op", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6039) },
                    { 17, "Games where players take turns to make decisions or moves.", "Turn-Based", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6040) },
                    { 18, "Strategy games where players make decisions in real-time.", "Real-Time Strategy", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6042) },
                    { 19, "Games that emphasize careful planning and tactical decision-making.", "Tactical", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6044) },
                    { 20, "Games designed to teach players about a specific subject or skill.", "Educational", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6045) },
                    { 21, "Games focused on creating or performing music.", "Music", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6047) },
                    { 22, "Games that are easy to learn and play.", "Casual", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6049) },
                    { 23, "Games that prioritize artistic expression or creativity.", "Artistic", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6050) },
                    { 24, "Games set in or inspired by historical events or periods.", "Historical", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6052) },
                    { 25, "Games set in fantastical or mythical worlds.", "Fantasy", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6054) },
                    { 26, "Games set in futuristic or science fiction settings.", "Sci-Fi", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6055) },
                    { 27, "Games that feature a dystopian future with advanced technology.", "Cyberpunk", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6057) },
                    { 28, "Games that require players to avoid detection and complete objectives stealthily.", "Stealth", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6058) },
                    { 29, "Games characterized by narrative-driven storytelling and minimal gameplay.", "Visual Novel", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6060) },
                    { 30, "Games that focus on romantic relationships and dating.", "Dating Sim", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6062) },
                    { 31, "Games designed to be experienced in virtual reality environments.", "Virtual Reality", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6063) },
                    { 32, "Games that blend virtual elements with real-world environments.", "Augmented Reality", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6065) },
                    { 33, "Games focused on exploring dungeons and defeating enemies.", "Dungeon Crawler", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6068) },
                    { 34, "Games where players defend against waves of enemies using strategic placements.", "Tower Defense", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6069) },
                    { 35, "Games where progress is made even when the player is not actively playing.", "Idle", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6071) },
                    { 36, "Games where players gradually increase resources or abilities over time.", "Incremental", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6072) },
                    { 37, "Games where players compete to be the last one standing in a shrinking play area.", "Battle Royale", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6074) },
                    { 38, "Games designed for multiplayer parties or gatherings.", "Party", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6076) },
                    { 39, "Games that involve managing resources, businesses, or scenarios.", "Management", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6077) },
                    { 40, "Games focused on humor and comedic situations.", "Comedy", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6079) },
                    { 41, "Games that involve solving puzzles or uncovering secrets.", "Mystery", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6081) },
                    { 42, "Games focused on exploring vast environments or uncovering mysteries.", "Exploration", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6082) },
                    { 43, "Games that explore the capabilities and implications of artificial intelligence.", "Artificial Intelligence", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6084) },
                    { 44, "Games that emphasize environmental themes or challenges.", "Environmental", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6085) },
                    { 45, "Games that involve creating or crafting items or structures.", "Crafting", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6087) },
                    { 46, "Games designed for social interaction and communication.", "Social", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6089) },
                    { 47, "Games that blend historical events with fictional elements.", "Historical Fiction", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6090) },
                    { 48, "Games that explore psychological themes or challenges.", "Psychological", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6092) },
                    { 49, "Games focused on criminal activities or investigations.", "Crime", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6094) },
                    { 50, "Games set in outer space or involving space exploration.", "Space", new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(6095) }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedTime", "Description", "MediaAverageRating", "RelaseDate", "Title", "UpdatedAt", "UserAverageRating" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5816), "An action-adventure game developed and published by Nintendo.", 9.8m, new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5826), 9.5m },
                    { 2, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5831), "A platform game developed and published by Nintendo for the Nintendo Switch.", 9.7m, new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super Mario Odyssey", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5834), 9.3m },
                    { 3, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5835), "An action-adventure game developed and published by Rockstar Games.", 9.8m, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5837), 9.6m },
                    { 4, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5839), "An action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.", 9.6m, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5841), 9.4m },
                    { 5, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5842), "An action role-playing game developed and published by CD Projekt.", 9.9m, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5844), 9.7m },
                    { 6, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5845), "An action role-playing game developed and published by CD Projekt.", 8.9m, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5848), 8.5m },
                    { 7, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5849), "A sandbox video game developed by Mojang.", 9.5m, new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5851), 9.2m },
                    { 8, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5853), "An online video game developed by Epic Games.", 9.0m, new DateTime(2017, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5854), 8.8m },
                    { 9, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5856), "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.", 9.7m, new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5858), 9.4m },
                    { 10, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5859), "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.", 9.5m, new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Zero Dawn", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5862), 9.3m },
                    { 11, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5863), "An action role-playing game developed and published by Square Enix.", 8.8m, new DateTime(2016, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Fantasy XV", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5865), 8.6m },
                    { 12, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5868), "A role-playing video game developed by Atlus.", 9.6m, new DateTime(2016, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persona 5", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5870), 9.5m },
                    { 13, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5872), "An action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.", 9.3m, new DateTime(2016, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Souls III", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5874), 9.1m },
                    { 14, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5875), "An action role-playing game developed by FromSoftware and published by Sony Computer Entertainment.", 9.4m, new DateTime(2015, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloodborne", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5877), 9.3m },
                    { 15, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5879), "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.", 9.1m, new DateTime(2016, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5880), 8.9m },
                    { 16, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5882), "An action-adventure game developed by FromSoftware and published by Activision.", 9.5m, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekiro: Shadows Die Twice", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5884), 9.2m },
                    { 17, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5886), "An action role-playing game developed by Team Ninja and published by Koei Tecmo.", 8.9m, new DateTime(2017, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nioh", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5888), 8.7m },
                    { 18, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5889), "An action role-playing game developed and published by Capcom.", 9.2m, new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monster Hunter: World", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5892), 9.0m },
                    { 19, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5894), "A survival horror game developed and published by Capcom.", 9.5m, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 2", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5895), 9.3m },
                    { 20, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5897), "An action-adventure game developed by Sucker Punch Productions and published by Sony Interactive Entertainment.", 9.5m, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost of Tsushima", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5899), 9.4m },
                    { 21, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5900), "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.", 9.0m, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5902), 8.8m },
                    { 22, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5903), "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.", 9.8m, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5905), 9.6m },
                    { 23, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5907), "An action-adventure game developed by Remedy Entertainment and published by 505 Games.", 9.1m, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5908), 8.9m },
                    { 24, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5910), "A roguelike action dungeon crawler video game developed and published by Supergiant Games.", 9.7m, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hades", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5911), 9.5m },
                    { 25, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5913), "A first-person shooter game developed by id Software and published by Bethesda Softworks.", 9.3m, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doom Eternal", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5914), 9.1m },
                    { 26, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5916), "An action role-playing game developed and published by miHoYo.", 8.8m, new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genshin Impact", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5919), 8.6m },
                    { 27, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5920), "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.", 8.9m, new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Stranding", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5922), 8.7m },
                    { 28, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5924), "An action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment.", 9.3m, new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5925), 9.2m },
                    { 29, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5927), "A virtual reality first-person shooter developed and published by Valve.", 9.6m, new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life: Alyx", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5928), 9.4m },
                    { 30, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5930), "An action role-playing game developed and published by TaleWorlds Entertainment. Bannerlord is a prequel to Mount & Blade: Warband, a stand-alone expansion pack for the 2008 game Mount & Blade.", 8.7m, new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mount and Blade II: Bannerlord", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5931), 8.5m },
                    { 31, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5933), "Explore the depths of Arkham Asylum as Batman, unraveling a sinister plot orchestrated by his arch-nemesis, the Joker.", 9.2m, new DateTime(2009, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Asylum", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5935), 9.0m },
                    { 32, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5936), "Gotham City is transformed into a sprawling prison, and Batman must navigate its dangerous streets to uncover a new threat.", 9.3m, new DateTime(2011, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham City", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5938), 9.1m },
                    { 33, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5939), "The Dark Knight faces the ultimate threat to Gotham City as the Scarecrow unites Batman's foes to destroy him once and for all.", 9.0m, new DateTime(2015, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Knight", new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(5941), 8.9m }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "City", "Country", "CreatedTime", "Email", "Fax", "MediaLogo", "MediaName", "Password", "TaxIdNumber", "UserName", "phone" },
                values: new object[,]
                {
                    { 1, "San Francisco", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(250), "contact@ign.com", "123-456-7891", null, "IGN", "password123", "123456789", "ign_user", "123-456-7890" },
                    { 2, "New York", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(257), "contact@gamespot.com", "987-654-3211", null, "GameSpot", "password456", "987654321", "gamespot_user", "987-654-3210" },
                    { 3, "Atlanta", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(261), "contact@polygon.com", "456-789-1231", null, "Polygon", "password789", "456789123", "polygon_user", "456-789-1230" },
                    { 4, "Los Angeles", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(264), "contact@kotaku.com", "654-321-9871", null, "Kotaku", "password321", "654321987", "kotaku_user", "654-321-9870" },
                    { 5, "Brighton", "UK", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(267), "contact@eurogamer.net", "321-987-6541", null, "Eurogamer", "password654", "321987654", "eurogamer_user", "321-987-6540" },
                    { 6, "Minneapolis", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(270), "contact@gameinformer.com", "789-123-4561", null, "Game Informer", "password987", "789123456", "gameinformer_user", "789-123-4560" },
                    { 7, "Bath", "UK", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(274), "contact@pcgamer.com", "111-222-3331", null, "PC Gamer", "password111", "111222333", "pcgamer_user", "111-222-3330" },
                    { 8, "London", "UK", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(277), "contact@rockpapershotgun.com", "222-333-4441", null, "Rock Paper Shotgun", "password222", "222333444", "rps_user", "222-333-4440" },
                    { 9, "San Francisco", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(281), "contact@destructoid.com", "333-444-5551", null, "Destructoid", "password333", "333444555", "destructoid_user", "333-444-5550" },
                    { 10, "San Francisco", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(285), "contact@giantbomb.com", "444-555-6661", null, "Giant Bomb", "password444", "444555666", "giantbomb_user", "444-555-6660" },
                    { 11, "New York", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(289), "contact@theverge.com", "555-666-7771", null, "The Verge", "password555", "555666777", "theverge_user", "555-666-7770" },
                    { 12, "San Francisco", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(292), "contact@venturebeat.com", "666-777-8881", null, "VentureBeat", "password666", "666777888", "venturebeat_user", "666-777-8880" },
                    { 13, "San Francisco", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(295), "contact@techcrunch.com", "777-888-9991", null, "TechCrunch", "password777", "777888999", "techcrunch_user", "777-888-9990" },
                    { 14, "New York", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(298), "contact@wired.com", "888-999-0001", null, "Wired", "password888", "888999000", "wired_user", "888-999-0000" },
                    { 15, "New York", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(301), "contact@mashable.com", "999-000-1111", null, "Mashable", "password999", "999000111", "mashable_user", "999-000-1110" },
                    { 16, "San Francisco", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(304), "contact@cnet.com", "000-111-2221", null, "CNET", "password000", "000111222", "cnet_user", "000-111-2220" },
                    { 17, "New York", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(307), "contact@arstechnica.com", "aaa-111-bbb1", null, "Ars Technica", "passwordaaa", "aaa111bbb", "arstechnica_user", "aaa-111-bbb0" },
                    { 18, "New York", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(310), "contact@gizmodo.com", "bbb-222-ccc1", null, "Gizmodo", "passwordbbb", "bbb222ccc", "gizmodo_user", "bbb-222-ccc0" },
                    { 19, "Portland", "USA", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(313), "contact@digitaltrends.com", "ccc-333-ddd1", null, "Digital Trends", "passwordccc", "ccc333ddd", "digitaltrends_user", "ccc-333-ddd0" },
                    { 20, "Bath", "UK", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(316), "contact@techradar.com", "ddd-444-eee1", null, "TechRadar", "passwordddd", "ddd444eee", "techradar_user", "ddd-444-eee0" },
                    { 21, "İstanbul", "Türkiye", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(319), "contact@level.com.tr", "+90-212-123-4568", null, "Level", "level_password", "TR1234567890", "level_user", "+90-212-123-4567" },
                    { 22, "Ankara", "Türkiye", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(322), "contact@oyungezer.com.tr", "+90-312-987-6544", null, "Oyungezer", "oyungezer_password", "TR0987654321", "oyungezer_user", "+90-312-987-6543" },
                    { 23, "İstanbul", "Türkiye", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(325), "contact@merlininkazani.com", "+90-212-567-8902", null, "Merlin'in Kazanı", "merlin_password", "TR5678901234", "merlin_user", "+90-212-567-8901" },
                    { 24, "İzmir", "Türkiye", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(328), "contact@turunculevye.com", "+90-232-345-6790", null, "Turuncu Levye", "turunculevye_password", "TR3456789012", "turunculevye_user", "+90-232-345-6789" },
                    { 25, "Bursa", "Türkiye", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(331), "contact@multiplayer.com.tr", "+90-224-456-7891", null, "Multiplayer", "multiplayer_password", "TR4567890123", "multiplayer_user", "+90-224-456-7890" },
                    { 26, "Antalya", "Türkiye", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(335), "contact@tamindir.com", "+90-242-678-9013", null, "Tamindir", "tamindir_password", "TR6789012345", "tamindir_user", "+90-242-678-9012" },
                    { 27, "İstanbul", "Türkiye", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(338), "contact@donanimhaber.com", "+90-212-789-0124", null, "Donanım Haber", "donanimhaber_password", "TR7890123456", "donanimhaber_user", "+90-212-789-0123" },
                    { 28, "İstanbul", "Türkiye", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(341), "contact@technopat.net", "+90-212-890-1235", null, "Technopat", "technopat_password", "TR8901234567", "technopat_user", "+90-212-890-1234" },
                    { 29, "İstanbul", "Türkiye", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(344), "contact@shiftdelete.net", "+90-212-901-2346", null, "ShiftDelete.Net", "shiftdelete_password", "TR9012345678", "shiftdelete_user", "+90-212-901-2345" },
                    { 30, "İstanbul", "Türkiye", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(347), "contact@webtekno.com", "+90-212-012-3457", null, "Webtekno", "webtekno_password", "TR0123456789", "webtekno_user", "+90-212-012-3456" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "CreatedTime", "Logo", "PlatformName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5682), null, "PlayStation 5" },
                    { 2, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5685), null, "Xbox Series X" },
                    { 3, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5687), null, "Nintendo Switch" },
                    { 4, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5689), null, "PlayStation 4" },
                    { 5, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5690), null, "Xbox One" },
                    { 6, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5692), null, "PC" },
                    { 7, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5693), null, "PlayStation Vita" },
                    { 8, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5695), null, "Nintendo 3DS" },
                    { 9, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5696), null, "Stadia" },
                    { 10, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5698), null, "Oculus Quest 2" },
                    { 11, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5699), null, "Nintendo Wii U" },
                    { 12, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5701), null, "PlayStation 3" },
                    { 13, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5702), null, "Xbox 360" },
                    { 14, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5704), null, "Nintendo Wii" },
                    { 15, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5705), null, "PlayStation Portable (PSP)" },
                    { 16, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5707), null, "Game Boy Advance" },
                    { 17, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5708), null, "Sega Dreamcast" },
                    { 18, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5710), null, "Super Nintendo Entertainment System (SNES)" },
                    { 19, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5711), null, "Sega Genesis" },
                    { 20, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5713), null, "Atari 2600" },
                    { 21, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5714), null, "PlayStation 2" },
                    { 22, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(5716), null, "PlayStation 1" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedTime", "Roles" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(8090), "Admin" },
                    { 2, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(8092), "Editor" },
                    { 3, new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(8094), "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedTime", "Email", "NickName", "Password", "Phone", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1661), "user1@example.com", "UserOne", "hashed_password", "1234567890", "user1" },
                    { 2, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1665), "user2@example.com", "UserTwo", "hashed_password", "1234567891", "user2" },
                    { 3, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1668), "user3@example.com", "UserThree", "hashed_password", "1234567892", "user3" },
                    { 4, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1670), "user4@example.com", "UserFour", "hashed_password", "1234567893", "user4" },
                    { 5, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1673), "user5@example.com", "UserFive", "hashed_password", "1234567894", "user5" },
                    { 6, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1675), "user6@example.com", "UserSix", "hashed_password", "1234567895", "user6" },
                    { 7, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1677), "user7@example.com", "UserSeven", "hashed_password", "1234567896", "user7" },
                    { 8, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1679), "user8@example.com", "UserEight", "hashed_password", "1234567897", "user8" },
                    { 9, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1682), "user9@example.com", "UserNine", "hashed_password", "1234567898", "user9" },
                    { 10, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1684), "user10@example.com", "UserTen", "hashed_password", "1234567899", "user10" },
                    { 11, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1686), "user11@example.com", "UserEleven", "hashed_password", "2234567890", "user11" },
                    { 12, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1697), "user12@example.com", "UserTwelve", "hashed_password", "2234567891", "user12" },
                    { 13, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1699), "user13@example.com", "UserThirteen", "hashed_password", "2234567892", "user13" },
                    { 14, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1702), "user14@example.com", "UserFourteen", "hashed_password", "2234567893", "user14" },
                    { 15, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1704), "user15@example.com", "UserFifteen", "hashed_password", "2234567894", "user15" },
                    { 16, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1707), "user16@example.com", "UserSixteen", "hashed_password", "2234567895", "user16" },
                    { 17, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1709), "user17@example.com", "UserSeventeen", "hashed_password", "2234567896", "user17" },
                    { 18, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1711), "user18@example.com", "UserEighteen", "hashed_password", "2234567897", "user18" },
                    { 19, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1713), "user19@example.com", "UserNineteen", "hashed_password", "2234567898", "user19" },
                    { 20, new DateTime(2024, 7, 11, 23, 48, 59, 189, DateTimeKind.Local).AddTicks(1715), "user20@example.com", "UserTwenty", "hashed_password", "2234567899", "user20" }
                });

            migrationBuilder.InsertData(
                table: "AdminActions",
                columns: new[] { "Id", "ActionType", "AdminId", "CreatedTime", "Description" },
                values: new object[,]
                {
                    { 1, "User Management", 1, new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(2905), "Created new user roles." },
                    { 2, "Content Management", 2, new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(2909), "Published new articles." },
                    { 3, "System Maintenance", 3, new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(2912), "Performed database backup." },
                    { 4, "User Management", 1, new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(2914), "Updated user permissions." },
                    { 5, "Content Management", 2, new DateTime(2024, 7, 11, 23, 48, 59, 184, DateTimeKind.Local).AddTicks(2916), "Reviewed and edited user-submitted content." }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "categoryId", "itemId", "CreatedTime", "Id" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 11, 23, 48, 59, 185, DateTimeKind.Local).AddTicks(5381), 1 },
                    { 2, 1, new DateTime(2024, 7, 11, 23, 48, 59, 185, DateTimeKind.Local).AddTicks(5385), 2 },
                    { 1, 6, new DateTime(2024, 7, 11, 23, 48, 59, 185, DateTimeKind.Local).AddTicks(5387), 3 },
                    { 2, 6, new DateTime(2024, 7, 11, 23, 48, 59, 185, DateTimeKind.Local).AddTicks(5389), 4 },
                    { 3, 6, new DateTime(2024, 7, 11, 23, 48, 59, 185, DateTimeKind.Local).AddTicks(5391), 5 },
                    { 14, 6, new DateTime(2024, 7, 11, 23, 48, 59, 185, DateTimeKind.Local).AddTicks(5392), 6 }
                });

            migrationBuilder.InsertData(
                table: "ItemPlatforms",
                columns: new[] { "itemId", "platformId", "CreatedTime", "Id" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(3239), 1 },
                    { 1, 11, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(3243), 2 },
                    { 6, 1, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(3245), 3 },
                    { 6, 2, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(3247), 4 },
                    { 6, 4, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(3248), 5 },
                    { 6, 5, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(3250), 6 },
                    { 6, 6, new DateTime(2024, 7, 11, 23, 48, 59, 186, DateTimeKind.Local).AddTicks(3252), 7 }
                });

            migrationBuilder.InsertData(
                table: "MediaReviews",
                columns: new[] { "Id", "Comment", "CreatedTime", "ItemId", "MediaId", "Rating" },
                values: new object[,]
                {
                    { 1, "Great game with stunning graphics and engaging gameplay.", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(3315), 1, 21, 85 },
                    { 2, "Interesting storyline but could improve on the controls.", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(3319), 2, 22, 70 },
                    { 3, "Fantastic multiplayer experience, highly recommended!", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(3321), 3, 23, 95 },
                    { 4, "Average game, had high expectations but it fell short.", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(3323), 4, 24, 60 },
                    { 5, "Good game overall, but needs some bug fixes.", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(3325), 5, 25, 75 },
                    { 6, "Very enjoyable game with lots of content.", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(3326), 6, 26, 80 },
                    { 7, "One of the best games I've played this year!", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(3328), 7, 27, 90 },
                    { 8, "Decent game but lacks depth in some areas.", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(3330), 8, 28, 65 },
                    { 9, "Solid game with good mechanics and storyline.", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(3332), 9, 29, 78 },
                    { 10, "Great game, would recommend to all RPG fans.", new DateTime(2024, 7, 11, 23, 48, 59, 187, DateTimeKind.Local).AddTicks(3334), 10, 30, 88 }
                });

            migrationBuilder.InsertData(
                table: "UserReviews",
                columns: new[] { "Id", "Comment", "CreatedTime", "ItemId", "UserId", "UserRating" },
                values: new object[,]
                {
                    { 1, "Great game, enjoyed playing it!", new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(379), 1, 1, 8 },
                    { 2, "Interesting game but needs better controls.", new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(384), 2, 9, 7 },
                    { 3, "Absolutely loved this game, couldn't stop playing.", new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(386), 3, 10, 9 },
                    { 4, "Decent game, but could use more content.", new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(388), 4, 11, 6 },
                    { 5, "Good game overall, enjoyed the storyline.", new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(390), 5, 12, 7 },
                    { 6, "Very immersive experience, would recommend.", new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(393), 6, 13, 8 },
                    { 7, "One of my favorite games, highly recommended.", new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(394), 7, 14, 9 },
                    { 8, "Liked the game, but could be more challenging.", new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(397), 8, 15, 6 },
                    { 9, "Solid gameplay mechanics, enjoyable experience.", new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(398), 9, 16, 7 },
                    { 10, "Great RPG game, loved the customization options.", new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(400), 10, 17, 8 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedTime", "Id" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(7954), 1 },
                    { 2, 1, new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(7958), 2 },
                    { 3, 1, new DateTime(2024, 7, 11, 23, 48, 59, 188, DateTimeKind.Local).AddTicks(7960), 3 }
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
                name: "IX_ItemCategories_categoryId",
                table: "ItemCategories",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPlatforms_platformId",
                table: "ItemPlatforms",
                column: "platformId");

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
                name: "IX_Roles_Roles",
                table: "Roles",
                column: "Roles",
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
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

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
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "ItemPlatforms");

            migrationBuilder.DropTable(
                name: "MediaReviews");

            migrationBuilder.DropTable(
                name: "UserReviews");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
