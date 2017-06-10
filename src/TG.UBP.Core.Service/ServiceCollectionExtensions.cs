using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataProtection;
using OSharp.Core.Dependency;
using OSharp.Core.Security;
using TG.UBP.Core.Entity.BaseManage.Identity;
using TG.UBP.Core.Service.BaseManage.OAuth;
using Owin;


namespace TG.UBP.Core.Service
{
    public static class ServiceCollectionExtensions
    {
        public static void AddUBPCoreServices(this IServiceCollection services, IAppBuilder app)
        {
            //Identity
            services.AddScoped<RoleManager<Role, int>, BaseManage.Identity.RoleManager>();
            services.AddScoped<UserManager<User, int>, BaseManage.Identity.UserManager>();
            services.AddScoped<SignInManager<User, int>, BaseManage.Identity.SignInManager>();
            services.AddScoped<IAuthenticationManager>(_ => HttpContext.Current.GetOwinContext().Authentication);
            services.AddScoped<IDataProtectionProvider>(_ => app.GetDataProtectionProvider());

            //Security
            //services.AddScoped<FunctionMapStore>();
            //services.AddScoped<EntityMapStore>();

            //OAuth
            services.AddScoped<OAuthClientStore>();
            services.AddScoped<IOAuthClientRefreshTokenStore, OAuthClientRefreshTokenStore>();
        }
    }
}
