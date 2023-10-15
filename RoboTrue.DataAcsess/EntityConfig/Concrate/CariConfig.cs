using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class CariConfig : BaseConfig<Cari>
    {
        public override void Configure(EntityTypeBuilder<Cari> builder)
        {
            base.Configure(builder);

        }
    }
}
