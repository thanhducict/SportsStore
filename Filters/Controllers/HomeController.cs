using Filters.Infrastructure;
using System.Web.Mvc;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        [CustomAuth(true)]
        [Authorize(Users = "admin")]
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }
    }
}