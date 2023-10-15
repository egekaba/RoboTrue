namespace RoboTrue.Core.Entities
{
    public class SatinAlinanUrun : BaseEntity
    {
        public string? UrunAdi { get; set; }
        public string UrunKodu { get; set; }
        public decimal? AlisFiyati { get; set; }
    }
}
