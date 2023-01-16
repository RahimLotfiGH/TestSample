using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserAddressModels;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;
using AUA.ProjectName.Services.ListService.Accounting.Contracts;
using AUA.ServiceInfrastructure.BaseSearchService;
using AutoMapper;

namespace AUA.ProjectName.Services.ListService.Accounting.Services
{
    public sealed class AppUserAddressListService : BaseListService<AppUserAddress, AppUserAddressListDto, AppUserAddressSearchVm>, IAppUserAddressListService
    {
        public AppUserAddressListService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {

        }

        public async Task<ListResultVm<AppUserAddressListDto>> ListAsync(AppUserAddressSearchVm searchVm)
        {
            SetSearchVm(searchVm);

            ApplyCityIdFilter();
            ApplyAppUserIdFilter();
            ApplyAddressFilter();
            ApplyProvinceIdFilters();

            ApplyOrderBy();


            return await CreateListVmResultAsync();
        }

        private void ApplyCityIdFilter()
        {
            if (SearchVm.CityId <= 0)
                return;

            Query = Query.Where(p => p.CityId == p.CityId);
        }

        private void ApplyAppUserIdFilter()
        {
            if (SearchVm.AppUserId <= 0)
                return;

            Query = Query.Where(p => p.AppUserId == SearchVm.AppUserId);
        }

        private void ApplyAddressFilter()
        {
            if (string.IsNullOrWhiteSpace(SearchVm.Address))
                return;

            Query = Query.Where(p => p.Address.Contains(SearchVm.Address));
        }

        private void ApplyProvinceIdFilters()
        {
            if (SearchVm.ProvinceId <= 0)
                return;

            Query = Query.Where(p => p.City.ProvinceId == SearchVm.ProvinceId);
        }
        private void ApplyOrderBy()
        {
            
            Query = Query.OrderBy(p => p.City.Id);
        }


    }
}
