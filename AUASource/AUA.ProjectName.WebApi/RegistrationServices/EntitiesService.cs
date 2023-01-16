using AUA.ProjectName.DataLayer.AppContext.EntityFrameworkContext;
using AUA.ProjectName.Services.EntitiesService.Accounting.Contracts;
using AUA.ProjectName.Services.EntitiesService.Accounting.Services;

namespace AUA.ProjectName.WebApi.RegistrationServices
{
    public static class EntitiesService
    {

        public static void RegistrationEntitiesService(this IServiceCollection services)
        {
            services.RegistrationBaseService();

            services.RegistrationAccountingService();

            services.RegistrationBaseInformationService();

        }

        private static void RegistrationBaseService(this IServiceCollection services)
        {
            services.AddDbContext<IUnitOfWork, ApplicationEfContext>();
        }

        private static void RegistrationAccountingService(this IServiceCollection services)
        {
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IAppUserAddressService, AppUserAddressService>();
        }


        private static void RegistrationBaseInformationService(this IServiceCollection services)
        {
            services.AddScoped<ICityService, CityService>();

            services.AddScoped<IProvinceService, ProvinceService>();
        }





    }
}
