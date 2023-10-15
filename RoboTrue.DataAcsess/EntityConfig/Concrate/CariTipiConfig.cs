using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class CariTipiConfig : BaseConfig<CariTipi>
    {
        public override void Configure(EntityTypeBuilder<CariTipi> builder)
        {
            base.Configure(builder);
            builder.HasData(new CariTipi
            {
                Id = 1,
                SirketTipi = "Anonim Şirket",
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });

            builder.HasData(new CariTipi
            {
                Id = 2,
                SirketTipi = "Limited Şirket",
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });

            builder.HasData(new CariTipi
            {
                Id = 3,
                SirketTipi = "Şahıs Şirket",
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });

            builder.HasData(new CariTipi
            {
                Id = 4,
                SirketTipi = "Şahıs",
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });

        }
    }
}
