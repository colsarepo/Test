using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return new JsonResult();
        }
	}
}