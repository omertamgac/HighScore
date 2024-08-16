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
                    { "0", 0, "eaddb985-e89e-494b-a0f4-82cd10e6efec", "MetaUser", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEB/bgprLtcT40VsvGJG2YolowUKPfGKjS0RTyDFSTDdEEbra7MthLbRcwurWj9P26w==", "555-666-777", false, "9289d637-eb04-4820-ad5b-fb79e07041ed", false, "admin" },
                    { "1", 0, "bd938061-1dc7-4783-8db3-d7631eb340ed", "MetaUser", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEA1lMTmkCZTamNzL3JAIduqp/arBZZUFmeyQ3ot2i95WEnikCJSIjfDHgmcxu1XvQw==", null, false, "9d379af5-22bc-42e1-84de-24018f229ae5", false, "user1" },
                    { "10", 0, "1df8ccfc-8e9b-4663-880e-70be8f6082cc", "MetaUser", "user10@example.com", true, false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEBJ78z2ZjdC0S+AZIsKsYe+WemxKzB6H1TBSZFpk93/J3FXGzBZopwsKUOxK4kRbfA==", null, false, "accb21ae-168c-4c3e-a788-cbffb6a50ee9", false, "user10" },
                    { "11", 0, "6a57d64d-fae3-48c8-a71d-fa030623edc7", "MetaUser", "user11@example.com", true, false, null, "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEOrsqC1dEDgAJJRYJ889IOVREusHfRRpLE5xcFC/ct/VdAXrugQSObE17xtWZYgjBQ==", null, false, "b55d4a4c-a32c-4cfc-b766-45797ba92231", false, "user11" },
                    { "12", 0, "1014d575-1431-4337-83f3-47820b0dc5ca", "MetaUser", "user12@example.com", true, false, null, "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEDrzEPOBtsViaESDH+3/T7GcVlgReu/RDZzQwD6yc88I79VhqFLPdgsmbb777+k9tw==", null, false, "a02c87e4-a0a2-437d-b028-f8171ae9cd84", false, "user12" },
                    { "13", 0, "a0b233f7-cec2-4288-b4be-2934f2ab82ba", "MetaUser", "user13@example.com", true, false, null, "USER13@EXAMPLE.COM", "USER13", "AQAAAAIAAYagAAAAEJV6zScOZxJJ8GhvXpKDpFPJ7a4+EowFDHTtKibajfS+IzHgAo+5GBRE8vtlLhjNbQ==", null, false, "15c0a13a-b9f4-4ce9-8076-3b8137dd7b1e", false, "user13" },
                    { "14", 0, "820bd8a1-0014-49b6-8fc6-2f361492e2f1", "MetaUser", "user14@example.com", true, false, null, "USER14@EXAMPLE.COM", "USER14", "AQAAAAIAAYagAAAAEHRLeWAcAVXm4nbj0Hdaf2BGet2DRRiyvn7Rw2aGul1prYgBVJnA1fvZVtJ3IkwALw==", null, false, "a611a203-2884-4a05-bc41-89a3f4283e8a", false, "user14" },
                    { "15", 0, "470a3a28-eec3-4cbb-b19e-9edd52df7fa6", "MetaUser", "user15@example.com", true, false, null, "USER15@EXAMPLE.COM", "USER15", "AQAAAAIAAYagAAAAEHodoQs+DusFyI+oLjbYICZCiTP6fiWuPrxTHgCLiitVqk2z3Ni9luNxndD6TmUn7w==", null, false, "9e78690b-4380-4b7d-a816-a09e249d8102", false, "user15" },
                    { "16", 0, "4da813cb-dcc8-42a2-b59f-3ddfb004ac7e", "MetaUser", "user16@example.com", true, false, null, "USER16@EXAMPLE.COM", "USER16", "AQAAAAIAAYagAAAAEEU4neqZxhTyxCZfQ4AGCkSpoU5hC1J9Dnk8Z/taFzBoGYFAIwdqBIp7dVDCV1sSsw==", null, false, "921cf370-4443-41e3-bf15-2701d925e53b", false, "user16" },
                    { "17", 0, "73d4516e-84ff-4095-9845-e9db7af2dabd", "MetaUser", "user17@example.com", true, false, null, "USER17@EXAMPLE.COM", "USER17", "AQAAAAIAAYagAAAAEN5wsLsoc3ofJAJ7oeKy4WE7xEe06yqaMdZcmHBWN77TvCiEumWzAhRzA4qPAYt7oA==", null, false, "780cfcf1-ba13-4d3e-a185-e20ed54aa6a3", false, "user17" },
                    { "18", 0, "2fe83a43-ad98-488a-ae52-818987d0274b", "MetaUser", "user18@example.com", true, false, null, "USER18@EXAMPLE.COM", "USER18", "AQAAAAIAAYagAAAAEI+R08jyOo3AGSP1BQgIt5+ol0rD1+tGb6HEIkqgJfHdWYW2ar+utDuwgeASYZ20yg==", null, false, "a32fe284-f26d-44fd-8c0a-68834f235d51", false, "user18" },
                    { "19", 0, "b314aa3a-9cc6-473b-b695-6dc101ffee49", "MetaUser", "user19@example.com", true, false, null, "USER19@EXAMPLE.COM", "USER19", "AQAAAAIAAYagAAAAEKB0lOwgvr5wdINFTr8ZPQHwVnjXPCVKpBKkDroF7eADhCayWkpqzo8Dgjx09hbyLQ==", null, false, "90b08e87-dd68-4858-a761-091d65c4542c", false, "user19" },
                    { "2", 0, "c91153b3-2d51-4462-baf2-9ec00642cd8d", "MetaUser", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEHySCOvToEiaxS2yzJwRO3AiYbUlBNCRffSBKgrlrt8AKIgA/91kKjbk66mG9KLQdw==", null, false, "cee04769-cf02-4972-a04b-9c6d7b5b1616", false, "user2" },
                    { "20", 0, "4d64e494-ff25-4f6f-b5d7-c6325f3159d3", "MetaUser", "user20@example.com", true, false, null, "USER20@EXAMPLE.COM", "USER20", "AQAAAAIAAYagAAAAEOcQ0PpcZXspElZwcZUvCxTS3afDOQpUlwSjtBUGo2QU6iMkhp/1qVmIkM7AP+Yk9g==", null, false, "5950e9c7-ff3d-42a0-9ba4-435001a14809", false, "user20" },
                    { "3", 0, "77f4893d-da78-4331-b518-411dd8cc01f1", "MetaUser", "user3@example.com", true, false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEFIqYo+Af3uSpQS4OwQKMfZ0hr+rgytWiWJXql9UJgEBbAq0e2v1Csc6J8xFYmyR5A==", null, false, "e3a13480-1c59-47c3-9720-d85e85f185a8", false, "user3" },
                    { "4", 0, "749ebb8d-a6d4-4931-b372-f598a6fe5d75", "MetaUser", "user4@example.com", true, false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEGIFIhuiDt+3Yh6/JG2ji+NKYb6JS88hPZL24n/y9bIsQDSoQnHXQO26hzKZL1OWBg==", null, false, "6ccb215c-6a57-4625-8258-719899bbba95", false, "user4" },
                    { "5", 0, "0c8de7a7-e810-40a2-bb9d-254e71791ad6", "MetaUser", "user5@example.com", true, false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEBZbUPT6IYkMsG+c6DO16V54Qfoa3BFkM2yxbOpTk+4/AF6GX9Tb0hhe3/TLReMHQA==", null, false, "848c5c55-d9f4-4560-a550-dbefc2ce4926", false, "user5" },
                    { "6", 0, "0ad9e5f1-9c14-42e8-a654-85695412e0c4", "MetaUser", "user6@example.com", true, false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEJNA3Imw9sh/fge5Iv9NP70kISCWoUGvl4a0z/Ns6ZQ6LhyGnrZVZWfTYN/Fi45U2A==", null, false, "781c68a3-eea0-413f-97b5-23df82ab93b8", false, "user6" },
                    { "7", 0, "85693176-f7eb-4357-8eeb-4b42693e7bef", "MetaUser", "user7@example.com", true, false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEMSN1ghEYzmqAOqrQBDyhDP1pJl+vfctAsLRIQER0B/kmtzoEQQ+GzQyO9XD2MjV2Q==", null, false, "0972ec44-1fbe-4a00-9bdb-6f9528261a5f", false, "user7" },
                    { "8", 0, "a08bba82-3d00-4b79-9803-7cb847923030", "MetaUser", "user8@example.com", true, false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEI4TYKmc6Iff0ocx304JSKT/MyAYerFZAebRgRazIWbmQNZOX80qDgrsHWRp9YFg8A==", null, false, "b69ca8b9-0635-4360-b999-805bf10e2e2b", false, "user8" },
                    { "9", 0, "47b62ea9-11e2-43cc-980f-eca704850857", "MetaUser", "user9@example.com", true, false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEP7zA57h9oEUrcnDY9qs1vEAKkfqYiKU/oz3heYIUhfaWvAw49z5peAjYjXjes6IgA==", null, false, "06b48ea6-2bef-413f-b833-96aca24c4008", false, "user9" }
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
                    { 1, "An action-adventure game developed and published by Nintendo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/zw47_q9wbBE\" title=\"The Legend of Zelda: Breath of the Wild - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2053), "1.jpg" },
                    { 2, "A platform game developed and published by Nintendo for the Nintendo Switch.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/5kcdRBHM7kM\" title=\"Super Mario Odyssey - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super Mario Odyssey", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2072), "2.webp" },
                    { 3, "An action-adventure game developed and published by Rockstar Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HVRzx17WHVk\" title=\"Red Dead Redemption 2 Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2074), "3.jpg" },
                    { 4, "An action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/Ty7WudwSKMA\" title=\"God of War: Ragnarok - Teaser Trailer | PS5 Showcase\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2076), "4.jpg" },
                    { 5, "An action role-playing game developed and published by CD Projekt.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/c0i88t0Kacs\" title=\"The Witcher 3: Wild Hunt - Killing Monsters Cinematic Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2078), "5.jpg" },
                    { 6, "An action role-playing game developed and published by CD Projekt.", "<iframe width=\"930\" height=\"388\" src=\"https://www.youtube.com/embed/P99qJGrPNLs\" title=\"Cyberpunk 2077 Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2081), "6.jpg" },
                    { 7, "A sandbox video game developed by Mojang.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/MmB9b5njVbA\" title=\"Official Minecraft Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2084), "7.jpg" },
                    { 8, "An online video game developed by Epic Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/hHTE5xg9E-g\" title=\"Fortnite Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2086), "8.png" },
                    { 9, "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/JSRtYpNRoN0\" title=\"The Elder Scrolls V: Skyrim - Official Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2087), "9.jpg" },
                    { 10, "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/u4-FCsiF5x4\" title=\"Horizon Zero Dawn - E3 2016 Trailer I PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Zero Dawn", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2089), "10.jpg" },
                    { 11, "An action role-playing game developed and published by Square Enix.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/CNM6o9um1dc\" title=\"FINAL FANTASY XV - Omen Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Fantasy XV", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2091), "11.jpg" },
                    { 12, "A role-playing video game developed by Atlus.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/QnDzJ9KzuV4\" title=\"Persona 5 | Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persona 5", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2093), "12.png" },
                    { 13, "An action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cWBwFhUv1-8\" title=\"Dark Souls III – Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Souls III", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2095), "13.jpg" },
                    { 14, "An action role-playing game developed by FromSoftware and published by Sony Computer Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/G203e1HhixY\" title=\"Bloodborne Debut Trailer | Face Your Fears | PlayStation 4 Action RPG\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2015, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloodborne", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2097), "14.jpg" },
                    { 15, "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/IBIwGKDwnWY\" title=\"Overwatch Theatrical Teaser | &quot;We Are Overwatch&quot;\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2099), "15.jpg" },
                    { 16, "An action-adventure game developed by FromSoftware and published by Activision.", "", new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekiro: Shadows Die Twice", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2104), "16.jpg" },
                    { 17, "An action role-playing game developed by Team Ninja and published by Koei Tecmo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cHTtNdkDduQ\" title=\"Nioh 2 Reveal Teaser Trailer - E3 2018\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nioh", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2106), "17.jpg" },
                    { 18, "An action role-playing game developed and published by Capcom.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monster Hunter: World", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2108), "18.png" },
                    { 19, "A survival horror game developed and published by Capcom.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 2", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2109), "19.jpg" },
                    { 20, "An action-adventure game developed by Sucker Punch Productions and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/RcWk08PBe7k\" title=\"Ghost of Tsushima - A Storm is Coming Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost of Tsushima", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2111), "20.jpg" },
                    { 21, "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.", "<iframe width=\"930\" height=\"390\" src=\"https://www.youtube.com/embed/rKjUAWlbTJk\" title=\"Assassin’s Creed Valhalla: Cinematic World Premiere Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2113), "21.jpg" },
                    { 22, "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/W2Wnvvj33Wo\" title=\"The Last of Us Part II - PlayStation Experience 2016: Reveal Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2115), "22.jpg" },
                    { 23, "An action-adventure game developed by Remedy Entertainment and published by 505 Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/w6bE11FrSFM\" title=\"Control - Ultimate Edition Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2117), "23.jpg" },
                    { 24, "A roguelike action dungeon crawler video game developed and published by Supergiant Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/91t0ha9x0AE\" title=\"Hades - Official Animated Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hades", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2119), "24.png" },
                    { 25, "A first-person shooter game developed by id Software and published by Bethesda Softworks.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/_oVwrpfo_QA\" title=\"DOOM Eternal – Official E3 Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doom Eternal", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2121), "25.jpg" },
                    { 26, "An action role-playing game developed and published by miHoYo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HLUY1nICQRY\" title=\"Genshin Impact - Official Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genshin Impact", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2123), "26.jpg" },
                    { 27, "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/H2Hy96sOnq8\" title=\"Death Stranding - Teaser Trailer - TGA 2016 - 4K\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Stranding", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2129), "27.jpg" },
                    { 28, "An action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/q4GdJVvdxss\" title=\"Marvel’s Spider-Man – Be Greater Extended Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2131), "28.jpg" },
                    { 29, "A virtual reality first-person shooter developed and published by Valve.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/O2W0N3uKXmo\" title=\"Half-Life: Alyx Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life: Alyx", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2133), "29.webp" },
                    { 30, "An action role-playing game developed and published by TaleWorlds Entertainment. Bannerlord is a prequel to Mount & Blade: Warband, a stand-alone expansion pack for the 2008 game Mount & Blade.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/yCk6Jk7DvrA\" title=\"Mount &amp; Blade II: Bannerlord Early Access Announcement\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mount and Blade II: Bannerlord", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2147), "30.jpg" },
                    { 31, "Explore the depths of Arkham Asylum as Batman, unraveling a sinister plot orchestrated by his arch-nemesis, the Joker.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/bVk9jW9EzD0\" title=\"Batman: Arkham Asylum Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2009, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Asylum", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2161), "31.jpg" },
                    { 32, "Gotham City is transformed into a sprawling prison, and Batman must navigate its dangerous streets to uncover a new threat.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/pcaFdTCiz4U\" title=\"Batman: Arkham City - Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham City", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2163), "32.jpg" },
                    { 33, "The Dark Knight faces the ultimate threat to Gotham City as the Scarecrow unites Batman's foes to destroy him once and for all.", "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/wsf78BS9VE0\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>\r\n", new DateTime(2015, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Knight", new DateTime(2024, 8, 15, 23, 7, 4, 268, DateTimeKind.Local).AddTicks(2165), "33.jpg" }
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
                    { 10, 1, 2 },
                    { 23, 1, 4 },
                    { 47, 1, 3 },
                    { 10, 2, 7 },
                    { 17, 2, 5 },
                    { 25, 2, 6 },
                    { 41, 2, 8 },
                    { 10, 3, 9 },
                    { 46, 3, 12 },
                    { 47, 3, 10 },
                    { 48, 3, 11 },
                    { 3, 4, 16 },
                    { 6, 4, 14 },
                    { 23, 4, 15 },
                    { 39, 4, 13 },
                    { 12, 5, 18 },
                    { 34, 5, 20 },
                    { 48, 5, 19 },
                    { 50, 5, 17 },
                    { 14, 6, 21 },
                    { 29, 6, 24 },
                    { 38, 6, 22 },
                    { 42, 6, 23 },
                    { 8, 7, 27 },
                    { 19, 7, 26 },
                    { 21, 7, 25 },
                    { 32, 7, 28 },
                    { 1, 8, 32 },
                    { 4, 8, 31 },
                    { 32, 8, 29 },
                    { 47, 8, 30 },
                    { 12, 9, 36 },
                    { 25, 9, 34 },
                    { 29, 9, 35 },
                    { 44, 9, 33 },
                    { 22, 10, 40 },
                    { 25, 10, 39 },
                    { 34, 10, 37 },
                    { 44, 10, 38 },
                    { 3, 11, 43 },
                    { 4, 11, 41 },
                    { 39, 11, 44 },
                    { 48, 11, 42 },
                    { 5, 12, 47 },
                    { 14, 12, 45 },
                    { 26, 12, 48 },
                    { 29, 12, 46 },
                    { 5, 13, 51 },
                    { 15, 13, 52 },
                    { 31, 13, 50 },
                    { 34, 13, 49 },
                    { 6, 14, 56 },
                    { 7, 14, 55 },
                    { 19, 14, 54 },
                    { 49, 14, 53 },
                    { 20, 15, 60 },
                    { 27, 15, 57 },
                    { 39, 15, 58 },
                    { 42, 15, 59 },
                    { 13, 16, 63 },
                    { 27, 16, 61 },
                    { 42, 16, 64 },
                    { 49, 16, 62 },
                    { 7, 17, 68 },
                    { 8, 17, 67 },
                    { 18, 17, 66 },
                    { 42, 17, 65 },
                    { 16, 18, 69 },
                    { 29, 18, 71 },
                    { 30, 18, 72 },
                    { 35, 18, 70 },
                    { 14, 19, 76 },
                    { 27, 19, 74 },
                    { 28, 19, 73 },
                    { 32, 19, 75 },
                    { 23, 20, 78 },
                    { 27, 20, 80 },
                    { 28, 20, 77 },
                    { 35, 20, 79 },
                    { 17, 21, 81 },
                    { 19, 21, 84 },
                    { 25, 21, 82 },
                    { 33, 21, 83 },
                    { 8, 22, 85 },
                    { 13, 22, 88 },
                    { 14, 22, 86 },
                    { 21, 22, 87 },
                    { 15, 23, 92 },
                    { 18, 23, 91 },
                    { 23, 23, 90 },
                    { 32, 23, 89 },
                    { 5, 24, 96 },
                    { 16, 24, 94 },
                    { 28, 24, 95 },
                    { 29, 24, 93 },
                    { 11, 25, 100 },
                    { 23, 25, 97 },
                    { 30, 25, 99 },
                    { 40, 25, 98 },
                    { 16, 26, 104 },
                    { 30, 26, 102 },
                    { 33, 26, 103 },
                    { 36, 26, 101 },
                    { 15, 27, 106 },
                    { 28, 27, 108 },
                    { 30, 27, 107 },
                    { 41, 27, 105 },
                    { 1, 28, 110 },
                    { 5, 28, 111 },
                    { 8, 28, 112 },
                    { 25, 28, 109 },
                    { 4, 29, 116 },
                    { 5, 29, 115 },
                    { 12, 29, 113 },
                    { 17, 29, 114 },
                    { 1, 30, 119 },
                    { 13, 30, 118 },
                    { 36, 30, 117 },
                    { 50, 30, 120 },
                    { 16, 31, 122 },
                    { 25, 31, 123 },
                    { 29, 31, 121 },
                    { 36, 31, 124 },
                    { 15, 32, 128 },
                    { 19, 32, 127 },
                    { 33, 32, 125 },
                    { 44, 32, 126 },
                    { 16, 33, 132 },
                    { 32, 33, 131 },
                    { 34, 33, 130 },
                    { 46, 33, 129 }
                });

            migrationBuilder.InsertData(
                table: "ItemPlatforms",
                columns: new[] { "itemId", "platformId", "Id" },
                values: new object[,]
                {
                    { 1, 4, 4 },
                    { 1, 7, 1 },
                    { 1, 11, 2 },
                    { 1, 12, 3 },
                    { 2, 3, 7 },
                    { 2, 4, 6 },
                    { 2, 8, 8 },
                    { 2, 22, 5 },
                    { 3, 1, 10 },
                    { 3, 4, 12 },
                    { 3, 5, 9 },
                    { 3, 10, 11 },
                    { 4, 6, 16 },
                    { 4, 11, 13 },
                    { 4, 14, 14 },
                    { 4, 16, 15 },
                    { 5, 1, 18 },
                    { 5, 2, 19 },
                    { 5, 8, 20 },
                    { 5, 16, 17 },
                    { 6, 1, 22 },
                    { 6, 2, 21 },
                    { 6, 3, 23 },
                    { 6, 20, 24 },
                    { 7, 5, 25 },
                    { 7, 8, 27 },
                    { 7, 9, 28 },
                    { 7, 16, 26 },
                    { 8, 3, 31 },
                    { 8, 9, 30 },
                    { 8, 12, 32 },
                    { 8, 13, 29 },
                    { 9, 10, 33 },
                    { 9, 14, 34 },
                    { 9, 20, 35 },
                    { 9, 22, 36 },
                    { 10, 6, 37 },
                    { 10, 11, 38 },
                    { 10, 17, 39 },
                    { 10, 19, 40 },
                    { 11, 6, 42 },
                    { 11, 7, 43 },
                    { 11, 8, 41 },
                    { 11, 15, 44 },
                    { 12, 1, 47 },
                    { 12, 2, 46 },
                    { 12, 5, 48 },
                    { 12, 10, 45 },
                    { 13, 2, 51 },
                    { 13, 5, 52 },
                    { 13, 7, 50 },
                    { 13, 9, 49 },
                    { 14, 4, 56 },
                    { 14, 8, 53 },
                    { 14, 10, 54 },
                    { 14, 20, 55 },
                    { 15, 6, 58 },
                    { 15, 7, 60 },
                    { 15, 14, 59 },
                    { 15, 19, 57 },
                    { 16, 3, 62 },
                    { 16, 8, 63 },
                    { 16, 11, 64 },
                    { 16, 14, 61 },
                    { 17, 2, 66 },
                    { 17, 13, 68 },
                    { 17, 15, 67 },
                    { 17, 22, 65 },
                    { 18, 6, 70 },
                    { 18, 13, 71 },
                    { 18, 14, 72 },
                    { 18, 17, 69 },
                    { 19, 5, 75 },
                    { 19, 14, 73 },
                    { 19, 15, 76 },
                    { 19, 18, 74 },
                    { 20, 5, 78 },
                    { 20, 6, 77 },
                    { 20, 9, 80 },
                    { 20, 13, 79 },
                    { 21, 2, 82 },
                    { 21, 4, 83 },
                    { 21, 14, 84 },
                    { 21, 17, 81 },
                    { 22, 2, 85 },
                    { 22, 4, 88 },
                    { 22, 15, 87 },
                    { 22, 16, 86 },
                    { 23, 15, 91 },
                    { 23, 19, 90 },
                    { 23, 21, 89 },
                    { 23, 22, 92 },
                    { 24, 1, 94 },
                    { 24, 12, 93 },
                    { 24, 13, 95 },
                    { 24, 19, 96 },
                    { 25, 3, 99 },
                    { 25, 16, 100 },
                    { 25, 18, 98 },
                    { 25, 20, 97 },
                    { 26, 3, 102 },
                    { 26, 14, 103 },
                    { 26, 15, 101 },
                    { 26, 17, 104 },
                    { 27, 4, 107 },
                    { 27, 6, 108 },
                    { 27, 8, 105 },
                    { 27, 16, 106 },
                    { 28, 7, 112 },
                    { 28, 9, 110 },
                    { 28, 13, 109 },
                    { 28, 14, 111 },
                    { 29, 3, 113 },
                    { 29, 14, 114 },
                    { 29, 20, 116 },
                    { 29, 22, 115 },
                    { 30, 6, 119 },
                    { 30, 7, 117 },
                    { 30, 16, 118 },
                    { 30, 17, 120 },
                    { 31, 1, 121 },
                    { 31, 10, 122 },
                    { 31, 11, 124 },
                    { 31, 12, 123 },
                    { 32, 16, 125 },
                    { 32, 18, 127 },
                    { 32, 19, 128 },
                    { 32, 20, 126 },
                    { 33, 4, 130 },
                    { 33, 5, 129 },
                    { 33, 6, 132 },
                    { 33, 10, 131 }
                });

            migrationBuilder.InsertData(
                table: "UserReviews",
                columns: new[] { "ItemId", "UserId", "Comment", "Id", "UserRating" },
                values: new object[,]
                {
                    { 1, "1", "Average game, nothing special.", 3, 22 },
                    { 1, "10", "Gameplay was not very engaging.", 18, 98 },
                    { 1, "11", "Quite boring and repetitive.", 4, 7 },
                    { 1, "12", "Fantastic experience, highly recommend!", 7, 5 },
                    { 1, "13", "Average game, nothing special.", 17, 56 },
                    { 1, "14", "Disappointing, had high expectations.", 5, 83 },
                    { 1, "15", "I didn't like this game much.", 9, 61 },
                    { 1, "16", "Not bad, could be better.", 15, 60 },
                    { 1, "17", "A must-play for all gamers!", 14, 22 },
                    { 1, "18", "Average game, nothing special.", 10, 80 },
                    { 1, "19", "Great game, really enjoyed it!", 16, 10 },
                    { 1, "2", "Fantastic experience, highly recommend!", 20, 75 },
                    { 1, "20", "Fantastic experience, highly recommend!", 12, 30 },
                    { 1, "3", "A must-play for all gamers!", 11, 19 },
                    { 1, "4", "Not bad, could be better.", 19, 24 },
                    { 1, "5", "Loved the graphics and storyline.", 6, 27 },
                    { 1, "6", "Quite boring and repetitive.", 8, 28 },
                    { 1, "7", "Disappointing, had high expectations.", 13, 41 },
                    { 1, "8", "Quite boring and repetitive.", 22, 84 },
                    { 1, "9", "Gameplay was not very engaging.", 21, 5 },
                    { 2, "1", "I didn't like this game much.", 11, 40 },
                    { 2, "10", "Loved the graphics and storyline.", 10, 6 },
                    { 2, "11", "Great game, really enjoyed it!", 7, 64 },
                    { 2, "12", "Quite boring and repetitive.", 15, 26 },
                    { 2, "13", "Average game, nothing special.", 17, 76 },
                    { 2, "14", "Great game, really enjoyed it!", 21, 25 },
                    { 2, "15", "A must-play for all gamers!", 23, 22 },
                    { 2, "16", "Quite boring and repetitive.", 8, 39 },
                    { 2, "17", "A must-play for all gamers!", 22, 88 },
                    { 2, "18", "Disappointing, had high expectations.", 14, 54 },
                    { 2, "19", "Gameplay was not very engaging.", 24, 92 },
                    { 2, "2", "A must-play for all gamers!", 6, 50 },
                    { 2, "20", "Disappointing, had high expectations.", 18, 38 },
                    { 2, "3", "Not bad, could be better.", 9, 55 },
                    { 2, "4", "Disappointing, had high expectations.", 20, 59 },
                    { 2, "5", "Gameplay was not very engaging.", 25, 29 },
                    { 2, "6", "Great game, really enjoyed it!", 16, 90 },
                    { 2, "7", "Gameplay was not very engaging.", 12, 97 },
                    { 2, "8", "Great game, really enjoyed it!", 19, 24 },
                    { 2, "9", "Gameplay was not very engaging.", 13, 17 },
                    { 3, "1", "Disappointing, had high expectations.", 15, 47 },
                    { 3, "10", "Disappointing, had high expectations.", 11, 83 },
                    { 3, "11", "I didn't like this game much.", 23, 52 },
                    { 3, "12", "Average game, nothing special.", 18, 40 },
                    { 3, "13", "Gameplay was not very engaging.", 26, 60 },
                    { 3, "14", "Loved the graphics and storyline.", 12, 11 },
                    { 3, "15", "Gameplay was not very engaging.", 22, 41 },
                    { 3, "16", "Gameplay was not very engaging.", 19, 53 },
                    { 3, "17", "Disappointing, had high expectations.", 13, 92 },
                    { 3, "18", "Average game, nothing special.", 16, 78 },
                    { 3, "19", "Not bad, could be better.", 14, 36 },
                    { 3, "2", "Gameplay was not very engaging.", 27, 27 },
                    { 3, "20", "A must-play for all gamers!", 10, 56 },
                    { 3, "3", "Gameplay was not very engaging.", 9, 97 },
                    { 3, "4", "Loved the graphics and storyline.", 24, 88 },
                    { 3, "5", "Disappointing, had high expectations.", 21, 87 },
                    { 3, "6", "Not bad, could be better.", 25, 65 },
                    { 3, "7", "Average game, nothing special.", 28, 29 },
                    { 3, "8", "Disappointing, had high expectations.", 20, 87 },
                    { 3, "9", "Fantastic experience, highly recommend!", 17, 55 },
                    { 4, "1", "Average game, nothing special.", 13, 39 },
                    { 4, "10", "Gameplay was not very engaging.", 31, 8 },
                    { 4, "11", "Quite boring and repetitive.", 14, 46 },
                    { 4, "12", "Great game, really enjoyed it!", 22, 25 },
                    { 4, "13", "Great game, really enjoyed it!", 12, 25 },
                    { 4, "14", "A must-play for all gamers!", 28, 40 },
                    { 4, "15", "I didn't like this game much.", 27, 58 },
                    { 4, "16", "Loved the graphics and storyline.", 18, 27 },
                    { 4, "17", "A must-play for all gamers!", 29, 21 },
                    { 4, "18", "I didn't like this game much.", 30, 92 },
                    { 4, "19", "A must-play for all gamers!", 26, 26 },
                    { 4, "2", "Quite boring and repetitive.", 21, 56 },
                    { 4, "20", "I didn't like this game much.", 19, 78 },
                    { 4, "3", "I didn't like this game much.", 25, 38 },
                    { 4, "4", "Gameplay was not very engaging.", 24, 97 },
                    { 4, "5", "A must-play for all gamers!", 16, 76 },
                    { 4, "6", "Loved the graphics and storyline.", 23, 50 },
                    { 4, "7", "Fantastic experience, highly recommend!", 15, 88 },
                    { 4, "8", "Gameplay was not very engaging.", 17, 30 },
                    { 4, "9", "A must-play for all gamers!", 20, 10 },
                    { 5, "1", "Disappointing, had high expectations.", 28, 11 },
                    { 5, "10", "Average game, nothing special.", 32, 10 },
                    { 5, "11", "Average game, nothing special.", 15, 20 },
                    { 5, "12", "Not bad, could be better.", 23, 5 },
                    { 5, "13", "Gameplay was not very engaging.", 34, 60 },
                    { 5, "14", "Gameplay was not very engaging.", 21, 34 },
                    { 5, "15", "Great game, really enjoyed it!", 20, 93 },
                    { 5, "16", "Great game, really enjoyed it!", 26, 66 },
                    { 5, "17", "Gameplay was not very engaging.", 33, 54 },
                    { 5, "18", "Quite boring and repetitive.", 24, 52 },
                    { 5, "19", "Gameplay was not very engaging.", 16, 23 },
                    { 5, "2", "Great game, really enjoyed it!", 27, 82 },
                    { 5, "20", "Quite boring and repetitive.", 25, 63 },
                    { 5, "3", "A must-play for all gamers!", 17, 56 },
                    { 5, "4", "Not bad, could be better.", 29, 3 },
                    { 5, "5", "Quite boring and repetitive.", 31, 24 },
                    { 5, "6", "Not bad, could be better.", 18, 60 },
                    { 5, "7", "Gameplay was not very engaging.", 30, 99 },
                    { 5, "8", "Not bad, could be better.", 19, 83 },
                    { 5, "9", "Gameplay was not very engaging.", 22, 42 },
                    { 6, "1", "Average game, nothing special.", 35, 95 },
                    { 6, "10", "Gameplay was not very engaging.", 27, 62 },
                    { 6, "11", "Average game, nothing special.", 37, 48 },
                    { 6, "12", "Gameplay was not very engaging.", 18, 1 },
                    { 6, "13", "Not bad, could be better.", 21, 84 },
                    { 6, "14", "Not bad, could be better.", 29, 56 },
                    { 6, "15", "Quite boring and repetitive.", 26, 97 },
                    { 6, "16", "Gameplay was not very engaging.", 24, 28 },
                    { 6, "17", "I didn't like this game much.", 32, 34 },
                    { 6, "18", "Loved the graphics and storyline.", 20, 68 },
                    { 6, "19", "Disappointing, had high expectations.", 19, 83 },
                    { 6, "2", "Gameplay was not very engaging.", 23, 24 },
                    { 6, "20", "I didn't like this game much.", 36, 4 },
                    { 6, "3", "Disappointing, had high expectations.", 30, 28 },
                    { 6, "4", "Gameplay was not very engaging.", 34, 87 },
                    { 6, "5", "I didn't like this game much.", 22, 44 },
                    { 6, "6", "I didn't like this game much.", 25, 37 },
                    { 6, "7", "Fantastic experience, highly recommend!", 33, 30 },
                    { 6, "8", "Fantastic experience, highly recommend!", 28, 5 },
                    { 6, "9", "Average game, nothing special.", 31, 99 },
                    { 7, "1", "Loved the graphics and storyline.", 24, 6 },
                    { 7, "10", "Average game, nothing special.", 30, 19 },
                    { 7, "11", "I didn't like this game much.", 29, 23 },
                    { 7, "12", "A must-play for all gamers!", 25, 75 },
                    { 7, "13", "Quite boring and repetitive.", 33, 4 },
                    { 7, "14", "Not bad, could be better.", 27, 16 },
                    { 7, "15", "Disappointing, had high expectations.", 31, 12 },
                    { 7, "16", "Average game, nothing special.", 23, 81 },
                    { 7, "17", "Not bad, could be better.", 38, 60 },
                    { 7, "18", "A must-play for all gamers!", 37, 18 },
                    { 7, "19", "Not bad, could be better.", 26, 47 },
                    { 7, "2", "I didn't like this game much.", 39, 24 },
                    { 7, "20", "Disappointing, had high expectations.", 40, 83 },
                    { 7, "3", "Loved the graphics and storyline.", 36, 20 },
                    { 7, "4", "Great game, really enjoyed it!", 32, 59 },
                    { 7, "5", "Not bad, could be better.", 21, 100 },
                    { 7, "6", "Quite boring and repetitive.", 28, 86 },
                    { 7, "7", "Loved the graphics and storyline.", 35, 27 },
                    { 7, "8", "Average game, nothing special.", 22, 47 },
                    { 7, "9", "Great game, really enjoyed it!", 34, 10 },
                    { 8, "1", "Disappointing, had high expectations.", 41, 64 },
                    { 8, "10", "Loved the graphics and storyline.", 37, 55 },
                    { 8, "11", "Average game, nothing special.", 40, 62 },
                    { 8, "12", "Fantastic experience, highly recommend!", 42, 95 },
                    { 8, "13", "Disappointing, had high expectations.", 35, 79 },
                    { 8, "14", "Quite boring and repetitive.", 39, 10 },
                    { 8, "15", "Fantastic experience, highly recommend!", 28, 64 },
                    { 8, "16", "A must-play for all gamers!", 29, 45 },
                    { 8, "17", "I didn't like this game much.", 38, 84 },
                    { 8, "18", "Gameplay was not very engaging.", 30, 89 },
                    { 8, "19", "I didn't like this game much.", 34, 46 },
                    { 8, "2", "Quite boring and repetitive.", 26, 57 },
                    { 8, "20", "Gameplay was not very engaging.", 32, 79 },
                    { 8, "3", "Average game, nothing special.", 25, 65 },
                    { 8, "4", "Fantastic experience, highly recommend!", 43, 16 },
                    { 8, "5", "Fantastic experience, highly recommend!", 31, 4 },
                    { 8, "6", "Fantastic experience, highly recommend!", 27, 20 },
                    { 8, "7", "Average game, nothing special.", 24, 95 },
                    { 8, "8", "Loved the graphics and storyline.", 33, 54 },
                    { 8, "9", "Great game, really enjoyed it!", 36, 8 },
                    { 9, "1", "Great game, really enjoyed it!", 45, 3 },
                    { 9, "10", "Gameplay was not very engaging.", 41, 8 },
                    { 9, "11", "Average game, nothing special.", 42, 56 },
                    { 9, "12", "A must-play for all gamers!", 28, 73 },
                    { 9, "13", "Disappointing, had high expectations.", 38, 41 },
                    { 9, "14", "I didn't like this game much.", 35, 82 },
                    { 9, "15", "Not bad, could be better.", 43, 58 },
                    { 9, "16", "Disappointing, had high expectations.", 44, 9 },
                    { 9, "17", "A must-play for all gamers!", 46, 14 },
                    { 9, "18", "I didn't like this game much.", 39, 34 },
                    { 9, "19", "Gameplay was not very engaging.", 34, 94 },
                    { 9, "2", "A must-play for all gamers!", 30, 68 },
                    { 9, "20", "Disappointing, had high expectations.", 31, 25 },
                    { 9, "3", "I didn't like this game much.", 27, 84 },
                    { 9, "4", "Not bad, could be better.", 36, 82 },
                    { 9, "5", "Disappointing, had high expectations.", 29, 43 },
                    { 9, "6", "A must-play for all gamers!", 37, 82 },
                    { 9, "7", "Average game, nothing special.", 32, 98 },
                    { 9, "8", "Gameplay was not very engaging.", 33, 50 },
                    { 9, "9", "I didn't like this game much.", 40, 43 },
                    { 10, "1", "Gameplay was not very engaging.", 42, 65 },
                    { 10, "10", "Not bad, could be better.", 34, 57 },
                    { 10, "11", "Gameplay was not very engaging.", 40, 94 },
                    { 10, "12", "Quite boring and repetitive.", 49, 90 },
                    { 10, "13", "Average game, nothing special.", 47, 48 },
                    { 10, "14", "A must-play for all gamers!", 33, 26 },
                    { 10, "15", "Gameplay was not very engaging.", 31, 35 },
                    { 10, "16", "Not bad, could be better.", 37, 35 },
                    { 10, "17", "Not bad, could be better.", 35, 17 },
                    { 10, "18", "Loved the graphics and storyline.", 43, 38 },
                    { 10, "19", "I didn't like this game much.", 38, 84 },
                    { 10, "2", "Great game, really enjoyed it!", 44, 69 },
                    { 10, "20", "Fantastic experience, highly recommend!", 46, 49 },
                    { 10, "3", "Great game, really enjoyed it!", 48, 53 },
                    { 10, "4", "Loved the graphics and storyline.", 41, 14 },
                    { 10, "5", "I didn't like this game much.", 45, 86 },
                    { 10, "6", "I didn't like this game much.", 32, 68 },
                    { 10, "7", "Fantastic experience, highly recommend!", 30, 30 },
                    { 10, "8", "Average game, nothing special.", 39, 96 },
                    { 10, "9", "Average game, nothing special.", 36, 22 },
                    { 11, "1", "I didn't like this game much.", 52, 16 },
                    { 11, "10", "Not bad, could be better.", 49, 73 },
                    { 11, "11", "Quite boring and repetitive.", 39, 14 },
                    { 11, "12", "Gameplay was not very engaging.", 44, 30 },
                    { 11, "13", "Not bad, could be better.", 51, 32 },
                    { 11, "14", "I didn't like this game much.", 48, 86 },
                    { 11, "15", "I didn't like this game much.", 45, 75 },
                    { 11, "16", "Average game, nothing special.", 46, 99 },
                    { 11, "17", "Average game, nothing special.", 34, 23 },
                    { 11, "18", "A must-play for all gamers!", 43, 22 },
                    { 11, "19", "Disappointing, had high expectations.", 47, 55 },
                    { 11, "2", "Average game, nothing special.", 35, 46 },
                    { 11, "20", "Quite boring and repetitive.", 38, 97 },
                    { 11, "3", "Quite boring and repetitive.", 36, 57 },
                    { 11, "4", "Not bad, could be better.", 37, 84 },
                    { 11, "5", "Loved the graphics and storyline.", 33, 69 },
                    { 11, "6", "Loved the graphics and storyline.", 41, 32 },
                    { 11, "7", "Quite boring and repetitive.", 42, 4 },
                    { 11, "8", "Quite boring and repetitive.", 40, 10 },
                    { 11, "9", "A must-play for all gamers!", 50, 63 },
                    { 12, "1", "A must-play for all gamers!", 45, 40 },
                    { 12, "10", "Gameplay was not very engaging.", 46, 73 },
                    { 12, "11", "A must-play for all gamers!", 43, 38 },
                    { 12, "12", "Great game, really enjoyed it!", 48, 95 },
                    { 12, "13", "Average game, nothing special.", 47, 18 },
                    { 12, "14", "Disappointing, had high expectations.", 49, 44 },
                    { 12, "15", "Gameplay was not very engaging.", 52, 51 },
                    { 12, "16", "Average game, nothing special.", 40, 42 },
                    { 12, "17", "I didn't like this game much.", 42, 44 },
                    { 12, "18", "Gameplay was not very engaging.", 36, 46 },
                    { 12, "19", "Loved the graphics and storyline.", 55, 8 },
                    { 12, "2", "Great game, really enjoyed it!", 44, 9 },
                    { 12, "20", "A must-play for all gamers!", 54, 32 },
                    { 12, "3", "Loved the graphics and storyline.", 50, 22 },
                    { 12, "4", "Great game, really enjoyed it!", 37, 51 },
                    { 12, "5", "I didn't like this game much.", 51, 83 },
                    { 12, "6", "Disappointing, had high expectations.", 39, 36 },
                    { 12, "7", "Average game, nothing special.", 41, 60 },
                    { 12, "8", "Average game, nothing special.", 53, 88 },
                    { 12, "9", "Average game, nothing special.", 38, 84 },
                    { 13, "1", "Great game, really enjoyed it!", 46, 53 },
                    { 13, "10", "Disappointing, had high expectations.", 44, 59 },
                    { 13, "11", "Loved the graphics and storyline.", 55, 4 },
                    { 13, "12", "Fantastic experience, highly recommend!", 56, 53 },
                    { 13, "13", "Great game, really enjoyed it!", 52, 47 },
                    { 13, "14", "Disappointing, had high expectations.", 45, 74 },
                    { 13, "15", "Quite boring and repetitive.", 40, 12 },
                    { 13, "16", "Fantastic experience, highly recommend!", 54, 29 },
                    { 13, "17", "I didn't like this game much.", 51, 33 },
                    { 13, "18", "Fantastic experience, highly recommend!", 47, 49 },
                    { 13, "19", "Disappointing, had high expectations.", 50, 28 },
                    { 13, "2", "Quite boring and repetitive.", 48, 28 },
                    { 13, "20", "Gameplay was not very engaging.", 43, 18 },
                    { 13, "3", "A must-play for all gamers!", 53, 99 },
                    { 13, "4", "Loved the graphics and storyline.", 49, 44 },
                    { 13, "5", "Average game, nothing special.", 41, 50 },
                    { 13, "6", "A must-play for all gamers!", 42, 2 },
                    { 13, "7", "Fantastic experience, highly recommend!", 58, 49 },
                    { 13, "8", "Average game, nothing special.", 57, 59 },
                    { 13, "9", "Loved the graphics and storyline.", 39, 29 },
                    { 14, "1", "Fantastic experience, highly recommend!", 52, 96 },
                    { 14, "10", "A must-play for all gamers!", 44, 61 },
                    { 14, "11", "Loved the graphics and storyline.", 51, 4 },
                    { 14, "12", "Fantastic experience, highly recommend!", 45, 90 },
                    { 14, "13", "Great game, really enjoyed it!", 42, 5 },
                    { 14, "14", "Quite boring and repetitive.", 60, 79 },
                    { 14, "15", "Not bad, could be better.", 61, 38 },
                    { 14, "16", "Gameplay was not very engaging.", 48, 91 },
                    { 14, "17", "Loved the graphics and storyline.", 59, 70 },
                    { 14, "18", "Average game, nothing special.", 55, 39 },
                    { 14, "19", "Disappointing, had high expectations.", 53, 11 },
                    { 14, "2", "Quite boring and repetitive.", 50, 43 },
                    { 14, "20", "A must-play for all gamers!", 43, 92 },
                    { 14, "3", "Quite boring and repetitive.", 54, 56 },
                    { 14, "4", "Gameplay was not very engaging.", 49, 66 },
                    { 14, "5", "Great game, really enjoyed it!", 57, 36 },
                    { 14, "6", "Gameplay was not very engaging.", 56, 2 },
                    { 14, "7", "Loved the graphics and storyline.", 58, 4 },
                    { 14, "8", "Disappointing, had high expectations.", 47, 44 },
                    { 14, "9", "A must-play for all gamers!", 46, 45 },
                    { 15, "1", "A must-play for all gamers!", 57, 65 },
                    { 15, "10", "A must-play for all gamers!", 45, 3 },
                    { 15, "11", "Not bad, could be better.", 48, 54 },
                    { 15, "12", "A must-play for all gamers!", 61, 92 },
                    { 15, "13", "Gameplay was not very engaging.", 62, 4 },
                    { 15, "14", "Average game, nothing special.", 49, 46 },
                    { 15, "15", "A must-play for all gamers!", 55, 64 },
                    { 15, "16", "Quite boring and repetitive.", 46, 9 },
                    { 15, "17", "Fantastic experience, highly recommend!", 47, 9 },
                    { 15, "18", "Disappointing, had high expectations.", 64, 67 },
                    { 15, "19", "Disappointing, had high expectations.", 56, 5 },
                    { 15, "2", "A must-play for all gamers!", 51, 11 },
                    { 15, "20", "Fantastic experience, highly recommend!", 63, 53 },
                    { 15, "3", "Loved the graphics and storyline.", 54, 55 },
                    { 15, "4", "Great game, really enjoyed it!", 58, 13 },
                    { 15, "5", "Great game, really enjoyed it!", 52, 77 },
                    { 15, "6", "I didn't like this game much.", 50, 29 },
                    { 15, "7", "Quite boring and repetitive.", 60, 46 },
                    { 15, "8", "Loved the graphics and storyline.", 53, 40 },
                    { 15, "9", "I didn't like this game much.", 59, 88 },
                    { 16, "1", "Disappointing, had high expectations.", 64, 46 },
                    { 16, "10", "I didn't like this game much.", 61, 14 },
                    { 16, "11", "Loved the graphics and storyline.", 50, 10 },
                    { 16, "12", "Loved the graphics and storyline.", 67, 20 },
                    { 16, "13", "Loved the graphics and storyline.", 63, 46 },
                    { 16, "14", "I didn't like this game much.", 60, 30 },
                    { 16, "15", "Fantastic experience, highly recommend!", 56, 23 },
                    { 16, "16", "Great game, really enjoyed it!", 49, 52 },
                    { 16, "17", "Average game, nothing special.", 66, 68 },
                    { 16, "18", "Not bad, could be better.", 52, 48 },
                    { 16, "19", "Quite boring and repetitive.", 58, 72 },
                    { 16, "2", "Loved the graphics and storyline.", 48, 25 },
                    { 16, "20", "Loved the graphics and storyline.", 59, 74 },
                    { 16, "3", "A must-play for all gamers!", 54, 99 },
                    { 16, "4", "Average game, nothing special.", 51, 72 },
                    { 16, "5", "Gameplay was not very engaging.", 55, 31 },
                    { 16, "6", "A must-play for all gamers!", 57, 65 },
                    { 16, "7", "A must-play for all gamers!", 62, 15 },
                    { 16, "8", "Quite boring and repetitive.", 65, 24 },
                    { 16, "9", "Average game, nothing special.", 53, 23 },
                    { 17, "1", "Fantastic experience, highly recommend!", 52, 23 },
                    { 17, "10", "I didn't like this game much.", 65, 53 },
                    { 17, "11", "Disappointing, had high expectations.", 67, 13 },
                    { 17, "12", "Fantastic experience, highly recommend!", 57, 25 },
                    { 17, "13", "Average game, nothing special.", 68, 57 },
                    { 17, "14", "Fantastic experience, highly recommend!", 70, 68 },
                    { 17, "15", "Quite boring and repetitive.", 56, 75 },
                    { 17, "16", "I didn't like this game much.", 64, 93 },
                    { 17, "17", "Quite boring and repetitive.", 66, 58 },
                    { 17, "18", "I didn't like this game much.", 63, 27 },
                    { 17, "19", "Fantastic experience, highly recommend!", 69, 59 },
                    { 17, "2", "Not bad, could be better.", 61, 37 },
                    { 17, "20", "Average game, nothing special.", 60, 5 },
                    { 17, "3", "Gameplay was not very engaging.", 51, 72 },
                    { 17, "4", "I didn't like this game much.", 55, 28 },
                    { 17, "5", "Quite boring and repetitive.", 62, 81 },
                    { 17, "6", "Fantastic experience, highly recommend!", 54, 24 },
                    { 17, "7", "Quite boring and repetitive.", 58, 44 },
                    { 17, "8", "Fantastic experience, highly recommend!", 59, 68 },
                    { 17, "9", "Loved the graphics and storyline.", 53, 19 },
                    { 18, "1", "Quite boring and repetitive.", 58, 80 },
                    { 18, "10", "Quite boring and repetitive.", 70, 51 },
                    { 18, "11", "Great game, really enjoyed it!", 72, 79 },
                    { 18, "12", "Not bad, could be better.", 57, 96 },
                    { 18, "13", "I didn't like this game much.", 69, 56 },
                    { 18, "14", "Gameplay was not very engaging.", 71, 24 },
                    { 18, "15", "Average game, nothing special.", 59, 89 },
                    { 18, "16", "Loved the graphics and storyline.", 66, 23 },
                    { 18, "17", "Average game, nothing special.", 62, 32 },
                    { 18, "18", "Quite boring and repetitive.", 68, 82 },
                    { 18, "19", "I didn't like this game much.", 54, 10 },
                    { 18, "2", "Average game, nothing special.", 65, 65 },
                    { 18, "20", "A must-play for all gamers!", 63, 38 },
                    { 18, "3", "Gameplay was not very engaging.", 61, 93 },
                    { 18, "4", "Quite boring and repetitive.", 55, 46 },
                    { 18, "5", "A must-play for all gamers!", 64, 72 },
                    { 18, "6", "Average game, nothing special.", 73, 23 },
                    { 18, "7", "Quite boring and repetitive.", 56, 93 },
                    { 18, "8", "Great game, really enjoyed it!", 60, 45 },
                    { 18, "9", "Quite boring and repetitive.", 67, 96 },
                    { 19, "1", "Great game, really enjoyed it!", 72, 20 },
                    { 19, "10", "A must-play for all gamers!", 73, 7 },
                    { 19, "11", "Quite boring and repetitive.", 60, 19 },
                    { 19, "12", "Fantastic experience, highly recommend!", 75, 100 },
                    { 19, "13", "Not bad, could be better.", 68, 56 },
                    { 19, "14", "Not bad, could be better.", 71, 1 },
                    { 19, "15", "Gameplay was not very engaging.", 76, 2 },
                    { 19, "16", "A must-play for all gamers!", 67, 98 },
                    { 19, "17", "I didn't like this game much.", 64, 4 },
                    { 19, "18", "Quite boring and repetitive.", 74, 36 },
                    { 19, "19", "A must-play for all gamers!", 66, 82 },
                    { 19, "2", "Not bad, could be better.", 59, 49 },
                    { 19, "20", "I didn't like this game much.", 61, 46 },
                    { 19, "3", "Loved the graphics and storyline.", 58, 62 },
                    { 19, "4", "I didn't like this game much.", 69, 13 },
                    { 19, "5", "Disappointing, had high expectations.", 57, 1 },
                    { 19, "6", "Disappointing, had high expectations.", 65, 62 },
                    { 19, "7", "Fantastic experience, highly recommend!", 70, 4 },
                    { 19, "8", "Disappointing, had high expectations.", 63, 19 },
                    { 19, "9", "Gameplay was not very engaging.", 62, 24 },
                    { 20, "1", "I didn't like this game much.", 79, 61 },
                    { 20, "10", "Fantastic experience, highly recommend!", 67, 30 },
                    { 20, "11", "Disappointing, had high expectations.", 70, 8 },
                    { 20, "12", "Not bad, could be better.", 68, 71 },
                    { 20, "13", "I didn't like this game much.", 72, 21 },
                    { 20, "14", "Fantastic experience, highly recommend!", 77, 81 },
                    { 20, "15", "Average game, nothing special.", 65, 47 },
                    { 20, "16", "Quite boring and repetitive.", 74, 78 },
                    { 20, "17", "Gameplay was not very engaging.", 62, 21 },
                    { 20, "18", "Gameplay was not very engaging.", 66, 74 },
                    { 20, "19", "Great game, really enjoyed it!", 76, 96 },
                    { 20, "2", "Average game, nothing special.", 78, 19 },
                    { 20, "20", "Gameplay was not very engaging.", 64, 3 },
                    { 20, "3", "Fantastic experience, highly recommend!", 63, 53 },
                    { 20, "4", "Loved the graphics and storyline.", 69, 35 },
                    { 20, "5", "Loved the graphics and storyline.", 73, 89 },
                    { 20, "6", "Gameplay was not very engaging.", 71, 1 },
                    { 20, "7", "A must-play for all gamers!", 60, 48 },
                    { 20, "8", "Great game, really enjoyed it!", 75, 64 },
                    { 20, "9", "Gameplay was not very engaging.", 61, 11 },
                    { 21, "1", "Gameplay was not very engaging.", 81, 53 },
                    { 21, "10", "Fantastic experience, highly recommend!", 77, 29 },
                    { 21, "11", "Quite boring and repetitive.", 82, 27 },
                    { 21, "12", "Average game, nothing special.", 69, 87 },
                    { 21, "13", "Gameplay was not very engaging.", 73, 17 },
                    { 21, "14", "Not bad, could be better.", 76, 54 },
                    { 21, "15", "Loved the graphics and storyline.", 70, 52 },
                    { 21, "16", "I didn't like this game much.", 71, 73 },
                    { 21, "17", "I didn't like this game much.", 75, 78 },
                    { 21, "18", "A must-play for all gamers!", 79, 80 },
                    { 21, "19", "Fantastic experience, highly recommend!", 63, 41 },
                    { 21, "2", "Disappointing, had high expectations.", 78, 52 },
                    { 21, "20", "Fantastic experience, highly recommend!", 67, 30 },
                    { 21, "3", "I didn't like this game much.", 80, 26 },
                    { 21, "4", "Disappointing, had high expectations.", 65, 54 },
                    { 21, "5", "A must-play for all gamers!", 74, 10 },
                    { 21, "6", "Gameplay was not very engaging.", 64, 31 },
                    { 21, "7", "Average game, nothing special.", 66, 82 },
                    { 21, "8", "I didn't like this game much.", 72, 85 },
                    { 21, "9", "I didn't like this game much.", 68, 98 },
                    { 22, "1", "Great game, really enjoyed it!", 68, 3 },
                    { 22, "10", "Loved the graphics and storyline.", 84, 7 },
                    { 22, "11", "Disappointing, had high expectations.", 78, 50 },
                    { 22, "12", "Great game, really enjoyed it!", 85, 9 },
                    { 22, "13", "Great game, really enjoyed it!", 73, 81 },
                    { 22, "14", "I didn't like this game much.", 69, 78 },
                    { 22, "15", "Average game, nothing special.", 75, 72 },
                    { 22, "16", "Fantastic experience, highly recommend!", 79, 34 },
                    { 22, "17", "Great game, really enjoyed it!", 74, 58 },
                    { 22, "18", "Disappointing, had high expectations.", 70, 90 },
                    { 22, "19", "Average game, nothing special.", 71, 31 },
                    { 22, "2", "Quite boring and repetitive.", 81, 92 },
                    { 22, "20", "Not bad, could be better.", 66, 73 },
                    { 22, "3", "I didn't like this game much.", 72, 13 },
                    { 22, "4", "Fantastic experience, highly recommend!", 82, 50 },
                    { 22, "5", "A must-play for all gamers!", 80, 92 },
                    { 22, "6", "Average game, nothing special.", 77, 69 },
                    { 22, "7", "A must-play for all gamers!", 76, 10 },
                    { 22, "8", "Gameplay was not very engaging.", 67, 87 },
                    { 22, "9", "Disappointing, had high expectations.", 83, 97 },
                    { 23, "1", "A must-play for all gamers!", 85, 73 },
                    { 23, "10", "Average game, nothing special.", 84, 37 },
                    { 23, "11", "A must-play for all gamers!", 73, 11 },
                    { 23, "12", "Not bad, could be better.", 75, 86 },
                    { 23, "13", "Quite boring and repetitive.", 72, 37 },
                    { 23, "14", "Quite boring and repetitive.", 78, 41 },
                    { 23, "15", "I didn't like this game much.", 86, 24 },
                    { 23, "16", "Great game, really enjoyed it!", 79, 48 },
                    { 23, "17", "Not bad, could be better.", 88, 12 },
                    { 23, "18", "Not bad, could be better.", 69, 52 },
                    { 23, "19", "A must-play for all gamers!", 82, 61 },
                    { 23, "2", "I didn't like this game much.", 87, 40 },
                    { 23, "20", "A must-play for all gamers!", 80, 82 },
                    { 23, "3", "Loved the graphics and storyline.", 74, 13 },
                    { 23, "4", "Great game, really enjoyed it!", 81, 57 },
                    { 23, "5", "A must-play for all gamers!", 76, 99 },
                    { 23, "6", "Gameplay was not very engaging.", 70, 4 },
                    { 23, "7", "Disappointing, had high expectations.", 71, 66 },
                    { 23, "8", "Great game, really enjoyed it!", 83, 63 },
                    { 23, "9", "Loved the graphics and storyline.", 77, 25 },
                    { 24, "1", "Gameplay was not very engaging.", 89, 76 },
                    { 24, "10", "Great game, really enjoyed it!", 85, 82 },
                    { 24, "11", "Great game, really enjoyed it!", 76, 83 },
                    { 24, "12", "Not bad, could be better.", 90, 21 },
                    { 24, "13", "I didn't like this game much.", 78, 1 },
                    { 24, "14", "Loved the graphics and storyline.", 86, 73 },
                    { 24, "15", "Great game, really enjoyed it!", 88, 8 },
                    { 24, "16", "Not bad, could be better.", 87, 77 },
                    { 24, "17", "Not bad, could be better.", 79, 75 },
                    { 24, "18", "Fantastic experience, highly recommend!", 81, 28 },
                    { 24, "19", "Not bad, could be better.", 84, 13 },
                    { 24, "2", "Not bad, could be better.", 74, 58 },
                    { 24, "20", "Fantastic experience, highly recommend!", 91, 16 },
                    { 24, "3", "Not bad, could be better.", 73, 1 },
                    { 24, "4", "Not bad, could be better.", 82, 9 },
                    { 24, "5", "Gameplay was not very engaging.", 80, 12 },
                    { 24, "6", "Disappointing, had high expectations.", 77, 26 },
                    { 24, "7", "Disappointing, had high expectations.", 72, 95 },
                    { 24, "8", "Loved the graphics and storyline.", 83, 77 },
                    { 24, "9", "Loved the graphics and storyline.", 75, 18 },
                    { 25, "1", "A must-play for all gamers!", 75, 63 },
                    { 25, "10", "A must-play for all gamers!", 80, 94 },
                    { 25, "11", "A must-play for all gamers!", 89, 69 },
                    { 25, "12", "Gameplay was not very engaging.", 82, 3 },
                    { 25, "13", "Not bad, could be better.", 83, 3 },
                    { 25, "14", "A must-play for all gamers!", 93, 85 },
                    { 25, "15", "Quite boring and repetitive.", 94, 72 },
                    { 25, "16", "Fantastic experience, highly recommend!", 79, 63 },
                    { 25, "17", "Great game, really enjoyed it!", 84, 71 },
                    { 25, "18", "Great game, really enjoyed it!", 78, 67 },
                    { 25, "19", "A must-play for all gamers!", 86, 81 },
                    { 25, "2", "A must-play for all gamers!", 90, 60 },
                    { 25, "20", "Fantastic experience, highly recommend!", 76, 79 },
                    { 25, "3", "A must-play for all gamers!", 91, 6 },
                    { 25, "4", "Fantastic experience, highly recommend!", 88, 59 },
                    { 25, "5", "Disappointing, had high expectations.", 85, 87 },
                    { 25, "6", "Disappointing, had high expectations.", 92, 84 },
                    { 25, "7", "I didn't like this game much.", 81, 51 },
                    { 25, "8", "Quite boring and repetitive.", 77, 68 },
                    { 25, "9", "Disappointing, had high expectations.", 87, 24 },
                    { 26, "1", "Not bad, could be better.", 93, 61 },
                    { 26, "10", "Not bad, could be better.", 94, 77 },
                    { 26, "11", "Not bad, could be better.", 89, 37 },
                    { 26, "12", "Gameplay was not very engaging.", 78, 15 },
                    { 26, "13", "Fantastic experience, highly recommend!", 82, 67 },
                    { 26, "14", "Disappointing, had high expectations.", 95, 63 },
                    { 26, "15", "Loved the graphics and storyline.", 96, 76 },
                    { 26, "16", "Gameplay was not very engaging.", 83, 14 },
                    { 26, "17", "Fantastic experience, highly recommend!", 87, 89 },
                    { 26, "18", "Gameplay was not very engaging.", 81, 5 },
                    { 26, "19", "Loved the graphics and storyline.", 92, 11 },
                    { 26, "2", "Gameplay was not very engaging.", 84, 74 },
                    { 26, "20", "Average game, nothing special.", 91, 88 },
                    { 26, "3", "Fantastic experience, highly recommend!", 97, 33 },
                    { 26, "4", "Disappointing, had high expectations.", 79, 36 },
                    { 26, "5", "Great game, really enjoyed it!", 90, 83 },
                    { 26, "6", "Loved the graphics and storyline.", 80, 65 },
                    { 26, "7", "Gameplay was not very engaging.", 88, 6 },
                    { 26, "8", "Disappointing, had high expectations.", 85, 65 },
                    { 26, "9", "Average game, nothing special.", 86, 55 },
                    { 27, "1", "A must-play for all gamers!", 91, 29 },
                    { 27, "10", "Loved the graphics and storyline.", 93, 56 },
                    { 27, "11", "Average game, nothing special.", 100, 36 },
                    { 27, "12", "Fantastic experience, highly recommend!", 86, 30 },
                    { 27, "13", "Not bad, could be better.", 94, 75 },
                    { 27, "14", "Fantastic experience, highly recommend!", 99, 6 },
                    { 27, "15", "Quite boring and repetitive.", 85, 36 },
                    { 27, "16", "Fantastic experience, highly recommend!", 83, 77 },
                    { 27, "17", "A must-play for all gamers!", 87, 40 },
                    { 27, "18", "Disappointing, had high expectations.", 95, 60 },
                    { 27, "19", "Disappointing, had high expectations.", 81, 1 },
                    { 27, "2", "Fantastic experience, highly recommend!", 88, 73 },
                    { 27, "20", "I didn't like this game much.", 84, 52 },
                    { 27, "3", "Great game, really enjoyed it!", 97, 76 },
                    { 27, "4", "Fantastic experience, highly recommend!", 90, 70 },
                    { 27, "5", "Quite boring and repetitive.", 89, 57 },
                    { 27, "6", "Fantastic experience, highly recommend!", 98, 44 },
                    { 27, "7", "Not bad, could be better.", 82, 8 },
                    { 27, "8", "Quite boring and repetitive.", 92, 62 },
                    { 27, "9", "Great game, really enjoyed it!", 96, 64 },
                    { 28, "1", "Great game, really enjoyed it!", 95, 96 },
                    { 28, "10", "Loved the graphics and storyline.", 103, 34 },
                    { 28, "11", "Great game, really enjoyed it!", 85, 3 },
                    { 28, "12", "Quite boring and repetitive.", 93, 40 },
                    { 28, "13", "Not bad, could be better.", 98, 53 },
                    { 28, "14", "Gameplay was not very engaging.", 84, 67 },
                    { 28, "15", "Gameplay was not very engaging.", 101, 58 },
                    { 28, "16", "Great game, really enjoyed it!", 89, 99 },
                    { 28, "17", "Great game, really enjoyed it!", 100, 52 },
                    { 28, "18", "Fantastic experience, highly recommend!", 91, 55 },
                    { 28, "19", "Fantastic experience, highly recommend!", 88, 76 },
                    { 28, "2", "Disappointing, had high expectations.", 99, 93 },
                    { 28, "20", "Quite boring and repetitive.", 87, 7 },
                    { 28, "3", "Average game, nothing special.", 90, 81 },
                    { 28, "4", "I didn't like this game much.", 97, 62 },
                    { 28, "5", "Average game, nothing special.", 96, 17 },
                    { 28, "6", "Great game, really enjoyed it!", 86, 70 },
                    { 28, "7", "Loved the graphics and storyline.", 94, 55 },
                    { 28, "8", "Loved the graphics and storyline.", 102, 62 },
                    { 28, "9", "Gameplay was not very engaging.", 92, 5 },
                    { 29, "1", "Average game, nothing special.", 99, 18 },
                    { 29, "10", "Quite boring and repetitive.", 90, 50 },
                    { 29, "11", "I didn't like this game much.", 92, 12 },
                    { 29, "12", "Average game, nothing special.", 96, 82 },
                    { 29, "13", "I didn't like this game much.", 88, 24 },
                    { 29, "14", "Not bad, could be better.", 95, 60 },
                    { 29, "15", "A must-play for all gamers!", 104, 96 },
                    { 29, "16", "Fantastic experience, highly recommend!", 105, 1 },
                    { 29, "17", "I didn't like this game much.", 102, 37 },
                    { 29, "18", "A must-play for all gamers!", 103, 100 },
                    { 29, "19", "A must-play for all gamers!", 87, 59 },
                    { 29, "2", "I didn't like this game much.", 91, 33 },
                    { 29, "20", "I didn't like this game much.", 106, 1 },
                    { 29, "3", "Not bad, could be better.", 94, 46 },
                    { 29, "4", "Gameplay was not very engaging.", 100, 81 },
                    { 29, "5", "Great game, really enjoyed it!", 101, 70 },
                    { 29, "6", "Great game, really enjoyed it!", 97, 1 },
                    { 29, "7", "Quite boring and repetitive.", 89, 75 },
                    { 29, "8", "Not bad, could be better.", 98, 42 },
                    { 29, "9", "Not bad, could be better.", 93, 76 },
                    { 30, "1", "Great game, really enjoyed it!", 101, 64 },
                    { 30, "10", "Quite boring and repetitive.", 91, 80 },
                    { 30, "11", "Disappointing, had high expectations.", 90, 7 },
                    { 30, "12", "Gameplay was not very engaging.", 104, 26 },
                    { 30, "13", "Not bad, could be better.", 93, 81 },
                    { 30, "14", "Average game, nothing special.", 105, 73 },
                    { 30, "15", "Great game, really enjoyed it!", 103, 96 },
                    { 30, "16", "Loved the graphics and storyline.", 94, 80 },
                    { 30, "17", "Gameplay was not very engaging.", 96, 22 },
                    { 30, "18", "Not bad, could be better.", 100, 36 },
                    { 30, "19", "I didn't like this game much.", 106, 20 },
                    { 30, "2", "Fantastic experience, highly recommend!", 92, 55 },
                    { 30, "20", "Loved the graphics and storyline.", 107, 100 },
                    { 30, "3", "Loved the graphics and storyline.", 102, 3 },
                    { 30, "4", "Fantastic experience, highly recommend!", 98, 85 },
                    { 30, "5", "Not bad, could be better.", 109, 27 },
                    { 30, "6", "Average game, nothing special.", 97, 70 },
                    { 30, "7", "Loved the graphics and storyline.", 108, 84 },
                    { 30, "8", "Not bad, could be better.", 95, 3 },
                    { 30, "9", "A must-play for all gamers!", 99, 5 },
                    { 31, "1", "Average game, nothing special.", 99, 62 },
                    { 31, "10", "Great game, really enjoyed it!", 106, 86 },
                    { 31, "11", "I didn't like this game much.", 112, 9 },
                    { 31, "12", "I didn't like this game much.", 111, 56 },
                    { 31, "13", "Not bad, could be better.", 103, 12 },
                    { 31, "14", "Gameplay was not very engaging.", 93, 27 },
                    { 31, "15", "Loved the graphics and storyline.", 105, 74 },
                    { 31, "16", "Great game, really enjoyed it!", 108, 6 },
                    { 31, "17", "Quite boring and repetitive.", 98, 50 },
                    { 31, "18", "Not bad, could be better.", 107, 33 },
                    { 31, "19", "I didn't like this game much.", 102, 31 },
                    { 31, "2", "Disappointing, had high expectations.", 101, 71 },
                    { 31, "20", "Gameplay was not very engaging.", 100, 91 },
                    { 31, "3", "I didn't like this game much.", 109, 26 },
                    { 31, "4", "Not bad, could be better.", 94, 90 },
                    { 31, "5", "A must-play for all gamers!", 104, 31 },
                    { 31, "6", "A must-play for all gamers!", 95, 1 },
                    { 31, "7", "Great game, really enjoyed it!", 97, 83 },
                    { 31, "8", "Average game, nothing special.", 110, 91 },
                    { 31, "9", "Fantastic experience, highly recommend!", 96, 91 },
                    { 32, "1", "Loved the graphics and storyline.", 111, 28 },
                    { 32, "10", "I didn't like this game much.", 99, 7 },
                    { 32, "11", "Loved the graphics and storyline.", 110, 23 },
                    { 32, "12", "Average game, nothing special.", 100, 89 },
                    { 32, "13", "Quite boring and repetitive.", 113, 65 },
                    { 32, "14", "Great game, really enjoyed it!", 102, 96 },
                    { 32, "15", "Fantastic experience, highly recommend!", 108, 42 },
                    { 32, "16", "Gameplay was not very engaging.", 112, 24 },
                    { 32, "17", "A must-play for all gamers!", 101, 55 },
                    { 32, "18", "Fantastic experience, highly recommend!", 103, 65 },
                    { 32, "19", "Fantastic experience, highly recommend!", 98, 44 },
                    { 32, "2", "Great game, really enjoyed it!", 105, 24 },
                    { 32, "20", "Fantastic experience, highly recommend!", 96, 6 },
                    { 32, "3", "Quite boring and repetitive.", 97, 97 },
                    { 32, "4", "Gameplay was not very engaging.", 104, 8 },
                    { 32, "5", "A must-play for all gamers!", 114, 39 },
                    { 32, "6", "Great game, really enjoyed it!", 107, 56 },
                    { 32, "7", "Great game, really enjoyed it!", 109, 74 },
                    { 32, "8", "Gameplay was not very engaging.", 106, 67 },
                    { 32, "9", "A must-play for all gamers!", 115, 89 },
                    { 33, "1", "Loved the graphics and storyline.", 104, 94 },
                    { 33, "10", "I didn't like this game much.", 107, 60 },
                    { 33, "11", "Great game, really enjoyed it!", 99, 14 },
                    { 33, "12", "A must-play for all gamers!", 103, 85 },
                    { 33, "13", "Fantastic experience, highly recommend!", 102, 24 },
                    { 33, "14", "Average game, nothing special.", 108, 46 },
                    { 33, "15", "Great game, really enjoyed it!", 112, 69 },
                    { 33, "16", "Loved the graphics and storyline.", 105, 58 },
                    { 33, "17", "Disappointing, had high expectations.", 116, 59 },
                    { 33, "18", "Gameplay was not very engaging.", 101, 94 },
                    { 33, "19", "Gameplay was not very engaging.", 109, 99 },
                    { 33, "2", "Great game, really enjoyed it!", 100, 22 },
                    { 33, "20", "Fantastic experience, highly recommend!", 113, 99 },
                    { 33, "3", "Loved the graphics and storyline.", 115, 24 },
                    { 33, "4", "I didn't like this game much.", 110, 64 },
                    { 33, "5", "Quite boring and repetitive.", 106, 8 },
                    { 33, "6", "A must-play for all gamers!", 118, 18 },
                    { 33, "7", "Not bad, could be better.", 114, 36 },
                    { 33, "8", "Gameplay was not very engaging.", 117, 94 },
                    { 33, "9", "Disappointing, had high expectations.", 111, 83 }
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
