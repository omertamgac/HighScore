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
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    Discriminator = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "varchar(255)", nullable: true),
                    UserRating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "varchar(800)", maxLength: 800, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReviews_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                    { "0", 0, "af9866ad-9d55-48fb-bf90-16469da3ba15", "MetaUser", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEITp4dNQLJyxHcv66Z9FHYvUMWtdkJxz3rrODJSnRpMWGQsJ1B1Tqzgn1eyYARXjGw==", null, false, "29df0a62-deae-4aeb-b9c3-eed6aa0b81e4", false, "admin" },
                    { "1", 0, "58eb160b-b355-45b8-83bd-38c2df4a10e9", "MetaUser", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAENoCkDIOj2tBrf8C9N6Z6kHCcugeBzkfWi/jHqbVQmGSrVLehrdYcBn7l+nC//8Eig==", null, false, "3a32ea92-99aa-4f10-abde-74ffb55a47bf", false, "user1" },
                    { "10", 0, "46c87f59-a1d5-4b77-93c2-cda98ced7ff3", "MetaUser", "user10@example.com", true, false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEKbtdjNOKj+8XOM8V0qOQwaZUqJcvtqWsJN1FCuMALW+b1bGXAkOv4f+qRHDJWDPeA==", null, false, "48cf6098-fc73-4727-8ea2-c9be079cc0ab", false, "user10" },
                    { "11", 0, "0310ca5c-32ae-4fbf-af65-04923317c249", "MetaUser", "user11@example.com", true, false, null, "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEGR7X6TFp0xNkrQqAIe74dJ9WeC5u+t9GZwGlsz44mm9uJ+q6u6aHLk6DEOEPsiP3A==", null, false, "68476179-e8eb-433a-a604-4b94fd5b5bcf", false, "user11" },
                    { "12", 0, "b7b7d835-41de-47db-8306-1bcd4ed51ebd", "MetaUser", "user12@example.com", true, false, null, "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEMnxmbOC5X5ZqBAXlzglf5ihyTNB/eRGGcxaS5V5bA+U1lsfmPke0qXGAIkBIHtvvQ==", null, false, "298c2680-f7cc-4cf8-b3bf-9611245fa168", false, "user12" },
                    { "13", 0, "174bdf69-4eed-485d-98ed-8eacaa2a1539", "MetaUser", "user13@example.com", true, false, null, "USER13@EXAMPLE.COM", "USER13", "AQAAAAIAAYagAAAAELHmeCKafY56IqQ45t613pnf4t18tcgeAbz6tJLIAEqtjwpQBcD/Im8BXip/nQOT4w==", null, false, "a41d53f2-63fb-4859-a3ad-a6c9200b909a", false, "user13" },
                    { "14", 0, "00d16410-f8cc-4179-89d3-9b4ad315e1c6", "MetaUser", "user14@example.com", true, false, null, "USER14@EXAMPLE.COM", "USER14", "AQAAAAIAAYagAAAAEHgI5OB/FlAqT0aGjhVdh/GVSHcA9F5ldOGcJJX9oYlwmPyhefaK8ntZH9u8Bi/Khw==", null, false, "ef7f1d81-2d34-4f09-98a1-de241fb4e7ce", false, "user14" },
                    { "15", 0, "8ab7a617-0f80-4dc2-8902-c6c71cdba23e", "MetaUser", "user15@example.com", true, false, null, "USER15@EXAMPLE.COM", "USER15", "AQAAAAIAAYagAAAAEHcE9UI3X9NhRiFvTl/aVD5eCa5pCXy0P2MzUy18ADOO3ALbsyhpy5rbRm1u45WZow==", null, false, "857db488-097d-4e91-a06a-9c940470776e", false, "user15" },
                    { "16", 0, "9187b4b5-35fa-40d7-a58f-40cf3e3bf6f5", "MetaUser", "user16@example.com", true, false, null, "USER16@EXAMPLE.COM", "USER16", "AQAAAAIAAYagAAAAEAETWx7Pwmx5mdbvV8xbntI3ybMMgDi9IiPk5PORAlg3UOhWWHPqL3TbJTZP/gJpZA==", null, false, "dd946c1c-ce53-4bcf-9bb3-6116fe68a232", false, "user16" },
                    { "17", 0, "d6cd4893-b1e2-4842-aff0-f18eacc6b552", "MetaUser", "user17@example.com", true, false, null, "USER17@EXAMPLE.COM", "USER17", "AQAAAAIAAYagAAAAEAP8CcgtIxXvD6breITiXGXoQmfG+JUrnxYWi8zcq+LyadU8fQRWceTeIOvFwNVBRw==", null, false, "d0689acb-1d01-4e58-a8cb-4f7db1f36137", false, "user17" },
                    { "18", 0, "0af4914b-266d-42d7-aead-3627992261ed", "MetaUser", "user18@example.com", true, false, null, "USER18@EXAMPLE.COM", "USER18", "AQAAAAIAAYagAAAAEBTfFJLlZ6Sycp0yj6qnrQpHaTTbkA0nhdEq3pkB63brNAxUL6TgHbYAyu9sEodjVQ==", null, false, "250dfbea-d830-43ab-bb59-ee7639aa9f2b", false, "user18" },
                    { "19", 0, "7f6fd9c3-c9a3-4ec3-b65a-c155b1ed5b79", "MetaUser", "user19@example.com", true, false, null, "USER19@EXAMPLE.COM", "USER19", "AQAAAAIAAYagAAAAEPNbu1+19MFSHEcKy+82S1EP6lOpqFHYnVb+E3CcIcDFDcJ+evG/vPgcHAVePr18NQ==", null, false, "5fc00def-daaa-4785-a594-b3f337e63795", false, "user19" },
                    { "2", 0, "f353bb66-602e-4acb-8752-f14892c76c94", "MetaUser", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEFoOKVNJ8TTuz5HLOZD0IAa1ILsnZyI2AxfztzC9k7H7QazC8Igy+cXaPVmGxV4V6w==", null, false, "905bbbad-2019-4cdf-a9a2-9042285bdd38", false, "user2" },
                    { "20", 0, "c9af8435-3976-47a6-bfac-a65ae5a04a40", "MetaUser", "user20@example.com", true, false, null, "USER20@EXAMPLE.COM", "USER20", "AQAAAAIAAYagAAAAEHLrF/ypksJRslof8v+/NFVDOZbqpevqFN+8viqAUS90XipORUNEF4JJeZhYHakivA==", null, false, "335e2e09-d78a-4d3b-9310-aa03660ff31f", false, "user20" },
                    { "3", 0, "01b5e1db-a7be-4ff6-959a-a7d01335efd0", "MetaUser", "user3@example.com", true, false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAELt8wWlkqrt9iPj3ao8PMgQnVejYjQF0m/4g5mzWBvVolOKur8IHofh2URI4ngrCNA==", null, false, "bf954401-306d-4d8f-84a9-3b408d33ac3a", false, "user3" },
                    { "4", 0, "2443c989-bb45-49e1-86ce-ba8c584e26d9", "MetaUser", "user4@example.com", true, false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEJrv8NWMxp3x3y4+XtBb4olwgZ4YFgQCR9Bw/A7C/VomHLeEptvzTTZHmqX1RGuibA==", null, false, "3e54c8a6-09de-4805-b835-09d8fb975be1", false, "user4" },
                    { "5", 0, "14e5adbb-2f86-4717-918b-1e205efda3e5", "MetaUser", "user5@example.com", true, false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEPKo2Mp/UKzA1Fq7+ZIVu7fLSlcokJera7Ptv4dAcaS3s06Zjg/hEAB97+oMvHiZ6Q==", null, false, "43ca30b4-bcb7-44c5-84db-61931cb556c7", false, "user5" },
                    { "6", 0, "85fa094d-8f61-4e25-adaa-fc27851f6197", "MetaUser", "user6@example.com", true, false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEG1H+zbQEGU/iag0sZrpH3QJ3n6k3tIUZMV8iBBcodzVskT8l3sdaaruCc2xaULe7w==", null, false, "895a3909-7fb1-4418-b727-90bee9fb957c", false, "user6" },
                    { "7", 0, "1be5cbb8-8956-4e98-9a71-f21d22f07fe8", "MetaUser", "user7@example.com", true, false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEBDMmUPPsmQerIHbt5QhGgTGsr/u6CWAJcqYOe3W51TSA/eNO4N0vdYUgAZu+pO/Bg==", null, false, "a0dba4cf-6389-42b4-9321-be76a2cfc718", false, "user7" },
                    { "8", 0, "106328ec-c6b4-4f8b-b492-21ed9adc0c3c", "MetaUser", "user8@example.com", true, false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEExKhAz/Ls1TWvTcqF5D3G+1N/C+owPt4YyqtOL505iJOo9Wab0ntdfTlFE7DGEfCQ==", null, false, "6c781dab-3aee-4fe9-b287-620031bf4313", false, "user8" },
                    { "9", 0, "5192ef40-2c59-4eb1-8fb2-caabf8b106fb", "MetaUser", "user9@example.com", true, false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEKKGV1/WCO2m2aiPVmEGr4fTNJCN4v8AflsmFFobMG9vhNjbxuOpzcbEJcxSB5jLjg==", null, false, "92acc107-a3b3-4be8-a02e-6115a99c2756", false, "user9" }
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
                    { 1, "An action-adventure game developed and published by Nintendo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/zw47_q9wbBE\" title=\"The Legend of Zelda: Breath of the Wild - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(990), "1.jpg" },
                    { 2, "A platform game developed and published by Nintendo for the Nintendo Switch.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/5kcdRBHM7kM\" title=\"Super Mario Odyssey - Nintendo Switch Presentation 2017 Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super Mario Odyssey", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1008), "2.webp" },
                    { 3, "An action-adventure game developed and published by Rockstar Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HVRzx17WHVk\" title=\"Red Dead Redemption 2 Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1011), "3.jpg" },
                    { 4, "An action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/Ty7WudwSKMA\" title=\"God of War: Ragnarok - Teaser Trailer | PS5 Showcase\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1013), "4.jpg" },
                    { 5, "An action role-playing game developed and published by CD Projekt.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/c0i88t0Kacs\" title=\"The Witcher 3: Wild Hunt - Killing Monsters Cinematic Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1015), "5.jpg" },
                    { 6, "An action role-playing game developed and published by CD Projekt.", "<iframe width=\"930\" height=\"388\" src=\"https://www.youtube.com/embed/P99qJGrPNLs\" title=\"Cyberpunk 2077 Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1019), "6.jpg" },
                    { 7, "A sandbox video game developed by Mojang.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/MmB9b5njVbA\" title=\"Official Minecraft Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1021), "7.jpg" },
                    { 8, "An online video game developed by Epic Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/hHTE5xg9E-g\" title=\"Fortnite Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1023), "8.png" },
                    { 9, "An action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/JSRtYpNRoN0\" title=\"The Elder Scrolls V: Skyrim - Official Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1025), "9.jpg" },
                    { 10, "An action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/u4-FCsiF5x4\" title=\"Horizon Zero Dawn - E3 2016 Trailer I PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Zero Dawn", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1028), "10.jpg" },
                    { 11, "An action role-playing game developed and published by Square Enix.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/CNM6o9um1dc\" title=\"FINAL FANTASY XV - Omen Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Fantasy XV", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1030), "11.jpg" },
                    { 12, "A role-playing video game developed by Atlus.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/QnDzJ9KzuV4\" title=\"Persona 5 | Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persona 5", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1033), "12.png" },
                    { 13, "An action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cWBwFhUv1-8\" title=\"Dark Souls III – Launch Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Souls III", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1036), "13.jpg" },
                    { 14, "An action role-playing game developed by FromSoftware and published by Sony Computer Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/G203e1HhixY\" title=\"Bloodborne Debut Trailer | Face Your Fears | PlayStation 4 Action RPG\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2015, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloodborne", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1038), "14.jpg" },
                    { 15, "A team-based multiplayer first-person shooter developed and published by Blizzard Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/IBIwGKDwnWY\" title=\"Overwatch Theatrical Teaser | &quot;We Are Overwatch&quot;\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2016, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1040), "15.jpg" },
                    { 16, "An action-adventure game developed by FromSoftware and published by Activision.", "", new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekiro: Shadows Die Twice", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1042), "16.jpg" },
                    { 17, "An action role-playing game developed by Team Ninja and published by Koei Tecmo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/cHTtNdkDduQ\" title=\"Nioh 2 Reveal Teaser Trailer - E3 2018\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2017, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nioh", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1045), "17.jpg" },
                    { 18, "An action role-playing game developed and published by Capcom.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monster Hunter: World", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1047), "18.png" },
                    { 19, "A survival horror game developed and published by Capcom.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/xtxJtQa6VSw\" title=\"Resident Evil 2 – E3 2018 Announcement Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 2", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1049), "19.jpg" },
                    { 20, "An action-adventure game developed by Sucker Punch Productions and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/RcWk08PBe7k\" title=\"Ghost of Tsushima - A Storm is Coming Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost of Tsushima", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1051), "20.jpg" },
                    { 21, "An action role-playing video game developed by Ubisoft Montreal and published by Ubisoft.", "<iframe width=\"930\" height=\"390\" src=\"https://www.youtube.com/embed/rKjUAWlbTJk\" title=\"Assassin’s Creed Valhalla: Cinematic World Premiere Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1053), "21.jpg" },
                    { 22, "An action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/W2Wnvvj33Wo\" title=\"The Last of Us Part II - PlayStation Experience 2016: Reveal Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1055), "22.jpg" },
                    { 23, "An action-adventure game developed by Remedy Entertainment and published by 505 Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/w6bE11FrSFM\" title=\"Control - Ultimate Edition Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1058), "23.jpg" },
                    { 24, "A roguelike action dungeon crawler video game developed and published by Supergiant Games.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/91t0ha9x0AE\" title=\"Hades - Official Animated Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hades", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1060), "24.png" },
                    { 25, "A first-person shooter game developed by id Software and published by Bethesda Softworks.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/_oVwrpfo_QA\" title=\"DOOM Eternal – Official E3 Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doom Eternal", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1063), "25.jpg" },
                    { 26, "An action role-playing game developed and published by miHoYo.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/HLUY1nICQRY\" title=\"Genshin Impact - Official Launch Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genshin Impact", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1065), "26.jpg" },
                    { 27, "An action game developed by Kojima Productions and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/H2Hy96sOnq8\" title=\"Death Stranding - Teaser Trailer - TGA 2016 - 4K\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Stranding", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1073), "27.jpg" },
                    { 28, "An action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/q4GdJVvdxss\" title=\"Marvel’s Spider-Man – Be Greater Extended Trailer | PS4\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1075), "28.jpg" },
                    { 29, "A virtual reality first-person shooter developed and published by Valve.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/O2W0N3uKXmo\" title=\"Half-Life: Alyx Announcement Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life: Alyx", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1077), "29.webp" },
                    { 30, "An action role-playing game developed and published by TaleWorlds Entertainment. Bannerlord is a prequel to Mount & Blade: Warband, a stand-alone expansion pack for the 2008 game Mount & Blade.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/yCk6Jk7DvrA\" title=\"Mount &amp; Blade II: Bannerlord Early Access Announcement\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mount and Blade II: Bannerlord", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1089), "30.jpg" },
                    { 31, "Explore the depths of Arkham Asylum as Batman, unraveling a sinister plot orchestrated by his arch-nemesis, the Joker.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/bVk9jW9EzD0\" title=\"Batman: Arkham Asylum Teaser Trailer\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2009, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Asylum", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1108), "31.jpg" },
                    { 32, "Gotham City is transformed into a sprawling prison, and Batman must navigate its dangerous streets to uncover a new threat.", "<iframe width=\"853\" height=\"480\" src=\"https://www.youtube.com/embed/pcaFdTCiz4U\" title=\"Batman: Arkham City - Teaser\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>", new DateTime(2011, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham City", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1110), "32.jpg" },
                    { 33, "The Dark Knight faces the ultimate threat to Gotham City as the Scarecrow unites Batman's foes to destroy him once and for all.", "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/wsf78BS9VE0\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe>\r\n", new DateTime(2015, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Knight", new DateTime(2024, 8, 6, 1, 2, 25, 736, DateTimeKind.Local).AddTicks(1112), "33.jpg" }
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

            migrationBuilder.InsertData(
                table: "UserReviews",
                columns: new[] { "Id", "Comment", "ItemId", "UserId", "UserId1", "UserRating" },
                values: new object[,]
                {
                    { 3, "Not bad, could be better.", 1, 9, null, 3 },
                    { 4, "Great game, really enjoyed it!", 1, 6, null, 5 },
                    { 5, "A must-play for all gamers!", 1, 8, null, 8 },
                    { 6, "Loved the graphics and storyline.", 2, 2, null, 2 },
                    { 7, "Disappointing, had high expectations.", 2, 9, null, 8 },
                    { 8, "I didn't like this game much.", 2, 16, null, 3 },
                    { 9, "Not bad, could be better.", 3, 6, null, 9 },
                    { 10, "I didn't like this game much.", 3, 16, null, 2 },
                    { 11, "Loved the graphics and storyline.", 3, 11, null, 1 },
                    { 12, "Quite boring and repetitive.", 4, 5, null, 9 },
                    { 13, "Quite boring and repetitive.", 4, 7, null, 4 },
                    { 14, "Great game, really enjoyed it!", 4, 11, null, 2 },
                    { 15, "Loved the graphics and storyline.", 5, 6, null, 2 },
                    { 16, "A must-play for all gamers!", 5, 10, null, 8 },
                    { 17, "Not bad, could be better.", 5, 20, null, 4 },
                    { 18, "Not bad, could be better.", 6, 11, null, 4 },
                    { 19, "I didn't like this game much.", 6, 6, null, 5 },
                    { 20, "A must-play for all gamers!", 6, 8, null, 10 },
                    { 21, "I didn't like this game much.", 7, 19, null, 10 },
                    { 22, "Not bad, could be better.", 7, 6, null, 5 },
                    { 23, "Fantastic experience, highly recommend!", 7, 5, null, 7 },
                    { 24, "I didn't like this game much.", 8, 20, null, 10 },
                    { 25, "Disappointing, had high expectations.", 8, 11, null, 2 },
                    { 26, "Great game, really enjoyed it!", 8, 10, null, 2 },
                    { 27, "Disappointing, had high expectations.", 9, 17, null, 10 },
                    { 28, "Not bad, could be better.", 9, 1, null, 7 },
                    { 29, "Great game, really enjoyed it!", 9, 12, null, 2 },
                    { 30, "A must-play for all gamers!", 10, 9, null, 5 },
                    { 31, "Great game, really enjoyed it!", 10, 19, null, 3 },
                    { 32, "Not bad, could be better.", 10, 6, null, 1 },
                    { 33, "Average game, nothing special.", 11, 5, null, 2 },
                    { 34, "Quite boring and repetitive.", 11, 9, null, 2 },
                    { 35, "Loved the graphics and storyline.", 11, 2, null, 2 },
                    { 36, "Gameplay was not very engaging.", 12, 7, null, 3 },
                    { 37, "Average game, nothing special.", 12, 9, null, 3 },
                    { 38, "Average game, nothing special.", 12, 4, null, 5 },
                    { 39, "A must-play for all gamers!", 13, 11, null, 10 },
                    { 40, "Gameplay was not very engaging.", 13, 19, null, 5 },
                    { 41, "Quite boring and repetitive.", 13, 20, null, 10 },
                    { 42, "Average game, nothing special.", 14, 15, null, 2 },
                    { 43, "Quite boring and repetitive.", 14, 1, null, 2 },
                    { 44, "A must-play for all gamers!", 14, 17, null, 6 },
                    { 45, "Great game, really enjoyed it!", 15, 16, null, 8 },
                    { 46, "Disappointing, had high expectations.", 15, 2, null, 9 },
                    { 47, "Disappointing, had high expectations.", 15, 17, null, 7 },
                    { 48, "Fantastic experience, highly recommend!", 16, 14, null, 8 },
                    { 49, "Great game, really enjoyed it!", 16, 12, null, 3 },
                    { 50, "Great game, really enjoyed it!", 16, 15, null, 6 },
                    { 51, "Fantastic experience, highly recommend!", 17, 6, null, 3 },
                    { 52, "Quite boring and repetitive.", 17, 11, null, 9 },
                    { 53, "Great game, really enjoyed it!", 17, 16, null, 6 },
                    { 54, "Not bad, could be better.", 18, 20, null, 9 },
                    { 55, "Loved the graphics and storyline.", 18, 4, null, 9 },
                    { 56, "Average game, nothing special.", 18, 15, null, 10 },
                    { 57, "Great game, really enjoyed it!", 19, 8, null, 5 },
                    { 58, "Average game, nothing special.", 19, 5, null, 5 },
                    { 59, "I didn't like this game much.", 19, 12, null, 10 },
                    { 60, "Disappointing, had high expectations.", 20, 4, null, 10 },
                    { 61, "Disappointing, had high expectations.", 20, 7, null, 6 },
                    { 62, "Not bad, could be better.", 20, 1, null, 10 },
                    { 63, "Average game, nothing special.", 21, 6, null, 5 },
                    { 64, "Not bad, could be better.", 21, 17, null, 8 },
                    { 65, "Not bad, could be better.", 21, 12, null, 4 },
                    { 66, "I didn't like this game much.", 22, 13, null, 7 },
                    { 67, "Great game, really enjoyed it!", 22, 5, null, 8 },
                    { 68, "Disappointing, had high expectations.", 22, 12, null, 7 },
                    { 69, "Loved the graphics and storyline.", 23, 5, null, 4 },
                    { 70, "Average game, nothing special.", 23, 14, null, 10 },
                    { 71, "Fantastic experience, highly recommend!", 23, 4, null, 5 },
                    { 72, "A must-play for all gamers!", 24, 2, null, 9 },
                    { 73, "A must-play for all gamers!", 24, 20, null, 6 },
                    { 74, "Average game, nothing special.", 24, 12, null, 2 },
                    { 75, "Not bad, could be better.", 25, 20, null, 9 },
                    { 76, "Loved the graphics and storyline.", 25, 16, null, 4 },
                    { 77, "Average game, nothing special.", 25, 18, null, 10 },
                    { 78, "Fantastic experience, highly recommend!", 26, 3, null, 9 },
                    { 79, "Gameplay was not very engaging.", 26, 15, null, 3 },
                    { 80, "Loved the graphics and storyline.", 26, 11, null, 1 },
                    { 81, "Average game, nothing special.", 27, 19, null, 10 },
                    { 82, "Not bad, could be better.", 27, 13, null, 5 },
                    { 83, "Disappointing, had high expectations.", 27, 7, null, 4 },
                    { 84, "Loved the graphics and storyline.", 28, 11, null, 10 },
                    { 85, "I didn't like this game much.", 28, 11, null, 5 },
                    { 86, "Great game, really enjoyed it!", 28, 2, null, 7 },
                    { 87, "I didn't like this game much.", 29, 11, null, 2 },
                    { 88, "Quite boring and repetitive.", 29, 16, null, 4 },
                    { 89, "Quite boring and repetitive.", 29, 1, null, 7 },
                    { 90, "Quite boring and repetitive.", 30, 13, null, 1 },
                    { 91, "A must-play for all gamers!", 30, 20, null, 2 },
                    { 92, "I didn't like this game much.", 30, 12, null, 10 },
                    { 93, "Average game, nothing special.", 31, 3, null, 9 },
                    { 94, "Loved the graphics and storyline.", 31, 19, null, 8 },
                    { 95, "Loved the graphics and storyline.", 31, 8, null, 5 },
                    { 96, "Disappointing, had high expectations.", 32, 20, null, 7 },
                    { 97, "Loved the graphics and storyline.", 32, 11, null, 6 },
                    { 98, "Not bad, could be better.", 32, 15, null, 3 },
                    { 99, "A must-play for all gamers!", 33, 13, null, 9 },
                    { 100, "Disappointing, had high expectations.", 33, 10, null, 3 },
                    { 101, "Average game, nothing special.", 33, 7, null, 4 }
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

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_UserId1",
                table: "UserReviews",
                column: "UserId1");
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
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
