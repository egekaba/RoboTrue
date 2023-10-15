namespace RoboTrue.Core.Entities
{
    public class Menu : BaseEntity
    {
        public string MenuAdi { get; set; }
        public string? Area { get; set; }
        public string? Controller { get; set; }
        public string? Action { get; set; }
        public string? CssClass { get; set; }
        public string? Icon { get; set; }
        public string? Css2 { get; set; }
        public string? Css3 { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public ICollection<OlusturanKullanici> OlusturanKullanici { get; set; }

    }
}
