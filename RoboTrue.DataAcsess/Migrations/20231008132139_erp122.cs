using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoboTrue.DataAcsess.Migrations
{
    /// <inheritdoc />
    public partial class erp122 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(8286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(7354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(6492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(5635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(4566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(2370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(1427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(8615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(7731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(6872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(6012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(3351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(2502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(8125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(9254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(6931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(5545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "BakimServisSozlesmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Kullanicii",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Sehirs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Ulkes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(7354));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(5754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(4820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(3958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(3118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(2309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(1342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(8967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(7890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(5794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(4897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(4118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(3276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(1259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(9579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(7887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(6978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(5895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "BakimServisSozlesmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Kullanicii",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Sehirs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Ulkes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(4820));
        }
    }
}
