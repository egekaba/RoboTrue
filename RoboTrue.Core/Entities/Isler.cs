namespace RoboTrue.Core.Entities
{
    public class Isler : BaseEntity
    {
        public string IsAdi { get; set; }
        public string Aciklama { get; set; }
        public DateTime GelenTarih { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int IsDurumuId { get; set; }
        public ICollection<IsDurumu> IsınAciliyeti { get; set; }

    }
}