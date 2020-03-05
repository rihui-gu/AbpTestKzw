using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace WMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : WMSControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}