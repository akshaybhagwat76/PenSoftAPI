using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PenSoftAPI.Configuration;

namespace PenSoftAPI.Web.Host.Startup
{
    [DependsOn(
       typeof(PenSoftAPIWebCoreModule))]
    public class PenSoftAPIWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PenSoftAPIWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PenSoftAPIWebHostModule).GetAssembly());
        }
    }
}
