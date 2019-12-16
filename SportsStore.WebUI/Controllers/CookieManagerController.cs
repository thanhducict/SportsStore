using SportsStore.WebUI.Service;
using System;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class CookieManagerController : Controller
    {
        private readonly ICookieService _cookieService;

        public CookieManagerController(ICookieService cookieService)
        {
            _cookieService = cookieService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string CreateCookie()
        {
            return _cookieService.CreateCookie("Cookie demo", "Cookie value", new DateTime(2019, 12, 20));
        }

        public string GetCookie()
        {
            return _cookieService.GetCookie("Cookie demo");
        }

        [HttpPost]
        public string DeleteCookie()
        {
            return _cookieService.DeleteCookie("Cookie demo");
        }
    }
}