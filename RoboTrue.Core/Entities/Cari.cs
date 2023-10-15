namespace RoboTrue.Core.Entities
{
    public class Cari : BaseEntity
    {
        public string? CariKodu { get; set; }
        public string? CariUnvani { get; set; }
        public int? CariTipiId { get; set; }
        public CariTipi? CariTipi { get; set; }
        public int? FaliyetSektoruId { get; set; }
        public CariFaliyetSektoru? FaliyetSektoru { get; set; }
        public int? VerigiDairesiId { get; set; }
        public VergiDairesi? VerigiDairesi { get; set; }
        public string? VergiNo { get; set; }
        public string? VatandasNo { get; set; }
        public string? Email { get; set; }
        public string? OzelKod { get; set; }
        public int? CariAdresCesitId { get; set; }
        public AdresCesit? CariAdresCesit { get; set; }
        public string? AdresAd { get; set; }
        public string? AdresSoyisim { get; set; }
        public string? Adres1 { get; set; }
        public string? Adres2 { get; set; }
        public string? Adres3 { get; set; }
        public int? SehirId { get; set; }
        public Sehir? Sehir { get; set; }
        public string? PostaKodu { get; set; }
        public int? IlceId { get; set; }
        public Ilce? Ilce { get; set; }
        public int? UlkeId { get; set; }
        public Ulke? Ulke { get; set; }
        public int? TelefonCesitId { get; set; }
        public TelefonCesit? TelefonCesit { get; set; }
        public string? TelefonAdi { get; set; }
        public int? TelUlkeKoduId { get; set; }
        public TelUlkeKodu? TelUlkeKodu { get; set; }
        public string? TelNo { get; set; }
        public string? Aktiflik { get; set; }
        public string? Bloke { get; set; }
        public int? DovizCesidiId { get; set; }
        public DovizCesidi? CalismaDovizi { get; set; }
        public string? SgkNo { get; set; }
        public int? SatilanUrunleriId { get; set; }
        public SatilanUrunler? SatilanUrunleri { get; set; }

    }
}
