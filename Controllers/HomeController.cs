using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index(uint id)
        {
            ViewBag.IdHojaRuta = id.ToString();
            return View();
        }

        public ActionResult Create()
        {
            return new JsonResult();
        }
	}
}