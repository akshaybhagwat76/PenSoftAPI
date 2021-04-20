using Abp.AspNetCore.Mvc.ViewComponents;

namespace PenSoftAPI.Web.Views
{
    public abstract class PenSoftAPIViewComponent : AbpViewComponent
    {
        protected PenSoftAPIViewComponent()
        {
            LocalizationSourceName = PenSoftAPIConsts.LocalizationSourceName;
        }
    }
}
