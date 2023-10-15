namespace RoboTrue.Core.Entities
{
    public class Sehir : BaseEntity
    {
        public string SehirAdi { get; set; }
        public int UlkeId { get; set; }
        public ICollection<Ulke> Ulkesi { get; set; }
    }
}