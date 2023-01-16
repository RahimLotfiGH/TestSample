using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.ProjectName.DomainEntities.EntitiesConfig.Accounting
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {

            builder
                .Property(p => p.Name)
                .HasMaxLength(LengthConsts.MaxStringLen50);

            builder
               .HasOne(p => p.Province)
               .WithMany(p => p.Cities)
               .HasForeignKey(p => p.ProvinceId)
               .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(p => p.IsActive)
                .IsRequired();

        }

    }
}
