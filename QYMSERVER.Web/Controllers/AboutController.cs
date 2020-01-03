using System.Web.Mvc;

namespace QYMSERVER.Web.Controllers
{
    public class AboutController : QYMSERVERControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}