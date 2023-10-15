using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoboTrue.DataAcsess.Migrations
{
    /// <inheritdoc />
    public partial class erpaa222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(5695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 880, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(4650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 880, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(3756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 880, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 880, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(9269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 880, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(8123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(6912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(5392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(4339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(1925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(9562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(8350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(6589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(5209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.AlterColumn<int>(
                name: "ToplamUrunSayisi",
                table: "Depos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GelenUrunId",
                table: "Depos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CıkanUrunId",
                table: "Depos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(3921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(1864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(6275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(3942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "BakimServisSozlesmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Kullanicii",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Sehirs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Ulkes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(4650));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 880, DateTimeKind.Local).AddTicks(3369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 880, DateTimeKind.Local).AddTicks(2505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 880, DateTimeKind.Local).AddTicks(1718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 880, DateTimeKind.Local).AddTicks(928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 880, DateTimeKind.Local).AddTicks(77),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(9199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(8287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(7426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(6612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(4970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(4049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(3151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(2320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.AlterColumn<int>(
                name: "ToplamUrunSayisi",
                table: "Depos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GelenUrunId",
                table: "Depos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CıkanUrunId",
                table: "Depos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(9442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(8524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(6375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(7586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(5367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(4092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "BakimServisSozlesmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 878, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Kullanicii",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Sehirs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 879, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Ulkes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 13, 34, 8, 880, DateTimeKind.Local).AddTicks(2505));
        }
    }
}
