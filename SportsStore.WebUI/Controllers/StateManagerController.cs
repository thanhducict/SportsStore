using SportsStore.WebUI.Service;
using System;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class StateManagerController : Controller
    {
        private readonly ICookieService _cookieService;
        private readonly ISessionService _sessionService;
        private readonly IApplicationStateService _applicationStateService;

        public StateManagerController(ICookieService cookieService,
            ISessionService sessionService,
            IApplicationStateService applicationStateService)
        {
            _cookieService = cookieService;
            _sessionService = sessionService;
            _applicationStateService = applicationStateService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClonePage()
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

        [HttpPost]
        public string CreateSession()
        {
            return _sessionService.CreateSession("Session demo", "Session value");
        }

        public string GetSession()
        {
            return _sessionService.GetSession("Session demo");
        }

        [HttpPost]
        public string DeleteSession()
        {
            return _sessionService.DeleteSession("Session demo");
        }

        [HttpPost]
        public string CreateApplicationState()
        {
            return _applicationStateService.CreateApplicationState("Application state demo", "Application state value");
        }

        public string GetApplicationState()
        {
            return _applicationStateService.GetApplicationState("Application state demo");
        }
    }
}