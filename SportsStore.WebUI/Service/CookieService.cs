using System;
using System.Web;

namespace SportsStore.WebUI.Service
{
    public class CookieService : ICookieService
    {
        /// <summary>
        /// Create simple Cookie
        /// </summary>
        public string CreateCookie(string cookieName, string cookieValue, DateTime datetime)
        {
            HttpContext.Current.Response.Cookies[cookieName].Value = cookieName;
            HttpContext.Current.Response.Cookies[cookieName].Expires = datetime;
            return "Cookie created";
        }

        /// <summary>
        /// Stores a value in a user Cookie, creating it if it doesn't exists yet.
        /// </summary>
        public void StoreInCookie(string cookieName, string cookieDomain, string keyName,
            string value, DateTime? expirationDate, bool httpOnly = false)
        {
            HttpCookie cookie = HttpContext.Current.Response.Cookies[cookieName]
                ?? HttpContext.Current.Request.Cookies[cookieName];
            if (cookie == null)
            {
                cookie = new HttpCookie(cookieName);
            }
            if (!string.IsNullOrEmpty(keyName))
            {
                cookie.Values.Set(keyName, value);
            }
            else
            {
                cookie.Value = value;
            }
            if (expirationDate.HasValue)
            {
                cookie.Expires = expirationDate.Value;
            }
            if (!string.IsNullOrEmpty(cookieDomain))
            {
                cookie.Domain = cookieDomain;
            }

            if (httpOnly)
            {
                cookie.HttpOnly = true;
            }
            HttpContext.Current.Response.Cookies.Set(cookie);
        }
    }
}