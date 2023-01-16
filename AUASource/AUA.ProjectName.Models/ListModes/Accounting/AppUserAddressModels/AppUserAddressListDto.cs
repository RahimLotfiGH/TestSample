using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.BaseModel.BaseDto;
using AutoMapper;

namespace AUA.ProjectName.Models.ListModes.Accounting.AppUserAddressModels
{
    public class AppUserAddressListDto : BaseEntityDto<long>, IHaveCustomMappings
    {
        public string Address { get; set; }

        public string CityName { get; set; }

        public string AppUserName { get; set; }

        public string ProvinceName { get; set; }

        public void ConfigureMapping(Profile configuration)
        {
            configuration.CreateMap<AppUserAddress, AppUserAddressListDto>()
                .ForMember(p => p.CityName, p => p.MapFrom(q => q.City.Name))
                .ForMember(p => p.ProvinceName, p => p.MapFrom(q => q.City.Province.Name))
                .ForMember(p => p.AppUserName, p => p.MapFrom(q => q.AppUser.FirstName + " " + q.AppUser.LastName));

        }
    }
}
