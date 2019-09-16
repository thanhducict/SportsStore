using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    [RoutePrefix("Users")]
    public class CustomerController : Controller
    {
        // [Route("Test")]
        [Route("~/Test")] // Without ~, to access: Users/Test
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        // [Route("Users/Add/{user}/{id:int}")]
        [Route("Add/{user}/{id:int}")] // No need "Users" because of [RoutePrefix("Users")]
        public string Create(string user, int id)
        {
            return string.Format("User: {0}, ID: {1}", user, id);
        }

        [Route("Users/Add/{user}/{password:alpha:length(6)}")]
        public string ChangePass(string user, string password)
        {
            return string.Format("ChangePass Method - User: {0}, Pass: {1}",
            user, password);
        }

        public ActionResult List()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";
            return View("ActionName");
        }
    }
}