using System.ComponentModel.DataAnnotations.Schema;
using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.DomainEntities.BaseEntities;

namespace AUA.ProjectName.DomainEntities.Entities.Accounting
{
    [Table("Province", Schema = SchemaConsts.BaseInformation)]
    public sealed class Province : DomainEntity<int>
    {
        public string Name { get; set; }
       
        public ICollection<City>  Cities { get; set; }
            
    }
}
