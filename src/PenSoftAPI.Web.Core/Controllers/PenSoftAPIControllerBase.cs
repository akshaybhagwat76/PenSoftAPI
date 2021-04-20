using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PenSoftAPI.Controllers
{
    public abstract class PenSoftAPIControllerBase: AbpController
    {
        protected PenSoftAPIControllerBase()
        {
            LocalizationSourceName = PenSoftAPIConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
