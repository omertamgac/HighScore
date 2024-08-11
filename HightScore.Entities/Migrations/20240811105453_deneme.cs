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
                    photo = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PlatformName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Logo = table.Column<string>(type: "longtext", nullable: true)
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
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserRating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "varchar(800)", maxLength: 800, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReviews", x => new { x.ItemId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserReviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserReviews_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0", 0, "640f980c-2a45-4ce2-9096-315337cfdfcc", "MetaUser", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEPRrkKjFWmKchHBXvlc6/hebdOEVcTM1WYbl/BofZUWgZ/DD2z13i6VkSx87SU/O3Q==", null, false, "70d8041d-bf51-4e88-9202-92944f678d15", false, "admin" },
                    { "1", 0, "a1b49bbd-19c1-450d-9db4-05ecdfbcf0bd", "MetaUser", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEKM+OGvvsnWtayEaZt79Ngiasckeu7PX+IwoiQ8aJd4Q3QyShRnunXpMOjHDQYN7qw==", null, false, "b8b0c323-4193-4920-8be3-d3d735fe6fc2", false, "user1" },
                    { "10", 0, "b9206ed4-e34c-42a6-81ea-2eb102fb25c8", "MetaUser", "user10@example.com", true, false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEJ31UMQAIweVLiwNLduSScmuwl759mGZHEwI7qejMCUqJXBoN9ojnUerNN/acjICtw==", null, false, "880b0541-87c2-42f5-b5b3-5f29a99d47d7", false, "user10" },
                    { "11", 0, "3b4b7c69-e414-4db5-8390-f334dfe44260", "MetaUser", "user11@example.com", true, false, null, "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAENTIo8Af4iRcPEdwaICP4iTw89G1NX+OtJSPRzzYeP8L0BQTTMRYfNJf2bnxF5raBQ==", null, false, "89473e64-c2f2-469a-b588-8026b9af0965", false, "user11" },
                    { "12", 0, "7de50582-1fd6-4989-a31f-23f2c114538c", "MetaUser", "user12@example.com", true, false, null, "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAECtjXBDyZ/ykTsjAR1iEUkpKyE8+eo5oHQAZwtLTC4QIZQORUbzalOrTjYlaekZuqw==", null, false, "674254d7-b659-4bdf-b400-a4a077014f0d", false, "user12" },
                    { "13", 0, "09f2e493-4f32-4cb2-945c-e3c4b4f9d8b3", "MetaUser", "user13@example.com", true, false, null, "USER13@EXAMPLE.COM", "USER13", "AQAAAAIAAYagAAAAEMmb1RictlesUQSwsb+/7V31r3H1BkeE03ZAAGvqUbwzKjXPTw6G8iRAe63l6hWXuw==", null, false, "da816902-1a64-4b46-b69b-30f6b6c84c8c", false, "user13" },
                    { "14", 0, "f5f028f5-40f9-40e0-9aa0-7830f43d49b5", "MetaUser", "user14@example.com", true, false, null, "USER14@EXAMPLE.COM", "USER14", "AQAAAAIAAYagAAAAEPkwJ8Ln5qD2emQILomlTBo1+nAR4TV/3lb6gLOrsgnqACZH4hv/7STeue6K3LclVw==", null, false, "1068990c-2147-4aa1-95e4-7cfe171f4f26", false, "user14" },
                    { "15", 0, "b1f89180-4e45-44d0-8d63-4948b8e22963", "MetaUser", "user15@example.com", true, false, null, "USER15@EXAMPLE.COM", "USER15", "AQAAAAIAAYagAAAAEHGVvEPDCrN8Lr2x4nhcMskv8TUJTLwi6TFTNhLm/ioIhZSSSepUfq6v972oiLetCg==", null, false, "9b428755-66fe-4651-9cb0-f981fea15090", false, "user15" },
                    { "16", 0, "b772b100-66b2-4b25-8ad1-73c564971923", "MetaUser", "user16@example.com", true, false, null, "USER16@EXAMPLE.COM", "USER16", "AQAAAAIAAYagAAAAEEpMZLM4nlU5YdOsBSQt4hX/Wb1USdcFsvsQoViYN1IMi/cx8xNrQEcBOTJIyG8VLg==", null, false, "826469af-3077-430c-bba9-a263c301897f", false, "user16" },
                    { "17", 0, "38be7e79-d097-494d-bc7c-18bbd23d3a21", "MetaUser", "user17@example.com", true, false, null, "USER17@EXAMPLE.COM", "USER17", "AQAAAAIAAYagAAAAEA/DxzZpTrz9qMrq5rlGJhks4nUNHobBPlEvtLn5/5vFKs+XP7W11tJ4kwPAVfXoQQ==", null, false, "6113ebe5-1979-40ba-9cb9-eefef4b4a632", false, "user17" },
                    { "18", 0, "2c1799fa-ee20-494f-b550-b3d8fcf92ae4", "MetaUser", "user18@example.com", true, false, null, "USER18@EXAMPLE.COM", "USER18", "AQAAAAIAAYagAAAAEEXOCjiJrh0yCpdVebTZImZ5Fn1f1nqutGHc6or3BQiCIRDeXeNNqw8VHRqur6jk4w==", null, false, "092db226-f4e7-4483-8635-1f1ade4fb63a", false, "user18" },
                    { "19", 0, "32611fb3-e2ca-4974-97a5-1c90767060cc", "MetaUser", "user19@example.com", true, false, null, "USER19@EXAMPLE.COM", "USER19", "AQAAAAIAAYagAAAAEKqphnbz/b2PhR1P9oFUREcP2QV4pEUEH4HtIoQPf3YMop4e0RttKgK3cVOAun5zKA==", null, false, "7492ab6d-9736-4be8-9868-d9563c560b25", false, "user19" },
                    { "2", 0, "8ec3c505-69ed-4683-b9b9-97955b1bda35", "MetaUser", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAED44FcPxKLXLsCfRb9mNDCX3t2KlNw527Ifb2AwbRMfJxPDbkwDfzUWJJqCrklUN+A==", null, false, "1409f4fc-d8a4-4ec3-83f2-e95157b3ad35", false, "user2" },
                    { "20", 0, "bf971d81-93a0-4d72-8e0c-17b6697de9e8", "MetaUser", "user20@example.com", true, false, null, "USER20@EXAMPLE.COM", "USER20", "AQAAAAIAAYagAAAAEKs1bmjiQLNqQegGak63beXu7+DzSOdXlCPeS404TUhqtUudE46o3RGfC0ZixAdiaw==", null, false, "e35710eb-2d49-4db7-a637-0051341a6916", false, "user20" },
                    { "3", 0, "6a8d463c-8f4c-49f8-ab99-133f3a6183df", "MetaUser", "user3@example.com", true, false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEI1aZ3oEJ8aYbr80ZBLO9zr/U70SxGlZDQKpxU4V/p3gksa20RaR/q/LnUBcv/Ebig==", null, false, "732640bc-44ea-4220-a88e-f4d7395720ef", false, "user3" },
                    { "4", 0, "af1c13f0-2248-4962-83a0-32878e014200", "MetaUser", "user4@example.com", true, false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAELM06pbGmb8wiwmM757ff+Z9GbbsZy5LwA3H8kJi/HkX0DXCl5DXAJo5s/iN4Hlsqg==", null, false, "a4c5508b-399e-4818-a84f-79584df55d6b", false, "user4" },
                    { "5", 0, "c3e59b94-a470-4fce-9873-835f0342e730", "MetaUser", "user5@example.com", true, false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEO1Wwxca2IZmDpkRAxlCdkMh15sAEpwxke2o0ZN5/+y4PIavOjlB7/wWhoaDDAVQBA==", null, false, "89ba6fc8-3c9b-44e6-acfa-e97bf0830da4", false, "user5" },
                    { "6", 0, "69697861-d15a-41c2-8b77-e00cd3932306", "MetaUser", "user6@example.com", true, false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEF+FBhG9lWEd5CI8hfN0CfMoochNihJPnJzLa1uF4nKvUEwbbyNUS7kX5x4BJfCF6A==", null, false, "5709bebe-deb3-4594-aea1-cf8696549e00", false, "user6" },
                    { "7", 0, "32f8c49b-08e7-405a-82e1-c3065884c064", "MetaUser", "user7@example.com", true, false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAENVAZeSXvekT9tR32M+QjpkyEELNvWjzUd+6g2kLiRZekNHQqPHSYRteucKoNuUXWQ==", null, false, "338d289d-f112-4f1d-8f20-55329ae40af6", false, "user7" },
                    { "8", 0, "1b16e633-3f9c-410d-be17-b0f7905c5d90", "MetaUser", "user8@example.com", true, false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEA6nmfxUrnDEvP0uvtj/he6+hf7sr83H7IP2d/s7sIRj5nT6tux5mrAICE9zDr054Q==", null, false, "202074cd-52a3-4107-a5b8-8b8f95aff18b", false, "user8" },
                    { "9", 0, "b4f87e2d-dafb-49cf-b643-132f85ac1923", "MetaUser", "user9@example.com", true, false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAENuCOMPcxpBJ7UmOL0rko3aHIQFlwhUO0VvhoFvOYpleYsrZHSFduHoBDsHWCnq0BQ==", null, false, "9af0b5fb-03e7-4560-86b8-616b9981aaee", false, "user9" }
                });

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
                columns: new[] { "Id", "Description", "Iframe", "RelaseDate", "Title", "UpdatedAt", "photo" },
                values: new object[,]
                {
                    { 1, "An action-adventure game developed and published by Nintendo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/zw47_q9wbBE\" title=\"The Legend of Zelda: Breath of the Wild - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9454), "1.jpg" },
                    { 2, "A platform game developed and published by Nintendo for the Nintendo Switch.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/5kcdRBHM7kM\" title=\"Super Mario Odyssey - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super Mario Odyssey", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9476), "2.webp" },
                    { 3, "An action-adventure game developed and published by Rockstar Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HVRzx17WHVk\" title=\"Red Dead Redemption 2 Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9479), "3.jpg" },
                    { 4, "An action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/Ty7WudwSKMA\" title=\"God of War: Ragnarok - Teaser Trailer | PS5 Showcase\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9481), "4.jpg" },
                    { 5, "An action role-playing game developed and published by CD Projekt.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/c0i88t0Kacs\" title=\"The Witcher 3: Wild Hunt - Killing Monsters Cinematic Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9482), "5.jpg" },
                    { 6, "An action role-playing game developed and published by CD Projekt.", "<iframe width=\"930\" height=\"388\" src=\"https://www.youtube.com/embed/P99qJGrPNLs\" title=\"Cyberpunk 2077 Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9486), "6.jpg" },
                    { 7, "A sandbox video game developed by Mojang.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/MmB9b5njVbA\" title=\"Official Minecraft Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9487), "7.jpg" },
                    { 8, "An online video game developed by Epic Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/hHTE5xg9E-g\" title=\"Fortnite Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9489), "8.png" },
                    { 9, "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/JSRtYpNRoN0\" title=\"The Elder Scrolls V: Skyrim - Official Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9491), "9.jpg" },
                    { 10, "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/u4-FCsiF5x4\" title=\"Horizon Zero Dawn - E3 2016 Trailer I PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Zero Dawn", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9493), "10.jpg" },
                    { 11, "An action role-playing game developed and published by Square Enix.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/CNM6o9um1dc\" title=\"FINAL FANTASY XV - Omen Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Fantasy XV", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9496), "11.jpg" },
                    { 12, "A role-playing video game developed by Atlus.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/QnDzJ9KzuV4\" title=\"Persona 5 | Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persona 5", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9500), "12.png" },
                    { 13, "An action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cWBwFhUv1-8\" title=\"Dark Souls III – Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Souls III", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9503), "13.jpg" },
                    { 14, "An action role-playing game developed by FromSoftware and published by Sony Computer Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/G203e1HhixY\" title=\"Bloodborne Debut Trailer | Face Your Fears | PlayStation 4 Action RPG\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2015, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloodborne", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9505), "14.jpg" },
                    { 15, "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/IBIwGKDwnWY\" title=\"Overwatch Theatrical Teaser | &quot;We Are Overwatch&quot;\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9506), "15.jpg" },
                    { 16, "An action-adventure game developed by FromSoftware and published by Activision.", "", new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekiro: Shadows Die Twice", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9509), "16.jpg" },
                    { 17, "An action role-playing game developed by Team Ninja and published by Koei Tecmo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cHTtNdkDduQ\" title=\"Nioh 2 Reveal Teaser Trailer - E3 2018\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nioh", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9511), "17.jpg" },
                    { 18, "An action role-playing game developed and published by Capcom.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monster Hunter: World", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9515), "18.png" },
                    { 19, "A survival horror game developed and published by Capcom.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 2", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9517), "19.jpg" },
                    { 20, "An action-adventure game developed by Sucker Punch Productions and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/RcWk08PBe7k\" title=\"Ghost of Tsushima - A Storm is Coming Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost of Tsushima", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9519), "20.jpg" },
                    { 21, "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.", "<iframe width=\"930\" height=\"390\" src=\"https://www.youtube.com/embed/rKjUAWlbTJk\" title=\"Assassin’s Creed Valhalla: Cinematic World Premiere Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9521), "21.jpg" },
                    { 22, "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/W2Wnvvj33Wo\" title=\"The Last of Us Part II - PlayStation Experience 2016: Reveal Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9531), "22.jpg" },
                    { 23, "An action-adventure game developed by Remedy Entertainment and published by 505 Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/w6bE11FrSFM\" title=\"Control - Ultimate Edition Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9533), "23.jpg" },
                    { 24, "A roguelike action dungeon crawler video game developed and published by Supergiant Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/91t0ha9x0AE\" title=\"Hades - Official Animated Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hades", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9535), "24.png" },
                    { 25, "A first-person shooter game developed by id Software and published by Bethesda Softworks.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/_oVwrpfo_QA\" title=\"DOOM Eternal – Official E3 Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doom Eternal", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9536), "25.jpg" },
                    { 26, "An action role-playing game developed and published by miHoYo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HLUY1nICQRY\" title=\"Genshin Impact - Official Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genshin Impact", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9538), "26.jpg" },
                    { 27, "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/H2Hy96sOnq8\" title=\"Death Stranding - Teaser Trailer - TGA 2016 - 4K\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Stranding", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9544), "27.jpg" },
                    { 28, "An action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/q4GdJVvdxss\" title=\"Marvel’s Spider-Man – Be Greater Extended Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9546), "28.jpg" },
                    { 29, "A virtual reality first-person shooter developed and published by Valve.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/O2W0N3uKXmo\" title=\"Half-Life: Alyx Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life: Alyx", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9547), "29.webp" },
                    { 30, "An action role-playing game developed and published by TaleWorlds Entertainment. Bannerlord is a prequel to Mount & Blade: Warband, a stand-alone expansion pack for the 2008 game Mount & Blade.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/yCk6Jk7DvrA\" title=\"Mount &amp; Blade II: Bannerlord Early Access Announcement\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mount and Blade II: Bannerlord", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9557), "30.jpg" },
                    { 31, "Explore the depths of Arkham Asylum as Batman, unraveling a sinister plot orchestrated by his arch-nemesis, the Joker.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/bVk9jW9EzD0\" title=\"Batman: Arkham Asylum Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2009, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Asylum", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9571), "31.jpg" },
                    { 32, "Gotham City is transformed into a sprawling prison, and Batman must navigate its dangerous streets to uncover a new threat.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/pcaFdTCiz4U\" title=\"Batman: Arkham City - Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham City", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9573), "32.jpg" },
                    { 33, "The Dark Knight faces the ultimate threat to Gotham City as the Scarecrow unites Batman's foes to destroy him once and for all.", "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/wsf78BS9VE0\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>\r\n", new DateTime(2015, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Knight", new DateTime(2024, 8, 11, 13, 54, 51, 144, DateTimeKind.Local).AddTicks(9575), "33.jpg" }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "0" },
                    { "2", "1" },
                    { "2", "10" },
                    { "2", "11" },
                    { "2", "12" },
                    { "2", "13" },
                    { "2", "14" },
                    { "2", "15" },
                    { "2", "16" },
                    { "2", "17" },
                    { "2", "18" },
                    { "2", "19" },
                    { "2", "2" },
                    { "2", "20" },
                    { "2", "3" },
                    { "2", "4" },
                    { "2", "5" },
                    { "2", "6" },
                    { "2", "7" },
                    { "2", "8" },
                    { "2", "9" }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "categoryId", "itemId", "Id" },
                values: new object[,]
                {
                    { 18, 1, 4 },
                    { 28, 1, 2 },
                    { 34, 1, 1 },
                    { 42, 1, 3 },
                    { 7, 2, 5 },
                    { 16, 2, 8 },
                    { 29, 2, 7 },
                    { 31, 2, 6 },
                    { 6, 3, 9 },
                    { 16, 3, 12 },
                    { 20, 3, 10 },
                    { 25, 3, 11 },
                    { 21, 4, 14 },
                    { 26, 4, 13 },
                    { 39, 4, 16 },
                    { 43, 4, 15 },
                    { 2, 5, 18 },
                    { 14, 5, 19 },
                    { 33, 5, 20 },
                    { 47, 5, 17 },
                    { 3, 6, 24 },
                    { 27, 6, 23 },
                    { 28, 6, 21 },
                    { 37, 6, 22 },
                    { 3, 7, 28 },
                    { 11, 7, 25 },
                    { 13, 7, 27 },
                    { 46, 7, 26 },
                    { 7, 8, 31 },
                    { 17, 8, 29 },
                    { 30, 8, 30 },
                    { 43, 8, 32 },
                    { 8, 9, 33 },
                    { 25, 9, 36 },
                    { 28, 9, 34 },
                    { 40, 9, 35 },
                    { 18, 10, 37 },
                    { 23, 10, 38 },
                    { 34, 10, 40 },
                    { 49, 10, 39 },
                    { 13, 11, 43 },
                    { 37, 11, 41 },
                    { 40, 11, 44 },
                    { 45, 11, 42 },
                    { 21, 12, 48 },
                    { 26, 12, 46 },
                    { 32, 12, 47 },
                    { 39, 12, 45 },
                    { 4, 13, 50 },
                    { 18, 13, 52 },
                    { 20, 13, 51 },
                    { 42, 13, 49 },
                    { 7, 14, 53 },
                    { 14, 14, 54 },
                    { 20, 14, 55 },
                    { 23, 14, 56 },
                    { 19, 15, 58 },
                    { 25, 15, 59 },
                    { 40, 15, 60 },
                    { 45, 15, 57 },
                    { 18, 16, 62 },
                    { 22, 16, 64 },
                    { 26, 16, 63 },
                    { 42, 16, 61 },
                    { 3, 17, 66 },
                    { 6, 17, 67 },
                    { 28, 17, 65 },
                    { 32, 17, 68 },
                    { 7, 18, 72 },
                    { 19, 18, 71 },
                    { 21, 18, 69 },
                    { 23, 18, 70 },
                    { 13, 19, 76 },
                    { 36, 19, 73 },
                    { 38, 19, 75 },
                    { 46, 19, 74 },
                    { 19, 20, 80 },
                    { 20, 20, 79 },
                    { 35, 20, 77 },
                    { 38, 20, 78 },
                    { 10, 21, 83 },
                    { 13, 21, 84 },
                    { 32, 21, 81 },
                    { 43, 21, 82 },
                    { 12, 22, 88 },
                    { 33, 22, 86 },
                    { 38, 22, 87 },
                    { 49, 22, 85 },
                    { 5, 23, 91 },
                    { 14, 23, 92 },
                    { 19, 23, 89 },
                    { 29, 23, 90 },
                    { 9, 24, 93 },
                    { 24, 24, 94 },
                    { 29, 24, 95 },
                    { 36, 24, 96 },
                    { 11, 25, 99 },
                    { 21, 25, 100 },
                    { 23, 25, 98 },
                    { 47, 25, 97 },
                    { 3, 26, 101 },
                    { 5, 26, 103 },
                    { 7, 26, 102 },
                    { 21, 26, 104 },
                    { 4, 27, 106 },
                    { 5, 27, 105 },
                    { 35, 27, 107 },
                    { 37, 27, 108 },
                    { 4, 28, 111 },
                    { 32, 28, 110 },
                    { 33, 28, 112 },
                    { 34, 28, 109 },
                    { 11, 29, 114 },
                    { 16, 29, 113 },
                    { 18, 29, 116 },
                    { 32, 29, 115 },
                    { 5, 30, 119 },
                    { 17, 30, 117 },
                    { 42, 30, 120 },
                    { 49, 30, 118 },
                    { 15, 31, 123 },
                    { 27, 31, 121 },
                    { 39, 31, 122 },
                    { 43, 31, 124 },
                    { 8, 32, 125 },
                    { 21, 32, 128 },
                    { 30, 32, 126 },
                    { 44, 32, 127 },
                    { 23, 33, 132 },
                    { 30, 33, 129 },
                    { 36, 33, 131 },
                    { 37, 33, 130 }
                });

            migrationBuilder.InsertData(
                table: "ItemPlatforms",
                columns: new[] { "itemId", "platformId", "Id" },
                values: new object[,]
                {
                    { 1, 6, 4 },
                    { 1, 10, 1 },
                    { 1, 11, 2 },
                    { 1, 18, 3 },
                    { 2, 1, 8 },
                    { 2, 2, 5 },
                    { 2, 4, 6 },
                    { 2, 11, 7 },
                    { 3, 1, 12 },
                    { 3, 9, 11 },
                    { 3, 11, 10 },
                    { 3, 20, 9 },
                    { 4, 10, 15 },
                    { 4, 17, 13 },
                    { 4, 18, 16 },
                    { 4, 20, 14 },
                    { 5, 4, 19 },
                    { 5, 8, 17 },
                    { 5, 15, 18 },
                    { 5, 20, 20 },
                    { 6, 15, 22 },
                    { 6, 17, 24 },
                    { 6, 20, 21 },
                    { 6, 22, 23 },
                    { 7, 5, 26 },
                    { 7, 11, 27 },
                    { 7, 20, 25 },
                    { 7, 22, 28 },
                    { 8, 5, 29 },
                    { 8, 11, 30 },
                    { 8, 14, 31 },
                    { 8, 20, 32 },
                    { 9, 1, 35 },
                    { 9, 2, 34 },
                    { 9, 19, 36 },
                    { 9, 20, 33 },
                    { 10, 1, 40 },
                    { 10, 11, 38 },
                    { 10, 13, 39 },
                    { 10, 16, 37 },
                    { 11, 3, 44 },
                    { 11, 5, 41 },
                    { 11, 15, 42 },
                    { 11, 20, 43 },
                    { 12, 2, 47 },
                    { 12, 10, 48 },
                    { 12, 17, 45 },
                    { 12, 21, 46 },
                    { 13, 3, 50 },
                    { 13, 7, 52 },
                    { 13, 15, 51 },
                    { 13, 21, 49 },
                    { 14, 1, 54 },
                    { 14, 10, 55 },
                    { 14, 12, 56 },
                    { 14, 15, 53 },
                    { 15, 9, 57 },
                    { 15, 12, 58 },
                    { 15, 16, 59 },
                    { 15, 17, 60 },
                    { 16, 10, 63 },
                    { 16, 12, 61 },
                    { 16, 13, 64 },
                    { 16, 17, 62 },
                    { 17, 3, 65 },
                    { 17, 4, 68 },
                    { 17, 9, 67 },
                    { 17, 18, 66 },
                    { 18, 1, 69 },
                    { 18, 3, 71 },
                    { 18, 16, 70 },
                    { 18, 21, 72 },
                    { 19, 13, 75 },
                    { 19, 15, 74 },
                    { 19, 16, 73 },
                    { 19, 19, 76 },
                    { 20, 1, 79 },
                    { 20, 2, 77 },
                    { 20, 18, 78 },
                    { 20, 22, 80 },
                    { 21, 14, 83 },
                    { 21, 15, 82 },
                    { 21, 19, 81 },
                    { 21, 22, 84 },
                    { 22, 4, 87 },
                    { 22, 6, 85 },
                    { 22, 9, 86 },
                    { 22, 17, 88 },
                    { 23, 3, 89 },
                    { 23, 9, 92 },
                    { 23, 15, 91 },
                    { 23, 16, 90 },
                    { 24, 1, 96 },
                    { 24, 9, 93 },
                    { 24, 10, 94 },
                    { 24, 13, 95 },
                    { 25, 1, 97 },
                    { 25, 4, 99 },
                    { 25, 13, 100 },
                    { 25, 19, 98 },
                    { 26, 5, 103 },
                    { 26, 8, 101 },
                    { 26, 12, 102 },
                    { 26, 20, 104 },
                    { 27, 4, 108 },
                    { 27, 5, 107 },
                    { 27, 16, 105 },
                    { 27, 21, 106 },
                    { 28, 2, 110 },
                    { 28, 11, 112 },
                    { 28, 15, 109 },
                    { 28, 21, 111 },
                    { 29, 1, 115 },
                    { 29, 5, 116 },
                    { 29, 13, 114 },
                    { 29, 14, 113 },
                    { 30, 11, 118 },
                    { 30, 16, 119 },
                    { 30, 17, 120 },
                    { 30, 20, 117 },
                    { 31, 5, 122 },
                    { 31, 6, 124 },
                    { 31, 11, 123 },
                    { 31, 22, 121 },
                    { 32, 14, 125 },
                    { 32, 15, 128 },
                    { 32, 16, 126 },
                    { 32, 17, 127 },
                    { 33, 4, 129 },
                    { 33, 8, 130 },
                    { 33, 15, 132 },
                    { 33, 18, 131 }
                });

            migrationBuilder.InsertData(
                table: "UserReviews",
                columns: new[] { "ItemId", "UserId", "Comment", "Id", "UserRating" },
                values: new object[,]
                {
                    { 1, "1", "Disappointing, had high expectations.", 10, 83 },
                    { 1, "10", "I didn't like this game much.", 6, 52 },
                    { 1, "12", "I didn't like this game much.", 12, 83 },
                    { 1, "13", "Not bad, could be better.", 3, 57 },
                    { 1, "16", "Disappointing, had high expectations.", 5, 75 },
                    { 1, "2", "Not bad, could be better.", 4, 35 },
                    { 1, "20", "Gameplay was not very engaging.", 7, 51 },
                    { 1, "5", "Fantastic experience, highly recommend!", 11, 33 },
                    { 1, "6", "Disappointing, had high expectations.", 8, 71 },
                    { 1, "8", "I didn't like this game much.", 9, 10 },
                    { 2, "1", "Quite boring and repetitive.", 11, 75 },
                    { 2, "11", "Quite boring and repetitive.", 10, 27 },
                    { 2, "12", "A must-play for all gamers!", 7, 53 },
                    { 2, "15", "Quite boring and repetitive.", 8, 99 },
                    { 2, "19", "Gameplay was not very engaging.", 9, 1 },
                    { 2, "2", "I didn't like this game much.", 15, 29 },
                    { 2, "20", "Gameplay was not very engaging.", 14, 28 },
                    { 2, "4", "A must-play for all gamers!", 12, 44 },
                    { 2, "6", "Gameplay was not very engaging.", 13, 83 },
                    { 2, "7", "Quite boring and repetitive.", 6, 64 },
                    { 3, "1", "Not bad, could be better.", 13, 41 },
                    { 3, "11", "Not bad, could be better.", 10, 3 },
                    { 3, "12", "Fantastic experience, highly recommend!", 17, 37 },
                    { 3, "14", "Quite boring and repetitive.", 15, 46 },
                    { 3, "18", "Great game, really enjoyed it!", 12, 90 },
                    { 3, "19", "Quite boring and repetitive.", 18, 99 },
                    { 3, "2", "Gameplay was not very engaging.", 16, 84 },
                    { 3, "3", "Fantastic experience, highly recommend!", 11, 29 },
                    { 3, "4", "Quite boring and repetitive.", 14, 86 },
                    { 3, "5", "A must-play for all gamers!", 9, 8 },
                    { 4, "1", "Average game, nothing special.", 15, 8 },
                    { 4, "13", "Not bad, could be better.", 21, 95 },
                    { 4, "14", "Quite boring and repetitive.", 12, 18 },
                    { 4, "17", "Not bad, could be better.", 17, 79 },
                    { 4, "2", "Quite boring and repetitive.", 13, 44 },
                    { 4, "3", "Disappointing, had high expectations.", 14, 98 },
                    { 4, "5", "Fantastic experience, highly recommend!", 20, 23 },
                    { 4, "6", "Quite boring and repetitive.", 19, 5 },
                    { 4, "8", "Average game, nothing special.", 16, 85 },
                    { 4, "9", "Disappointing, had high expectations.", 18, 20 },
                    { 5, "15", "Not bad, could be better.", 24, 59 },
                    { 5, "16", "A must-play for all gamers!", 23, 74 },
                    { 5, "17", "Average game, nothing special.", 20, 62 },
                    { 5, "18", "Quite boring and repetitive.", 17, 24 },
                    { 5, "19", "Disappointing, had high expectations.", 18, 7 },
                    { 5, "2", "Gameplay was not very engaging.", 19, 56 },
                    { 5, "20", "Loved the graphics and storyline.", 15, 85 },
                    { 5, "5", "Average game, nothing special.", 22, 16 },
                    { 5, "6", "Not bad, could be better.", 16, 14 },
                    { 5, "7", "A must-play for all gamers!", 21, 4 },
                    { 6, "1", "Gameplay was not very engaging.", 23, 21 },
                    { 6, "10", "Fantastic experience, highly recommend!", 25, 37 },
                    { 6, "11", "Quite boring and repetitive.", 22, 79 },
                    { 6, "13", "Great game, really enjoyed it!", 20, 68 },
                    { 6, "14", "I didn't like this game much.", 26, 16 },
                    { 6, "2", "Quite boring and repetitive.", 19, 42 },
                    { 6, "20", "Average game, nothing special.", 24, 61 },
                    { 6, "3", "Average game, nothing special.", 27, 29 },
                    { 6, "4", "A must-play for all gamers!", 21, 35 },
                    { 6, "9", "Not bad, could be better.", 18, 39 },
                    { 7, "11", "Not bad, could be better.", 21, 52 },
                    { 7, "12", "Loved the graphics and storyline.", 22, 75 },
                    { 7, "15", "Quite boring and repetitive.", 25, 56 },
                    { 7, "17", "A must-play for all gamers!", 26, 80 },
                    { 7, "18", "Quite boring and repetitive.", 23, 66 },
                    { 7, "19", "Loved the graphics and storyline.", 30, 18 },
                    { 7, "20", "Great game, really enjoyed it!", 28, 7 },
                    { 7, "5", "Gameplay was not very engaging.", 27, 53 },
                    { 7, "6", "A must-play for all gamers!", 29, 50 },
                    { 7, "7", "Great game, really enjoyed it!", 24, 13 },
                    { 8, "1", "A must-play for all gamers!", 27, 89 },
                    { 8, "12", "Loved the graphics and storyline.", 28, 80 },
                    { 8, "15", "Great game, really enjoyed it!", 29, 38 },
                    { 8, "18", "Not bad, could be better.", 26, 79 },
                    { 8, "2", "Not bad, could be better.", 24, 42 },
                    { 8, "20", "I didn't like this game much.", 33, 54 },
                    { 8, "3", "Great game, really enjoyed it!", 32, 47 },
                    { 8, "4", "Not bad, could be better.", 31, 15 },
                    { 8, "6", "A must-play for all gamers!", 25, 17 },
                    { 8, "7", "Great game, really enjoyed it!", 30, 89 },
                    { 9, "1", "Average game, nothing special.", 35, 46 },
                    { 9, "11", "Not bad, could be better.", 34, 4 },
                    { 9, "13", "Not bad, could be better.", 36, 15 },
                    { 9, "14", "Not bad, could be better.", 28, 18 },
                    { 9, "16", "I didn't like this game much.", 32, 72 },
                    { 9, "17", "Fantastic experience, highly recommend!", 29, 85 },
                    { 9, "19", "A must-play for all gamers!", 27, 6 },
                    { 9, "4", "I didn't like this game much.", 33, 1 },
                    { 9, "6", "Average game, nothing special.", 30, 85 },
                    { 9, "8", "I didn't like this game much.", 31, 18 },
                    { 10, "1", "Average game, nothing special.", 34, 35 },
                    { 10, "11", "Disappointing, had high expectations.", 31, 94 },
                    { 10, "12", "Great game, really enjoyed it!", 39, 61 },
                    { 10, "13", "Average game, nothing special.", 35, 5 },
                    { 10, "17", "Fantastic experience, highly recommend!", 32, 77 },
                    { 10, "18", "Loved the graphics and storyline.", 30, 5 },
                    { 10, "3", "Quite boring and repetitive.", 38, 44 },
                    { 10, "5", "Great game, really enjoyed it!", 37, 20 },
                    { 10, "7", "Not bad, could be better.", 36, 17 },
                    { 10, "9", "Quite boring and repetitive.", 33, 6 },
                    { 11, "1", "Fantastic experience, highly recommend!", 33, 66 },
                    { 11, "14", "Loved the graphics and storyline.", 34, 89 },
                    { 11, "15", "Loved the graphics and storyline.", 39, 55 },
                    { 11, "17", "Fantastic experience, highly recommend!", 35, 32 },
                    { 11, "18", "I didn't like this game much.", 42, 17 },
                    { 11, "2", "Disappointing, had high expectations.", 40, 9 },
                    { 11, "3", "A must-play for all gamers!", 41, 34 },
                    { 11, "5", "I didn't like this game much.", 38, 94 },
                    { 11, "8", "A must-play for all gamers!", 37, 93 },
                    { 11, "9", "I didn't like this game much.", 36, 61 },
                    { 12, "10", "I didn't like this game much.", 38, 78 },
                    { 12, "11", "Great game, really enjoyed it!", 44, 25 },
                    { 12, "13", "Average game, nothing special.", 39, 18 },
                    { 12, "15", "Disappointing, had high expectations.", 37, 35 },
                    { 12, "19", "Great game, really enjoyed it!", 36, 46 },
                    { 12, "20", "Fantastic experience, highly recommend!", 41, 86 },
                    { 12, "4", "I didn't like this game much.", 40, 15 },
                    { 12, "5", "Fantastic experience, highly recommend!", 42, 20 },
                    { 12, "6", "A must-play for all gamers!", 43, 64 },
                    { 12, "8", "I didn't like this game much.", 45, 27 },
                    { 13, "10", "Not bad, could be better.", 40, 74 },
                    { 13, "11", "I didn't like this game much.", 47, 47 },
                    { 13, "12", "Average game, nothing special.", 42, 25 },
                    { 13, "13", "Average game, nothing special.", 44, 80 },
                    { 13, "16", "Not bad, could be better.", 46, 79 },
                    { 13, "19", "Great game, really enjoyed it!", 45, 74 },
                    { 13, "2", "A must-play for all gamers!", 48, 28 },
                    { 13, "20", "Gameplay was not very engaging.", 41, 29 },
                    { 13, "4", "A must-play for all gamers!", 43, 84 },
                    { 13, "9", "Fantastic experience, highly recommend!", 39, 18 },
                    { 14, "1", "Not bad, could be better.", 47, 58 },
                    { 14, "10", "Quite boring and repetitive.", 46, 59 },
                    { 14, "15", "Average game, nothing special.", 49, 16 },
                    { 14, "19", "Disappointing, had high expectations.", 51, 100 },
                    { 14, "2", "A must-play for all gamers!", 48, 84 },
                    { 14, "20", "Average game, nothing special.", 50, 61 },
                    { 14, "3", "Great game, really enjoyed it!", 44, 73 },
                    { 14, "5", "Not bad, could be better.", 42, 27 },
                    { 14, "7", "A must-play for all gamers!", 45, 13 },
                    { 14, "9", "Not bad, could be better.", 43, 28 },
                    { 15, "1", "Average game, nothing special.", 53, 36 },
                    { 15, "11", "Average game, nothing special.", 51, 42 },
                    { 15, "12", "A must-play for all gamers!", 52, 10 },
                    { 15, "13", "A must-play for all gamers!", 46, 28 },
                    { 15, "14", "Fantastic experience, highly recommend!", 54, 10 },
                    { 15, "17", "Disappointing, had high expectations.", 48, 44 },
                    { 15, "18", "Gameplay was not very engaging.", 47, 46 },
                    { 15, "19", "Average game, nothing special.", 49, 35 },
                    { 15, "20", "I didn't like this game much.", 45, 63 },
                    { 15, "3", "Average game, nothing special.", 50, 43 },
                    { 16, "13", "I didn't like this game much.", 55, 38 },
                    { 16, "14", "Quite boring and repetitive.", 50, 99 },
                    { 16, "15", "Average game, nothing special.", 48, 87 },
                    { 16, "16", "Loved the graphics and storyline.", 56, 52 },
                    { 16, "17", "Loved the graphics and storyline.", 52, 15 },
                    { 16, "18", "Great game, really enjoyed it!", 54, 60 },
                    { 16, "5", "Disappointing, had high expectations.", 57, 17 },
                    { 16, "6", "Gameplay was not very engaging.", 51, 29 },
                    { 16, "8", "I didn't like this game much.", 49, 87 },
                    { 16, "9", "Quite boring and repetitive.", 53, 59 },
                    { 17, "11", "Quite boring and repetitive.", 52, 11 },
                    { 17, "12", "Great game, really enjoyed it!", 60, 52 },
                    { 17, "14", "Great game, really enjoyed it!", 57, 96 },
                    { 17, "15", "Average game, nothing special.", 54, 20 },
                    { 17, "16", "I didn't like this game much.", 56, 30 },
                    { 17, "17", "Fantastic experience, highly recommend!", 59, 43 },
                    { 17, "2", "Fantastic experience, highly recommend!", 53, 64 },
                    { 17, "20", "Great game, really enjoyed it!", 51, 91 },
                    { 17, "5", "I didn't like this game much.", 55, 67 },
                    { 17, "7", "Loved the graphics and storyline.", 58, 30 },
                    { 18, "1", "Fantastic experience, highly recommend!", 55, 87 },
                    { 18, "11", "Not bad, could be better.", 58, 58 },
                    { 18, "12", "Disappointing, had high expectations.", 56, 61 },
                    { 18, "13", "A must-play for all gamers!", 61, 20 },
                    { 18, "18", "I didn't like this game much.", 60, 82 },
                    { 18, "2", "Average game, nothing special.", 63, 20 },
                    { 18, "20", "Not bad, could be better.", 62, 13 },
                    { 18, "4", "Average game, nothing special.", 57, 47 },
                    { 18, "5", "Gameplay was not very engaging.", 54, 62 },
                    { 18, "7", "Disappointing, had high expectations.", 59, 31 },
                    { 19, "11", "Disappointing, had high expectations.", 65, 79 },
                    { 19, "13", "Disappointing, had high expectations.", 63, 69 },
                    { 19, "14", "Disappointing, had high expectations.", 62, 1 },
                    { 19, "16", "A must-play for all gamers!", 66, 63 },
                    { 19, "17", "Loved the graphics and storyline.", 60, 99 },
                    { 19, "18", "Great game, really enjoyed it!", 64, 93 },
                    { 19, "3", "Quite boring and repetitive.", 57, 89 },
                    { 19, "4", "Disappointing, had high expectations.", 58, 75 },
                    { 19, "7", "Average game, nothing special.", 61, 14 },
                    { 19, "9", "Great game, really enjoyed it!", 59, 15 },
                    { 20, "10", "Fantastic experience, highly recommend!", 64, 58 },
                    { 20, "12", "Quite boring and repetitive.", 63, 26 },
                    { 20, "14", "Gameplay was not very engaging.", 65, 1 },
                    { 20, "16", "A must-play for all gamers!", 69, 34 },
                    { 20, "19", "I didn't like this game much.", 68, 4 },
                    { 20, "3", "Fantastic experience, highly recommend!", 66, 2 },
                    { 20, "5", "Average game, nothing special.", 62, 77 },
                    { 20, "6", "Gameplay was not very engaging.", 61, 72 },
                    { 20, "7", "Fantastic experience, highly recommend!", 60, 55 },
                    { 20, "8", "A must-play for all gamers!", 67, 5 },
                    { 21, "12", "Great game, really enjoyed it!", 70, 13 },
                    { 21, "13", "Average game, nothing special.", 64, 94 },
                    { 21, "18", "Disappointing, had high expectations.", 72, 65 },
                    { 21, "19", "Average game, nothing special.", 68, 19 },
                    { 21, "3", "Average game, nothing special.", 66, 79 },
                    { 21, "4", "Not bad, could be better.", 71, 42 },
                    { 21, "5", "Not bad, could be better.", 67, 64 },
                    { 21, "6", "Quite boring and repetitive.", 69, 16 },
                    { 21, "7", "Quite boring and repetitive.", 65, 81 },
                    { 21, "9", "Loved the graphics and storyline.", 63, 37 },
                    { 22, "11", "Gameplay was not very engaging.", 73, 57 },
                    { 22, "12", "Not bad, could be better.", 69, 43 },
                    { 22, "14", "Quite boring and repetitive.", 72, 26 },
                    { 22, "16", "Great game, really enjoyed it!", 67, 91 },
                    { 22, "17", "Average game, nothing special.", 70, 29 },
                    { 22, "18", "Gameplay was not very engaging.", 71, 20 },
                    { 22, "20", "Loved the graphics and storyline.", 66, 29 },
                    { 22, "6", "Disappointing, had high expectations.", 74, 83 },
                    { 22, "8", "I didn't like this game much.", 68, 56 },
                    { 22, "9", "Great game, really enjoyed it!", 75, 7 },
                    { 23, "1", "I didn't like this game much.", 73, 20 },
                    { 23, "10", "Quite boring and repetitive.", 71, 51 },
                    { 23, "12", "Disappointing, had high expectations.", 72, 54 },
                    { 23, "15", "Great game, really enjoyed it!", 70, 76 },
                    { 23, "17", "Disappointing, had high expectations.", 74, 58 },
                    { 23, "18", "Average game, nothing special.", 78, 81 },
                    { 23, "19", "Disappointing, had high expectations.", 75, 10 },
                    { 23, "5", "Loved the graphics and storyline.", 77, 24 },
                    { 23, "7", "Great game, really enjoyed it!", 76, 11 },
                    { 23, "8", "Not bad, could be better.", 69, 28 },
                    { 24, "10", "Disappointing, had high expectations.", 81, 35 },
                    { 24, "11", "Not bad, could be better.", 77, 14 },
                    { 24, "12", "I didn't like this game much.", 73, 67 },
                    { 24, "14", "I didn't like this game much.", 72, 96 },
                    { 24, "15", "Fantastic experience, highly recommend!", 78, 65 },
                    { 24, "17", "Great game, really enjoyed it!", 75, 38 },
                    { 24, "19", "I didn't like this game much.", 74, 68 },
                    { 24, "5", "Quite boring and repetitive.", 80, 23 },
                    { 24, "7", "Average game, nothing special.", 79, 21 },
                    { 24, "9", "Gameplay was not very engaging.", 76, 30 },
                    { 25, "1", "Average game, nothing special.", 76, 67 },
                    { 25, "12", "Not bad, could be better.", 81, 20 },
                    { 25, "15", "Not bad, could be better.", 82, 77 },
                    { 25, "17", "Loved the graphics and storyline.", 78, 81 },
                    { 25, "20", "Average game, nothing special.", 77, 65 },
                    { 25, "4", "I didn't like this game much.", 80, 53 },
                    { 25, "6", "Quite boring and repetitive.", 84, 97 },
                    { 25, "7", "Disappointing, had high expectations.", 83, 62 },
                    { 25, "8", "Loved the graphics and storyline.", 75, 98 },
                    { 25, "9", "Loved the graphics and storyline.", 79, 19 },
                    { 26, "1", "I didn't like this game much.", 79, 32 },
                    { 26, "10", "Gameplay was not very engaging.", 85, 1 },
                    { 26, "12", "Not bad, could be better.", 80, 13 },
                    { 26, "14", "Gameplay was not very engaging.", 81, 28 },
                    { 26, "17", "Not bad, could be better.", 86, 19 },
                    { 26, "18", "Gameplay was not very engaging.", 87, 97 },
                    { 26, "19", "Fantastic experience, highly recommend!", 84, 18 },
                    { 26, "4", "Loved the graphics and storyline.", 78, 69 },
                    { 26, "5", "I didn't like this game much.", 83, 98 },
                    { 26, "9", "Average game, nothing special.", 82, 33 },
                    { 27, "12", "Quite boring and repetitive.", 88, 5 },
                    { 27, "15", "Fantastic experience, highly recommend!", 87, 63 },
                    { 27, "16", "Quite boring and repetitive.", 90, 69 },
                    { 27, "17", "Average game, nothing special.", 84, 30 },
                    { 27, "2", "Not bad, could be better.", 86, 20 },
                    { 27, "20", "Loved the graphics and storyline.", 82, 31 },
                    { 27, "3", "Average game, nothing special.", 85, 84 },
                    { 27, "4", "Fantastic experience, highly recommend!", 81, 9 },
                    { 27, "7", "Loved the graphics and storyline.", 89, 35 },
                    { 27, "8", "Gameplay was not very engaging.", 83, 2 },
                    { 28, "1", "Disappointing, had high expectations.", 93, 93 },
                    { 28, "12", "I didn't like this game much.", 85, 79 },
                    { 28, "16", "A must-play for all gamers!", 89, 100 },
                    { 28, "18", "Quite boring and repetitive.", 90, 48 },
                    { 28, "19", "Average game, nothing special.", 92, 98 },
                    { 28, "20", "Gameplay was not very engaging.", 86, 33 },
                    { 28, "3", "Average game, nothing special.", 91, 59 },
                    { 28, "5", "I didn't like this game much.", 88, 64 },
                    { 28, "7", "Gameplay was not very engaging.", 87, 43 },
                    { 28, "9", "Disappointing, had high expectations.", 84, 18 },
                    { 29, "1", "Quite boring and repetitive.", 93, 32 },
                    { 29, "10", "Loved the graphics and storyline.", 87, 44 },
                    { 29, "14", "Fantastic experience, highly recommend!", 94, 99 },
                    { 29, "15", "Disappointing, had high expectations.", 89, 89 },
                    { 29, "16", "Gameplay was not very engaging.", 96, 73 },
                    { 29, "19", "Quite boring and repetitive.", 92, 43 },
                    { 29, "20", "Quite boring and repetitive.", 90, 69 },
                    { 29, "3", "Fantastic experience, highly recommend!", 95, 68 },
                    { 29, "5", "A must-play for all gamers!", 88, 93 },
                    { 29, "9", "Average game, nothing special.", 91, 52 },
                    { 30, "14", "I didn't like this game much.", 96, 45 },
                    { 30, "15", "I didn't like this game much.", 94, 89 },
                    { 30, "16", "Great game, really enjoyed it!", 93, 66 },
                    { 30, "17", "Average game, nothing special.", 97, 1 },
                    { 30, "18", "I didn't like this game much.", 92, 71 },
                    { 30, "19", "Great game, really enjoyed it!", 91, 22 },
                    { 30, "4", "Loved the graphics and storyline.", 95, 71 },
                    { 30, "6", "Disappointing, had high expectations.", 99, 15 },
                    { 30, "8", "A must-play for all gamers!", 98, 45 },
                    { 30, "9", "Quite boring and repetitive.", 90, 79 },
                    { 31, "1", "Gameplay was not very engaging.", 102, 3 },
                    { 31, "11", "Disappointing, had high expectations.", 100, 38 },
                    { 31, "16", "A must-play for all gamers!", 101, 24 },
                    { 31, "17", "A must-play for all gamers!", 99, 13 },
                    { 31, "18", "Not bad, could be better.", 94, 19 },
                    { 31, "2", "Quite boring and repetitive.", 95, 15 },
                    { 31, "20", "Disappointing, had high expectations.", 93, 66 },
                    { 31, "3", "Average game, nothing special.", 97, 72 },
                    { 31, "5", "Loved the graphics and storyline.", 98, 18 },
                    { 31, "6", "A must-play for all gamers!", 96, 63 },
                    { 32, "1", "Not bad, could be better.", 104, 2 },
                    { 32, "10", "Fantastic experience, highly recommend!", 98, 57 },
                    { 32, "11", "A must-play for all gamers!", 103, 68 },
                    { 32, "14", "Not bad, could be better.", 97, 58 },
                    { 32, "16", "Average game, nothing special.", 96, 91 },
                    { 32, "2", "Loved the graphics and storyline.", 105, 90 },
                    { 32, "20", "Average game, nothing special.", 101, 90 },
                    { 32, "5", "Average game, nothing special.", 102, 22 },
                    { 32, "6", "Fantastic experience, highly recommend!", 100, 47 },
                    { 32, "7", "Not bad, could be better.", 99, 53 },
                    { 33, "10", "Not bad, could be better.", 99, 51 },
                    { 33, "15", "Quite boring and repetitive.", 100, 73 },
                    { 33, "16", "Great game, really enjoyed it!", 105, 16 },
                    { 33, "18", "Gameplay was not very engaging.", 104, 41 },
                    { 33, "19", "Loved the graphics and storyline.", 108, 24 },
                    { 33, "2", "I didn't like this game much.", 101, 35 },
                    { 33, "3", "Disappointing, had high expectations.", 103, 33 },
                    { 33, "5", "Not bad, could be better.", 106, 71 },
                    { 33, "6", "Not bad, could be better.", 102, 96 },
                    { 33, "8", "Disappointing, had high expectations.", 107, 79 }
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
                name: "IX_Platforms_PlatformName",
                table: "Platforms",
                column: "PlatformName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_UserId",
                table: "UserReviews",
                column: "UserId");
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
                name: "UserReviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
