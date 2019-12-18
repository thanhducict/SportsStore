using System.Web;

namespace SportsStore.WebUI.Service
{
    public class SessionService : ISessionService
    {
        public string CreateSession(string sessionName, string sessionValue)
        {
            HttpContext.Current.Session.Timeout = 1;
            HttpContext.Current.Session[sessionName] = sessionValue;

            return "Session created";
        }

        public string GetSession(string sessionName)
        {
            return HttpContext.Current.Session[sessionName].ToString();
        }

        public string DeleteSession(string sessionName)
        {
            //HttpContext.Current.Session.Abandon();
            HttpContext.Current.Session.Clear();

            return "Session deleted";
        }
    }
}