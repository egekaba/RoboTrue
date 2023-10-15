using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class SehirConfig : BaseConfig<Sehir>
    {
        public override void Configure(EntityTypeBuilder<Sehir> builder)
        {
            base.Configure(builder);
            builder.HasData(new Sehir
            {
                Id = 1,
                UlkeId = 1,
                Ulkesi = { },
                SehirAdi = "Adana",
                CreateDate = new DateTime()
            });
        }
    }
}
