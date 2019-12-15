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
            //_cookieService.StoreInCookie("BabyCookie", "http://localhost:52574/", "BabyKey", "Oa oa oa", new DateTime(2019, 12, 20));
            _cookieService.CreateCookie("Kazootie", "Valuable", new DateTime(2019, 12, 20));
            return View();
        }
    }
}