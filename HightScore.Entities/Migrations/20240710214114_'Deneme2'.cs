using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HightScore.Entities.Migrations
{
    /// <inheritdoc />
    public partial class Deneme2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 554, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 554, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 554, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 554, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "AdminActions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 554, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4243), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4260), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4267), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4271), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4275), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4279), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4284), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4288), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4297), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4305), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4309), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4313), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4317), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4325), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4329), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4332), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4336), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4339), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4344), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4347), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4351), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4369), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4373), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4381), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4385), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4388), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4392), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4396), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4399), new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 556, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 556, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 556, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 556, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 556, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 556, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 556, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 556, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 556, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "MediaReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 556, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 555, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 11, 0, 41, 13, 557, DateTimeKind.Local).AddTicks(6741));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8379), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8381), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedTime", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 35, 19, 778, DateTimeKind.Local).AddTicks(8383), null });

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
    }
}
