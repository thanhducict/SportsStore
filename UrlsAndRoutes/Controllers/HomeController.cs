using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        // Using Optional URL Segments to Enforce Separation of Concerns (string id = "DefaultId")
        public ActionResult CustomVariable(string id = "DefaultId")
        {
            // Accessing a Custom Segment Variable in an Action Method
            ViewBag.Controller = RouteData.Values["controller"];
            ViewBag.Action = RouteData.Values["action"];

            ViewBag.CustomVariable = id;

            // Checking for an Optional Segment Variable
            //ViewBag.CustomVariable = id ?? "<no value>";
            return View();
        }
    }
}