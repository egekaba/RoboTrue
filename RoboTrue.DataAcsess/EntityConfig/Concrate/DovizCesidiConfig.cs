using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class DovizCesidiConfig : BaseConfig<DovizCesidi>
    {
        public override void Configure(EntityTypeBuilder<DovizCesidi> builder)
        {
            base.Configure(builder);
            builder.HasData(new DovizCesidi
            {
                Id = 1,
                DovizCesitleri = "Tr",
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new DovizCesidi
            {
                Id = 2,
                DovizCesitleri = "Euro",
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new DovizCesidi
            {
                Id = 3,
                DovizCesitleri = "Dolar",
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new DovizCesidi
            {
                Id = 4,
                DovizCesitleri = "Sterlin",
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
        }
    }
}
