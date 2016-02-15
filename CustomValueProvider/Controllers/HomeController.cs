using System.Web;
using System.Web.Mvc;

namespace CustomValueProvider.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            HttpContext.Response.Cookies.Add(new HttpCookie("lang", "en"));
            return View();
        }

        [HttpPost]
        public ActionResult Index(string lang)
        {
            return View();
        }
    }
}