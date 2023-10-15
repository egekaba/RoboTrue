using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class SozlesmeDurumuConfig : BaseConfig<SozlesmeDurum>
    {
        public override void Configure(EntityTypeBuilder<SozlesmeDurum> builder)
        {
            base.Configure(builder);
        }
    }
}
