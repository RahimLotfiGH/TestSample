using AUA.ProjectName.Services.ListService.Accounting.Contracts;
using AUA.ProjectName.Services.ListService.Accounting.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AUA.ProjectName.WebApi.RegistrationServices
{
    public static class ListService
    {

        public static void RegistrationListService(this IServiceCollection services)
        {
            services.RegistrationAccountingListService();
            services.RegistratioBaseInformationistService();
        }

        public static void RegistrationAccountingListService(this IServiceCollection services)
        {
            services.AddScoped<IAppUserListService, AppUserListService>();
        }
        public static void RegistratioBaseInformationistService(this IServiceCollection services)
        {
            services.AddScoped<IAppUserAddressListService, AppUserAddressListService>();
    
        }
    }
}
