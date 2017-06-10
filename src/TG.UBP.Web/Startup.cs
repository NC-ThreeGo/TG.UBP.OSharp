using Hangfire;
using Hangfire.MemoryStorage;
using Owin;
using Microsoft.Owin;

using OSharp.Autofac.Hangfire.Initialize;
using OSharp.Autofac.Http;
using OSharp.Autofac.Mvc;
using OSharp.AutoMapper;
using OSharp.Core.Caching;
using OSharp.Core.Dependency;
using OSharp.Core.Security;
using OSharp.Data.Entity;
using OSharp.Logging.Log4Net;
using OSharp.Web.Http.Initialize;
using OSharp.Web.Mvc.Initialize;

using TG.UBP.Core.Service;
using TG.UBP.Web;
using TG.UBP.Web.Startups.Hangfires;
using TG.UBP.Utility;

[assembly: OwinStartup(typeof(Startup))]

namespace TG.UBP.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            ICacheProvider provider = new RuntimeMemoryCacheProvider();
            CacheManager.SetProvider(provider, CacheLevel.First);

            IServicesBuilder builder = new ServicesBuilder();
            IServiceCollection services = builder.Build();
            services.AddLog4NetServices();
            services.AddDataServices();
            services.AddAutoMapperServices();
            services.AddOAuthServices();

            //加载TG.UBP的接口服务，主要包括基础设施层、领域层和应用层
            services.AddUBPUtilityServices(app);
            services.AddUBPCoreServices(app);
            //services.AddUBPApplicationServices(app);

            IIocBuilder mvcIocBuilder = new MvcAutofacIocBuilder(services);
            app.UseOsharpMvc(mvcIocBuilder);
            IIocBuilder apiIocBuilder = new WebApiAutofacIocBuilder(services);
            app.UseOsharpWebApi(apiIocBuilder);
            //app.UseOsharpSignalR(new SignalRAutofacIocBuilder(services));

            app.ConfigureOAuth(apiIocBuilder.ServiceProvider);
            app.ConfigureWebApi();
            //app.ConfigureSignalR();

            IIocBuilder hangfireBuilder = new HangfireAutofacIocBuilder(services);
            app.UseOSharpHangfile(hangfireBuilder);
            GlobalConfiguration.Configuration.UseMemoryStorage();
            app.UseHangfireDashboard();
            app.UseHangfireServer(new BackgroundJobServerOptions() { WorkerCount = 1 });
            HangfireJobsRunner.Start();
        }
    }
}