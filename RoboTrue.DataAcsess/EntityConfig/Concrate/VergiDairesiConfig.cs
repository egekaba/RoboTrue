using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class VergiDairesiConfig : BaseConfig<VergiDairesi>
    {
        public override void Configure(EntityTypeBuilder<VergiDairesi> builder)
        {
            base.Configure(builder);
        }
    }
}
