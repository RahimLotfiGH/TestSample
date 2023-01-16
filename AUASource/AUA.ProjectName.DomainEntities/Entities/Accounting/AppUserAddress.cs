using System.ComponentModel.DataAnnotations.Schema;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.BaseEntities;

namespace AUA.ProjectName.DomainEntities.Entities.Accounting
{
    [Table("AppUserAddress", Schema = SchemaConsts.Accounting)]
    public sealed class AppUserAddress : DomainEntity<long>
    {
        public string Address { get; set; }

        public int CityId { get; set; }

        public long AppUserId { get; set; }

        public City City { get; set; }

        public AppUser AppUser { get; set; }
    }
}
