using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "UserReviews",
                type: "varchar(800)",
                maxLength: 800,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8259), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8274), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8277), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8280), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8284), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8290), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8294), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8297), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8300), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8302), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8305), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8308), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8311), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8317), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8320), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8322), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8325), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8328), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8331), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8334), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8341), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8344), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8346), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8359), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8363), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8367), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8371), new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedTime", "Description", "MediaAverageRating", "RelaseDate", "Title", "UpdatedAt", "UserAverageRating" },
                values: new object[,]
                {
                    { 31, new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8379), "Explore the depths of Arkham Asylum as Batman, unraveling a sinister plot orchestrated by his arch-nemesis, the Joker.", 9.2m, new DateTime(2009, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Asylum", null, 9.0m },
                    { 32, new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8381), "Gotham City is transformed into a sprawling prison, and Batman must navigate its dangerous streets to uncover a new threat.", 9.3m, new DateTime(2011, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham City", null, 9.1m },
                    { 33, new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8383), "The Dark Knight faces the ultimate threat to Gotham City as the Scarecrow unites Batman's foes to destroy him once and for all.", 9.0m, new DateTime(2015, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Arkham Knight", null, 8.9m }
                });

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 779, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 780, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 35, 19, 781, DateTimeKind.Local).AddTicks(3329));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "UserReviews",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(800)",
                oldMaxLength: 800);

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6428), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6431), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6434), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6437), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6440), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6444), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6446), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6448), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6450), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6453), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6455), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6457), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6461), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6463), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6465), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6467), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6479), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6481), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6483), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6486), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6488), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6491), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6493), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6495), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6497), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6500), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6502), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6505), new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 742, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 743, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 10, 23, 22, 36, 744, DateTimeKind.Local).AddTicks(282));
        }
    }
}
