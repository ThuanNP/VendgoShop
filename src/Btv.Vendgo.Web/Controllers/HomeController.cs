using Microsoft.AspNetCore.Mvc;

namespace Btv.Vendgo.Web.Controllers
{
    public class HomeController : VendgoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}