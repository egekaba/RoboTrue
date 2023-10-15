using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoboTrue.DataAcsess.Migrations
{
    /// <inheritdoc />
    public partial class erpaa22245 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 869, DateTimeKind.Local).AddTicks(1547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 869, DateTimeKind.Local).AddTicks(726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(9941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(9197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(8285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(7471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.AddColumn<string>(
                name: "UrunKodu",
                table: "SatinAlinanUruns",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(6721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(5899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(5012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(3448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(2671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(1807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(9229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(8447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(7424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(5447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(6653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(4376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(3022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "BakimServisSozlesmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Kullanicii",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Sehirs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Ulkes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 10, 16, 30, 36, 869, DateTimeKind.Local).AddTicks(726));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrunKodu",
                table: "SatinAlinanUruns");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(5695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 869, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(4650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 869, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(3756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 792, DateTimeKind.Local).AddTicks(446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(9269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(8123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(6912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(5392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(4339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(1925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 791, DateTimeKind.Local).AddTicks(885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(9562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(8350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(6589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(5209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(3921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(1864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 790, DateTimeKind.Local).AddTicks(489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(6275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 13, 44, 31, 789, DateTimeKind.Local).AddTicks(3942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(3022));

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
    }
}
