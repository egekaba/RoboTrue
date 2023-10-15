namespace RoboTrue.Core.Entities
{
    public class Kullanici
    {

        public int Id { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Sifre { get; set; }
        public string? Email { get; set; }

        public int? DepartmanId { get; set; }
        public Departman? KayitliOlduguDepartman { get; set; }

        public int? RolId { get; set; }
        public ICollection<Role>? Rol { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
