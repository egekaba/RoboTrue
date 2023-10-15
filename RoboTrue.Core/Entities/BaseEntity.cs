namespace RoboTrue.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        //olusturan kullanici
        public int OlusturanKullaniciId { get; set; }
        public ICollection<OlusturanKullanici> Kullanici { get; set; }
    }
}
