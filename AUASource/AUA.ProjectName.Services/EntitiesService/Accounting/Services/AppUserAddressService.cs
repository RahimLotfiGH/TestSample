using AUA.Mapping.Mapping;
using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ServiceInfrastructure.BaseServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.Services.EntitiesService.Accounting.Services
{
    public class AppUserAddressService : GenericEntityService<AppUserAddress, AppUserAddressDto, long>, IAppUserAddressService
    {

        public AppUserAddressService(IUnitOfWork unitOfWork, IMapper mapperInstance) : base(unitOfWork, mapperInstance)
        {

        }
        public async Task<List<UserAddressDto>> GetAddressCityIdAsync(int cityId, long startId, int count)
        {
            
                return await GetAll().Where(p => p.CityId == cityId && p.Id > startId)
                                     .Take(count)
                                     .ConvertTo<UserAddressDto>(MapperInstance)                                 
                                     .ToListAsync();
            
            
        }

    }
}
