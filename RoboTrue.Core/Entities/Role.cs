namespace RoboTrue.Core.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string RoleName { get; set; }
        public ICollection<Menu> Menuler { get; set; }


    }
}