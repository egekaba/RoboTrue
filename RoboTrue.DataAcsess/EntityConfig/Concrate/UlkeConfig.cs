using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class UlkeConfig : BaseConfig<Ulke>
    {
        public override void Configure(EntityTypeBuilder<Ulke> builder)
        {
            base.Configure(builder);
            builder.HasData(new Ulke
            {
                Id = 1,
                Ulkeler = "Türkiye",
                CreateDate = new DateTime(),
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
        }
    }
}
