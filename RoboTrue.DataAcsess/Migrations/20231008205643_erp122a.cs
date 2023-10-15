using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoboTrue.DataAcsess.Migrations
{
    /// <inheritdoc />
    public partial class erp122a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuRole");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(5299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(4433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(3623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(2804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(1977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(1103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(9322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(8209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(6808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(5921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(5170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(4263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(1480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(8804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(9843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(7709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(6683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "BakimServisSozlesmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Kullanicii",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Sehirs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Ulkes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.CreateIndex(
                name: "IX_Menus_RoleId",
                table: "Menus",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Roles_RoleId",
                table: "Menus",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Roles_RoleId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_RoleId",
                table: "Menus");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(8286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(7354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(6492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(5635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(4566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(2370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(1427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 151, DateTimeKind.Local).AddTicks(670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(8615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(7731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(6872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(6012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(4527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(3351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(2502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 150, DateTimeKind.Local).AddTicks(726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(8125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(9254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(6931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 21, 39, 149, DateTimeKind.Local).AddTicks(5545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.CreateTable(
                name: "MenuRole",
                columns: table => new
                {
                    MenulerId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRole", x => new { x.MenulerId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_MenuRole_Menus_MenulerId",
                        column: x => x.MenulerId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuRole_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_RoleId",
                table: "MenuRole",
                column: "RoleId");
        }
    }
}
