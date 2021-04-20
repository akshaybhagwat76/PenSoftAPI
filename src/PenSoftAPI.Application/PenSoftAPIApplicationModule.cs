using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PenSoftAPI.Authorization;
using PenSoftAPI.MenuPermission.Dtos;
using PenSoftAPI.Menus;
using PenSoftAPI.Menus.Dtos;
using PenSoftAPI.MenusPermission;

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
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<CreateOrEditMenuDto, Menu>().ReverseMap();
                config.CreateMap<CreateOrEditMenuPermissionDto, Menu_permission>().ReverseMap();

            });
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
