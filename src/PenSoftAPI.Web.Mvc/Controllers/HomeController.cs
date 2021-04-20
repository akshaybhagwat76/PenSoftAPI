using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using PenSoftAPI.Controllers;

namespace PenSoftAPI.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PenSoftAPIControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
