using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class TelUlkeKoduConfig : BaseConfig<TelUlkeKodu>
    {
        public override void Configure(EntityTypeBuilder<TelUlkeKodu> builder)
        {
            base.Configure(builder);
        }
    }
}
