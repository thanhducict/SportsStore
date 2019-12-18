using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsStore.WebUI.Service
{
    public class ApplicationStateService : IApplicationStateService
    {
        public string CreateApplicationState(string applicationStateName, string applicationStateValue)
        {
            HttpContext.Current.Application[applicationStateName] = applicationStateValue;
            return "Application state created";
        }

        public string GetApplicationState(string applicationStateName)
        {
            return HttpContext.Current.Application[applicationStateName].ToString();
        }
    }
}