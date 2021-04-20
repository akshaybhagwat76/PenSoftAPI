using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace PenSoftAPI.Web.Views
{
    public abstract class PenSoftAPIRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PenSoftAPIRazorPage()
        {
            LocalizationSourceName = PenSoftAPIConsts.LocalizationSourceName;
        }
    }
}
