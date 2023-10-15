namespace RoboTrue.Core.Entities
{
    public class SozlesmeDurum : BaseEntity
    {
        public string? SozlesmeDurumu { get; set; }
        public DateTime? SozlesmeBaslangıcTarihi { get; set; }
        public DateTime? SozlesmeBitis { get; set; }
    }
}