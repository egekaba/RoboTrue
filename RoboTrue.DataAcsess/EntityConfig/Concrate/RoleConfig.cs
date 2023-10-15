using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class RoleConfig : RoleBaseConfig<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.HasData(new Role
            {
                Id = 1,
                CreateDate = DateTime.Now,
                Menuler = { },
                RoleName = "Personel",

            });
            builder.HasData(new Role
            {
                Id = 2,
                CreateDate = DateTime.Now,
                Menuler = { },
                RoleName = "Yetkili",

            });
        }
    }
}
