using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class KefilConfig : BaseConfig<Kefil>
    {
        public override void Configure(EntityTypeBuilder<Kefil> builder)
        {
            base.Configure(builder);
        }
    }
}
