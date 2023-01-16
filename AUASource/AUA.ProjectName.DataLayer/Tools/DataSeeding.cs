using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.DataLayer.Tools
{
    public static class DataSeeding
    {

        public static void Seeding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser { Id = 1, IsActive = true, FirstName = "Rahim", LastName = "Lotfi", UserName = "admin", Password = "3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2", Phone = "+989199906342", Email = "Mr_lotfi@ymail.com" });



        }
    }
}
