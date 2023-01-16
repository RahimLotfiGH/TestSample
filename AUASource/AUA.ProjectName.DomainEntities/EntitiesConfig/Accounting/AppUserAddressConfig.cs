using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUA.ProjectName.DomainEntities.EntitiesConfig.Accounting
{
    public class AppUserAddressConfig : IEntityTypeConfiguration<AppUserAddress>
    {
        public void Configure(EntityTypeBuilder<AppUserAddress> builder)
        {

            builder
                .Property(p => p.Address)
                .HasMaxLength(LengthConsts.MaxStringLen250);

            builder
               .HasOne(p => p.City)
               .WithMany(p => p.AppUserAddress)
               .HasForeignKey(p => p.CityId)
               .OnDelete(DeleteBehavior.NoAction);


            builder
               .HasOne(p => p.AppUser)
               .WithMany(p => p.AppUserAddresses)
               .HasForeignKey(p => p.AppUserId)
               .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(p => p.IsActive)
                .IsRequired();

        }

    }
}
