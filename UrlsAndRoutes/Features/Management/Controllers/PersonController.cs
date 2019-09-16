using System.Web.Mvc;
using UrlsAndRoutes.Features.Management.Models;

namespace UrlsAndRoutes.Features.Management.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            Person person = new Person() { Name = "Shane", Age = 50 };
            return View("~/Features/Management/Views/Person/Index.cshtml", person);
        }
    }
}