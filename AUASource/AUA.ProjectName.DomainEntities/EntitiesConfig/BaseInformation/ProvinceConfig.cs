using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.ProjectName.DomainEntities.EntitiesConfig.Accounting
{
    public class ProvinceConfig : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            
            builder
                .Property(p => p.Name)
                .HasMaxLength(LengthConsts.MaxStringLen50);
            
                        
            builder
                .Property(p => p.IsActive)
                .IsRequired();

        }

    }
}
