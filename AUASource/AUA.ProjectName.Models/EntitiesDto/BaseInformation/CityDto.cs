using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.BaseModel.BaseDto;

namespace AUA.ProjectName.Models.EntitiesDto.Accounting
{
    public class CityDto : BaseEntityDto, IMapFrom<City>
    {
        public string Name { get; set; }

        public int ProvinceId { get; set; }

        public Province Province { get; set; }

        public ICollection<AppUserAddress> AppUserAddress { get; set; }

    }
}
