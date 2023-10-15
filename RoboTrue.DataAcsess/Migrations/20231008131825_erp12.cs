using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoboTrue.DataAcsess.Migrations
{
    /// <inheritdoc />
    public partial class erp12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BakimServisSozlesmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CariId = table.Column<int>(type: "int", nullable: false),
                    SozlesmeDurumId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(6978)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakimServisSozlesmes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departmen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(473))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Depos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GelenUrunId = table.Column<int>(type: "int", nullable: false),
                    CıkanUrunId = table.Column<int>(type: "int", nullable: false),
                    ToplamUrunSayisi = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Islers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GelenTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDurumuId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(4118)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Islers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kefils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KefilAdiSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(4897)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kefils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CssClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Css2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Css3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(7890))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SahisUnvanis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SahisGorevi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(451)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SahisUnvanis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SozlesmeDurums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SozlesmeDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SozlesmeBaslangıcTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SozlesmeBitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BakimServisSozlesmeId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(2309)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SozlesmeDurums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SozlesmeDurums_BakimServisSozlesmes_BakimServisSozlesmeId",
                        column: x => x.BakimServisSozlesmeId,
                        principalTable: "BakimServisSozlesmes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SatilanUruns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DovizCesidiId = table.Column<int>(type: "int", nullable: true),
                    Kdv = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SatilanCarilerId = table.Column<int>(type: "int", nullable: true),
                    DepoId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatilanUruns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SatilanUruns_Depos_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SatinAlinanUruns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlisFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepoId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatinAlinanUruns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SatinAlinanUruns_Depos_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IsDurumus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciliyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IslerId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(3276)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsDurumus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsDurumus_Islers_IslerId",
                        column: x => x.IslerId,
                        principalTable: "Islers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Caris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CariKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariUnvani = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariTipiId = table.Column<int>(type: "int", nullable: false),
                    FaliyetSektoruId = table.Column<int>(type: "int", nullable: false),
                    VerigiDairesiId = table.Column<int>(type: "int", nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VatandasNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OzelKod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariAdresCesitId = table.Column<int>(type: "int", nullable: false),
                    AdresAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresSoyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirId = table.Column<int>(type: "int", nullable: false),
                    PostaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlceId = table.Column<int>(type: "int", nullable: false),
                    UlkeId = table.Column<int>(type: "int", nullable: false),
                    TelefonCesitId = table.Column<int>(type: "int", nullable: false),
                    TelefonAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelUlkeKoduId = table.Column<int>(type: "int", nullable: false),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aktiflik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bloke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DovizCesidiId = table.Column<int>(type: "int", nullable: false),
                    SgkNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SatilanUrunleriId = table.Column<int>(type: "int", nullable: true),
                    BakimServisSozlesmeId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(7887)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caris_BakimServisSozlesmes_BakimServisSozlesmeId",
                        column: x => x.BakimServisSozlesmeId,
                        principalTable: "BakimServisSozlesmes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Caris_SatilanUruns_SatilanUrunleriId",
                        column: x => x.SatilanUrunleriId,
                        principalTable: "SatilanUruns",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdresCesits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresCesidi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(5895)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdresCesits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdresCesits_Caris_CariId",
                        column: x => x.CariId,
                        principalTable: "Caris",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CariFaliyetSektorus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaliyetSektoru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(8772)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CariFaliyetSektorus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CariFaliyetSektorus_Caris_CariId",
                        column: x => x.CariId,
                        principalTable: "Caris",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CariTipis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(9579)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CariTipis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CariTipis_Caris_CariId",
                        column: x => x.CariId,
                        principalTable: "Caris",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DovizCesidis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DovizCesitleri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    SatilanUrunlerId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(1259)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DovizCesidis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DovizCesidis_Caris_CariId",
                        column: x => x.CariId,
                        principalTable: "Caris",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DovizCesidis_SatilanUruns_SatilanUrunlerId",
                        column: x => x.SatilanUrunlerId,
                        principalTable: "SatilanUruns",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ilces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlceAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirId = table.Column<int>(type: "int", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2262)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilces_Caris_CariId",
                        column: x => x.CariId,
                        principalTable: "Caris",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TelefonCesits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelefonCesiti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(3118)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonCesits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelefonCesits_Caris_CariId",
                        column: x => x.CariId,
                        principalTable: "Caris",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TelUlkeKodus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlkeKodlari = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(3958)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelUlkeKodus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelUlkeKodus_Caris_CariId",
                        column: x => x.CariId,
                        principalTable: "Caris",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VergiDairesis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VergiDairesiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(5754)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VergiDairesis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VergiDairesis_Caris_CariId",
                        column: x => x.CariId,
                        principalTable: "Caris",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sehirs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UlkeId = table.Column<int>(type: "int", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    IlceId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(1342)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sehirs_Caris_CariId",
                        column: x => x.CariId,
                        principalTable: "Caris",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sehirs_Ilces_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ulkes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ulkeler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    SehirId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 834, DateTimeKind.Local).AddTicks(4820)),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulkes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ulkes_Caris_CariId",
                        column: x => x.CariId,
                        principalTable: "Caris",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ulkes_Sehirs_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kullanicii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresCesitId = table.Column<int>(type: "int", nullable: true),
                    BakimServisSozlesmeId = table.Column<int>(type: "int", nullable: true),
                    CariFaliyetSektoruId = table.Column<int>(type: "int", nullable: true),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    CariTipiId = table.Column<int>(type: "int", nullable: true),
                    DepoId = table.Column<int>(type: "int", nullable: true),
                    DovizCesidiId = table.Column<int>(type: "int", nullable: true),
                    IlceId = table.Column<int>(type: "int", nullable: true),
                    IsDurumuId = table.Column<int>(type: "int", nullable: true),
                    IslerId = table.Column<int>(type: "int", nullable: true),
                    KefilId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    MenuId1 = table.Column<int>(type: "int", nullable: true),
                    SahisUnvaniId = table.Column<int>(type: "int", nullable: true),
                    SatilanUrunlerId = table.Column<int>(type: "int", nullable: true),
                    SatinAlinanUrunId = table.Column<int>(type: "int", nullable: true),
                    SehirId = table.Column<int>(type: "int", nullable: true),
                    SozlesmeDurumId = table.Column<int>(type: "int", nullable: true),
                    TelUlkeKoduId = table.Column<int>(type: "int", nullable: true),
                    TelefonCesitId = table.Column<int>(type: "int", nullable: true),
                    UlkeId = table.Column<int>(type: "int", nullable: true),
                    VergiDairesiId = table.Column<int>(type: "int", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmanId = table.Column<int>(type: "int", nullable: true),
                    RolId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(5794))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicii", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanicii_AdresCesits_AdresCesitId",
                        column: x => x.AdresCesitId,
                        principalTable: "AdresCesits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_BakimServisSozlesmes_BakimServisSozlesmeId",
                        column: x => x.BakimServisSozlesmeId,
                        principalTable: "BakimServisSozlesmes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_CariFaliyetSektorus_CariFaliyetSektoruId",
                        column: x => x.CariFaliyetSektoruId,
                        principalTable: "CariFaliyetSektorus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_CariTipis_CariTipiId",
                        column: x => x.CariTipiId,
                        principalTable: "CariTipis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_Caris_CariId",
                        column: x => x.CariId,
                        principalTable: "Caris",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_Departmen_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departmen",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_Depos_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_DovizCesidis_DovizCesidiId",
                        column: x => x.DovizCesidiId,
                        principalTable: "DovizCesidis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_Ilces_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_IsDurumus_IsDurumuId",
                        column: x => x.IsDurumuId,
                        principalTable: "IsDurumus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_Islers_IslerId",
                        column: x => x.IslerId,
                        principalTable: "Islers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_Kefils_KefilId",
                        column: x => x.KefilId,
                        principalTable: "Kefils",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_Menus_MenuId1",
                        column: x => x.MenuId1,
                        principalTable: "Menus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_SahisUnvanis_SahisUnvaniId",
                        column: x => x.SahisUnvaniId,
                        principalTable: "SahisUnvanis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_SatilanUruns_SatilanUrunlerId",
                        column: x => x.SatilanUrunlerId,
                        principalTable: "SatilanUruns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_SatinAlinanUruns_SatinAlinanUrunId",
                        column: x => x.SatinAlinanUrunId,
                        principalTable: "SatinAlinanUruns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_Sehirs_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_SozlesmeDurums_SozlesmeDurumId",
                        column: x => x.SozlesmeDurumId,
                        principalTable: "SozlesmeDurums",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_TelUlkeKodus_TelUlkeKoduId",
                        column: x => x.TelUlkeKoduId,
                        principalTable: "TelUlkeKodus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_TelefonCesits_TelefonCesitId",
                        column: x => x.TelefonCesitId,
                        principalTable: "TelefonCesits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_Ulkes_UlkeId",
                        column: x => x.UlkeId,
                        principalTable: "Ulkes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kullanicii_VergiDairesis_VergiDairesiId",
                        column: x => x.VergiDairesiId,
                        principalTable: "VergiDairesis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(8967)),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Kullanicii_OlusturanKullaniciId",
                        column: x => x.OlusturanKullaniciId,
                        principalTable: "Kullanicii",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "AdresCesits",
                columns: new[] { "Id", "AdresCesidi", "CariId", "CreateDate", "OlusturanKullaniciId" },
                values: new object[,]
                {
                    { 1, "İş Yeri", null, new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(6272), 1 },
                    { 2, "Ev", null, new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(6295), 1 },
                    { 3, "Diğer", null, new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(6298), 1 }
                });

            migrationBuilder.InsertData(
                table: "BakimServisSozlesmes",
                columns: new[] { "Id", "CariId", "CreateDate", "OlusturanKullaniciId", "SozlesmeDurumId" },
                values: new object[] { 1, 1, new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(7224), 1, 1 });

            migrationBuilder.InsertData(
                table: "CariTipis",
                columns: new[] { "Id", "CariId", "CreateDate", "OlusturanKullaniciId", "SirketTipi" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(9851), 1, "Anonim Şirket" },
                    { 2, null, new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(9866), 1, "Limited Şirket" },
                    { 3, null, new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(9869), 1, "Şahıs Şirket" },
                    { 4, null, new DateTime(2023, 10, 8, 16, 18, 24, 832, DateTimeKind.Local).AddTicks(9872), 1, "Şahıs" }
                });

            migrationBuilder.InsertData(
                table: "Departmen",
                columns: new[] { "Id", "CreateDate", "DepartmanAdi" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(708), "Satış" },
                    { 2, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(722), "Teknik" },
                    { 3, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(725), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "DovizCesidis",
                columns: new[] { "Id", "CariId", "CreateDate", "DovizCesitleri", "OlusturanKullaniciId", "SatilanUrunlerId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(1587), "Tr", 1, null },
                    { 2, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(1602), "Euro", 1, null },
                    { 3, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(1605), "Dolar", 1, null },
                    { 4, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(1607), "Sterlin", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Ilces",
                columns: new[] { "Id", "CariId", "CreateDate", "IlceAdi", "OlusturanKullaniciId", "SehirId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2578), "Aladağ", 1, 1 },
                    { 2, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2594), "Ceyhan", 1, 1 },
                    { 3, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2596), "Çukurova", 1, 1 },
                    { 4, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2599), "Feke", 1, 1 },
                    { 5, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2602), "İmamoğlu", 1, 1 },
                    { 6, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2607), "Karaisalı", 1, 1 },
                    { 7, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2611), "Karataş", 1, 1 },
                    { 8, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2613), "Kozan", 1, 1 },
                    { 9, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2616), "Pozantı", 1, 1 },
                    { 10, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2620), "Saimbeyli", 1, 1 },
                    { 11, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2623), "Sarıçam", 1, 1 },
                    { 12, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2625), "Seyhan", 1, 1 },
                    { 13, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2628), "Tufanbeyli", 1, 1 },
                    { 14, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2631), "Yumurtalık", 1, 1 },
                    { 15, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(2633), "Yüreğir", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "OlusturanKullaniciId", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(9629), null, "Personel" },
                    { 2, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(9650), null, "Yetkili" }
                });

            migrationBuilder.InsertData(
                table: "Sehirs",
                columns: new[] { "Id", "CariId", "IlceId", "OlusturanKullaniciId", "SehirAdi", "UlkeId" },
                values: new object[] { 1, null, null, 0, "Adana", 1 });

            migrationBuilder.InsertData(
                table: "Ulkes",
                columns: new[] { "Id", "CariId", "OlusturanKullaniciId", "SehirId", "Ulkeler" },
                values: new object[] { 1, null, 1, null, "Türkiye" });

            migrationBuilder.InsertData(
                table: "Kullanicii",
                columns: new[] { "Id", "AdresCesitId", "BakimServisSozlesmeId", "CariFaliyetSektoruId", "CariId", "CariTipiId", "CreateDate", "DepartmanId", "DepoId", "DovizCesidiId", "Email", "IlceId", "IsDurumuId", "IslerId", "KefilId", "KullaniciAdi", "MenuId", "MenuId1", "RolId", "SahisUnvaniId", "SatilanUrunlerId", "SatinAlinanUrunId", "SehirId", "Sifre", "SozlesmeDurumId", "TelUlkeKoduId", "TelefonCesitId", "UlkeId", "VergiDairesiId" },
                values: new object[] { 1, null, null, null, null, null, new DateTime(2023, 10, 8, 16, 18, 24, 833, DateTimeKind.Local).AddTicks(6648), 3, null, null, "egekava3235@gmail.com", null, null, null, null, "Ege Kaba", null, null, 2, null, null, null, null, "ege32353908306", null, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_AdresCesits_CariId",
                table: "AdresCesits",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_CariFaliyetSektorus_CariId",
                table: "CariFaliyetSektorus",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_BakimServisSozlesmeId",
                table: "Caris",
                column: "BakimServisSozlesmeId");

            migrationBuilder.CreateIndex(
                name: "IX_Caris_SatilanUrunleriId",
                table: "Caris",
                column: "SatilanUrunleriId");

            migrationBuilder.CreateIndex(
                name: "IX_CariTipis_CariId",
                table: "CariTipis",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_DovizCesidis_CariId",
                table: "DovizCesidis",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_DovizCesidis_SatilanUrunlerId",
                table: "DovizCesidis",
                column: "SatilanUrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilces_CariId",
                table: "Ilces",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_IsDurumus_IslerId",
                table: "IsDurumus",
                column: "IslerId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_AdresCesitId",
                table: "Kullanicii",
                column: "AdresCesitId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_BakimServisSozlesmeId",
                table: "Kullanicii",
                column: "BakimServisSozlesmeId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_CariFaliyetSektoruId",
                table: "Kullanicii",
                column: "CariFaliyetSektoruId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_CariId",
                table: "Kullanicii",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_CariTipiId",
                table: "Kullanicii",
                column: "CariTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_DepartmanId",
                table: "Kullanicii",
                column: "DepartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_DepoId",
                table: "Kullanicii",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_DovizCesidiId",
                table: "Kullanicii",
                column: "DovizCesidiId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_IlceId",
                table: "Kullanicii",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_IsDurumuId",
                table: "Kullanicii",
                column: "IsDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_IslerId",
                table: "Kullanicii",
                column: "IslerId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_KefilId",
                table: "Kullanicii",
                column: "KefilId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_MenuId",
                table: "Kullanicii",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_MenuId1",
                table: "Kullanicii",
                column: "MenuId1");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_SahisUnvaniId",
                table: "Kullanicii",
                column: "SahisUnvaniId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_SatilanUrunlerId",
                table: "Kullanicii",
                column: "SatilanUrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_SatinAlinanUrunId",
                table: "Kullanicii",
                column: "SatinAlinanUrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_SehirId",
                table: "Kullanicii",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_SozlesmeDurumId",
                table: "Kullanicii",
                column: "SozlesmeDurumId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_TelefonCesitId",
                table: "Kullanicii",
                column: "TelefonCesitId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_TelUlkeKoduId",
                table: "Kullanicii",
                column: "TelUlkeKoduId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_UlkeId",
                table: "Kullanicii",
                column: "UlkeId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicii_VergiDairesiId",
                table: "Kullanicii",
                column: "VergiDairesiId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_RoleId",
                table: "MenuRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_OlusturanKullaniciId",
                table: "Roles",
                column: "OlusturanKullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_SatilanUruns_DepoId",
                table: "SatilanUruns",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_SatinAlinanUruns_DepoId",
                table: "SatinAlinanUruns",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sehirs_CariId",
                table: "Sehirs",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Sehirs_IlceId",
                table: "Sehirs",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_SozlesmeDurums_BakimServisSozlesmeId",
                table: "SozlesmeDurums",
                column: "BakimServisSozlesmeId");

            migrationBuilder.CreateIndex(
                name: "IX_TelefonCesits_CariId",
                table: "TelefonCesits",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_TelUlkeKodus_CariId",
                table: "TelUlkeKodus",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Ulkes_CariId",
                table: "Ulkes",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Ulkes_SehirId",
                table: "Ulkes",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_VergiDairesis_CariId",
                table: "VergiDairesis",
                column: "CariId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuRole");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Kullanicii");

            migrationBuilder.DropTable(
                name: "AdresCesits");

            migrationBuilder.DropTable(
                name: "CariFaliyetSektorus");

            migrationBuilder.DropTable(
                name: "CariTipis");

            migrationBuilder.DropTable(
                name: "Departmen");

            migrationBuilder.DropTable(
                name: "DovizCesidis");

            migrationBuilder.DropTable(
                name: "IsDurumus");

            migrationBuilder.DropTable(
                name: "Kefils");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "SahisUnvanis");

            migrationBuilder.DropTable(
                name: "SatinAlinanUruns");

            migrationBuilder.DropTable(
                name: "SozlesmeDurums");

            migrationBuilder.DropTable(
                name: "TelUlkeKodus");

            migrationBuilder.DropTable(
                name: "TelefonCesits");

            migrationBuilder.DropTable(
                name: "Ulkes");

            migrationBuilder.DropTable(
                name: "VergiDairesis");

            migrationBuilder.DropTable(
                name: "Islers");

            migrationBuilder.DropTable(
                name: "Sehirs");

            migrationBuilder.DropTable(
                name: "Ilces");

            migrationBuilder.DropTable(
                name: "Caris");

            migrationBuilder.DropTable(
                name: "BakimServisSozlesmes");

            migrationBuilder.DropTable(
                name: "SatilanUruns");

            migrationBuilder.DropTable(
                name: "Depos");
        }
    }
}
