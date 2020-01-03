using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace QYMSERVER.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : QYMSERVERControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}