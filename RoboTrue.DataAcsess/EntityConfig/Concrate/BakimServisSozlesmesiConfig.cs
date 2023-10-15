using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class BakimServisSozlesmesiConfig : BaseConfig<BakimServisSozlesme>
    {
        public override void Configure(EntityTypeBuilder<BakimServisSozlesme> builder)
        {
            base.Configure(builder);
            builder.HasData(new BakimServisSozlesme
            {
                Id = 1,
                CariId = 1,
                SozlesmeDurumId = 1,
                SozlesmeD = { },
                Caris = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }

            });
        }
    }
}
