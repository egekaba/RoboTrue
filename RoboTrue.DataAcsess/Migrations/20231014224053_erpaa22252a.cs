using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoboTrue.DataAcsess.Migrations
{
    /// <inheritdoc />
    public partial class erpaa22252a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caris_Depos_DepoId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_DovizCesidis_Depos_DepoId",
                table: "DovizCesidis");

            migrationBuilder.DropIndex(
                name: "IX_DovizCesidis_DepoId",
                table: "DovizCesidis");

            migrationBuilder.DropIndex(
                name: "IX_Caris_DepoId",
                table: "Caris");

            migrationBuilder.DropColumn(
                name: "DepoId",
                table: "DovizCesidis");

            migrationBuilder.DropColumn(
                name: "DovizCesidiId",
                table: "Depos");

            migrationBuilder.DropColumn(
                name: "Kdv",
                table: "Depos");

            migrationBuilder.DropColumn(
                name: "SatilanCarilerId",
                table: "Depos");

            migrationBuilder.DropColumn(
                name: "UrunAdi",
                table: "Depos");

            migrationBuilder.DropColumn(
                name: "UrunFiyati",
                table: "Depos");

            migrationBuilder.DropColumn(
                name: "DepoId",
                table: "Caris");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 494, DateTimeKind.Local).AddTicks(823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 831, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(9842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 831, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(8918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(8031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(7079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(6052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(5076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(3890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(2791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(1242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(9125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(8077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(6968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(5849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.AlterColumn<string>(
                name: "UrunKodu",
                table: "Depos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(4752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(3769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(1292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(2701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 491, DateTimeKind.Local).AddTicks(8737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 491, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 491, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 491, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "BakimServisSozlesmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Kullanicii",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Sehirs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Ulkes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(9842));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 831, DateTimeKind.Local).AddTicks(966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 494, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 831, DateTimeKind.Local).AddTicks(97),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(9288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(8280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(2250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(9065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(8075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(7135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(5634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(4687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 493, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(3703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(2755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.AddColumn<int>(
                name: "DepoId",
                table: "DovizCesidis",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrunKodu",
                table: "Depos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DovizCesidiId",
                table: "Depos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Kdv",
                table: "Depos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "SatilanCarilerId",
                table: "Depos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrunAdi",
                table: "Depos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "UrunFiyati",
                table: "Depos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(7086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.AddColumn<int>(
                name: "DepoId",
                table: "Caris",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(8315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(6279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 492, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(5346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 15, 1, 40, 52, 491, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "BakimServisSozlesmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "DepoId" },
                values: new object[] { new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1018), null });

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "DepoId" },
                values: new object[] { new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1031), null });

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "DepoId" },
                values: new object[] { new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1034), null });

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "DepoId" },
                values: new object[] { new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1037), null });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Kullanicii",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Sehirs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Ulkes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 14, 23, 1, 2, 831, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.CreateIndex(
                name: "IX_DovizCesidis_DepoId",
                table: "DovizCesidis",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_DepoId",
                table: "Caris",
                column: "DepoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_Depos_DepoId",
                table: "Caris",
                column: "DepoId",
                principalTable: "Depos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DovizCesidis_Depos_DepoId",
                table: "DovizCesidis",
                column: "DepoId",
                principalTable: "Depos",
                principalColumn: "Id");
        }
    }
}
