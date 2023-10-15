using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;

namespace RoboTrue.DataAcsess.EntityConfig.Abstract
{
    public abstract class RoleBaseConfig<T> : IEntityTypeConfiguration<T> where T : Role
    {

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CreateDate).HasDefaultValue(DateTime.Now);

        }
    }
}
