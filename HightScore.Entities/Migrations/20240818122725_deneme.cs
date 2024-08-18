using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HighScore.Entities.Migrations
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
                    { "0", 0, "6faff7ca-d705-4fc1-8398-f4b6c84a195f", "MetaUser", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEH3paaWNkCQ1FnX66vO4dj+ZZ1XHhSgYWP4XuImMbTKU5QlCLzAlneWsVV8by0Z6XQ==", "555-666-777", false, "29ec10e4-3499-4a92-af34-5187bbf64135", false, "admin" },
                    { "1", 0, "ad9d4257-987e-4c52-be63-b55c1b36efa9", "MetaUser", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEH+I0wzvtMlQ5zF8mi6wOs3OBI9sGAMXQdfUYVmzoybbvQEzH/ZEQROhRZWqTrU4tw==", null, false, "9912e1af-da0b-4baf-a826-7dc59be87e90", false, "user1" },
                    { "10", 0, "63c2b724-ba77-47d9-af08-95bf71d49430", "MetaUser", "user10@example.com", true, false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEDGvpg5gtAio8AIizzhkmX7g2Vi27QzgXifh/vOvXfk9QLo/zsdjkNCNb92iSJv2Jw==", null, false, "6c3790f9-8ea7-4c42-986a-af1e6926eaa5", false, "user10" },
                    { "11", 0, "fae7cf02-be15-4675-ad8d-f90154e8606a", "MetaUser", "user11@example.com", true, false, null, "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEPmd9uJbQay7M7aOq4+P+L4N6AThK2wWKWM2J1/nu+hTMYQHEeK78UJDX8r9Mw6bjg==", null, false, "c1c93bc1-0f7b-4196-be95-6b99299b977f", false, "user11" },
                    { "12", 0, "b3fe10a1-48e8-49ff-9aad-58945fc95d23", "MetaUser", "user12@example.com", true, false, null, "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEJBHJ/SdDqrgqciezhB6uhg2ZH9xGydIMMHjEKgapi3jXbXnmjeL4z2CI8xJtvtZCA==", null, false, "ae0d4d2a-993c-4264-b1d7-9a7cccb13a31", false, "user12" },
                    { "13", 0, "8d0fda97-b663-46b5-a76a-53499e7c234b", "MetaUser", "user13@example.com", true, false, null, "USER13@EXAMPLE.COM", "USER13", "AQAAAAIAAYagAAAAEP0nME0Lw8107OCJJQLgSGJgw0YFpoWqK1iEC0tkXa035/9yz8IeOqXyMzmebw1+Ig==", null, false, "a5cc8b97-5b0c-4e9f-ba40-0e6bfa129ca7", false, "user13" },
                    { "14", 0, "7487b1f9-ef5a-4017-aec1-980baa6c1dd2", "MetaUser", "user14@example.com", true, false, null, "USER14@EXAMPLE.COM", "USER14", "AQAAAAIAAYagAAAAEJnMcvDRnhOJHDskv5TgUyIuS/3w9AMVxX082c7K230jB9YSp7l79x1iKQ2qdxOGoQ==", null, false, "7d8916ff-4aa1-45e2-b777-5dbac1701fa0", false, "user14" },
                    { "15", 0, "701401a9-1e69-4b8b-a653-041a9d857eef", "MetaUser", "user15@example.com", true, false, null, "USER15@EXAMPLE.COM", "USER15", "AQAAAAIAAYagAAAAEM+Jp1kYxMoBMDhaRHlncd10wKuZ3yrDmhOkJIH4hoOYTim4nwvZDek2TlVpTpTm2A==", null, false, "e2a26e06-5fd6-404f-829f-dc6a8f07c670", false, "user15" },
                    { "16", 0, "3097b649-ac58-41f6-a5bb-cd981f82628c", "MetaUser", "user16@example.com", true, false, null, "USER16@EXAMPLE.COM", "USER16", "AQAAAAIAAYagAAAAEN3kHUtEeL7kEwgklu6dREMliRmtGx1NCHrdInTU3Se4bTbJWEfZ5pY94Spq70n6Yg==", null, false, "25765dce-befa-4855-8a6e-03048c7169d0", false, "user16" },
                    { "17", 0, "e5d552b3-0129-4186-87d8-3e1f8acba205", "MetaUser", "user17@example.com", true, false, null, "USER17@EXAMPLE.COM", "USER17", "AQAAAAIAAYagAAAAELuIjXFbsGv7BISSXhH6mZSz4IM9AnEOmhfQMkiE7yVvlL5Uq10sRHUamBffpIdhKg==", null, false, "9642da5e-f1b2-480f-8388-0e69e0d8a468", false, "user17" },
                    { "18", 0, "dfaca90f-85df-46f2-af56-1d859e74bf89", "MetaUser", "user18@example.com", true, false, null, "USER18@EXAMPLE.COM", "USER18", "AQAAAAIAAYagAAAAECLJWXQ45zCcwRxbY+rE/gwKiyDI330gO3VCOlQqG5OHfK0GJr9xtnVE/sNftuvp6g==", null, false, "9f14eeb9-93a4-4a13-ae55-b83e281076c8", false, "user18" },
                    { "19", 0, "34565970-cb4b-4440-ab94-ef85286c0935", "MetaUser", "user19@example.com", true, false, null, "USER19@EXAMPLE.COM", "USER19", "AQAAAAIAAYagAAAAEEBDHD9uFF4124Q6LOzp0zT3I82lrk9LvDmr0dsYzpoNG7K8snyYXx1der5l3eXYUQ==", null, false, "da899156-7a65-42bf-a5ae-cc758b782422", false, "user19" },
                    { "2", 0, "ef29ee2b-bcbd-441d-ba0d-864e7f4e1a7f", "MetaUser", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEFd/ZPXThKIGVLRKoJYb/Sf8z73hsQGy1L2lMo4VaFjQWoheXR/YedwJmwdXVkLgUA==", null, false, "f3a73202-7a66-43cc-84e5-2c7b57339271", false, "user2" },
                    { "20", 0, "c16e76ed-79b5-4e54-963b-ab44f6d33712", "MetaUser", "user20@example.com", true, false, null, "USER20@EXAMPLE.COM", "USER20", "AQAAAAIAAYagAAAAENKlqSWun5S+gw3GDGpPVadmy0RYAnw4JSM/knLBIE32T9S37wzbKGENn4CNwOP+Cw==", null, false, "2049d9c5-0e92-467f-876b-97158520c388", false, "user20" },
                    { "3", 0, "46986c35-7040-42d1-bbd2-a9832494c6d6", "MetaUser", "user3@example.com", true, false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEAMDbFH0mGk0v/nZrXrwg4F+04F5gdCck5MjCaq/WspUIGg52WVlIvt/L/cb3NJu8A==", null, false, "b3503f48-ad4c-4f60-971d-f767e669f2a9", false, "user3" },
                    { "4", 0, "11127c3e-a583-4ab4-9fcd-7ee0a4e5267a", "MetaUser", "user4@example.com", true, false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEP4qhzsNiDZqA/MyAyuF2QpZa9s0nc4qU2R/69zWvYyoG3IN0H4S4bcCRMP1DSegdQ==", null, false, "e38de094-cf0b-4d56-a4ba-e9a0e83aa66c", false, "user4" },
                    { "5", 0, "8b9a56e9-2fe8-4b21-9981-fa1e14d402b1", "MetaUser", "user5@example.com", true, false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEOkdSQdxxAFcAEr3k+oPQ+hEGfnBMAuhUAhAxMoKlGJr2YCdT56cuxodnEhoU2Gq1g==", null, false, "a814fc7e-1f49-4e3c-8ab5-7a26ce4fc994", false, "user5" },
                    { "6", 0, "a0c039dc-32f0-422e-8d7b-1cf53713e1cf", "MetaUser", "user6@example.com", true, false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEB+/f6A5RHkDwc/C5c3Jpw75aHAuFGE+8av2emVziBBRfqS1SUn9RiiOt+PpresVLg==", null, false, "bd24e141-1378-4397-96fc-4436cdc2355a", false, "user6" },
                    { "7", 0, "93db6e9a-0249-407c-ba9e-848f5ef863e6", "MetaUser", "user7@example.com", true, false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAENvrTtkJLHpejpyLPFrHHdqzNry+HzD/w8nefIEAbU0/FZPklBKoNBBu32P1lpkaxA==", null, false, "f6349ee0-ef64-4d5c-9a3c-80b922e301e5", false, "user7" },
                    { "8", 0, "0770844a-27d8-4192-b121-25a250409953", "MetaUser", "user8@example.com", true, false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEOV70jycNWUkclERZpHfjcIoC2ZH4Jr9SzM3iFIDf9w8UZswKcgB9QPoKrwckZ4dkQ==", null, false, "d96a217b-2923-4882-9be3-9b70d59dda0d", false, "user8" },
                    { "9", 0, "515cfb7b-438b-41c6-a8d8-42f1ea775c29", "MetaUser", "user9@example.com", true, false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEE7V3Dc/OHnv7vtTPLsXn+Sg24OPThaH5+1ds96r3s/uYlz1YwwgZPXTr+IfGkWA/g==", null, false, "39709151-c3a0-4a43-a27b-2e3cff990426", false, "user9" }
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
                    { 1, "An action-adventure game developed and published by Nintendo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/zw47_q9wbBE\" title=\"The Legend of Zelda: Breath of the Wild - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5159), "1.jpg" },
                    { 2, "A platform game developed and published by Nintendo for the Nintendo Switch.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/5kcdRBHM7kM\" title=\"Super Mario Odyssey - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super Mario Odyssey", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5180), "2.webp" },
                    { 3, "An action-adventure game developed and published by Rockstar Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HVRzx17WHVk\" title=\"Red Dead Redemption 2 Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5183), "3.jpg" },
                    { 4, "An action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/Ty7WudwSKMA\" title=\"God of War: Ragnarok - Teaser Trailer | PS5 Showcase\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5184), "4.jpg" },
                    { 5, "An action role-playing game developed and published by CD Projekt.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/c0i88t0Kacs\" title=\"The Witcher 3: Wild Hunt - Killing Monsters Cinematic Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5187), "5.jpg" },
                    { 6, "An action role-playing game developed and published by CD Projekt.", "<iframe width=\"930\" height=\"388\" src=\"https://www.youtube.com/embed/P99qJGrPNLs\" title=\"Cyberpunk 2077 Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5193), "6.jpg" },
                    { 7, "A sandbox video game developed by Mojang.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/MmB9b5njVbA\" title=\"Official Minecraft Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5195), "7.jpg" },
                    { 8, "An online video game developed by Epic Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/hHTE5xg9E-g\" title=\"Fortnite Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5196), "8.png" },
                    { 9, "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/JSRtYpNRoN0\" title=\"The Elder Scrolls V: Skyrim - Official Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5198), "9.jpg" },
                    { 10, "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/u4-FCsiF5x4\" title=\"Horizon Zero Dawn - E3 2016 Trailer I PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Zero Dawn", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5200), "10.jpg" },
                    { 11, "An action role-playing game developed and published by Square Enix.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/CNM6o9um1dc\" title=\"FINAL FANTASY XV - Omen Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Fantasy XV", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5201), "11.jpg" },
                    { 12, "A role-playing video game developed by Atlus.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/QnDzJ9KzuV4\" title=\"Persona 5 | Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persona 5", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5203), "12.png" },
                    { 13, "An action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cWBwFhUv1-8\" title=\"Dark Souls III – Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Souls III", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5205), "13.jpg" },
                    { 14, "An action role-playing game developed by FromSoftware and published by Sony Computer Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/G203e1HhixY\" title=\"Bloodborne Debut Trailer | Face Your Fears | PlayStation 4 Action RPG\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2015, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloodborne", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5206), "14.jpg" },
                    { 15, "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/IBIwGKDwnWY\" title=\"Overwatch Theatrical Teaser | &quot;We Are Overwatch&quot;\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5208), "15.jpg" },
                    { 16, "An action-adventure game developed by FromSoftware and published by Activision.", "", new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekiro: Shadows Die Twice", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5211), "16.jpg" },
                    { 17, "An action role-playing game developed by Team Ninja and published by Koei Tecmo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cHTtNdkDduQ\" title=\"Nioh 2 Reveal Teaser Trailer - E3 2018\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nioh", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5213), "17.jpg" },
                    { 18, "An action role-playing game developed and published by Capcom.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monster Hunter: World", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5214), "18.png" },
                    { 19, "A survival horror game developed and published by Capcom.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 2", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5216), "19.jpg" },
                    { 20, "An action-adventure game developed by Sucker Punch Productions and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/RcWk08PBe7k\" title=\"Ghost of Tsushima - A Storm is Coming Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost of Tsushima", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5218), "20.jpg" },
                    { 21, "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.", "<iframe width=\"930\" height=\"390\" src=\"https://www.youtube.com/embed/rKjUAWlbTJk\" title=\"Assassin’s Creed Valhalla: Cinematic World Premiere Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5220), "21.jpg" },
                    { 22, "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/W2Wnvvj33Wo\" title=\"The Last of Us Part II - PlayStation Experience 2016: Reveal Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5222), "22.jpg" },
                    { 23, "An action-adventure game developed by Remedy Entertainment and published by 505 Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/w6bE11FrSFM\" title=\"Control - Ultimate Edition Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5223), "23.jpg" },
                    { 24, "A roguelike action dungeon crawler video game developed and published by Supergiant Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/91t0ha9x0AE\" title=\"Hades - Official Animated Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hades", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5225), "24.png" },
                    { 25, "A first-person shooter game developed by id Software and published by Bethesda Softworks.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/_oVwrpfo_QA\" title=\"DOOM Eternal – Official E3 Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doom Eternal", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5226), "25.jpg" },
                    { 26, "An action role-playing game developed and published by miHoYo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HLUY1nICQRY\" title=\"Genshin Impact - Official Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genshin Impact", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5228), "26.jpg" },
                    { 27, "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/H2Hy96sOnq8\" title=\"Death Stranding - Teaser Trailer - TGA 2016 - 4K\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Stranding", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5235), "27.jpg" },
                    { 28, "An action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/q4GdJVvdxss\" title=\"Marvel’s Spider-Man – Be Greater Extended Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5237), "28.jpg" },
                    { 29, "A virtual reality first-person shooter developed and published by Valve.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/O2W0N3uKXmo\" title=\"Half-Life: Alyx Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life: Alyx", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5240), "29.webp" },
                    { 30, "An action role-playing game developed and published by TaleWorlds Entertainment. Bannerlord is a prequel to Mount & Blade: Warband, a stand-alone expansion pack for the 2008 game Mount & Blade.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/yCk6Jk7DvrA\" title=\"Mount &amp; Blade II: Bannerlord Early Access Announcement\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mount and Blade II: Bannerlord", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5248), "30.jpg" },
                    { 31, "Explore the depths of Arkham Asylum as Batman, unraveling a sinister plot orchestrated by his arch-nemesis, the Joker.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/bVk9jW9EzD0\" title=\"Batman: Arkham Asylum Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2009, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Asylum", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5261), "31.jpg" },
                    { 32, "Gotham City is transformed into a sprawling prison, and Batman must navigate its dangerous streets to uncover a new threat.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/pcaFdTCiz4U\" title=\"Batman: Arkham City - Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham City", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5263), "32.jpg" },
                    { 33, "The Dark Knight faces the ultimate threat to Gotham City as the Scarecrow unites Batman's foes to destroy him once and for all.", "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/wsf78BS9VE0\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>\r\n", new DateTime(2015, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Knight", new DateTime(2024, 8, 18, 15, 27, 23, 294, DateTimeKind.Local).AddTicks(5274), "33.jpg" }
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
                    { 16, 1, 4 },
                    { 29, 1, 2 },
                    { 41, 1, 1 },
                    { 44, 1, 3 },
                    { 12, 2, 6 },
                    { 25, 2, 8 },
                    { 32, 2, 7 },
                    { 43, 2, 5 },
                    { 1, 3, 10 },
                    { 25, 3, 12 },
                    { 48, 3, 11 },
                    { 50, 3, 9 },
                    { 2, 4, 16 },
                    { 6, 4, 13 },
                    { 23, 4, 14 },
                    { 44, 4, 15 },
                    { 19, 5, 19 },
                    { 33, 5, 18 },
                    { 44, 5, 17 },
                    { 45, 5, 20 },
                    { 2, 6, 22 },
                    { 8, 6, 24 },
                    { 43, 6, 23 },
                    { 49, 6, 21 },
                    { 14, 7, 25 },
                    { 20, 7, 26 },
                    { 45, 7, 28 },
                    { 49, 7, 27 },
                    { 17, 8, 32 },
                    { 22, 8, 30 },
                    { 30, 8, 29 },
                    { 50, 8, 31 },
                    { 3, 9, 34 },
                    { 12, 9, 36 },
                    { 20, 9, 35 },
                    { 41, 9, 33 },
                    { 14, 10, 40 },
                    { 16, 10, 39 },
                    { 26, 10, 38 },
                    { 50, 10, 37 },
                    { 5, 11, 43 },
                    { 7, 11, 42 },
                    { 27, 11, 41 },
                    { 35, 11, 44 },
                    { 5, 12, 46 },
                    { 9, 12, 48 },
                    { 10, 12, 45 },
                    { 42, 12, 47 },
                    { 1, 13, 50 },
                    { 11, 13, 49 },
                    { 21, 13, 52 },
                    { 22, 13, 51 },
                    { 3, 14, 56 },
                    { 5, 14, 54 },
                    { 24, 14, 53 },
                    { 49, 14, 55 },
                    { 7, 15, 58 },
                    { 24, 15, 59 },
                    { 25, 15, 57 },
                    { 26, 15, 60 },
                    { 8, 16, 62 },
                    { 23, 16, 64 },
                    { 35, 16, 61 },
                    { 40, 16, 63 },
                    { 3, 17, 67 },
                    { 11, 17, 68 },
                    { 12, 17, 66 },
                    { 31, 17, 65 },
                    { 10, 18, 69 },
                    { 14, 18, 72 },
                    { 24, 18, 71 },
                    { 32, 18, 70 },
                    { 6, 19, 75 },
                    { 18, 19, 76 },
                    { 36, 19, 74 },
                    { 50, 19, 73 },
                    { 1, 20, 79 },
                    { 34, 20, 80 },
                    { 36, 20, 77 },
                    { 50, 20, 78 },
                    { 9, 21, 84 },
                    { 22, 21, 83 },
                    { 40, 21, 81 },
                    { 45, 21, 82 },
                    { 7, 22, 86 },
                    { 21, 22, 87 },
                    { 26, 22, 88 },
                    { 36, 22, 85 },
                    { 25, 23, 90 },
                    { 28, 23, 89 },
                    { 30, 23, 91 },
                    { 42, 23, 92 },
                    { 11, 24, 93 },
                    { 21, 24, 96 },
                    { 37, 24, 95 },
                    { 49, 24, 94 },
                    { 3, 25, 99 },
                    { 10, 25, 98 },
                    { 35, 25, 100 },
                    { 40, 25, 97 },
                    { 3, 26, 102 },
                    { 16, 26, 104 },
                    { 27, 26, 101 },
                    { 28, 26, 103 },
                    { 7, 27, 105 },
                    { 15, 27, 107 },
                    { 16, 27, 106 },
                    { 33, 27, 108 },
                    { 1, 28, 109 },
                    { 19, 28, 110 },
                    { 36, 28, 112 },
                    { 44, 28, 111 },
                    { 6, 29, 114 },
                    { 9, 29, 113 },
                    { 31, 29, 115 },
                    { 39, 29, 116 },
                    { 8, 30, 117 },
                    { 14, 30, 118 },
                    { 21, 30, 120 },
                    { 24, 30, 119 },
                    { 4, 31, 123 },
                    { 7, 31, 122 },
                    { 36, 31, 121 },
                    { 50, 31, 124 },
                    { 15, 32, 125 },
                    { 32, 32, 127 },
                    { 37, 32, 128 },
                    { 49, 32, 126 },
                    { 5, 33, 132 },
                    { 15, 33, 129 },
                    { 24, 33, 131 },
                    { 36, 33, 130 }
                });

            migrationBuilder.InsertData(
                table: "ItemPlatforms",
                columns: new[] { "itemId", "platformId", "Id" },
                values: new object[,]
                {
                    { 1, 4, 4 },
                    { 1, 7, 3 },
                    { 1, 16, 2 },
                    { 1, 17, 1 },
                    { 2, 5, 7 },
                    { 2, 8, 8 },
                    { 2, 11, 6 },
                    { 2, 16, 5 },
                    { 3, 6, 11 },
                    { 3, 8, 10 },
                    { 3, 11, 9 },
                    { 3, 18, 12 },
                    { 4, 8, 15 },
                    { 4, 9, 13 },
                    { 4, 12, 14 },
                    { 4, 19, 16 },
                    { 5, 3, 19 },
                    { 5, 6, 20 },
                    { 5, 8, 17 },
                    { 5, 10, 18 },
                    { 6, 2, 21 },
                    { 6, 15, 22 },
                    { 6, 18, 24 },
                    { 6, 20, 23 },
                    { 7, 1, 25 },
                    { 7, 6, 27 },
                    { 7, 8, 28 },
                    { 7, 15, 26 },
                    { 8, 9, 30 },
                    { 8, 10, 32 },
                    { 8, 15, 31 },
                    { 8, 17, 29 },
                    { 9, 6, 33 },
                    { 9, 10, 35 },
                    { 9, 13, 34 },
                    { 9, 21, 36 },
                    { 10, 2, 39 },
                    { 10, 3, 40 },
                    { 10, 14, 38 },
                    { 10, 19, 37 },
                    { 11, 5, 41 },
                    { 11, 7, 43 },
                    { 11, 13, 44 },
                    { 11, 20, 42 },
                    { 12, 4, 45 },
                    { 12, 11, 46 },
                    { 12, 12, 48 },
                    { 12, 17, 47 },
                    { 13, 8, 49 },
                    { 13, 14, 50 },
                    { 13, 19, 51 },
                    { 13, 21, 52 },
                    { 14, 5, 53 },
                    { 14, 9, 56 },
                    { 14, 14, 55 },
                    { 14, 15, 54 },
                    { 15, 8, 57 },
                    { 15, 14, 58 },
                    { 15, 19, 59 },
                    { 15, 21, 60 },
                    { 16, 1, 64 },
                    { 16, 6, 62 },
                    { 16, 17, 61 },
                    { 16, 20, 63 },
                    { 17, 2, 67 },
                    { 17, 12, 68 },
                    { 17, 13, 66 },
                    { 17, 21, 65 },
                    { 18, 5, 71 },
                    { 18, 8, 69 },
                    { 18, 18, 70 },
                    { 18, 19, 72 },
                    { 19, 2, 76 },
                    { 19, 3, 74 },
                    { 19, 16, 75 },
                    { 19, 21, 73 },
                    { 20, 5, 80 },
                    { 20, 11, 79 },
                    { 20, 19, 77 },
                    { 20, 20, 78 },
                    { 21, 7, 82 },
                    { 21, 8, 83 },
                    { 21, 12, 81 },
                    { 21, 19, 84 },
                    { 22, 3, 87 },
                    { 22, 6, 85 },
                    { 22, 19, 88 },
                    { 22, 21, 86 },
                    { 23, 6, 91 },
                    { 23, 7, 92 },
                    { 23, 13, 89 },
                    { 23, 16, 90 },
                    { 24, 2, 94 },
                    { 24, 5, 95 },
                    { 24, 6, 93 },
                    { 24, 16, 96 },
                    { 25, 1, 100 },
                    { 25, 4, 98 },
                    { 25, 8, 97 },
                    { 25, 10, 99 },
                    { 26, 3, 101 },
                    { 26, 5, 102 },
                    { 26, 10, 103 },
                    { 26, 18, 104 },
                    { 27, 2, 105 },
                    { 27, 8, 108 },
                    { 27, 13, 107 },
                    { 27, 14, 106 },
                    { 28, 7, 110 },
                    { 28, 12, 109 },
                    { 28, 19, 111 },
                    { 28, 20, 112 },
                    { 29, 2, 115 },
                    { 29, 6, 113 },
                    { 29, 14, 114 },
                    { 29, 19, 116 },
                    { 30, 4, 118 },
                    { 30, 8, 117 },
                    { 30, 13, 119 },
                    { 30, 17, 120 },
                    { 31, 1, 122 },
                    { 31, 2, 121 },
                    { 31, 6, 123 },
                    { 31, 16, 124 },
                    { 32, 6, 127 },
                    { 32, 12, 126 },
                    { 32, 13, 125 },
                    { 32, 21, 128 },
                    { 33, 4, 131 },
                    { 33, 8, 129 },
                    { 33, 15, 130 },
                    { 33, 16, 132 }
                });

            migrationBuilder.InsertData(
                table: "UserReviews",
                columns: new[] { "ItemId", "UserId", "Comment", "Id", "UserRating" },
                values: new object[,]
                {
                    { 1, "1", "Fantastic experience, highly recommend!", 9, 90 },
                    { 1, "10", "I didn't like this game much.", 11, 94 },
                    { 1, "11", "Not bad, could be better.", 21, 47 },
                    { 1, "12", "I didn't like this game much.", 5, 30 },
                    { 1, "13", "A must-play for all gamers!", 13, 97 },
                    { 1, "14", "Gameplay was not very engaging.", 3, 39 },
                    { 1, "15", "Great game, really enjoyed it!", 10, 86 },
                    { 1, "16", "Loved the graphics and storyline.", 7, 70 },
                    { 1, "17", "Average game, nothing special.", 6, 36 },
                    { 1, "18", "Great game, really enjoyed it!", 15, 88 },
                    { 1, "19", "Gameplay was not very engaging.", 18, 74 },
                    { 1, "2", "A must-play for all gamers!", 12, 58 },
                    { 1, "20", "Great game, really enjoyed it!", 20, 50 },
                    { 1, "3", "Not bad, could be better.", 4, 34 },
                    { 1, "4", "A must-play for all gamers!", 14, 52 },
                    { 1, "5", "Disappointing, had high expectations.", 8, 36 },
                    { 1, "6", "Fantastic experience, highly recommend!", 22, 95 },
                    { 1, "7", "A must-play for all gamers!", 16, 65 },
                    { 1, "8", "Fantastic experience, highly recommend!", 19, 33 },
                    { 1, "9", "Not bad, could be better.", 17, 78 },
                    { 2, "1", "Quite boring and repetitive.", 22, 84 },
                    { 2, "10", "Great game, really enjoyed it!", 11, 69 },
                    { 2, "11", "Loved the graphics and storyline.", 24, 93 },
                    { 2, "12", "Great game, really enjoyed it!", 19, 42 },
                    { 2, "13", "Gameplay was not very engaging.", 18, 75 },
                    { 2, "14", "Fantastic experience, highly recommend!", 25, 31 },
                    { 2, "15", "I didn't like this game much.", 23, 35 },
                    { 2, "16", "Not bad, could be better.", 17, 87 },
                    { 2, "17", "Great game, really enjoyed it!", 8, 94 },
                    { 2, "18", "Loved the graphics and storyline.", 16, 73 },
                    { 2, "19", "A must-play for all gamers!", 14, 100 },
                    { 2, "2", "Not bad, could be better.", 9, 66 },
                    { 2, "20", "Fantastic experience, highly recommend!", 7, 55 },
                    { 2, "3", "Fantastic experience, highly recommend!", 21, 37 },
                    { 2, "4", "Average game, nothing special.", 6, 76 },
                    { 2, "5", "Loved the graphics and storyline.", 12, 41 },
                    { 2, "6", "I didn't like this game much.", 10, 73 },
                    { 2, "7", "Not bad, could be better.", 20, 76 },
                    { 2, "8", "Average game, nothing special.", 15, 99 },
                    { 2, "9", "Great game, really enjoyed it!", 13, 76 },
                    { 3, "1", "Average game, nothing special.", 20, 66 },
                    { 3, "10", "A must-play for all gamers!", 27, 94 },
                    { 3, "11", "A must-play for all gamers!", 17, 45 },
                    { 3, "12", "Not bad, could be better.", 14, 97 },
                    { 3, "13", "Disappointing, had high expectations.", 11, 93 },
                    { 3, "14", "I didn't like this game much.", 24, 69 },
                    { 3, "15", "Not bad, could be better.", 21, 96 },
                    { 3, "16", "Disappointing, had high expectations.", 10, 69 },
                    { 3, "17", "Great game, really enjoyed it!", 18, 88 },
                    { 3, "18", "Great game, really enjoyed it!", 28, 65 },
                    { 3, "19", "Loved the graphics and storyline.", 12, 90 },
                    { 3, "2", "Disappointing, had high expectations.", 19, 38 },
                    { 3, "20", "Average game, nothing special.", 13, 85 },
                    { 3, "3", "Loved the graphics and storyline.", 22, 84 },
                    { 3, "4", "Disappointing, had high expectations.", 15, 98 },
                    { 3, "5", "Gameplay was not very engaging.", 16, 84 },
                    { 3, "6", "Quite boring and repetitive.", 23, 57 },
                    { 3, "7", "Great game, really enjoyed it!", 26, 64 },
                    { 3, "8", "I didn't like this game much.", 9, 92 },
                    { 3, "9", "Fantastic experience, highly recommend!", 25, 38 },
                    { 4, "1", "Disappointing, had high expectations.", 27, 95 },
                    { 4, "10", "Fantastic experience, highly recommend!", 23, 37 },
                    { 4, "11", "Disappointing, had high expectations.", 30, 52 },
                    { 4, "12", "Disappointing, had high expectations.", 18, 47 },
                    { 4, "13", "I didn't like this game much.", 29, 71 },
                    { 4, "14", "Gameplay was not very engaging.", 20, 68 },
                    { 4, "15", "A must-play for all gamers!", 14, 54 },
                    { 4, "16", "Great game, really enjoyed it!", 24, 74 },
                    { 4, "17", "Disappointing, had high expectations.", 19, 70 },
                    { 4, "18", "Loved the graphics and storyline.", 13, 62 },
                    { 4, "19", "I didn't like this game much.", 25, 38 },
                    { 4, "2", "Disappointing, had high expectations.", 22, 82 },
                    { 4, "20", "Quite boring and repetitive.", 12, 32 },
                    { 4, "3", "Disappointing, had high expectations.", 15, 47 },
                    { 4, "4", "Fantastic experience, highly recommend!", 31, 34 },
                    { 4, "5", "Not bad, could be better.", 17, 96 },
                    { 4, "6", "Disappointing, had high expectations.", 28, 30 },
                    { 4, "7", "A must-play for all gamers!", 21, 50 },
                    { 4, "8", "Average game, nothing special.", 16, 75 },
                    { 4, "9", "Loved the graphics and storyline.", 26, 93 },
                    { 5, "1", "Loved the graphics and storyline.", 30, 55 },
                    { 5, "10", "A must-play for all gamers!", 31, 78 },
                    { 5, "11", "Average game, nothing special.", 32, 36 },
                    { 5, "12", "Not bad, could be better.", 34, 40 },
                    { 5, "13", "Gameplay was not very engaging.", 22, 95 },
                    { 5, "14", "Gameplay was not very engaging.", 25, 85 },
                    { 5, "15", "Quite boring and repetitive.", 21, 95 },
                    { 5, "16", "Loved the graphics and storyline.", 27, 49 },
                    { 5, "17", "A must-play for all gamers!", 28, 41 },
                    { 5, "18", "Gameplay was not very engaging.", 20, 43 },
                    { 5, "19", "Quite boring and repetitive.", 26, 81 },
                    { 5, "2", "Great game, really enjoyed it!", 29, 70 },
                    { 5, "20", "Loved the graphics and storyline.", 23, 93 },
                    { 5, "3", "Great game, really enjoyed it!", 18, 34 },
                    { 5, "4", "I didn't like this game much.", 16, 77 },
                    { 5, "5", "Gameplay was not very engaging.", 15, 73 },
                    { 5, "6", "A must-play for all gamers!", 24, 35 },
                    { 5, "7", "I didn't like this game much.", 33, 65 },
                    { 5, "8", "Not bad, could be better.", 19, 58 },
                    { 5, "9", "Fantastic experience, highly recommend!", 17, 71 },
                    { 6, "1", "Great game, really enjoyed it!", 25, 73 },
                    { 6, "10", "A must-play for all gamers!", 32, 74 },
                    { 6, "11", "Disappointing, had high expectations.", 21, 73 },
                    { 6, "12", "Quite boring and repetitive.", 26, 65 },
                    { 6, "13", "Gameplay was not very engaging.", 24, 55 },
                    { 6, "14", "Loved the graphics and storyline.", 36, 62 },
                    { 6, "15", "Gameplay was not very engaging.", 29, 99 },
                    { 6, "16", "Gameplay was not very engaging.", 20, 42 },
                    { 6, "17", "A must-play for all gamers!", 35, 35 },
                    { 6, "18", "Gameplay was not very engaging.", 27, 61 },
                    { 6, "19", "Great game, really enjoyed it!", 18, 91 },
                    { 6, "2", "Loved the graphics and storyline.", 34, 31 },
                    { 6, "20", "Average game, nothing special.", 31, 94 },
                    { 6, "3", "I didn't like this game much.", 33, 86 },
                    { 6, "4", "Not bad, could be better.", 30, 63 },
                    { 6, "5", "Quite boring and repetitive.", 28, 93 },
                    { 6, "6", "I didn't like this game much.", 23, 88 },
                    { 6, "7", "Loved the graphics and storyline.", 19, 35 },
                    { 6, "8", "Loved the graphics and storyline.", 22, 40 },
                    { 6, "9", "Average game, nothing special.", 37, 89 },
                    { 7, "1", "Fantastic experience, highly recommend!", 26, 34 },
                    { 7, "10", "Fantastic experience, highly recommend!", 28, 94 },
                    { 7, "11", "Great game, really enjoyed it!", 34, 54 },
                    { 7, "12", "Great game, really enjoyed it!", 31, 57 },
                    { 7, "13", "Disappointing, had high expectations.", 38, 36 },
                    { 7, "14", "Not bad, could be better.", 29, 51 },
                    { 7, "15", "A must-play for all gamers!", 24, 41 },
                    { 7, "16", "Not bad, could be better.", 30, 56 },
                    { 7, "17", "Loved the graphics and storyline.", 40, 49 },
                    { 7, "18", "Fantastic experience, highly recommend!", 35, 49 },
                    { 7, "19", "Disappointing, had high expectations.", 33, 57 },
                    { 7, "2", "Not bad, could be better.", 37, 74 },
                    { 7, "20", "Quite boring and repetitive.", 21, 55 },
                    { 7, "3", "A must-play for all gamers!", 23, 46 },
                    { 7, "4", "Quite boring and repetitive.", 22, 82 },
                    { 7, "5", "Loved the graphics and storyline.", 36, 36 },
                    { 7, "6", "Disappointing, had high expectations.", 25, 96 },
                    { 7, "7", "Average game, nothing special.", 39, 30 },
                    { 7, "8", "Fantastic experience, highly recommend!", 32, 59 },
                    { 7, "9", "A must-play for all gamers!", 27, 36 },
                    { 8, "1", "Gameplay was not very engaging.", 24, 37 },
                    { 8, "10", "Great game, really enjoyed it!", 39, 83 },
                    { 8, "11", "Fantastic experience, highly recommend!", 30, 48 },
                    { 8, "12", "Loved the graphics and storyline.", 38, 75 },
                    { 8, "13", "Disappointing, had high expectations.", 29, 43 },
                    { 8, "14", "Average game, nothing special.", 27, 37 },
                    { 8, "15", "Quite boring and repetitive.", 26, 79 },
                    { 8, "16", "Quite boring and repetitive.", 28, 76 },
                    { 8, "17", "Not bad, could be better.", 32, 42 },
                    { 8, "18", "Loved the graphics and storyline.", 33, 78 },
                    { 8, "19", "Great game, really enjoyed it!", 41, 44 },
                    { 8, "2", "I didn't like this game much.", 31, 67 },
                    { 8, "20", "A must-play for all gamers!", 34, 76 },
                    { 8, "3", "I didn't like this game much.", 35, 65 },
                    { 8, "4", "Not bad, could be better.", 43, 89 },
                    { 8, "5", "Quite boring and repetitive.", 42, 34 },
                    { 8, "6", "Gameplay was not very engaging.", 25, 31 },
                    { 8, "7", "Disappointing, had high expectations.", 40, 80 },
                    { 8, "8", "Loved the graphics and storyline.", 36, 70 },
                    { 8, "9", "Not bad, could be better.", 37, 57 },
                    { 9, "1", "Average game, nothing special.", 30, 57 },
                    { 9, "10", "I didn't like this game much.", 44, 49 },
                    { 9, "11", "Great game, really enjoyed it!", 40, 83 },
                    { 9, "12", "Disappointing, had high expectations.", 33, 93 },
                    { 9, "13", "Average game, nothing special.", 34, 89 },
                    { 9, "14", "I didn't like this game much.", 31, 66 },
                    { 9, "15", "Loved the graphics and storyline.", 38, 54 },
                    { 9, "16", "Disappointing, had high expectations.", 32, 94 },
                    { 9, "17", "Average game, nothing special.", 39, 47 },
                    { 9, "18", "Quite boring and repetitive.", 27, 33 },
                    { 9, "19", "I didn't like this game much.", 36, 74 },
                    { 9, "2", "Loved the graphics and storyline.", 37, 31 },
                    { 9, "20", "Gameplay was not very engaging.", 35, 35 },
                    { 9, "3", "Gameplay was not very engaging.", 42, 39 },
                    { 9, "4", "Great game, really enjoyed it!", 41, 38 },
                    { 9, "5", "Loved the graphics and storyline.", 28, 84 },
                    { 9, "6", "Fantastic experience, highly recommend!", 43, 50 },
                    { 9, "7", "Gameplay was not very engaging.", 29, 54 },
                    { 9, "8", "Great game, really enjoyed it!", 46, 44 },
                    { 9, "9", "Gameplay was not very engaging.", 45, 79 },
                    { 10, "1", "Loved the graphics and storyline.", 36, 32 },
                    { 10, "10", "I didn't like this game much.", 30, 76 },
                    { 10, "11", "I didn't like this game much.", 44, 71 },
                    { 10, "12", "Gameplay was not very engaging.", 42, 66 },
                    { 10, "13", "Disappointing, had high expectations.", 31, 75 },
                    { 10, "14", "I didn't like this game much.", 39, 62 },
                    { 10, "15", "Not bad, could be better.", 40, 58 },
                    { 10, "16", "Quite boring and repetitive.", 37, 40 },
                    { 10, "17", "Loved the graphics and storyline.", 47, 52 },
                    { 10, "18", "Average game, nothing special.", 32, 49 },
                    { 10, "19", "Average game, nothing special.", 38, 47 },
                    { 10, "2", "Fantastic experience, highly recommend!", 34, 77 },
                    { 10, "20", "Great game, really enjoyed it!", 46, 50 },
                    { 10, "3", "Gameplay was not very engaging.", 48, 68 },
                    { 10, "4", "Quite boring and repetitive.", 41, 31 },
                    { 10, "5", "Gameplay was not very engaging.", 33, 66 },
                    { 10, "6", "Loved the graphics and storyline.", 43, 43 },
                    { 10, "7", "A must-play for all gamers!", 35, 78 },
                    { 10, "8", "Great game, really enjoyed it!", 45, 56 },
                    { 10, "9", "Quite boring and repetitive.", 49, 75 },
                    { 11, "1", "Quite boring and repetitive.", 38, 80 },
                    { 11, "10", "A must-play for all gamers!", 35, 91 },
                    { 11, "11", "I didn't like this game much.", 50, 51 },
                    { 11, "12", "Great game, really enjoyed it!", 43, 59 },
                    { 11, "13", "Gameplay was not very engaging.", 46, 100 },
                    { 11, "14", "Not bad, could be better.", 48, 78 },
                    { 11, "15", "Loved the graphics and storyline.", 34, 85 },
                    { 11, "16", "I didn't like this game much.", 45, 59 },
                    { 11, "17", "Average game, nothing special.", 52, 88 },
                    { 11, "18", "Not bad, could be better.", 39, 98 },
                    { 11, "19", "I didn't like this game much.", 37, 77 },
                    { 11, "2", "Quite boring and repetitive.", 36, 73 },
                    { 11, "20", "Average game, nothing special.", 47, 77 },
                    { 11, "3", "Gameplay was not very engaging.", 51, 47 },
                    { 11, "4", "I didn't like this game much.", 42, 52 },
                    { 11, "5", "A must-play for all gamers!", 44, 42 },
                    { 11, "6", "Fantastic experience, highly recommend!", 33, 63 },
                    { 11, "7", "Disappointing, had high expectations.", 49, 82 },
                    { 11, "8", "Average game, nothing special.", 40, 85 },
                    { 11, "9", "Average game, nothing special.", 41, 54 },
                    { 12, "1", "Not bad, could be better.", 52, 64 },
                    { 12, "10", "I didn't like this game much.", 44, 51 },
                    { 12, "11", "Disappointing, had high expectations.", 48, 73 },
                    { 12, "12", "Quite boring and repetitive.", 45, 51 },
                    { 12, "13", "I didn't like this game much.", 51, 50 },
                    { 12, "14", "I didn't like this game much.", 47, 43 },
                    { 12, "15", "Disappointing, had high expectations.", 53, 84 },
                    { 12, "16", "Loved the graphics and storyline.", 55, 99 },
                    { 12, "17", "Quite boring and repetitive.", 43, 52 },
                    { 12, "18", "Not bad, could be better.", 49, 62 },
                    { 12, "19", "Great game, really enjoyed it!", 46, 32 },
                    { 12, "2", "Not bad, could be better.", 36, 97 },
                    { 12, "20", "Loved the graphics and storyline.", 40, 54 },
                    { 12, "3", "Gameplay was not very engaging.", 38, 51 },
                    { 12, "4", "Great game, really enjoyed it!", 54, 58 },
                    { 12, "5", "Gameplay was not very engaging.", 37, 70 },
                    { 12, "6", "Not bad, could be better.", 39, 30 },
                    { 12, "7", "Loved the graphics and storyline.", 41, 64 },
                    { 12, "8", "Great game, really enjoyed it!", 50, 44 },
                    { 12, "9", "Average game, nothing special.", 42, 73 },
                    { 13, "1", "Average game, nothing special.", 48, 77 },
                    { 13, "10", "Loved the graphics and storyline.", 50, 92 },
                    { 13, "11", "Fantastic experience, highly recommend!", 46, 60 },
                    { 13, "12", "Quite boring and repetitive.", 42, 57 },
                    { 13, "13", "Fantastic experience, highly recommend!", 58, 93 },
                    { 13, "14", "Not bad, could be better.", 57, 52 },
                    { 13, "15", "Fantastic experience, highly recommend!", 52, 88 },
                    { 13, "16", "Disappointing, had high expectations.", 53, 85 },
                    { 13, "17", "I didn't like this game much.", 45, 99 },
                    { 13, "18", "Loved the graphics and storyline.", 44, 38 },
                    { 13, "19", "Gameplay was not very engaging.", 54, 90 },
                    { 13, "2", "Gameplay was not very engaging.", 41, 35 },
                    { 13, "20", "Not bad, could be better.", 49, 75 },
                    { 13, "3", "Great game, really enjoyed it!", 47, 70 },
                    { 13, "4", "Great game, really enjoyed it!", 43, 63 },
                    { 13, "5", "Loved the graphics and storyline.", 39, 58 },
                    { 13, "6", "Not bad, could be better.", 51, 97 },
                    { 13, "7", "Gameplay was not very engaging.", 40, 86 },
                    { 13, "8", "Not bad, could be better.", 56, 53 },
                    { 13, "9", "A must-play for all gamers!", 55, 57 },
                    { 14, "1", "Average game, nothing special.", 58, 81 },
                    { 14, "10", "Disappointing, had high expectations.", 49, 99 },
                    { 14, "11", "Average game, nothing special.", 57, 79 },
                    { 14, "12", "Average game, nothing special.", 50, 85 },
                    { 14, "13", "A must-play for all gamers!", 55, 59 },
                    { 14, "14", "Not bad, could be better.", 54, 48 },
                    { 14, "15", "A must-play for all gamers!", 48, 83 },
                    { 14, "16", "Gameplay was not very engaging.", 45, 40 },
                    { 14, "17", "Disappointing, had high expectations.", 46, 68 },
                    { 14, "18", "Loved the graphics and storyline.", 56, 60 },
                    { 14, "19", "A must-play for all gamers!", 52, 67 },
                    { 14, "2", "I didn't like this game much.", 47, 42 },
                    { 14, "20", "Fantastic experience, highly recommend!", 60, 69 },
                    { 14, "3", "Not bad, could be better.", 53, 32 },
                    { 14, "4", "Disappointing, had high expectations.", 61, 97 },
                    { 14, "5", "Gameplay was not very engaging.", 44, 63 },
                    { 14, "6", "Disappointing, had high expectations.", 43, 62 },
                    { 14, "7", "Quite boring and repetitive.", 59, 99 },
                    { 14, "8", "Average game, nothing special.", 51, 39 },
                    { 14, "9", "I didn't like this game much.", 42, 31 },
                    { 15, "1", "Not bad, could be better.", 56, 31 },
                    { 15, "10", "Great game, really enjoyed it!", 54, 63 },
                    { 15, "11", "Disappointing, had high expectations.", 49, 96 },
                    { 15, "12", "Not bad, could be better.", 45, 48 },
                    { 15, "13", "Average game, nothing special.", 59, 39 },
                    { 15, "14", "Disappointing, had high expectations.", 63, 56 },
                    { 15, "15", "Quite boring and repetitive.", 48, 55 },
                    { 15, "16", "Gameplay was not very engaging.", 60, 74 },
                    { 15, "17", "I didn't like this game much.", 57, 38 },
                    { 15, "18", "Average game, nothing special.", 64, 86 },
                    { 15, "19", "Disappointing, had high expectations.", 61, 61 },
                    { 15, "2", "Quite boring and repetitive.", 51, 93 },
                    { 15, "20", "Loved the graphics and storyline.", 62, 56 },
                    { 15, "3", "A must-play for all gamers!", 52, 33 },
                    { 15, "4", "I didn't like this game much.", 50, 31 },
                    { 15, "5", "Loved the graphics and storyline.", 46, 34 },
                    { 15, "6", "A must-play for all gamers!", 47, 81 },
                    { 15, "7", "Disappointing, had high expectations.", 53, 100 },
                    { 15, "8", "A must-play for all gamers!", 58, 69 },
                    { 15, "9", "Average game, nothing special.", 55, 88 },
                    { 16, "1", "Disappointing, had high expectations.", 55, 67 },
                    { 16, "10", "Loved the graphics and storyline.", 67, 57 },
                    { 16, "11", "A must-play for all gamers!", 60, 35 },
                    { 16, "12", "Not bad, could be better.", 49, 71 },
                    { 16, "13", "Not bad, could be better.", 56, 53 },
                    { 16, "14", "Disappointing, had high expectations.", 54, 85 },
                    { 16, "15", "Gameplay was not very engaging.", 66, 43 },
                    { 16, "16", "Quite boring and repetitive.", 58, 98 },
                    { 16, "17", "Disappointing, had high expectations.", 59, 51 },
                    { 16, "18", "Not bad, could be better.", 57, 100 },
                    { 16, "19", "Great game, really enjoyed it!", 64, 48 },
                    { 16, "2", "Disappointing, had high expectations.", 65, 33 },
                    { 16, "20", "Average game, nothing special.", 53, 74 },
                    { 16, "3", "Quite boring and repetitive.", 62, 86 },
                    { 16, "4", "Quite boring and repetitive.", 51, 39 },
                    { 16, "5", "Average game, nothing special.", 63, 55 },
                    { 16, "6", "Loved the graphics and storyline.", 52, 38 },
                    { 16, "7", "A must-play for all gamers!", 48, 30 },
                    { 16, "8", "Loved the graphics and storyline.", 50, 41 },
                    { 16, "9", "A must-play for all gamers!", 61, 53 },
                    { 17, "1", "Loved the graphics and storyline.", 69, 47 },
                    { 17, "10", "Average game, nothing special.", 62, 43 },
                    { 17, "11", "I didn't like this game much.", 52, 49 },
                    { 17, "12", "Great game, really enjoyed it!", 64, 35 },
                    { 17, "13", "A must-play for all gamers!", 53, 68 },
                    { 17, "14", "I didn't like this game much.", 67, 90 },
                    { 17, "15", "Quite boring and repetitive.", 56, 65 },
                    { 17, "16", "Loved the graphics and storyline.", 51, 53 },
                    { 17, "17", "Quite boring and repetitive.", 55, 88 },
                    { 17, "18", "Average game, nothing special.", 63, 61 },
                    { 17, "19", "Disappointing, had high expectations.", 66, 54 },
                    { 17, "2", "Not bad, could be better.", 61, 40 },
                    { 17, "20", "Not bad, could be better.", 54, 71 },
                    { 17, "3", "Quite boring and repetitive.", 60, 85 },
                    { 17, "4", "Not bad, could be better.", 70, 80 },
                    { 17, "5", "A must-play for all gamers!", 59, 73 },
                    { 17, "6", "Not bad, could be better.", 65, 93 },
                    { 17, "7", "Average game, nothing special.", 58, 34 },
                    { 17, "8", "Quite boring and repetitive.", 57, 90 },
                    { 17, "9", "Great game, really enjoyed it!", 68, 30 },
                    { 18, "1", "Average game, nothing special.", 63, 91 },
                    { 18, "10", "Gameplay was not very engaging.", 70, 70 },
                    { 18, "11", "I didn't like this game much.", 54, 92 },
                    { 18, "12", "Average game, nothing special.", 59, 52 },
                    { 18, "13", "I didn't like this game much.", 73, 41 },
                    { 18, "14", "Average game, nothing special.", 56, 90 },
                    { 18, "15", "Quite boring and repetitive.", 65, 65 },
                    { 18, "16", "A must-play for all gamers!", 62, 83 },
                    { 18, "17", "Not bad, could be better.", 72, 31 },
                    { 18, "18", "Not bad, could be better.", 66, 37 },
                    { 18, "19", "Gameplay was not very engaging.", 69, 97 },
                    { 18, "2", "Disappointing, had high expectations.", 60, 33 },
                    { 18, "20", "Not bad, could be better.", 55, 36 },
                    { 18, "3", "Average game, nothing special.", 58, 92 },
                    { 18, "4", "Average game, nothing special.", 67, 38 },
                    { 18, "5", "Average game, nothing special.", 64, 31 },
                    { 18, "6", "Loved the graphics and storyline.", 68, 100 },
                    { 18, "7", "Average game, nothing special.", 61, 63 },
                    { 18, "8", "Loved the graphics and storyline.", 71, 59 },
                    { 18, "9", "Disappointing, had high expectations.", 57, 98 },
                    { 19, "1", "Average game, nothing special.", 71, 78 },
                    { 19, "10", "Not bad, could be better.", 66, 49 },
                    { 19, "11", "A must-play for all gamers!", 64, 91 },
                    { 19, "12", "I didn't like this game much.", 74, 40 },
                    { 19, "13", "Loved the graphics and storyline.", 75, 48 },
                    { 19, "14", "I didn't like this game much.", 63, 53 },
                    { 19, "15", "Quite boring and repetitive.", 69, 46 },
                    { 19, "16", "Disappointing, had high expectations.", 62, 30 },
                    { 19, "17", "Gameplay was not very engaging.", 76, 46 },
                    { 19, "18", "Quite boring and repetitive.", 70, 33 },
                    { 19, "19", "Not bad, could be better.", 67, 97 },
                    { 19, "2", "Gameplay was not very engaging.", 65, 98 },
                    { 19, "20", "Fantastic experience, highly recommend!", 68, 47 },
                    { 19, "3", "Great game, really enjoyed it!", 60, 96 },
                    { 19, "4", "Disappointing, had high expectations.", 61, 39 },
                    { 19, "5", "Great game, really enjoyed it!", 58, 39 },
                    { 19, "6", "Not bad, could be better.", 73, 37 },
                    { 19, "7", "I didn't like this game much.", 72, 95 },
                    { 19, "8", "Disappointing, had high expectations.", 57, 92 },
                    { 19, "9", "Not bad, could be better.", 59, 91 },
                    { 20, "1", "Gameplay was not very engaging.", 66, 64 },
                    { 20, "10", "Gameplay was not very engaging.", 60, 51 },
                    { 20, "11", "Average game, nothing special.", 70, 75 },
                    { 20, "12", "Great game, really enjoyed it!", 69, 77 },
                    { 20, "13", "Gameplay was not very engaging.", 74, 42 },
                    { 20, "14", "Great game, really enjoyed it!", 78, 52 },
                    { 20, "15", "I didn't like this game much.", 75, 61 },
                    { 20, "16", "I didn't like this game much.", 64, 81 },
                    { 20, "17", "Loved the graphics and storyline.", 71, 72 },
                    { 20, "18", "Gameplay was not very engaging.", 79, 48 },
                    { 20, "19", "Disappointing, had high expectations.", 63, 60 },
                    { 20, "2", "Disappointing, had high expectations.", 61, 72 },
                    { 20, "20", "Quite boring and repetitive.", 77, 95 },
                    { 20, "3", "I didn't like this game much.", 68, 89 },
                    { 20, "4", "Not bad, could be better.", 72, 100 },
                    { 20, "5", "Average game, nothing special.", 73, 97 },
                    { 20, "6", "Great game, really enjoyed it!", 67, 71 },
                    { 20, "7", "Disappointing, had high expectations.", 62, 65 },
                    { 20, "8", "Disappointing, had high expectations.", 76, 87 },
                    { 20, "9", "Disappointing, had high expectations.", 65, 78 },
                    { 21, "1", "Loved the graphics and storyline.", 66, 43 },
                    { 21, "10", "Loved the graphics and storyline.", 65, 30 },
                    { 21, "11", "Average game, nothing special.", 77, 94 },
                    { 21, "12", "Disappointing, had high expectations.", 72, 74 },
                    { 21, "13", "Not bad, could be better.", 82, 70 },
                    { 21, "14", "Disappointing, had high expectations.", 67, 44 },
                    { 21, "15", "Disappointing, had high expectations.", 80, 65 },
                    { 21, "16", "Gameplay was not very engaging.", 71, 31 },
                    { 21, "17", "Average game, nothing special.", 73, 30 },
                    { 21, "18", "Quite boring and repetitive.", 68, 84 },
                    { 21, "19", "Gameplay was not very engaging.", 70, 49 },
                    { 21, "2", "Disappointing, had high expectations.", 74, 36 },
                    { 21, "20", "Quite boring and repetitive.", 63, 64 },
                    { 21, "3", "Average game, nothing special.", 78, 32 },
                    { 21, "4", "Loved the graphics and storyline.", 75, 45 },
                    { 21, "5", "I didn't like this game much.", 64, 65 },
                    { 21, "6", "Average game, nothing special.", 69, 31 },
                    { 21, "7", "Not bad, could be better.", 76, 85 },
                    { 21, "8", "Quite boring and repetitive.", 79, 99 },
                    { 21, "9", "Quite boring and repetitive.", 81, 82 },
                    { 22, "1", "Average game, nothing special.", 73, 30 },
                    { 22, "10", "A must-play for all gamers!", 81, 75 },
                    { 22, "11", "I didn't like this game much.", 84, 81 },
                    { 22, "12", "Fantastic experience, highly recommend!", 80, 60 },
                    { 22, "13", "Gameplay was not very engaging.", 68, 49 },
                    { 22, "14", "Gameplay was not very engaging.", 78, 30 },
                    { 22, "15", "I didn't like this game much.", 83, 81 },
                    { 22, "16", "Disappointing, had high expectations.", 66, 60 },
                    { 22, "17", "Disappointing, had high expectations.", 85, 58 },
                    { 22, "18", "Not bad, could be better.", 67, 51 },
                    { 22, "19", "Disappointing, had high expectations.", 70, 64 },
                    { 22, "2", "Gameplay was not very engaging.", 77, 94 },
                    { 22, "20", "A must-play for all gamers!", 72, 95 },
                    { 22, "3", "Average game, nothing special.", 79, 46 },
                    { 22, "4", "Average game, nothing special.", 82, 46 },
                    { 22, "5", "Loved the graphics and storyline.", 76, 73 },
                    { 22, "6", "Gameplay was not very engaging.", 69, 72 },
                    { 22, "7", "Gameplay was not very engaging.", 74, 51 },
                    { 22, "8", "Not bad, could be better.", 71, 66 },
                    { 22, "9", "Great game, really enjoyed it!", 75, 67 },
                    { 23, "1", "Disappointing, had high expectations.", 84, 66 },
                    { 23, "10", "Average game, nothing special.", 78, 62 },
                    { 23, "11", "Gameplay was not very engaging.", 82, 87 },
                    { 23, "12", "Fantastic experience, highly recommend!", 85, 94 },
                    { 23, "13", "Gameplay was not very engaging.", 75, 96 },
                    { 23, "14", "Loved the graphics and storyline.", 87, 38 },
                    { 23, "15", "A must-play for all gamers!", 72, 36 },
                    { 23, "16", "Not bad, could be better.", 74, 71 },
                    { 23, "17", "Quite boring and repetitive.", 83, 31 },
                    { 23, "18", "Average game, nothing special.", 81, 55 },
                    { 23, "19", "Fantastic experience, highly recommend!", 88, 75 },
                    { 23, "2", "Not bad, could be better.", 79, 41 },
                    { 23, "20", "Disappointing, had high expectations.", 71, 68 },
                    { 23, "3", "Gameplay was not very engaging.", 76, 37 },
                    { 23, "4", "A must-play for all gamers!", 73, 86 },
                    { 23, "5", "Disappointing, had high expectations.", 80, 92 },
                    { 23, "6", "Average game, nothing special.", 86, 92 },
                    { 23, "7", "Quite boring and repetitive.", 77, 49 },
                    { 23, "8", "Gameplay was not very engaging.", 69, 46 },
                    { 23, "9", "Disappointing, had high expectations.", 70, 88 },
                    { 24, "1", "Quite boring and repetitive.", 90, 36 },
                    { 24, "10", "I didn't like this game much.", 87, 51 },
                    { 24, "11", "Fantastic experience, highly recommend!", 75, 68 },
                    { 24, "12", "Not bad, could be better.", 74, 83 },
                    { 24, "13", "A must-play for all gamers!", 88, 49 },
                    { 24, "14", "Loved the graphics and storyline.", 78, 72 },
                    { 24, "15", "Great game, really enjoyed it!", 82, 35 },
                    { 24, "16", "Not bad, could be better.", 91, 32 },
                    { 24, "17", "Fantastic experience, highly recommend!", 84, 49 },
                    { 24, "18", "Gameplay was not very engaging.", 83, 98 },
                    { 24, "19", "Loved the graphics and storyline.", 77, 70 },
                    { 24, "2", "Quite boring and repetitive.", 72, 69 },
                    { 24, "20", "Not bad, could be better.", 73, 93 },
                    { 24, "3", "Disappointing, had high expectations.", 80, 55 },
                    { 24, "4", "I didn't like this game much.", 79, 76 },
                    { 24, "5", "Average game, nothing special.", 81, 78 },
                    { 24, "6", "Gameplay was not very engaging.", 85, 68 },
                    { 24, "7", "Not bad, could be better.", 76, 42 },
                    { 24, "8", "Quite boring and repetitive.", 86, 84 },
                    { 24, "9", "Gameplay was not very engaging.", 89, 55 },
                    { 25, "1", "I didn't like this game much.", 83, 30 },
                    { 25, "10", "I didn't like this game much.", 79, 53 },
                    { 25, "11", "Quite boring and repetitive.", 90, 34 },
                    { 25, "12", "I didn't like this game much.", 94, 70 },
                    { 25, "13", "Fantastic experience, highly recommend!", 80, 96 },
                    { 25, "14", "Quite boring and repetitive.", 76, 38 },
                    { 25, "15", "Loved the graphics and storyline.", 82, 77 },
                    { 25, "16", "Not bad, could be better.", 89, 70 },
                    { 25, "17", "Average game, nothing special.", 91, 40 },
                    { 25, "18", "Gameplay was not very engaging.", 77, 31 },
                    { 25, "19", "I didn't like this game much.", 92, 30 },
                    { 25, "2", "Disappointing, had high expectations.", 85, 48 },
                    { 25, "20", "Loved the graphics and storyline.", 75, 96 },
                    { 25, "3", "I didn't like this game much.", 81, 54 },
                    { 25, "4", "Disappointing, had high expectations.", 78, 58 },
                    { 25, "5", "Quite boring and repetitive.", 93, 45 },
                    { 25, "6", "Loved the graphics and storyline.", 86, 91 },
                    { 25, "7", "A must-play for all gamers!", 88, 98 },
                    { 25, "8", "A must-play for all gamers!", 87, 52 },
                    { 25, "9", "Not bad, could be better.", 84, 75 },
                    { 26, "1", "Gameplay was not very engaging.", 83, 42 },
                    { 26, "10", "Gameplay was not very engaging.", 85, 48 },
                    { 26, "11", "Not bad, could be better.", 79, 42 },
                    { 26, "12", "Not bad, could be better.", 93, 76 },
                    { 26, "13", "Loved the graphics and storyline.", 78, 98 },
                    { 26, "14", "Average game, nothing special.", 90, 42 },
                    { 26, "15", "Average game, nothing special.", 97, 62 },
                    { 26, "16", "Disappointing, had high expectations.", 92, 43 },
                    { 26, "17", "Loved the graphics and storyline.", 84, 89 },
                    { 26, "18", "Not bad, could be better.", 94, 96 },
                    { 26, "19", "A must-play for all gamers!", 91, 94 },
                    { 26, "2", "Not bad, could be better.", 81, 80 },
                    { 26, "20", "Fantastic experience, highly recommend!", 82, 90 },
                    { 26, "3", "Fantastic experience, highly recommend!", 80, 55 },
                    { 26, "4", "Average game, nothing special.", 95, 42 },
                    { 26, "5", "Gameplay was not very engaging.", 89, 40 },
                    { 26, "6", "Great game, really enjoyed it!", 86, 75 },
                    { 26, "7", "I didn't like this game much.", 87, 43 },
                    { 26, "8", "Fantastic experience, highly recommend!", 96, 52 },
                    { 26, "9", "Gameplay was not very engaging.", 88, 85 },
                    { 27, "1", "Loved the graphics and storyline.", 84, 72 },
                    { 27, "10", "Average game, nothing special.", 95, 40 },
                    { 27, "11", "A must-play for all gamers!", 100, 83 },
                    { 27, "12", "Disappointing, had high expectations.", 91, 89 },
                    { 27, "13", "Not bad, could be better.", 98, 59 },
                    { 27, "14", "Disappointing, had high expectations.", 87, 51 },
                    { 27, "15", "Gameplay was not very engaging.", 97, 66 },
                    { 27, "16", "Fantastic experience, highly recommend!", 83, 84 },
                    { 27, "17", "I didn't like this game much.", 86, 73 },
                    { 27, "18", "Loved the graphics and storyline.", 96, 41 },
                    { 27, "19", "Average game, nothing special.", 88, 90 },
                    { 27, "2", "Quite boring and repetitive.", 81, 32 },
                    { 27, "20", "Not bad, could be better.", 94, 59 },
                    { 27, "3", "Disappointing, had high expectations.", 90, 34 },
                    { 27, "4", "Quite boring and repetitive.", 85, 51 },
                    { 27, "5", "Loved the graphics and storyline.", 99, 97 },
                    { 27, "6", "Great game, really enjoyed it!", 89, 79 },
                    { 27, "7", "Quite boring and repetitive.", 93, 87 },
                    { 27, "8", "Disappointing, had high expectations.", 82, 79 },
                    { 27, "9", "Loved the graphics and storyline.", 92, 43 },
                    { 28, "1", "I didn't like this game much.", 101, 78 },
                    { 28, "10", "Fantastic experience, highly recommend!", 85, 88 },
                    { 28, "11", "Fantastic experience, highly recommend!", 102, 59 },
                    { 28, "12", "Quite boring and repetitive.", 98, 74 },
                    { 28, "13", "Gameplay was not very engaging.", 91, 96 },
                    { 28, "14", "Disappointing, had high expectations.", 97, 84 },
                    { 28, "15", "Quite boring and repetitive.", 93, 76 },
                    { 28, "16", "Great game, really enjoyed it!", 89, 100 },
                    { 28, "17", "Gameplay was not very engaging.", 88, 57 },
                    { 28, "18", "Great game, really enjoyed it!", 94, 99 },
                    { 28, "19", "Average game, nothing special.", 99, 88 },
                    { 28, "2", "A must-play for all gamers!", 95, 58 },
                    { 28, "20", "Disappointing, had high expectations.", 100, 78 },
                    { 28, "3", "A must-play for all gamers!", 96, 67 },
                    { 28, "4", "I didn't like this game much.", 86, 53 },
                    { 28, "5", "Great game, really enjoyed it!", 84, 81 },
                    { 28, "6", "Gameplay was not very engaging.", 92, 74 },
                    { 28, "7", "Fantastic experience, highly recommend!", 87, 39 },
                    { 28, "8", "Average game, nothing special.", 90, 40 },
                    { 28, "9", "Average game, nothing special.", 103, 49 },
                    { 29, "1", "Fantastic experience, highly recommend!", 88, 71 },
                    { 29, "10", "Fantastic experience, highly recommend!", 97, 55 },
                    { 29, "11", "Quite boring and repetitive.", 93, 33 },
                    { 29, "12", "A must-play for all gamers!", 98, 64 },
                    { 29, "13", "Average game, nothing special.", 87, 53 },
                    { 29, "14", "Average game, nothing special.", 104, 87 },
                    { 29, "15", "Not bad, could be better.", 100, 45 },
                    { 29, "16", "Not bad, could be better.", 101, 71 },
                    { 29, "17", "Not bad, could be better.", 89, 32 },
                    { 29, "18", "Gameplay was not very engaging.", 94, 71 },
                    { 29, "19", "Gameplay was not very engaging.", 102, 59 },
                    { 29, "2", "A must-play for all gamers!", 91, 43 },
                    { 29, "20", "A must-play for all gamers!", 106, 34 },
                    { 29, "3", "Average game, nothing special.", 103, 88 },
                    { 29, "4", "A must-play for all gamers!", 105, 86 },
                    { 29, "5", "Disappointing, had high expectations.", 96, 65 },
                    { 29, "6", "A must-play for all gamers!", 92, 35 },
                    { 29, "7", "Fantastic experience, highly recommend!", 90, 52 },
                    { 29, "8", "Quite boring and repetitive.", 95, 53 },
                    { 29, "9", "Great game, really enjoyed it!", 99, 93 },
                    { 30, "1", "Loved the graphics and storyline.", 97, 92 },
                    { 30, "10", "I didn't like this game much.", 93, 74 },
                    { 30, "11", "Loved the graphics and storyline.", 108, 94 },
                    { 30, "12", "Fantastic experience, highly recommend!", 102, 50 },
                    { 30, "13", "Great game, really enjoyed it!", 96, 51 },
                    { 30, "14", "Great game, really enjoyed it!", 109, 67 },
                    { 30, "15", "Disappointing, had high expectations.", 98, 41 },
                    { 30, "16", "Gameplay was not very engaging.", 91, 96 },
                    { 30, "17", "Quite boring and repetitive.", 94, 53 },
                    { 30, "18", "Average game, nothing special.", 101, 76 },
                    { 30, "19", "Gameplay was not very engaging.", 100, 47 },
                    { 30, "2", "Loved the graphics and storyline.", 92, 89 },
                    { 30, "20", "Disappointing, had high expectations.", 106, 77 },
                    { 30, "3", "Loved the graphics and storyline.", 104, 93 },
                    { 30, "4", "Fantastic experience, highly recommend!", 107, 35 },
                    { 30, "5", "Gameplay was not very engaging.", 99, 82 },
                    { 30, "6", "Fantastic experience, highly recommend!", 103, 92 },
                    { 30, "7", "Average game, nothing special.", 95, 63 },
                    { 30, "8", "Fantastic experience, highly recommend!", 90, 64 },
                    { 30, "9", "Loved the graphics and storyline.", 105, 36 },
                    { 31, "1", "Great game, really enjoyed it!", 104, 38 },
                    { 31, "10", "A must-play for all gamers!", 107, 75 },
                    { 31, "11", "Gameplay was not very engaging.", 111, 40 },
                    { 31, "12", "Not bad, could be better.", 98, 93 },
                    { 31, "13", "A must-play for all gamers!", 102, 34 },
                    { 31, "14", "I didn't like this game much.", 100, 58 },
                    { 31, "15", "Quite boring and repetitive.", 103, 76 },
                    { 31, "16", "A must-play for all gamers!", 108, 38 },
                    { 31, "17", "Gameplay was not very engaging.", 112, 90 },
                    { 31, "18", "Great game, really enjoyed it!", 95, 57 },
                    { 31, "19", "Not bad, could be better.", 97, 86 },
                    { 31, "2", "Not bad, could be better.", 101, 43 },
                    { 31, "20", "Gameplay was not very engaging.", 105, 57 },
                    { 31, "3", "Disappointing, had high expectations.", 109, 37 },
                    { 31, "4", "Quite boring and repetitive.", 93, 31 },
                    { 31, "5", "Fantastic experience, highly recommend!", 94, 57 },
                    { 31, "6", "A must-play for all gamers!", 106, 78 },
                    { 31, "7", "Average game, nothing special.", 99, 44 },
                    { 31, "8", "Disappointing, had high expectations.", 96, 97 },
                    { 31, "9", "Fantastic experience, highly recommend!", 110, 97 },
                    { 32, "1", "Gameplay was not very engaging.", 115, 97 },
                    { 32, "10", "Quite boring and repetitive.", 105, 87 },
                    { 32, "11", "Fantastic experience, highly recommend!", 114, 83 },
                    { 32, "12", "Quite boring and repetitive.", 106, 76 },
                    { 32, "13", "Gameplay was not very engaging.", 96, 74 },
                    { 32, "14", "Disappointing, had high expectations.", 98, 63 },
                    { 32, "15", "Disappointing, had high expectations.", 101, 87 },
                    { 32, "16", "Average game, nothing special.", 109, 62 },
                    { 32, "17", "Disappointing, had high expectations.", 99, 89 },
                    { 32, "18", "Loved the graphics and storyline.", 111, 40 },
                    { 32, "19", "I didn't like this game much.", 112, 83 },
                    { 32, "2", "Loved the graphics and storyline.", 107, 91 },
                    { 32, "20", "Fantastic experience, highly recommend!", 113, 84 },
                    { 32, "3", "Fantastic experience, highly recommend!", 97, 100 },
                    { 32, "4", "Quite boring and repetitive.", 103, 99 },
                    { 32, "5", "Great game, really enjoyed it!", 110, 54 },
                    { 32, "6", "Average game, nothing special.", 104, 88 },
                    { 32, "7", "Fantastic experience, highly recommend!", 102, 70 },
                    { 32, "8", "I didn't like this game much.", 100, 56 },
                    { 32, "9", "Disappointing, had high expectations.", 108, 32 },
                    { 33, "1", "A must-play for all gamers!", 108, 42 },
                    { 33, "10", "Gameplay was not very engaging.", 105, 83 },
                    { 33, "11", "Not bad, could be better.", 117, 50 },
                    { 33, "12", "Quite boring and repetitive.", 110, 47 },
                    { 33, "13", "Not bad, could be better.", 106, 68 },
                    { 33, "14", "Great game, really enjoyed it!", 112, 41 },
                    { 33, "15", "Disappointing, had high expectations.", 99, 36 },
                    { 33, "16", "Fantastic experience, highly recommend!", 103, 54 },
                    { 33, "17", "Fantastic experience, highly recommend!", 116, 61 },
                    { 33, "18", "Not bad, could be better.", 107, 58 },
                    { 33, "19", "I didn't like this game much.", 104, 77 },
                    { 33, "2", "Fantastic experience, highly recommend!", 111, 67 },
                    { 33, "20", "Not bad, could be better.", 109, 53 },
                    { 33, "3", "Quite boring and repetitive.", 100, 37 },
                    { 33, "4", "Quite boring and repetitive.", 115, 41 },
                    { 33, "5", "Not bad, could be better.", 113, 65 },
                    { 33, "6", "Fantastic experience, highly recommend!", 118, 73 },
                    { 33, "7", "Gameplay was not very engaging.", 114, 53 },
                    { 33, "8", "Fantastic experience, highly recommend!", 101, 98 },
                    { 33, "9", "Loved the graphics and storyline.", 102, 92 }
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
