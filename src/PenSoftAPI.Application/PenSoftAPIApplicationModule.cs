using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PenSoftAPI.Authorization;

namespace PenSoftAPI
{
    [DependsOn(
        typeof(PenSoftAPICoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PenSoftAPIApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PenSoftAPIAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PenSoftAPIApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
