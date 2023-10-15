using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class SahisUnvaniConfig : BaseConfig<SahisUnvani>
    {
        public override void Configure(EntityTypeBuilder<SahisUnvani> builder)
        {
            base.Configure(builder);
        }
    }
}
