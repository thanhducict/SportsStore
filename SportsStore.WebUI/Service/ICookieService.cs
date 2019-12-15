using System;

namespace SportsStore.WebUI.Service
{
    public interface ICookieService
    {
        string CreateCookie(string cookieName, string cookieValue, DateTime datetime);
        void StoreInCookie(string cookieName, string cookieDomain, string keyName,
            string value, DateTime? expirationDate, bool httpOnly = false);
    }
}