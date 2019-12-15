using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            #region Chapter 16 Advanced Routing Features

            routes.RouteExistingFiles = true;

            routes.MapMvcAttributeRoutes();

            routes.MapRoute("MyRoute", "{controller}/{action}", null,
                new[] { "UrlsAndRoutes.Controllers" });
            routes.MapRoute("MyOtherRoute", "App/{action}", new { controller = "Home" },
                new[] { "UrlsAndRoutes.Controllers" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "UrlsAndRoutes.Controllers" });

            #endregion

            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            //routes.Add("MyRoute", myRoute);

            //routes.MapRoute("ShopSchema2", "Shop/OldAction", new { controller = "Home", action = "Index" });

            //routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });

            // A URL Pattern with a Mixed Segment
            //routes.MapRoute("", "X{controller}/{action}");

            //routes.MapRoute("MyRoute", "{controller}/{action}", new { controller = "Home", action = "Index" });

            // A URL Pattern with Static Segments
            //routes.MapRoute("", "Public/{controller}/{action}", new { controller = "Home", action = "Index" });

            #region Using Multiple Routes to Control Namespace Resolution

            //Designating a Catchall Variable { *catchall}
            //routes.MapRoute("AddContollerRoute", "Home/{action}/{id}/{*catchall}",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    }, new[] { "URLsAndRoutes.AdditionalControllers" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    }, new[] { "URLsAndRoutes.Controllers" });

            #endregion

            #region Disabling Fallback Namespaces

            //Route myRoute = routes.MapRoute("AddContollerRoute", "Home/{action}/{id}/{*catchall}",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    }, new[] { "URLsAndRoutes.AdditionalControllers" });

            //myRoute.DataTokens["UseNamespaceFallback"] = false;

            #endregion

            #region Constrain Routes

            //routes.MapRoute("ChromeRoute", "{*catchall}",
            //    new { controller = "Home", action = "Index" },
            //    new { customConstraint = new UserAgentConstraint("Chrome") },
            //    new[] { "UrlsAndRoutes.AdditionalControllers" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new
            //    {
            //        controller = "^H.*",
            //        action = "Index|About",
            //        httpMethod = new HttpMethodConstraint("GET"),
            //        id = new CompoundRouteConstraint(new IRouteConstraint[] 
            //            {
            //                    new AlphaRouteConstraint(),
            //                    new MinLengthRouteConstraint(6)
            //            })
            //    },
            //    new[] { "URLsAndRoutes.Controllers" });

            #endregion
        }
    }
}
