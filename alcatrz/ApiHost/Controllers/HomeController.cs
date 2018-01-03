using System.Web.Mvc;

namespace ApiHost.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            string res = GetSaleInfo().Result;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}