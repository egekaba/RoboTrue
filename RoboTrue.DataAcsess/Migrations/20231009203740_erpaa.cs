using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoboTrue.DataAcsess.Migrations
{
    /// <inheritdoc />
    public partial class erpaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caris_AdresCesits_CariAdresCesitId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_CariFaliyetSektorus_FaliyetSektoruId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_CariTipis_CariTipiId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_DovizCesidis_DovizCesidiId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_Ilces_IlceId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_Sehirs_SehirId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_TelUlkeKodus_TelUlkeKoduId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_TelefonCesits_TelefonCesitId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_Ulkes_UlkeId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_VergiDairesis_VerigiDairesiId",
                table: "Caris");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(9519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(8658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(7855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(7090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(6262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(5416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(4531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(3686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(2876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(1328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(9531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(7771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(6763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(5830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(4943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.AlterColumn<int>(
                name: "VerigiDairesiId",
                table: "Caris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VatandasNo",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "UlkeId",
                table: "Caris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TelefonCesitId",
                table: "Caris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TelefonAdi",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TelUlkeKoduId",
                table: "Caris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TelNo",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SgkNo",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SehirId",
                table: "Caris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PostaKodu",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OzelKod",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IlceId",
                table: "Caris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FaliyetSektoruId",
                table: "Caris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DovizCesidiId",
                table: "Caris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(2765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.AlterColumn<string>(
                name: "CariUnvani",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CariTipiId",
                table: "Caris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CariKodu",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CariAdresCesitId",
                table: "Caris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Bloke",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Aktiflik",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AdresSoyisim",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AdresAd",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Adres3",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Adres2",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Adres1",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FaliyetSektoru",
                table: "CariFaliyetSektorus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(3999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(1744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "BakimServisSozlesmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Kullanicii",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Sehirs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Ulkes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_AdresCesits_CariAdresCesitId",
                table: "Caris",
                column: "CariAdresCesitId",
                principalTable: "AdresCesits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_CariFaliyetSektorus_FaliyetSektoruId",
                table: "Caris",
                column: "FaliyetSektoruId",
                principalTable: "CariFaliyetSektorus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_CariTipis_CariTipiId",
                table: "Caris",
                column: "CariTipiId",
                principalTable: "CariTipis",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_DovizCesidis_DovizCesidiId",
                table: "Caris",
                column: "DovizCesidiId",
                principalTable: "DovizCesidis",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_Ilces_IlceId",
                table: "Caris",
                column: "IlceId",
                principalTable: "Ilces",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_Sehirs_SehirId",
                table: "Caris",
                column: "SehirId",
                principalTable: "Sehirs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_TelUlkeKodus_TelUlkeKoduId",
                table: "Caris",
                column: "TelUlkeKoduId",
                principalTable: "TelUlkeKodus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_TelefonCesits_TelefonCesitId",
                table: "Caris",
                column: "TelefonCesitId",
                principalTable: "TelefonCesits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_Ulkes_UlkeId",
                table: "Caris",
                column: "UlkeId",
                principalTable: "Ulkes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_VergiDairesis_VerigiDairesiId",
                table: "Caris",
                column: "VerigiDairesiId",
                principalTable: "VergiDairesis",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caris_AdresCesits_CariAdresCesitId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_CariFaliyetSektorus_FaliyetSektoruId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_CariTipis_CariTipiId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_DovizCesidis_DovizCesidiId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_Ilces_IlceId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_Sehirs_SehirId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_TelUlkeKodus_TelUlkeKoduId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_TelefonCesits_TelefonCesitId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_Ulkes_UlkeId",
                table: "Caris");

            migrationBuilder.DropForeignKey(
                name: "FK_Caris_VergiDairesis_VerigiDairesiId",
                table: "Caris");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(8032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(7217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(6378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(5627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(4727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(3903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(3058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(2239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(1393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(9951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(9147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 242, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(8264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(7455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(5719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.AlterColumn<int>(
                name: "VerigiDairesiId",
                table: "Caris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VatandasNo",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UlkeId",
                table: "Caris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TelefonCesitId",
                table: "Caris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefonAdi",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TelUlkeKoduId",
                table: "Caris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelNo",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SgkNo",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SehirId",
                table: "Caris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostaKodu",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OzelKod",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IlceId",
                table: "Caris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FaliyetSektoruId",
                table: "Caris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DovizCesidiId",
                table: "Caris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(2190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.AlterColumn<string>(
                name: "CariUnvani",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CariTipiId",
                table: "Caris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CariKodu",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CariAdresCesitId",
                table: "Caris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bloke",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aktiflik",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdresSoyisim",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdresAd",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adres3",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adres2",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adres1",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FaliyetSektoru",
                table: "CariFaliyetSektorus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(3270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(1379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(97),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 23, 37, 40, 241, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "BakimServisSozlesmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Departmen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Kullanicii",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Sehirs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Ulkes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_AdresCesits_CariAdresCesitId",
                table: "Caris",
                column: "CariAdresCesitId",
                principalTable: "AdresCesits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_CariFaliyetSektorus_FaliyetSektoruId",
                table: "Caris",
                column: "FaliyetSektoruId",
                principalTable: "CariFaliyetSektorus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_CariTipis_CariTipiId",
                table: "Caris",
                column: "CariTipiId",
                principalTable: "CariTipis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_DovizCesidis_DovizCesidiId",
                table: "Caris",
                column: "DovizCesidiId",
                principalTable: "DovizCesidis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_Ilces_IlceId",
                table: "Caris",
                column: "IlceId",
                principalTable: "Ilces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_Sehirs_SehirId",
                table: "Caris",
                column: "SehirId",
                principalTable: "Sehirs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_TelUlkeKodus_TelUlkeKoduId",
                table: "Caris",
                column: "TelUlkeKoduId",
                principalTable: "TelUlkeKodus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_TelefonCesits_TelefonCesitId",
                table: "Caris",
                column: "TelefonCesitId",
                principalTable: "TelefonCesits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_Ulkes_UlkeId",
                table: "Caris",
                column: "UlkeId",
                principalTable: "Ulkes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Caris_VergiDairesis_VerigiDairesiId",
                table: "Caris",
                column: "VerigiDairesiId",
                principalTable: "VergiDairesis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
