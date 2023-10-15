using RoboTrue.Business.Abstract;
using RoboTrue.Business.Concrate;

namespace RoboTrue.UI.Extensions
{
    public static class ErpExtensions
    {
        public static IServiceCollection AddErpService(this IServiceCollection services)
        {
            /*
             * 
             * Projeye Eklenen Manager Siniflari Burada tanimlanacak
             * 
             */
            services.AddScoped<ICariManager, CariManager>();
            services.AddScoped<IMenuManager, MenuManager>();

            return services;

        }
    }
}
