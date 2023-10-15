namespace RoboTrue.Core.Entities
{
    public class BakimServisSozlesme : BaseEntity
    {
        public int CariId { get; set; }
        public ICollection<Cari> Caris { get; set; }
        public int SozlesmeDurumId { get; set; }
        public ICollection<SozlesmeDurum> SozlesmeD { get; set; }

    }
}
