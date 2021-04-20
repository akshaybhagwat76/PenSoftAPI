using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PenSoftAPI.EntityFrameworkCore;
using PenSoftAPI.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PenSoftAPI.Web.Tests
{
    [DependsOn(
        typeof(PenSoftAPIWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PenSoftAPIWebTestModule : AbpModule
    {
        public PenSoftAPIWebTestModule(PenSoftAPIEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PenSoftAPIWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PenSoftAPIWebMvcModule).Assembly);
        }
    }
}