using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserAddressModels;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;
using AUA.ServiceInfrastructure.BaseSearchService;

namespace AUA.ProjectName.Services.ListService.Accounting.Contracts
{
    public interface IAppUserAddressListService : IBaseListService<AppUserAddress, AppUserAddressListDto>
    {
        Task<ListResultVm<AppUserAddressListDto>> ListAsync(AppUserAddressSearchVm appUserSearchVm);

    }
}
