

namespace AUA.ProjectName.WebApi.RegistrationServices
{
    public static class ValidationService
    {
        public static void RegistrationValidationService(this IServiceCollection services)
        {
            services.AccountingValidationService();

        }

        private static void AccountingValidationService(this IServiceCollection services)
        {
       
        }


    }

}
