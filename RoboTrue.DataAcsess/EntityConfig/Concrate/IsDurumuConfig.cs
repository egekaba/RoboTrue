using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class IsDurumuConfig : BaseConfig<IsDurumu>
    {
        public override void Configure(EntityTypeBuilder<IsDurumu> builder)
        {
            base.Configure(builder);
        }
    }
}
