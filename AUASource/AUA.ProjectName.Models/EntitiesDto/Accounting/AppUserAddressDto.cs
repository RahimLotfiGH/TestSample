using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.BaseModel.BaseDto;

namespace AUA.ProjectName.Models.EntitiesDto.Accounting
{
    public class AppUserAddressDto : BaseEntityDto<long>, IMapFrom<AppUserAddress>
    {
        public string Address { get; set; }

        public int CityId { get; set; }

        public long AppUserId { get; set; }


    }
}
