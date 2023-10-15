using Microsoft.EntityFrameworkCore;
using RoboTrue.Core.Entities;
using System.Reflection;

namespace RoboTrue.DataAcsess.Contexts
{
    public class SqlDbContext : DbContext
    {

        public DbSet<AdresCesit> AdresCesits { get; set; }
        public DbSet<BakimServisSozlesme> BakimServisSozlesmes { get; set; }
        public DbSet<Cari> Caris { get; set; }
        public DbSet<CariFaliyetSektoru> CariFaliyetSektorus { get; set; }
        public DbSet<CariTipi> CariTipis { get; set; }
        public DbSet<Departman> Departmen { get; set; }
        public DbSet<DovizCesidi> DovizCesidis { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
        public DbSet<IsDurumu> IsDurumus { get; set; }
        public DbSet<Isler> Islers { get; set; }
        public DbSet<Kefil> Kefils { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SahisUnvani> SahisUnvanis { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }
        public DbSet<SozlesmeDurum> SozlesmeDurums { get; set; }
        public DbSet<TelefonCesit> TelefonCesits { get; set; }
        public DbSet<TelUlkeKodu> TelUlkeKodus { get; set; }
        public DbSet<Ulke> Ulkes { get; set; }
        public DbSet<VergiDairesi> VergiDairesis { get; set; }
        public DbSet<SatilanUrunler> SatilanUruns { get; set; }
        public DbSet<Depo> Depos { get; set; }
        public DbSet<SatinAlinanUrun> SatinAlinanUruns { get; set; }
        public DbSet<OlusturanKullanici> Kullanicii { get; set; }






        public SqlDbContext()
        {

        }

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ErpApp1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
