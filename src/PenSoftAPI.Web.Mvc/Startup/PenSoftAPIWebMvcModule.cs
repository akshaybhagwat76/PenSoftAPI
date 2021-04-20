using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PenSoftAPI.Configuration;

namespace PenSoftAPI.Web.Startup
{
    [DependsOn(typeof(PenSoftAPIWebCoreModule))]
    public class PenSoftAPIWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PenSoftAPIWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<PenSoftAPINavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PenSoftAPIWebMvcModule).GetAssembly());
        }
    }
}
