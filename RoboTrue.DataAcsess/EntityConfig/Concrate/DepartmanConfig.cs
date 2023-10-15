using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class DepartmanConfig : DepartmanBaseConfig<Departman>
    {
        public override void Configure(EntityTypeBuilder<Departman> builder)
        {
            base.Configure(builder);

            builder.HasData(new Departman
            {
                Id = 1,
                DepartmanAdi = "Satış",
                CreateDate = DateTime.Now,

            });
            builder.HasData(new Departman
            {
                Id = 2,
                DepartmanAdi = "Teknik",
                CreateDate = DateTime.Now,

            });
            builder.HasData(new Departman
            {
                Id = 3,
                DepartmanAdi = "Admin",
                CreateDate = DateTime.Now,

            });

        }
    }
}
