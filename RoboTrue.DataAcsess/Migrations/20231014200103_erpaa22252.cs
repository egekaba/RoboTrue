using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoboTrue.DataAcsess.Migrations
{
    /// <inheritdoc />
    public partial class erpaa22252 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 831, DateTimeKind.Local).AddTicks(966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 869, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 831, DateTimeKind.Local).AddTicks(97),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 869, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(9288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(8280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.AlterColumn<string>(
                name: "SozlesmeDurumu",
                table: "SozlesmeDurums",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SozlesmeBitis",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SozlesmeBaslangıcTarihi",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(2250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.AlterColumn<string>(
                name: "UrunKodu",
                table: "SatinAlinanUruns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrunKodu",
                table: "SatilanUruns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(9065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(8075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(7135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(5634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(4687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(3703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(2755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.AddColumn<int>(
                name: "DepoId",
                table: "DovizCesidis",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "UrunKodu",
                table: "Depos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(7086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(5447));

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
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(6279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(5346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(3022));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "UrunKodu",
                table: "Depos");

            migrationBuilder.DropColumn(
                name: "DepoId",
                table: "Caris");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 869, DateTimeKind.Local).AddTicks(1547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 831, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 869, DateTimeKind.Local).AddTicks(726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 831, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(9941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(9197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.AlterColumn<string>(
                name: "SozlesmeDurumu",
                table: "SozlesmeDurums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SozlesmeBitis",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SozlesmeBaslangıcTarihi",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(8285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(7471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 830, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.AlterColumn<string>(
                name: "UrunKodu",
                table: "SatinAlinanUruns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UrunKodu",
                table: "SatilanUruns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(6721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(5899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(5012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(3448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(2671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(1807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 868, DateTimeKind.Local).AddTicks(107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(9229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 829, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(8447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(7424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(5447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(6653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(4376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 16, 30, 36, 867, DateTimeKind.Local).AddTicks(3022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 14, 23, 1, 2, 828, DateTimeKind.Local).AddTicks(5346));

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
    }
}
