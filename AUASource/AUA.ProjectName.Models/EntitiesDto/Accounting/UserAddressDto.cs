using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.BaseModel.BaseDto;

namespace AUA.ProjectName.Models.EntitiesDto.Accounting
{
    public class UserAddressDto : IMapFrom<AppUserAddress>
    {
        public long Id { get; set; }

        public string Address { get; set; }

        public int CityId { get; set; }

        public long AppUserId { get; set; }


    }
}
