using System.ComponentModel.DataAnnotations.Schema;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.BaseEntities;

namespace AUA.ProjectName.DomainEntities.Entities.Accounting
{
    [Table("City", Schema = SchemaConsts.BaseInformation)]
    public sealed class City : DomainEntity<int>
    {
        public string Name { get; set; }

        public int ProvinceId { get; set; }

        public Province Province { get; set; }

        public ICollection<AppUserAddress> AppUserAddress { get; set; }
    }
}
