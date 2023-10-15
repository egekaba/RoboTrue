using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{

    public class KullaniciConfig : KullaniciBaseConfig<OlusturanKullanici>
    {
        public override void Configure(EntityTypeBuilder<OlusturanKullanici> builder)
        {
            base.Configure(builder);
            builder.HasData(new OlusturanKullanici
            {
                Id = 1,
                CreateDate = DateTime.Now,
                DepartmanId = 3,
                Email = "egekava3235@gmail.com",
                KayitliOlduguDepartman = { },
                KullaniciAdi = "Ege Kaba",
                Rol = { },
                RolId = 2,
                Sifre = "ege32353908306"

            });
        }
    }
}
