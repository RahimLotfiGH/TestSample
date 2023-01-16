using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.ViewModels.Accounting.AppUserAddressModels
{
    public class AppUserAddressUpdateVm : GeneralVm<long>, IMapFrom<AppUserAddress>
    {
        public string Address { get; set; }

        public int CityId { get; set; }

        public long AppUserId { get; set; }

    }
}
