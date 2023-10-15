namespace RoboTrue.Core.Entities
{
    public class Ilce : BaseEntity
    {
        public string IlceAdi { get; set; }
        public int SehirId { get; set; }
        public ICollection<Sehir> Sehiri { get; set; }
    }
}