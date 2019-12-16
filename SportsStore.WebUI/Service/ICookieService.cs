using System;

namespace SportsStore.WebUI.Service
{
    public interface ICookieService
    {
        string CreateCookie(string cookieName, string cookieValue, DateTime datetime);
        string GetCookie(string cookieName);
        string DeleteCookie(string cookieName);
    }
}