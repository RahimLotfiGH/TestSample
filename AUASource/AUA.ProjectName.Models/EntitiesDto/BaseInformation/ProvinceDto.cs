using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.BaseModel.BaseDto;

namespace AUA.ProjectName.Models.EntitiesDto.Accounting
{
    public class ProvinceDto : BaseEntityDto, IMapFrom<Province>
    {
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }

    }
}
