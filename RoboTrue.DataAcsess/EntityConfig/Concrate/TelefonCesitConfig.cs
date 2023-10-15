using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class TelefonCesitConfig : BaseConfig<TelefonCesit>
    {
        public override void Configure(EntityTypeBuilder<TelefonCesit> builder)
        {
            base.Configure(builder);
        }
    }
}
