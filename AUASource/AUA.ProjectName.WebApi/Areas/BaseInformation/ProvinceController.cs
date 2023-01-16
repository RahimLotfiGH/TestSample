using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.ViewModels.Accounting.AppUserAddressModels;
using AUA.ProjectName.Models.ViewModels.BaseInformation;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AUA.ProjectName.WebApi.Areas.Accounting.Controllers
{

    public class ProvinceController : BaseApiController
    {
        private  readonly  IProvinceService _provinceService;

        public ProvinceController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }

        [HttpPost]
        public async Task<ResultModel<int>> InsertAsync(ProvinceInsertVm addressVm)
        {

            addressVm.CreatorUserId = UserId;

            var id = await _provinceService.InsertCustomVmAsync(addressVm);

            return id == 0 ?
                   CreateInvalidResult<int>(EResultStatus.ErrorOperations) :
                   CreateSuccessResult(id);
        }

    }
}
