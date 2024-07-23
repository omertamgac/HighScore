using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HightScore.Entities.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Discriminator = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CategoryDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
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
                    Iframe = table.Column<string>(type: "longtext", nullable: true),
                    photo = table.Column<string>(type: "longtext", nullable: true),
                    UserAverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MediaAverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    Fax = table.Column<string>(type: "longtext", nullable: true)
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
                    Logo = table.Column<byte>(type: "tinyint unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    itemId = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
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
                name: "UserReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserRating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "varchar(800)", maxLength: 800, nullable: false)
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
                    Comment = table.Column<string>(type: "longtext", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-0000-0000-0000-000000000000", 0, "d4a7ff6f-2000-44ea-8b82-9c191c2f87c1", "MetaUser", "admin@hotmail.com", true, false, null, "ADMIN@HOTMAIL.COM", "ADMIN", "asd123.", null, false, "JZTQQKJ3CQCXYN4AWFLARBLI4NXY2FYW", false, "admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Games that emphasize physical challenges, including hand-eye coordination and reaction-time.", "Action" },
                    { 2, "Narrative-focused games that often involve exploration and puzzle-solving.", "Adventure" },
                    { 3, "Games that allow players to assume the roles of characters in a fictional setting.", "Role-Playing" },
                    { 4, "Games that require careful planning and decision-making.", "Strategy" },
                    { 5, "Games that replicate real-world activities or systems.", "Simulation" },
                    { 6, "Games based on real or fictional sports.", "Sports" },
                    { 7, "Games centered around competitive or non-competitive racing.", "Racing" },
                    { 8, "Games focused on hand-to-hand combat between characters.", "Fighting" },
                    { 9, "Games designed to scare or unsettle players.", "Horror" },
                    { 10, "Games that challenge problem-solving skills.", "Puzzle" },
                    { 11, "Games characterized by jumping between platforms and overcoming obstacles.", "Platformer" },
                    { 12, "Games focused on shooting enemies or targets.", "Shooter" },
                    { 13, "Games where the player must survive in a hostile environment.", "Survival" },
                    { 14, "Games that allow players to roam freely through a virtual world.", "Open World" },
                    { 15, "Massively multiplayer online role-playing games.", "MMORPG" },
                    { 16, "Games designed for cooperative multiplayer gameplay.", "Co-op" },
                    { 17, "Games where players take turns to make decisions or moves.", "Turn-Based" },
                    { 18, "Strategy games where players make decisions in real-time.", "Real-Time Strategy" },
                    { 19, "Games that emphasize careful planning and tactical decision-making.", "Tactical" },
                    { 20, "Games designed to teach players about a specific subject or skill.", "Educational" },
                    { 21, "Games focused on creating or performing music.", "Music" },
                    { 22, "Games that are easy to learn and play.", "Casual" },
                    { 23, "Games that prioritize artistic expression or creativity.", "Artistic" },
                    { 24, "Games set in or inspired by historical events or periods.", "Historical" },
                    { 25, "Games set in fantastical or mythical worlds.", "Fantasy" },
                    { 26, "Games set in futuristic or science fiction settings.", "Sci-Fi" },
                    { 27, "Games that feature a dystopian future with advanced technology.", "Cyberpunk" },
                    { 28, "Games that require players to avoid detection and complete objectives stealthily.", "Stealth" },
                    { 29, "Games characterized by narrative-driven storytelling and minimal gameplay.", "Visual Novel" },
                    { 30, "Games that focus on romantic relationships and dating.", "Dating Sim" },
                    { 31, "Games designed to be experienced in virtual reality environments.", "Virtual Reality" },
                    { 32, "Games that blend virtual elements with real-world environments.", "Augmented Reality" },
                    { 33, "Games focused on exploring dungeons and defeating enemies.", "Dungeon Crawler" },
                    { 34, "Games where players defend against waves of enemies using strategic placements.", "Tower Defense" },
                    { 35, "Games where progress is made even when the player is not actively playing.", "Idle" },
                    { 36, "Games where players gradually increase resources or abilities over time.", "Incremental" },
                    { 37, "Games where players compete to be the last one standing in a shrinking play area.", "Battle Royale" },
                    { 38, "Games designed for multiplayer parties or gatherings.", "Party" },
                    { 39, "Games that involve managing resources, businesses, or scenarios.", "Management" },
                    { 40, "Games focused on humor and comedic situations.", "Comedy" },
                    { 41, "Games that involve solving puzzles or uncovering secrets.", "Mystery" },
                    { 42, "Games focused on exploring vast environments or uncovering mysteries.", "Exploration" },
                    { 43, "Games that explore the capabilities and implications of artificial intelligence.", "Artificial Intelligence" },
                    { 44, "Games that emphasize environmental themes or challenges.", "Environmental" },
                    { 45, "Games that involve creating or crafting items or structures.", "Crafting" },
                    { 46, "Games designed for social interaction and communication.", "Social" },
                    { 47, "Games that blend historical events with fictional elements.", "Historical Fiction" },
                    { 48, "Games that explore psychological themes or challenges.", "Psychological" },
                    { 49, "Games focused on criminal activities or investigations.", "Crime" },
                    { 50, "Games set in outer space or involving space exploration.", "Space" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Iframe", "MediaAverageRating", "RelaseDate", "Title", "UpdatedAt", "UserAverageRating", "photo" },
                values: new object[,]
                {
                    { 1, "An action-adventure game developed and published by Nintendo.", null, 9.8m, new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7799), 9.5m, "1.jpg" },
                    { 2, "A platform game developed and published by Nintendo for the Nintendo Switch.", null, 9.7m, new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super Mario Odyssey", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7821), 9.3m, "2.webp" },
                    { 3, "An action-adventure game developed and published by Rockstar Games.", null, 9.8m, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7824), 9.6m, "3.jpg" },
                    { 4, "An action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.", null, 9.6m, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7827), 9.4m, "4.jpg" },
                    { 5, "An action role-playing game developed and published by CD Projekt.", null, 9.9m, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7829), 9.7m, "5.jpg" },
                    { 6, "An action role-playing game developed and published by CD Projekt.", null, 8.9m, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7836), 8.5m, "6.jpg" },
                    { 7, "A sandbox video game developed by Mojang.", null, 9.5m, new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7838), 9.2m, "7.jpg" },
                    { 8, "An online video game developed by Epic Games.", null, 9.0m, new DateTime(2017, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7841), 8.8m, "8.png" },
                    { 9, "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.", null, 9.7m, new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7844), 9.4m, "9.jpg" },
                    { 10, "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.", null, 9.5m, new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Zero Dawn", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7847), 9.3m, "10.jpg" },
                    { 11, "An action role-playing game developed and published by Square Enix.", null, 8.8m, new DateTime(2016, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Fantasy XV", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7850), 8.6m, "11.jpg" },
                    { 12, "A role-playing video game developed by Atlus.", null, 9.6m, new DateTime(2016, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persona 5", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7853), 9.5m, "12.png" },
                    { 13, "An action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.", null, 9.3m, new DateTime(2016, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Souls III", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7857), 9.1m, "13.jpg" },
                    { 14, "An action role-playing game developed by FromSoftware and published by Sony Computer Entertainment.", null, 9.4m, new DateTime(2015, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloodborne", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7859), 9.3m, "14.jpg" },
                    { 15, "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.", null, 9.1m, new DateTime(2016, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7862), 8.9m, "15.jpg" },
                    { 16, "An action-adventure game developed by FromSoftware and published by Activision.", null, 9.5m, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekiro: Shadows Die Twice", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7882), 9.2m, "16.jpg" },
                    { 17, "An action role-playing game developed by Team Ninja and published by Koei Tecmo.", null, 8.9m, new DateTime(2017, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nioh", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7885), 8.7m, "17.jpg" },
                    { 18, "An action role-playing game developed and published by Capcom.", null, 9.2m, new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monster Hunter: World", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7887), 9.0m, "18.png" },
                    { 19, "A survival horror game developed and published by Capcom.", null, 9.5m, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 2", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7890), 9.3m, "19.jpg" },
                    { 20, "An action-adventure game developed by Sucker Punch Productions and published by Sony Interactive Entertainment.", null, 9.5m, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost of Tsushima", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7893), 9.4m, "20.jpg" },
                    { 21, "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.", null, 9.0m, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7897), 8.8m, "21.jpg" },
                    { 22, "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.", null, 9.8m, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7899), 9.6m, "22.jpg" },
                    { 23, "An action-adventure game developed by Remedy Entertainment and published by 505 Games.", null, 9.1m, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7902), 8.9m, "23.jpg" },
                    { 24, "A roguelike action dungeon crawler video game developed and published by Supergiant Games.", null, 9.7m, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hades", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7905), 9.5m, "24.png" },
                    { 25, "A first-person shooter game developed by id Software and published by Bethesda Softworks.", null, 9.3m, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doom Eternal", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7907), 9.1m, "25.jpg" },
                    { 26, "An action role-playing game developed and published by miHoYo.", null, 8.8m, new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genshin Impact", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7910), 8.6m, "26.jpg" },
                    { 27, "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.", null, 8.9m, new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Stranding", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7913), 8.7m, "27.jpg" },
                    { 28, "An action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment.", null, 9.3m, new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7916), 9.2m, "28.jpg" },
                    { 29, "A virtual reality first-person shooter developed and published by Valve.", null, 9.6m, new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life: Alyx", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7922), 9.4m, "29.webp" },
                    { 30, "An action role-playing game developed and published by TaleWorlds Entertainment. Bannerlord is a prequel to Mount & Blade: Warband, a stand-alone expansion pack for the 2008 game Mount & Blade.", null, 8.7m, new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mount and Blade II: Bannerlord", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7924), 8.5m, "30.jpg" },
                    { 31, "Explore the depths of Arkham Asylum as Batman, unraveling a sinister plot orchestrated by his arch-nemesis, the Joker.", null, 9.2m, new DateTime(2009, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Asylum", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7929), 9.0m, "31.jpg" },
                    { 32, "Gotham City is transformed into a sprawling prison, and Batman must navigate its dangerous streets to uncover a new threat.", null, 9.3m, new DateTime(2011, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham City", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7933), 9.1m, "32.jpg" },
                    { 33, "The Dark Knight faces the ultimate threat to Gotham City as the Scarecrow unites Batman's foes to destroy him once and for all.", null, 9.0m, new DateTime(2015, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Knight", new DateTime(2024, 7, 22, 21, 23, 6, 561, DateTimeKind.Local).AddTicks(7935), 8.9m, "33.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "City", "Country", "Email", "Fax", "MediaLogo", "MediaName", "Password", "TaxIdNumber", "UserName", "phone" },
                values: new object[,]
                {
                    { 1, "San Francisco", "USA", "contact@ign.com", "123-456-7891", null, "IGN", "password123", "123456789", "ign_user", "123-456-7890" },
                    { 2, "New York", "USA", "contact@gamespot.com", "987-654-3211", null, "GameSpot", "password456", "987654321", "gamespot_user", "987-654-3210" },
                    { 3, "Atlanta", "USA", "contact@polygon.com", "456-789-1231", null, "Polygon", "password789", "456789123", "polygon_user", "456-789-1230" },
                    { 4, "Los Angeles", "USA", "contact@kotaku.com", "654-321-9871", null, "Kotaku", "password321", "654321987", "kotaku_user", "654-321-9870" },
                    { 5, "Brighton", "UK", "contact@eurogamer.net", "321-987-6541", null, "Eurogamer", "password654", "321987654", "eurogamer_user", "321-987-6540" },
                    { 6, "Minneapolis", "USA", "contact@gameinformer.com", "789-123-4561", null, "Game Informer", "password987", "789123456", "gameinformer_user", "789-123-4560" },
                    { 7, "Bath", "UK", "contact@pcgamer.com", "111-222-3331", null, "PC Gamer", "password111", "111222333", "pcgamer_user", "111-222-3330" },
                    { 8, "London", "UK", "contact@rockpapershotgun.com", "222-333-4441", null, "Rock Paper Shotgun", "password222", "222333444", "rps_user", "222-333-4440" },
                    { 9, "San Francisco", "USA", "contact@destructoid.com", "333-444-5551", null, "Destructoid", "password333", "333444555", "destructoid_user", "333-444-5550" },
                    { 10, "San Francisco", "USA", "contact@giantbomb.com", "444-555-6661", null, "Giant Bomb", "password444", "444555666", "giantbomb_user", "444-555-6660" },
                    { 11, "New York", "USA", "contact@theverge.com", "555-666-7771", null, "The Verge", "password555", "555666777", "theverge_user", "555-666-7770" },
                    { 12, "San Francisco", "USA", "contact@venturebeat.com", "666-777-8881", null, "VentureBeat", "password666", "666777888", "venturebeat_user", "666-777-8880" },
                    { 13, "San Francisco", "USA", "contact@techcrunch.com", "777-888-9991", null, "TechCrunch", "password777", "777888999", "techcrunch_user", "777-888-9990" },
                    { 14, "New York", "USA", "contact@wired.com", "888-999-0001", null, "Wired", "password888", "888999000", "wired_user", "888-999-0000" },
                    { 15, "New York", "USA", "contact@mashable.com", "999-000-1111", null, "Mashable", "password999", "999000111", "mashable_user", "999-000-1110" },
                    { 16, "San Francisco", "USA", "contact@cnet.com", "000-111-2221", null, "CNET", "password000", "000111222", "cnet_user", "000-111-2220" },
                    { 17, "New York", "USA", "contact@arstechnica.com", "aaa-111-bbb1", null, "Ars Technica", "passwordaaa", "aaa111bbb", "arstechnica_user", "aaa-111-bbb0" },
                    { 18, "New York", "USA", "contact@gizmodo.com", "bbb-222-ccc1", null, "Gizmodo", "passwordbbb", "bbb222ccc", "gizmodo_user", "bbb-222-ccc0" },
                    { 19, "Portland", "USA", "contact@digitaltrends.com", "ccc-333-ddd1", null, "Digital Trends", "passwordccc", "ccc333ddd", "digitaltrends_user", "ccc-333-ddd0" },
                    { 20, "Bath", "UK", "contact@techradar.com", "ddd-444-eee1", null, "TechRadar", "passwordddd", "ddd444eee", "techradar_user", "ddd-444-eee0" },
                    { 21, "İstanbul", "Türkiye", "contact@level.com.tr", "+90-212-123-4568", null, "Level", "level_password", "TR1234567890", "level_user", "+90-212-123-4567" },
                    { 22, "Ankara", "Türkiye", "contact@oyungezer.com.tr", "+90-312-987-6544", null, "Oyungezer", "oyungezer_password", "TR0987654321", "oyungezer_user", "+90-312-987-6543" },
                    { 23, "İstanbul", "Türkiye", "contact@merlininkazani.com", "+90-212-567-8902", null, "Merlin'in Kazanı", "merlin_password", "TR5678901234", "merlin_user", "+90-212-567-8901" },
                    { 24, "İzmir", "Türkiye", "contact@turunculevye.com", "+90-232-345-6790", null, "Turuncu Levye", "turunculevye_password", "TR3456789012", "turunculevye_user", "+90-232-345-6789" },
                    { 25, "Bursa", "Türkiye", "contact@multiplayer.com.tr", "+90-224-456-7891", null, "Multiplayer", "multiplayer_password", "TR4567890123", "multiplayer_user", "+90-224-456-7890" },
                    { 26, "Antalya", "Türkiye", "contact@tamindir.com", "+90-242-678-9013", null, "Tamindir", "tamindir_password", "TR6789012345", "tamindir_user", "+90-242-678-9012" },
                    { 27, "İstanbul", "Türkiye", "contact@donanimhaber.com", "+90-212-789-0124", null, "Donanım Haber", "donanimhaber_password", "TR7890123456", "donanimhaber_user", "+90-212-789-0123" },
                    { 28, "İstanbul", "Türkiye", "contact@technopat.net", "+90-212-890-1235", null, "Technopat", "technopat_password", "TR8901234567", "technopat_user", "+90-212-890-1234" },
                    { 29, "İstanbul", "Türkiye", "contact@shiftdelete.net", "+90-212-901-2346", null, "ShiftDelete.Net", "shiftdelete_password", "TR9012345678", "shiftdelete_user", "+90-212-901-2345" },
                    { 30, "İstanbul", "Türkiye", "contact@webtekno.com", "+90-212-012-3457", null, "Webtekno", "webtekno_password", "TR0123456789", "webtekno_user", "+90-212-012-3456" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Logo", "PlatformName" },
                values: new object[,]
                {
                    { 1, null, "PlayStation 5" },
                    { 2, null, "Xbox Series X" },
                    { 3, null, "Nintendo Switch" },
                    { 4, null, "PlayStation 4" },
                    { 5, null, "Xbox One" },
                    { 6, null, "PC" },
                    { 7, null, "PlayStation Vita" },
                    { 8, null, "Nintendo 3DS" },
                    { 9, null, "Stadia" },
                    { 10, null, "Oculus Quest 2" },
                    { 11, null, "Nintendo Wii U" },
                    { 12, null, "PlayStation 3" },
                    { 13, null, "Xbox 360" },
                    { 14, null, "Nintendo Wii" },
                    { 15, null, "PlayStation Portable (PSP)" },
                    { 16, null, "Game Boy Advance" },
                    { 17, null, "Sega Dreamcast" },
                    { 18, null, "Super Nintendo Entertainment System (SNES)" },
                    { 19, null, "Sega Genesis" },
                    { 20, null, "Atari 2600" },
                    { 21, null, "PlayStation 2" },
                    { 22, null, "PlayStation 1" }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "categoryId", "itemId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 1, 6, 3 },
                    { 2, 6, 4 },
                    { 3, 6, 5 },
                    { 14, 6, 6 }
                });

            migrationBuilder.InsertData(
                table: "ItemPlatforms",
                columns: new[] { "itemId", "platformId", "Id" },
                values: new object[,]
                {
                    { 1, 3, 1 },
                    { 1, 11, 2 },
                    { 6, 1, 3 },
                    { 6, 2, 4 },
                    { 6, 4, 5 },
                    { 6, 5, 6 },
                    { 6, 6, 7 }
                });

            migrationBuilder.InsertData(
                table: "MediaReviews",
                columns: new[] { "Id", "Comment", "ItemId", "MediaId", "Rating" },
                values: new object[,]
                {
                    { 1, "Great game with stunning graphics and engaging gameplay.", 1, 21, 85 },
                    { 2, "Interesting storyline but could improve on the controls.", 2, 22, 70 },
                    { 3, "Fantastic multiplayer experience, highly recommended!", 3, 23, 95 },
                    { 4, "Average game, had high expectations but it fell short.", 4, 24, 60 },
                    { 5, "Good game overall, but needs some bug fixes.", 5, 25, 75 },
                    { 6, "Very enjoyable game with lots of content.", 6, 26, 80 },
                    { 7, "One of the best games I've played this year!", 7, 27, 90 },
                    { 8, "Decent game but lacks depth in some areas.", 8, 28, 65 },
                    { 9, "Solid game with good mechanics and storyline.", 9, 29, 78 },
                    { 10, "Great game, would recommend to all RPG fans.", 10, 30, 88 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "IX_UserReviews_ItemId",
                table: "UserReviews",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "ItemPlatforms");

            migrationBuilder.DropTable(
                name: "MediaReviews");

            migrationBuilder.DropTable(
                name: "UserReviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
