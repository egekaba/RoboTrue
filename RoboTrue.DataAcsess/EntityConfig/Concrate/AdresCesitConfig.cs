using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class AdresCesitConfig : BaseConfig<AdresCesit>
    {
        public override void Configure(EntityTypeBuilder<AdresCesit> builder)
        {
            base.Configure(builder);
            builder.HasData(new AdresCesit
            {
                Id = 1,
                AdresCesidi = "İş Yeri",
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new AdresCesit
            {
                Id = 2,
                AdresCesidi = "Ev",
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new AdresCesit
            {
                Id = 3,
                AdresCesidi = "Diğer",
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });

        }
    }
}
