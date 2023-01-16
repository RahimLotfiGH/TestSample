using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserAddressModels;
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;
using AUA.ProjectName.Models.ViewModels.Accounting.AppUserAddressModels;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.Services.ListService.Accounting.Contracts;
using AUA.ProjectName.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AUA.ProjectName.WebApi.Areas.Accounting.Controllers
{

    public class AppUserAddressController : BaseApiController
    {
        private readonly IAppUserAddressService _appUserAddressService;
        private readonly IAppUserAddressListService _appUserAddressListService;

        public AppUserAddressController(IAppUserAddressService appUserAddressService
                                        , IAppUserAddressListService appUserAddressListService)
        {
            _appUserAddressService = appUserAddressService;
            _appUserAddressListService = appUserAddressListService;
        }

        [HttpGet]
        public async Task<ResultModel<List<UserAddressDto>>> GetAddressCityIdAsync(int cityId, long startId, int count)
        {

            var result = await _appUserAddressService
                                       .GetAddressCityIdAsync(cityId, startId, count);

            return CreateSuccessResult(result);
        }

        [HttpPost]
        public async Task<ResultModel<ListResultVm<AppUserAddressListDto>>> ListAsync(AppUserAddressSearchVm searchVm)
        {
            ValidationSearchVm(searchVm);

            if (HasError)
                return CreateInvalidResult<ListResultVm<AppUserAddressListDto>>();

            var result = await _appUserAddressListService
                                        .ListAsync(searchVm);

            return CreateSuccessResult(result);
        }

        [HttpPost]
        public async Task<ResultModel<long>> InsertAsync(AppUserAddressInsertVm addressVm)
        {

            addressVm.CreatorUserId = UserId;

            var id = await _appUserAddressService.InsertCustomVmAsync(addressVm);

            return id == 0 ?
                   CreateInvalidResult<long>(EResultStatus.ErrorOperations) :
                   CreateSuccessResult(id);
        }

        [HttpPut]
        public async Task<ResultModel<bool>> UpdateAsync(AppUserAddressUpdateVm addressVm)
        {
            var result = await _appUserAddressService.UpdateCustomVmAsync(addressVm);

            return result ?
                   CreateInvalidResult<bool>(EResultStatus.ErrorOperations) :
                   CreateSuccessResult(result);
        }

        [HttpDelete]
        public async Task<ResultModel<bool>> DeleteAsync(long addressId)
        {
            var isDeleted = await _appUserAddressService.TryDeleteAsync(addressId);

            return isDeleted ?
                   CreateSuccessResult(true) :
                   CreateInvalidResult<bool>(EResultStatus.ErrorOperations);
        }


    }
}
