using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        // GET: Derived
        public ActionResult Index(string id = "DefaultId")
        {
            //ControllerContext.
            return View((object)id);
        }
    }
}