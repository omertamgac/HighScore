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
                    { "0", 0, "5d7f04c2-f20a-45a5-89b1-64bd3653b130", "MetaUser", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEHDpNJpmFEfuOLLmKl8wJgnHHbCI8d6gv84hdNPMCZWKpJ0NlcX5NVgebtErfanLrQ==", null, false, "21683415-1a68-48e0-8c70-564b1e4b5081", false, "admin" },
                    { "1", 0, "85ec6ca0-6969-41cf-ab1f-354cd4b92d6e", "MetaUser", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEDLetrSVhwN/w4A3egysVRukoaElUS8WH3dB5hNMxHYLfF6pQlOSvMNXXX4AQ9dQ1w==", null, false, "4aed0d7f-4ccc-45e4-8b22-b277b0045d57", false, "user1" },
                    { "10", 0, "19d42810-f28a-406e-ab5f-e181850c1b41", "MetaUser", "user10@example.com", true, false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEFJNVxNyEWoyB5edyWEZfKNfKdH25ZIKHoIB81tXyvR8fxE480SHSWkmiTVvcA36mA==", null, false, "8107dd96-538b-472e-b9ac-2c97256348d4", false, "user10" },
                    { "11", 0, "08fc4751-3571-4e28-bf53-7fc13c4b92cf", "MetaUser", "user11@example.com", true, false, null, "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEDOIyRXCZ34hsx9kWY+1Kz9pWeVuSF79Y2U/c1CIsQxivVX8bRd4x/RT4k+VhcqoyA==", null, false, "bf192c25-1c71-4ede-ab2c-bc940552f235", false, "user11" },
                    { "12", 0, "6cec5ac9-fbe5-491f-ab8e-62eb714b76f4", "MetaUser", "user12@example.com", true, false, null, "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEPvI09hA7sAfWd/TtVx2wQHTBBeTvj1zhrh1XyN0cASiif4B8qRES6eyEF+T2Hr3Jg==", null, false, "22687b89-4ad7-4694-8118-3bc7e6e16c7d", false, "user12" },
                    { "13", 0, "ed7d3955-c93f-48e1-b709-fc9dcf2833d4", "MetaUser", "user13@example.com", true, false, null, "USER13@EXAMPLE.COM", "USER13", "AQAAAAIAAYagAAAAEB1qbe8N92PuQfVNLyfOWnhdREuI63rb7K626drELwQwOHpmjhp8g3djCr0zcsDZDA==", null, false, "740d9e5b-d87c-4576-84a5-5c6d24592312", false, "user13" },
                    { "14", 0, "96aa92c6-fd81-4318-81ec-78a6affad82a", "MetaUser", "user14@example.com", true, false, null, "USER14@EXAMPLE.COM", "USER14", "AQAAAAIAAYagAAAAEKR7KaY6Iu+XtU+1ryrLhNQS96gFrSH1Pu0mF330nXJocYdPG5ulw6KIfzYzjlEFnw==", null, false, "df20f457-01ba-4418-80d1-ae7c3e34be84", false, "user14" },
                    { "15", 0, "f1f78637-a486-4a2b-9fa5-1ed0380da7ce", "MetaUser", "user15@example.com", true, false, null, "USER15@EXAMPLE.COM", "USER15", "AQAAAAIAAYagAAAAEJMTn076rOT1v1y/pS6dSWkkZ6NK83Wp0qRvAwekevIYucynfXcZn8MPvbhdTn98Dw==", null, false, "13b5b43d-ee82-4269-85b9-6aeb2144bd88", false, "user15" },
                    { "16", 0, "2d3c52e4-3d85-42b8-8b32-5717e06e9232", "MetaUser", "user16@example.com", true, false, null, "USER16@EXAMPLE.COM", "USER16", "AQAAAAIAAYagAAAAEAX/Fmt48dwotrkRz2f4KREAgEpJMgNcgeVwtrCoiadIO7UN30liturkSRMUf4n2bQ==", null, false, "93825ba3-0b47-4b52-a3ab-899f56915b4e", false, "user16" },
                    { "17", 0, "32262912-36d7-4e37-8c7a-83be6784692d", "MetaUser", "user17@example.com", true, false, null, "USER17@EXAMPLE.COM", "USER17", "AQAAAAIAAYagAAAAEHe0A/+fkuUpliXKzpCNLGlK2FIr+15areeMigZtv3J/b6ZhayrEpK3VGWYhlsRbuA==", null, false, "3cf29f63-c081-4ebb-8d5f-626f3e872996", false, "user17" },
                    { "18", 0, "e346eaf1-ffbb-4b53-86da-4fc49b1ce35c", "MetaUser", "user18@example.com", true, false, null, "USER18@EXAMPLE.COM", "USER18", "AQAAAAIAAYagAAAAEBRuJq0YHq8kmwrcZwBMDO5jDBL30beaG1NtTDD0Wrj72KKz4B2g8a+/oNoa2YyseA==", null, false, "d7cacd80-ed89-44dc-82d9-0c71fa02ece0", false, "user18" },
                    { "19", 0, "e2543d0d-98e1-4dcf-8b10-ca783d9180f9", "MetaUser", "user19@example.com", true, false, null, "USER19@EXAMPLE.COM", "USER19", "AQAAAAIAAYagAAAAEKqRJKJkWI6k0rjlF8ApKnoxhJR7IFy4AtnkTUXmS/Ixw56MOf2nKBNKFiR9ZSR5Eg==", null, false, "4688eeea-4b17-4f77-9275-8f9d268927bc", false, "user19" },
                    { "2", 0, "94f9b818-a8ca-4ca7-9927-9e53a65bf4e5", "MetaUser", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEDYnQPvdwLIe793MqSN+44r2h8xWvteqZ0DYOiaQDOJyxjSZLKkvKAOUVaswU2KfFg==", null, false, "d279ffcb-554f-43f1-a878-d767efc4cbf9", false, "user2" },
                    { "20", 0, "c12a1682-a9dd-4a1c-b386-5a3f493f9d50", "MetaUser", "user20@example.com", true, false, null, "USER20@EXAMPLE.COM", "USER20", "AQAAAAIAAYagAAAAEOUVYEWThS5tQ+PZNN2xyvAMY/DJnUjWzy8J/N2a8v4k24u3aEb5xghOAGD626Supg==", null, false, "fa263557-210d-4c83-b700-86a7d5dba0a6", false, "user20" },
                    { "3", 0, "6d9c8d8d-d142-415e-86c2-18ff49d1b7e0", "MetaUser", "user3@example.com", true, false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEBp1dIKfGfea4ycmov3OvV9KJzz0u41ZgertIMzYduBQgeLwoiMzyGk4U2QiEvcrgw==", null, false, "eaa45cdf-fc09-4e52-8baa-0cdf3481b986", false, "user3" },
                    { "4", 0, "771c3aa8-5931-4312-965b-4d49bf63f17e", "MetaUser", "user4@example.com", true, false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEAcRsYPRgjqHvmKVSs7IMeQrU4hpUMSVK/hu5A32jzLmRKhlcD75Fv3KYcNSN5B1Jg==", null, false, "4460f281-4a62-4f37-9ff5-1c2e4bb54abe", false, "user4" },
                    { "5", 0, "69026507-d376-4cbe-bb92-92f653837a8d", "MetaUser", "user5@example.com", true, false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEIG2oNiXaF85QqlwyoP+CIOOMV4d8JLwXexCEGB38IgTD0CXCUWjbTni0/qfoiN33w==", null, false, "60124a3d-dfa8-4e51-bfb5-f15759df64dd", false, "user5" },
                    { "6", 0, "49a8c069-ab84-40f9-880a-4c0d2a1e2f25", "MetaUser", "user6@example.com", true, false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAED7LaAhJoewra+jx+8XGaPfp0KWUGGp/X47CcaTqoS7aPHsIMZY8nTxeKtxwIrptrQ==", null, false, "8e3bb74b-368a-4fdf-9b9d-6c43fee7b406", false, "user6" },
                    { "7", 0, "2a0aefe6-717c-4e9a-a9e9-6239cadf889b", "MetaUser", "user7@example.com", true, false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAELVYu0dgOwOGttJynarWfP/UJOXkxpGlBzKe0pElFG7TKW41T3QgU0KiPG7QVdJ4Bw==", null, false, "8f86c170-2c87-46a1-bfb3-48f57efb9e2e", false, "user7" },
                    { "8", 0, "ceee90f0-2b42-4559-8414-10bd33f838a7", "MetaUser", "user8@example.com", true, false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEB9vi2iw+iBEO07KX0SkTkKkUXViu6SEBUxogjMrKB1df82XvnP9FUwWVcggvcy2Pw==", null, false, "70cc17a5-7020-49fe-8384-80fa32337ae2", false, "user8" },
                    { "9", 0, "c6471286-126a-4fba-b341-d5ce79a0ff61", "MetaUser", "user9@example.com", true, false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEDysjDkzNyZTyY7VyRnbEL54n/Qs1GlaLKmn5eyYphYMWCV8g4+KpXvNhoo7HAT44g==", null, false, "7ef88d03-0820-433e-a5e6-63c95c8f4338", false, "user9" }
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
                    { 1, "An action-adventure game developed and published by Nintendo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/zw47_q9wbBE\" title=\"The Legend of Zelda: Breath of the Wild - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6219), "1.jpg" },
                    { 2, "A platform game developed and published by Nintendo for the Nintendo Switch.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/5kcdRBHM7kM\" title=\"Super Mario Odyssey - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super Mario Odyssey", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6235), "2.webp" },
                    { 3, "An action-adventure game developed and published by Rockstar Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HVRzx17WHVk\" title=\"Red Dead Redemption 2 Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6237), "3.jpg" },
                    { 4, "An action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/Ty7WudwSKMA\" title=\"God of War: Ragnarok - Teaser Trailer | PS5 Showcase\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6239), "4.jpg" },
                    { 5, "An action role-playing game developed and published by CD Projekt.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/c0i88t0Kacs\" title=\"The Witcher 3: Wild Hunt - Killing Monsters Cinematic Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6242), "5.jpg" },
                    { 6, "An action role-playing game developed and published by CD Projekt.", "<iframe width=\"930\" height=\"388\" src=\"https://www.youtube.com/embed/P99qJGrPNLs\" title=\"Cyberpunk 2077 Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6244), "6.jpg" },
                    { 7, "A sandbox video game developed by Mojang.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/MmB9b5njVbA\" title=\"Official Minecraft Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6246), "7.jpg" },
                    { 8, "An online video game developed by Epic Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/hHTE5xg9E-g\" title=\"Fortnite Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6248), "8.png" },
                    { 9, "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/JSRtYpNRoN0\" title=\"The Elder Scrolls V: Skyrim - Official Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6249), "9.jpg" },
                    { 10, "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/u4-FCsiF5x4\" title=\"Horizon Zero Dawn - E3 2016 Trailer I PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Zero Dawn", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6251), "10.jpg" },
                    { 11, "An action role-playing game developed and published by Square Enix.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/CNM6o9um1dc\" title=\"FINAL FANTASY XV - Omen Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Fantasy XV", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6253), "11.jpg" },
                    { 12, "A role-playing video game developed by Atlus.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/QnDzJ9KzuV4\" title=\"Persona 5 | Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persona 5", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6255), "12.png" },
                    { 13, "An action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cWBwFhUv1-8\" title=\"Dark Souls III – Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Souls III", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6256), "13.jpg" },
                    { 14, "An action role-playing game developed by FromSoftware and published by Sony Computer Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/G203e1HhixY\" title=\"Bloodborne Debut Trailer | Face Your Fears | PlayStation 4 Action RPG\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2015, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloodborne", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6258), "14.jpg" },
                    { 15, "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/IBIwGKDwnWY\" title=\"Overwatch Theatrical Teaser | &quot;We Are Overwatch&quot;\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6260), "15.jpg" },
                    { 16, "An action-adventure game developed by FromSoftware and published by Activision.", "", new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekiro: Shadows Die Twice", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6262), "16.jpg" },
                    { 17, "An action role-playing game developed by Team Ninja and published by Koei Tecmo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cHTtNdkDduQ\" title=\"Nioh 2 Reveal Teaser Trailer - E3 2018\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nioh", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6264), "17.jpg" },
                    { 18, "An action role-playing game developed and published by Capcom.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monster Hunter: World", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6265), "18.png" },
                    { 19, "A survival horror game developed and published by Capcom.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 2", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6267), "19.jpg" },
                    { 20, "An action-adventure game developed by Sucker Punch Productions and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/RcWk08PBe7k\" title=\"Ghost of Tsushima - A Storm is Coming Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost of Tsushima", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6269), "20.jpg" },
                    { 21, "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.", "<iframe width=\"930\" height=\"390\" src=\"https://www.youtube.com/embed/rKjUAWlbTJk\" title=\"Assassin’s Creed Valhalla: Cinematic World Premiere Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6270), "21.jpg" },
                    { 22, "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/W2Wnvvj33Wo\" title=\"The Last of Us Part II - PlayStation Experience 2016: Reveal Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6272), "22.jpg" },
                    { 23, "An action-adventure game developed by Remedy Entertainment and published by 505 Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/w6bE11FrSFM\" title=\"Control - Ultimate Edition Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6274), "23.jpg" },
                    { 24, "A roguelike action dungeon crawler video game developed and published by Supergiant Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/91t0ha9x0AE\" title=\"Hades - Official Animated Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hades", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6275), "24.png" },
                    { 25, "A first-person shooter game developed by id Software and published by Bethesda Softworks.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/_oVwrpfo_QA\" title=\"DOOM Eternal – Official E3 Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doom Eternal", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6277), "25.jpg" },
                    { 26, "An action role-playing game developed and published by miHoYo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HLUY1nICQRY\" title=\"Genshin Impact - Official Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genshin Impact", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6279), "26.jpg" },
                    { 27, "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/H2Hy96sOnq8\" title=\"Death Stranding - Teaser Trailer - TGA 2016 - 4K\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Stranding", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6285), "27.jpg" },
                    { 28, "An action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/q4GdJVvdxss\" title=\"Marvel’s Spider-Man – Be Greater Extended Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6287), "28.jpg" },
                    { 29, "A virtual reality first-person shooter developed and published by Valve.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/O2W0N3uKXmo\" title=\"Half-Life: Alyx Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life: Alyx", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6289), "29.webp" },
                    { 30, "An action role-playing game developed and published by TaleWorlds Entertainment. Bannerlord is a prequel to Mount & Blade: Warband, a stand-alone expansion pack for the 2008 game Mount & Blade.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/yCk6Jk7DvrA\" title=\"Mount &amp; Blade II: Bannerlord Early Access Announcement\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mount and Blade II: Bannerlord", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6299), "30.jpg" },
                    { 31, "Explore the depths of Arkham Asylum as Batman, unraveling a sinister plot orchestrated by his arch-nemesis, the Joker.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/bVk9jW9EzD0\" title=\"Batman: Arkham Asylum Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2009, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Asylum", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6316), "31.jpg" },
                    { 32, "Gotham City is transformed into a sprawling prison, and Batman must navigate its dangerous streets to uncover a new threat.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/pcaFdTCiz4U\" title=\"Batman: Arkham City - Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham City", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6317), "32.jpg" },
                    { 33, "The Dark Knight faces the ultimate threat to Gotham City as the Scarecrow unites Batman's foes to destroy him once and for all.", "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/wsf78BS9VE0\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>\r\n", new DateTime(2015, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Knight", new DateTime(2024, 8, 10, 17, 7, 0, 125, DateTimeKind.Local).AddTicks(6319), "33.jpg" }
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
                table: "UserReviews",
                columns: new[] { "ItemId", "UserId", "Comment", "Id", "UserRating" },
                values: new object[,]
                {
                    { 1, "1", "I didn't like this game much.", 9, 66 },
                    { 1, "10", "Loved the graphics and storyline.", 11, 14 },
                    { 1, "12", "Gameplay was not very engaging.", 3, 71 },
                    { 1, "14", "Quite boring and repetitive.", 6, 21 },
                    { 1, "15", "Disappointing, had high expectations.", 7, 34 },
                    { 1, "17", "Average game, nothing special.", 10, 12 },
                    { 1, "2", "I didn't like this game much.", 4, 78 },
                    { 1, "4", "Loved the graphics and storyline.", 12, 61 },
                    { 1, "6", "Not bad, could be better.", 8, 50 },
                    { 1, "9", "Great game, really enjoyed it!", 5, 77 },
                    { 2, "12", "Not bad, could be better.", 15, 79 },
                    { 2, "14", "Loved the graphics and storyline.", 7, 55 },
                    { 2, "15", "Not bad, could be better.", 13, 82 },
                    { 2, "17", "Loved the graphics and storyline.", 6, 51 },
                    { 2, "2", "Great game, really enjoyed it!", 9, 78 },
                    { 2, "3", "Fantastic experience, highly recommend!", 10, 73 },
                    { 2, "4", "Loved the graphics and storyline.", 12, 37 },
                    { 2, "5", "Fantastic experience, highly recommend!", 8, 11 },
                    { 2, "7", "Quite boring and repetitive.", 14, 26 },
                    { 2, "8", "Average game, nothing special.", 11, 59 },
                    { 3, "1", "Quite boring and repetitive.", 16, 57 },
                    { 3, "13", "Quite boring and repetitive.", 10, 88 },
                    { 3, "15", "Gameplay was not very engaging.", 13, 58 },
                    { 3, "16", "Loved the graphics and storyline.", 9, 30 },
                    { 3, "17", "Loved the graphics and storyline.", 18, 31 },
                    { 3, "2", "Fantastic experience, highly recommend!", 12, 65 },
                    { 3, "20", "Not bad, could be better.", 11, 69 },
                    { 3, "3", "I didn't like this game much.", 15, 73 },
                    { 3, "4", "I didn't like this game much.", 14, 6 },
                    { 3, "8", "Great game, really enjoyed it!", 17, 3 },
                    { 4, "10", "Quite boring and repetitive.", 20, 28 },
                    { 4, "13", "A must-play for all gamers!", 19, 41 },
                    { 4, "14", "Quite boring and repetitive.", 17, 25 },
                    { 4, "15", "I didn't like this game much.", 12, 83 },
                    { 4, "16", "Loved the graphics and storyline.", 16, 39 },
                    { 4, "18", "Loved the graphics and storyline.", 13, 19 },
                    { 4, "19", "Loved the graphics and storyline.", 14, 69 },
                    { 4, "2", "I didn't like this game much.", 15, 73 },
                    { 4, "20", "Gameplay was not very engaging.", 21, 14 },
                    { 4, "9", "Great game, really enjoyed it!", 18, 22 },
                    { 5, "10", "Fantastic experience, highly recommend!", 23, 21 },
                    { 5, "11", "Quite boring and repetitive.", 15, 95 },
                    { 5, "13", "A must-play for all gamers!", 18, 51 },
                    { 5, "14", "Gameplay was not very engaging.", 20, 22 },
                    { 5, "15", "Disappointing, had high expectations.", 17, 10 },
                    { 5, "16", "Disappointing, had high expectations.", 21, 67 },
                    { 5, "17", "Disappointing, had high expectations.", 19, 45 },
                    { 5, "20", "Disappointing, had high expectations.", 22, 68 },
                    { 5, "7", "Fantastic experience, highly recommend!", 24, 12 },
                    { 5, "9", "Disappointing, had high expectations.", 16, 18 },
                    { 6, "11", "A must-play for all gamers!", 21, 12 },
                    { 6, "12", "Not bad, could be better.", 25, 70 },
                    { 6, "14", "Gameplay was not very engaging.", 24, 36 },
                    { 6, "16", "A must-play for all gamers!", 26, 52 },
                    { 6, "18", "Not bad, could be better.", 18, 83 },
                    { 6, "2", "Fantastic experience, highly recommend!", 23, 85 },
                    { 6, "4", "Not bad, could be better.", 19, 35 },
                    { 6, "6", "Average game, nothing special.", 20, 31 },
                    { 6, "7", "Great game, really enjoyed it!", 22, 67 },
                    { 6, "8", "I didn't like this game much.", 27, 81 },
                    { 7, "1", "Gameplay was not very engaging.", 29, 88 },
                    { 7, "10", "Average game, nothing special.", 25, 62 },
                    { 7, "11", "Gameplay was not very engaging.", 22, 30 },
                    { 7, "12", "I didn't like this game much.", 27, 48 },
                    { 7, "15", "Not bad, could be better.", 24, 7 },
                    { 7, "17", "I didn't like this game much.", 23, 74 },
                    { 7, "18", "A must-play for all gamers!", 28, 14 },
                    { 7, "2", "Average game, nothing special.", 30, 55 },
                    { 7, "20", "Average game, nothing special.", 21, 63 },
                    { 7, "5", "A must-play for all gamers!", 26, 7 },
                    { 8, "1", "Fantastic experience, highly recommend!", 32, 100 },
                    { 8, "11", "Quite boring and repetitive.", 28, 79 },
                    { 8, "13", "Fantastic experience, highly recommend!", 26, 58 },
                    { 8, "15", "I didn't like this game much.", 33, 68 },
                    { 8, "17", "Disappointing, had high expectations.", 30, 75 },
                    { 8, "18", "Gameplay was not very engaging.", 25, 48 },
                    { 8, "2", "Fantastic experience, highly recommend!", 31, 72 },
                    { 8, "20", "Fantastic experience, highly recommend!", 24, 61 },
                    { 8, "6", "Not bad, could be better.", 27, 9 },
                    { 8, "8", "Disappointing, had high expectations.", 29, 90 },
                    { 9, "10", "Disappointing, had high expectations.", 31, 16 },
                    { 9, "13", "Great game, really enjoyed it!", 32, 8 },
                    { 9, "15", "Loved the graphics and storyline.", 28, 89 },
                    { 9, "16", "Average game, nothing special.", 34, 36 },
                    { 9, "19", "Average game, nothing special.", 30, 72 },
                    { 9, "2", "Gameplay was not very engaging.", 27, 49 },
                    { 9, "20", "Great game, really enjoyed it!", 36, 44 },
                    { 9, "4", "Great game, really enjoyed it!", 33, 80 },
                    { 9, "8", "Fantastic experience, highly recommend!", 35, 28 },
                    { 9, "9", "Not bad, could be better.", 29, 34 },
                    { 10, "13", "I didn't like this game much.", 31, 59 },
                    { 10, "14", "Quite boring and repetitive.", 39, 48 },
                    { 10, "15", "Not bad, could be better.", 32, 50 },
                    { 10, "19", "A must-play for all gamers!", 30, 40 },
                    { 10, "2", "I didn't like this game much.", 35, 87 },
                    { 10, "3", "A must-play for all gamers!", 38, 67 },
                    { 10, "4", "Quite boring and repetitive.", 33, 88 },
                    { 10, "6", "Loved the graphics and storyline.", 36, 40 },
                    { 10, "7", "Average game, nothing special.", 34, 9 },
                    { 10, "9", "Quite boring and repetitive.", 37, 56 },
                    { 11, "10", "Loved the graphics and storyline.", 38, 21 },
                    { 11, "14", "Great game, really enjoyed it!", 35, 72 },
                    { 11, "15", "Quite boring and repetitive.", 37, 42 },
                    { 11, "17", "Gameplay was not very engaging.", 40, 94 },
                    { 11, "19", "Quite boring and repetitive.", 34, 33 },
                    { 11, "2", "I didn't like this game much.", 39, 11 },
                    { 11, "3", "Loved the graphics and storyline.", 42, 69 },
                    { 11, "4", "Fantastic experience, highly recommend!", 41, 88 },
                    { 11, "5", "I didn't like this game much.", 33, 90 },
                    { 11, "7", "A must-play for all gamers!", 36, 44 },
                    { 12, "1", "Disappointing, had high expectations.", 37, 100 },
                    { 12, "12", "Disappointing, had high expectations.", 36, 8 },
                    { 12, "13", "I didn't like this game much.", 42, 22 },
                    { 12, "18", "Fantastic experience, highly recommend!", 43, 41 },
                    { 12, "19", "Average game, nothing special.", 39, 20 },
                    { 12, "2", "Fantastic experience, highly recommend!", 45, 38 },
                    { 12, "3", "Disappointing, had high expectations.", 38, 37 },
                    { 12, "5", "Great game, really enjoyed it!", 41, 44 },
                    { 12, "6", "Quite boring and repetitive.", 40, 31 },
                    { 12, "8", "Gameplay was not very engaging.", 44, 51 },
                    { 13, "1", "Quite boring and repetitive.", 40, 71 },
                    { 13, "10", "Disappointing, had high expectations.", 41, 32 },
                    { 13, "11", "I didn't like this game much.", 43, 22 },
                    { 13, "14", "Not bad, could be better.", 48, 87 },
                    { 13, "17", "Not bad, could be better.", 42, 38 },
                    { 13, "19", "Gameplay was not very engaging.", 47, 87 },
                    { 13, "3", "Quite boring and repetitive.", 44, 23 },
                    { 13, "4", "Fantastic experience, highly recommend!", 39, 35 },
                    { 13, "5", "A must-play for all gamers!", 45, 62 },
                    { 13, "8", "A must-play for all gamers!", 46, 88 },
                    { 14, "1", "A must-play for all gamers!", 47, 13 },
                    { 14, "10", "A must-play for all gamers!", 43, 14 },
                    { 14, "12", "Not bad, could be better.", 46, 69 },
                    { 14, "13", "Quite boring and repetitive.", 42, 46 },
                    { 14, "17", "Loved the graphics and storyline.", 51, 33 },
                    { 14, "18", "Average game, nothing special.", 48, 28 },
                    { 14, "2", "Average game, nothing special.", 49, 54 },
                    { 14, "4", "Not bad, could be better.", 44, 66 },
                    { 14, "6", "A must-play for all gamers!", 45, 51 },
                    { 14, "9", "Average game, nothing special.", 50, 19 },
                    { 15, "1", "Fantastic experience, highly recommend!", 51, 55 },
                    { 15, "11", "Gameplay was not very engaging.", 52, 93 },
                    { 15, "12", "Great game, really enjoyed it!", 45, 35 },
                    { 15, "14", "Fantastic experience, highly recommend!", 53, 97 },
                    { 15, "15", "Disappointing, had high expectations.", 48, 37 },
                    { 15, "17", "Loved the graphics and storyline.", 46, 86 },
                    { 15, "18", "Disappointing, had high expectations.", 49, 56 },
                    { 15, "3", "I didn't like this game much.", 47, 10 },
                    { 15, "7", "Great game, really enjoyed it!", 54, 16 },
                    { 15, "9", "Quite boring and repetitive.", 50, 86 },
                    { 16, "1", "Fantastic experience, highly recommend!", 49, 72 },
                    { 16, "11", "Not bad, could be better.", 55, 53 },
                    { 16, "13", "Not bad, could be better.", 52, 13 },
                    { 16, "17", "Great game, really enjoyed it!", 56, 15 },
                    { 16, "18", "A must-play for all gamers!", 53, 54 },
                    { 16, "19", "Fantastic experience, highly recommend!", 50, 97 },
                    { 16, "3", "Average game, nothing special.", 51, 99 },
                    { 16, "5", "Average game, nothing special.", 57, 24 },
                    { 16, "6", "Gameplay was not very engaging.", 48, 49 },
                    { 16, "8", "Great game, really enjoyed it!", 54, 12 },
                    { 17, "1", "Quite boring and repetitive.", 55, 44 },
                    { 17, "13", "A must-play for all gamers!", 57, 37 },
                    { 17, "2", "Fantastic experience, highly recommend!", 59, 42 },
                    { 17, "3", "I didn't like this game much.", 60, 67 },
                    { 17, "4", "A must-play for all gamers!", 58, 33 },
                    { 17, "5", "Fantastic experience, highly recommend!", 52, 57 },
                    { 17, "6", "Great game, really enjoyed it!", 51, 20 },
                    { 17, "7", "Fantastic experience, highly recommend!", 56, 11 },
                    { 17, "8", "I didn't like this game much.", 54, 10 },
                    { 17, "9", "Loved the graphics and storyline.", 53, 44 },
                    { 18, "1", "Disappointing, had high expectations.", 56, 16 },
                    { 18, "10", "Gameplay was not very engaging.", 57, 55 },
                    { 18, "11", "Not bad, could be better.", 54, 17 },
                    { 18, "13", "Disappointing, had high expectations.", 62, 68 },
                    { 18, "19", "A must-play for all gamers!", 63, 79 },
                    { 18, "20", "Quite boring and repetitive.", 55, 61 },
                    { 18, "4", "Disappointing, had high expectations.", 58, 34 },
                    { 18, "5", "A must-play for all gamers!", 61, 44 },
                    { 18, "7", "Average game, nothing special.", 59, 5 },
                    { 18, "8", "Gameplay was not very engaging.", 60, 10 },
                    { 19, "1", "Gameplay was not very engaging.", 65, 16 },
                    { 19, "10", "Not bad, could be better.", 64, 37 },
                    { 19, "13", "A must-play for all gamers!", 59, 97 },
                    { 19, "14", "Fantastic experience, highly recommend!", 66, 64 },
                    { 19, "16", "Loved the graphics and storyline.", 60, 83 },
                    { 19, "17", "Gameplay was not very engaging.", 61, 96 },
                    { 19, "19", "A must-play for all gamers!", 62, 17 },
                    { 19, "2", "Quite boring and repetitive.", 57, 97 },
                    { 19, "5", "Disappointing, had high expectations.", 58, 7 },
                    { 19, "8", "Loved the graphics and storyline.", 63, 90 },
                    { 20, "1", "Fantastic experience, highly recommend!", 61, 21 },
                    { 20, "10", "Quite boring and repetitive.", 66, 84 },
                    { 20, "13", "A must-play for all gamers!", 69, 100 },
                    { 20, "16", "Disappointing, had high expectations.", 63, 100 },
                    { 20, "17", "Not bad, could be better.", 65, 21 },
                    { 20, "19", "Great game, really enjoyed it!", 62, 97 },
                    { 20, "20", "Gameplay was not very engaging.", 67, 44 },
                    { 20, "5", "Average game, nothing special.", 68, 52 },
                    { 20, "8", "A must-play for all gamers!", 60, 65 },
                    { 20, "9", "I didn't like this game much.", 64, 68 },
                    { 21, "10", "Quite boring and repetitive.", 64, 60 },
                    { 21, "12", "Quite boring and repetitive.", 63, 98 },
                    { 21, "14", "Loved the graphics and storyline.", 70, 98 },
                    { 21, "15", "Disappointing, had high expectations.", 72, 1 },
                    { 21, "17", "Great game, really enjoyed it!", 67, 8 },
                    { 21, "18", "A must-play for all gamers!", 71, 2 },
                    { 21, "19", "Great game, really enjoyed it!", 68, 43 },
                    { 21, "2", "Average game, nothing special.", 66, 69 },
                    { 21, "3", "Fantastic experience, highly recommend!", 65, 11 },
                    { 21, "5", "Not bad, could be better.", 69, 44 },
                    { 22, "1", "Quite boring and repetitive.", 75, 93 },
                    { 22, "10", "I didn't like this game much.", 73, 86 },
                    { 22, "13", "Average game, nothing special.", 70, 37 },
                    { 22, "19", "Quite boring and repetitive.", 74, 64 },
                    { 22, "2", "I didn't like this game much.", 71, 10 },
                    { 22, "3", "Not bad, could be better.", 66, 69 },
                    { 22, "5", "I didn't like this game much.", 67, 94 },
                    { 22, "6", "Quite boring and repetitive.", 69, 6 },
                    { 22, "7", "Great game, really enjoyed it!", 68, 21 },
                    { 22, "9", "I didn't like this game much.", 72, 44 },
                    { 23, "11", "Gameplay was not very engaging.", 73, 97 },
                    { 23, "12", "Quite boring and repetitive.", 74, 73 },
                    { 23, "13", "Not bad, could be better.", 70, 51 },
                    { 23, "14", "I didn't like this game much.", 78, 95 },
                    { 23, "18", "A must-play for all gamers!", 72, 51 },
                    { 23, "19", "A must-play for all gamers!", 77, 85 },
                    { 23, "20", "I didn't like this game much.", 69, 87 },
                    { 23, "4", "Average game, nothing special.", 75, 34 },
                    { 23, "7", "Disappointing, had high expectations.", 76, 26 },
                    { 23, "8", "Loved the graphics and storyline.", 71, 32 },
                    { 24, "10", "Not bad, could be better.", 72, 14 },
                    { 24, "11", "Quite boring and repetitive.", 81, 16 },
                    { 24, "13", "Great game, really enjoyed it!", 75, 44 },
                    { 24, "17", "Gameplay was not very engaging.", 80, 14 },
                    { 24, "2", "Loved the graphics and storyline.", 79, 40 },
                    { 24, "4", "Loved the graphics and storyline.", 74, 24 },
                    { 24, "5", "Great game, really enjoyed it!", 78, 40 },
                    { 24, "7", "A must-play for all gamers!", 76, 18 },
                    { 24, "8", "Quite boring and repetitive.", 77, 20 },
                    { 24, "9", "I didn't like this game much.", 73, 24 },
                    { 25, "1", "I didn't like this game much.", 84, 51 },
                    { 25, "10", "Fantastic experience, highly recommend!", 79, 45 },
                    { 25, "12", "A must-play for all gamers!", 80, 40 },
                    { 25, "13", "Loved the graphics and storyline.", 83, 10 },
                    { 25, "14", "Quite boring and repetitive.", 81, 62 },
                    { 25, "18", "A must-play for all gamers!", 78, 83 },
                    { 25, "20", "Disappointing, had high expectations.", 76, 9 },
                    { 25, "5", "Disappointing, had high expectations.", 75, 44 },
                    { 25, "6", "Fantastic experience, highly recommend!", 77, 19 },
                    { 25, "8", "Quite boring and repetitive.", 82, 82 },
                    { 26, "11", "I didn't like this game much.", 80, 72 },
                    { 26, "12", "Gameplay was not very engaging.", 85, 15 },
                    { 26, "13", "Average game, nothing special.", 84, 40 },
                    { 26, "14", "Disappointing, had high expectations.", 86, 55 },
                    { 26, "15", "Quite boring and repetitive.", 87, 55 },
                    { 26, "16", "Loved the graphics and storyline.", 78, 76 },
                    { 26, "18", "Average game, nothing special.", 82, 39 },
                    { 26, "20", "Average game, nothing special.", 79, 7 },
                    { 26, "8", "Gameplay was not very engaging.", 83, 76 },
                    { 26, "9", "Great game, really enjoyed it!", 81, 54 },
                    { 27, "11", "I didn't like this game much.", 83, 85 },
                    { 27, "12", "I didn't like this game much.", 84, 40 },
                    { 27, "15", "Fantastic experience, highly recommend!", 90, 85 },
                    { 27, "17", "Gameplay was not very engaging.", 87, 14 },
                    { 27, "19", "Great game, really enjoyed it!", 85, 53 },
                    { 27, "2", "Loved the graphics and storyline.", 82, 46 },
                    { 27, "20", "Quite boring and repetitive.", 89, 91 },
                    { 27, "3", "Disappointing, had high expectations.", 88, 71 },
                    { 27, "6", "Fantastic experience, highly recommend!", 86, 5 },
                    { 27, "7", "Not bad, could be better.", 81, 71 },
                    { 28, "1", "Gameplay was not very engaging.", 91, 36 },
                    { 28, "10", "Disappointing, had high expectations.", 87, 19 },
                    { 28, "12", "I didn't like this game much.", 93, 31 },
                    { 28, "14", "A must-play for all gamers!", 90, 27 },
                    { 28, "15", "Loved the graphics and storyline.", 85, 80 },
                    { 28, "16", "Gameplay was not very engaging.", 89, 17 },
                    { 28, "4", "Disappointing, had high expectations.", 84, 50 },
                    { 28, "7", "Great game, really enjoyed it!", 86, 73 },
                    { 28, "8", "A must-play for all gamers!", 92, 10 },
                    { 28, "9", "Fantastic experience, highly recommend!", 88, 33 },
                    { 29, "10", "Disappointing, had high expectations.", 94, 77 },
                    { 29, "11", "I didn't like this game much.", 91, 78 },
                    { 29, "12", "Average game, nothing special.", 93, 77 },
                    { 29, "14", "Fantastic experience, highly recommend!", 92, 25 },
                    { 29, "15", "I didn't like this game much.", 90, 56 },
                    { 29, "18", "Quite boring and repetitive.", 96, 72 },
                    { 29, "19", "Average game, nothing special.", 89, 74 },
                    { 29, "4", "Quite boring and repetitive.", 88, 71 },
                    { 29, "5", "Average game, nothing special.", 87, 31 },
                    { 29, "7", "A must-play for all gamers!", 95, 10 },
                    { 30, "11", "Disappointing, had high expectations.", 95, 42 },
                    { 30, "12", "Fantastic experience, highly recommend!", 94, 100 },
                    { 30, "15", "Gameplay was not very engaging.", 96, 16 },
                    { 30, "16", "Quite boring and repetitive.", 90, 85 },
                    { 30, "17", "Gameplay was not very engaging.", 99, 50 },
                    { 30, "18", "A must-play for all gamers!", 91, 96 },
                    { 30, "2", "Fantastic experience, highly recommend!", 93, 98 },
                    { 30, "20", "Gameplay was not very engaging.", 92, 54 },
                    { 30, "6", "Loved the graphics and storyline.", 97, 1 },
                    { 30, "9", "Disappointing, had high expectations.", 98, 59 },
                    { 31, "10", "Great game, really enjoyed it!", 99, 96 },
                    { 31, "11", "I didn't like this game much.", 101, 96 },
                    { 31, "12", "Average game, nothing special.", 95, 95 },
                    { 31, "14", "Great game, really enjoyed it!", 93, 82 },
                    { 31, "17", "Quite boring and repetitive.", 96, 49 },
                    { 31, "18", "Fantastic experience, highly recommend!", 94, 34 },
                    { 31, "19", "A must-play for all gamers!", 98, 59 },
                    { 31, "20", "Loved the graphics and storyline.", 100, 4 },
                    { 31, "7", "Not bad, could be better.", 102, 98 },
                    { 31, "8", "Loved the graphics and storyline.", 97, 78 },
                    { 32, "1", "Not bad, could be better.", 101, 16 },
                    { 32, "10", "A must-play for all gamers!", 99, 61 },
                    { 32, "14", "Loved the graphics and storyline.", 100, 87 },
                    { 32, "15", "I didn't like this game much.", 96, 18 },
                    { 32, "18", "Gameplay was not very engaging.", 105, 63 },
                    { 32, "3", "Gameplay was not very engaging.", 102, 61 },
                    { 32, "4", "Fantastic experience, highly recommend!", 104, 47 },
                    { 32, "5", "Average game, nothing special.", 103, 88 },
                    { 32, "6", "A must-play for all gamers!", 97, 64 },
                    { 32, "7", "Great game, really enjoyed it!", 98, 25 },
                    { 33, "12", "Not bad, could be better.", 107, 100 },
                    { 33, "13", "Quite boring and repetitive.", 99, 95 },
                    { 33, "14", "Loved the graphics and storyline.", 102, 47 },
                    { 33, "15", "I didn't like this game much.", 100, 80 },
                    { 33, "18", "Quite boring and repetitive.", 106, 28 },
                    { 33, "2", "Quite boring and repetitive.", 104, 58 },
                    { 33, "20", "Quite boring and repetitive.", 105, 41 },
                    { 33, "6", "Disappointing, had high expectations.", 103, 11 },
                    { 33, "7", "Fantastic experience, highly recommend!", 108, 71 },
                    { 33, "8", "Gameplay was not very engaging.", 101, 79 }
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
