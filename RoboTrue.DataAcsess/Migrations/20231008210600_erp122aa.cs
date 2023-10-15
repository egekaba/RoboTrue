using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoboTrue.DataAcsess.Migrations
{
    /// <inheritdoc />
    public partial class erp122aa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdresCesits_Caris_CariId",
                table: "AdresCesits");

            migrationBuilder.DropForeignKey(
                name: "FK_CariFaliyetSektorus_Caris_CariId",
                table: "CariFaliyetSektorus");

            migrationBuilder.DropForeignKey(
                name: "FK_CariTipis_Caris_CariId",
                table: "CariTipis");

            migrationBuilder.DropForeignKey(
                name: "FK_DovizCesidis_Caris_CariId",
                table: "DovizCesidis");

            migrationBuilder.DropForeignKey(
                name: "FK_Ilces_Caris_CariId",
                table: "Ilces");

            migrationBuilder.DropForeignKey(
                name: "FK_Sehirs_Caris_CariId",
                table: "Sehirs");

            migrationBuilder.DropForeignKey(
                name: "FK_TelefonCesits_Caris_CariId",
                table: "TelefonCesits");

            migrationBuilder.DropForeignKey(
                name: "FK_TelUlkeKodus_Caris_CariId",
                table: "TelUlkeKodus");

            migrationBuilder.DropForeignKey(
                name: "FK_Ulkes_Caris_CariId",
                table: "Ulkes");

            migrationBuilder.DropForeignKey(
                name: "FK_VergiDairesis_Caris_CariId",
                table: "VergiDairesis");

            migrationBuilder.DropIndex(
                name: "IX_VergiDairesis_CariId",
                table: "VergiDairesis");

            migrationBuilder.DropIndex(
                name: "IX_Ulkes_CariId",
                table: "Ulkes");

            migrationBuilder.DropIndex(
                name: "IX_TelUlkeKodus_CariId",
                table: "TelUlkeKodus");

            migrationBuilder.DropIndex(
                name: "IX_TelefonCesits_CariId",
                table: "TelefonCesits");

            migrationBuilder.DropIndex(
                name: "IX_Sehirs_CariId",
                table: "Sehirs");

            migrationBuilder.DropIndex(
                name: "IX_Ilces_CariId",
                table: "Ilces");

            migrationBuilder.DropIndex(
                name: "IX_DovizCesidis_CariId",
                table: "DovizCesidis");

            migrationBuilder.DropIndex(
                name: "IX_CariTipis_CariId",
                table: "CariTipis");

            migrationBuilder.DropIndex(
                name: "IX_CariFaliyetSektorus_CariId",
                table: "CariFaliyetSektorus");

            migrationBuilder.DropIndex(
                name: "IX_AdresCesits_CariId",
                table: "AdresCesits");

            migrationBuilder.DropColumn(
                name: "CariId",
                table: "VergiDairesis");

            migrationBuilder.DropColumn(
                name: "CariId",
                table: "Ulkes");

            migrationBuilder.DropColumn(
                name: "CariId",
                table: "TelUlkeKodus");

            migrationBuilder.DropColumn(
                name: "CariId",
                table: "TelefonCesits");

            migrationBuilder.DropColumn(
                name: "CariId",
                table: "Sehirs");

            migrationBuilder.DropColumn(
                name: "CariId",
                table: "Ilces");

            migrationBuilder.DropColumn(
                name: "CariId",
                table: "DovizCesidis");

            migrationBuilder.DropColumn(
                name: "CariId",
                table: "CariTipis");

            migrationBuilder.DropColumn(
                name: "CariId",
                table: "CariFaliyetSektorus");

            migrationBuilder.DropColumn(
                name: "CariId",
                table: "AdresCesits");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(8032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(7217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(6378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(5627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(4727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(3903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(3058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(2239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(1393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(9951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(9147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(8264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(7455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(5719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(2190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(3270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(1379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(97),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(6683));

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

            migrationBuilder.CreateIndex(
                name: "IX_Caris_CariAdresCesitId",
                table: "Caris",
                column: "CariAdresCesitId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_CariTipiId",
                table: "Caris",
                column: "CariTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_DovizCesidiId",
                table: "Caris",
                column: "DovizCesidiId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_FaliyetSektoruId",
                table: "Caris",
                column: "FaliyetSektoruId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_IlceId",
                table: "Caris",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_SehirId",
                table: "Caris",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_TelefonCesitId",
                table: "Caris",
                column: "TelefonCesitId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_TelUlkeKoduId",
                table: "Caris",
                column: "TelUlkeKoduId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_UlkeId",
                table: "Caris",
                column: "UlkeId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_VerigiDairesiId",
                table: "Caris",
                column: "VerigiDairesiId");

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

            migrationBuilder.DropIndex(
                name: "IX_Caris_CariAdresCesitId",
                table: "Caris");

            migrationBuilder.DropIndex(
                name: "IX_Caris_CariTipiId",
                table: "Caris");

            migrationBuilder.DropIndex(
                name: "IX_Caris_DovizCesidiId",
                table: "Caris");

            migrationBuilder.DropIndex(
                name: "IX_Caris_FaliyetSektoruId",
                table: "Caris");

            migrationBuilder.DropIndex(
                name: "IX_Caris_IlceId",
                table: "Caris");

            migrationBuilder.DropIndex(
                name: "IX_Caris_SehirId",
                table: "Caris");

            migrationBuilder.DropIndex(
                name: "IX_Caris_TelefonCesitId",
                table: "Caris");

            migrationBuilder.DropIndex(
                name: "IX_Caris_TelUlkeKoduId",
                table: "Caris");

            migrationBuilder.DropIndex(
                name: "IX_Caris_UlkeId",
                table: "Caris");

            migrationBuilder.DropIndex(
                name: "IX_Caris_VerigiDairesiId",
                table: "Caris");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "VergiDairesis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(5299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.AddColumn<int>(
                name: "CariId",
                table: "VergiDairesis",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ulkes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(4433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.AddColumn<int>(
                name: "CariId",
                table: "Ulkes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelUlkeKodus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(3623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.AddColumn<int>(
                name: "CariId",
                table: "TelUlkeKodus",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "TelefonCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(2804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.AddColumn<int>(
                name: "CariId",
                table: "TelefonCesits",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeDurums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(1977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sehirs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(1103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.AddColumn<int>(
                name: "CariId",
                table: "Sehirs",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SahisUnvanis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(9322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(8209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 174, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicii",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(6808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Kefils",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(5921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Islers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(5170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "IsDurumus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(4263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ilces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.AddColumn<int>(
                name: "CariId",
                table: "Ilces",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "DovizCesidis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.AddColumn<int>(
                name: "CariId",
                table: "DovizCesidis",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Departmen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(1480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariTipis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.AddColumn<int>(
                name: "CariId",
                table: "CariTipis",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Caris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(8804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CariFaliyetSektorus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(9843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.AddColumn<int>(
                name: "CariId",
                table: "CariFaliyetSektorus",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BakimServisSozlesmes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(7709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AdresCesits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(6683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 9, 0, 6, 0, 173, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.AddColumn<int>(
                name: "CariId",
                table: "AdresCesits",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "AdresCesits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 373, DateTimeKind.Local).AddTicks(7116) });

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
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "CariTipis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(977) });

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
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "DovizCesidis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 374, DateTimeKind.Local).AddTicks(3634) });

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
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Ulkes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CariId", "CreateDate" },
                values: new object[] { null, new DateTime(2023, 10, 8, 23, 56, 43, 375, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.CreateIndex(
                name: "IX_VergiDairesis_CariId",
                table: "VergiDairesis",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Ulkes_CariId",
                table: "Ulkes",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_TelUlkeKodus_CariId",
                table: "TelUlkeKodus",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_TelefonCesits_CariId",
                table: "TelefonCesits",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Sehirs_CariId",
                table: "Sehirs",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilces_CariId",
                table: "Ilces",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_DovizCesidis_CariId",
                table: "DovizCesidis",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_CariTipis_CariId",
                table: "CariTipis",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_CariFaliyetSektorus_CariId",
                table: "CariFaliyetSektorus",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_AdresCesits_CariId",
                table: "AdresCesits",
                column: "CariId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdresCesits_Caris_CariId",
                table: "AdresCesits",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CariFaliyetSektorus_Caris_CariId",
                table: "CariFaliyetSektorus",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CariTipis_Caris_CariId",
                table: "CariTipis",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DovizCesidis_Caris_CariId",
                table: "DovizCesidis",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ilces_Caris_CariId",
                table: "Ilces",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sehirs_Caris_CariId",
                table: "Sehirs",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TelefonCesits_Caris_CariId",
                table: "TelefonCesits",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TelUlkeKodus_Caris_CariId",
                table: "TelUlkeKodus",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ulkes_Caris_CariId",
                table: "Ulkes",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VergiDairesis_Caris_CariId",
                table: "VergiDairesis",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id");
        }
    }
}
