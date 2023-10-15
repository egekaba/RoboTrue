namespace RoboTrue.Core.Entities
{
    public class SatilanUrunler : BaseEntity
    {
        public string? UrunAdi { get; set; }
        public string UrunKodu { get; set; }
        public decimal? UrunFiyati { get; set; }

        public int? DovizCesidiId { get; set; }
        public ICollection<DovizCesidi>? DovizKuru { get; set; }

        public decimal? Kdv { get; set; }

        public int? SatilanCarilerId { get; set; }

        public ICollection<Cari>? SatilanCariler { get; set; }

    }
}