using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using PenSoftAPI.Controllers;

namespace PenSoftAPI.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : PenSoftAPIControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
