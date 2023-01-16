using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.ViewModels.BaseInformation
{
    public class ProvinceInsertVm: BaseActionModel, IMapFrom<Province>
    {
        public string Name { get; set; }
    }
}
