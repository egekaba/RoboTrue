using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class IslerConfig : BaseConfig<Isler>
    {
        public override void Configure(EntityTypeBuilder<Isler> builder)
        {
            base.Configure(builder);
        }
    }
}
