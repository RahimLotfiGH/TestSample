using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;


namespace AUA.ProjectName.Models.ViewModels.BaseInformation.CityModels
{
    public class CityInsertVm : BaseActionModel, IMapFrom<City>
    {
        public string Name { get; set; }

        public int ProvinceId { get; set; }
    }
}
