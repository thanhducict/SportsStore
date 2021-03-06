﻿using System;
using System.Web;

namespace SportsStore.WebUI.Service
{
    public class CookieService : ICookieService
    {
        public string CreateCookie(string cookieName, string cookieValue, DateTime datetime)
        {
            //HttpContext.Current.Response.Cookies[cookieName].Value = cookieValue;
            //HttpContext.Current.Response.Cookies[cookieName].Expires = datetime;

            HttpCookie strname = new HttpCookie(cookieName)
            {
                Value = cookieValue,
                Expires = datetime
            };
            HttpContext.Current.Response.Cookies.Add(strname);

            return "Cookie created";
        }

        public string GetCookie(string cookieName)
        {
            return HttpContext.Current.Request.Cookies[cookieName].Value;
        }

        public string DeleteCookie(string cookieName)
        {
            HttpCookie myCookie = new HttpCookie(cookieName);
            myCookie.Expires = DateTime.Now.AddDays(-1d);
            HttpContext.Current.Response.Cookies.Add(myCookie);

            return "Cookie deleted";
        }
    }
}