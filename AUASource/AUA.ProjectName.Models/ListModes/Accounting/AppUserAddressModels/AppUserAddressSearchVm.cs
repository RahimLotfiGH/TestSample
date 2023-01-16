using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.ListModes.Accounting.AppUserModels
{
    public class AppUserAddressSearchVm : BaseSearchVm
    {
        public int CityId { get; set; }

        public long AppUserId { get; set; }

        public int ProvinceId { get; set; }

        public string Address { get; set; }

    }
}
