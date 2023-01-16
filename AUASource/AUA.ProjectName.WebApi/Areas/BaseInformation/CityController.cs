using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ViewModels.Accounting.AppUserAddressModels;
using AUA.ProjectName.Models.ViewModels.BaseInformation.CityModels;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AUA.ProjectName.WebApi.Areas.Accounting.Controllers
{

    public class CityController : BaseApiController
    {
        private  readonly  ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpPost]
        public async Task<ResultModel<int>> InsertAsync(CityInsertVm addressVm)
        {

            addressVm.CreatorUserId = UserId;

            var id = await _cityService.InsertCustomVmAsync(addressVm);

            return id == 0 ?
                   CreateInvalidResult<int>(EResultStatus.ErrorOperations) :
                   CreateSuccessResult(id);
        }

    }
}
