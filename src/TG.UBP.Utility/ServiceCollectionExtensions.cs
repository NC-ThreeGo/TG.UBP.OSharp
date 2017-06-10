using OSharp.Core.Dependency;
using Owin;
using TG.UBP.Utility.Config;

namespace TG.UBP.Utility
{
    public static class ServiceCollectionExtensions
    {
        public static void AddUBPUtilityServices(this IServiceCollection services, IAppBuilder app)
        {
            //Config
            services.AddScoped<ISiteConfigProvider, SiteConfigProvider>();
        }
    }
}
