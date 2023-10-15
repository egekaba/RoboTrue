namespace RoboTrue.Core.Entities
{
    public class Depo : BaseEntity
    {
        public int? GelenUrunId { get; set; }
        public ICollection<SatinAlinanUrun>? GelenUrun { get; set; }
        public int? CıkanUrunId { get; set; }
        public ICollection<SatilanUrunler>? CıkanUrun { get; set; }
        public int? ToplamUrunSayisi { get; set; }


        public string? UrunKodu { get; set; }



    }
}
