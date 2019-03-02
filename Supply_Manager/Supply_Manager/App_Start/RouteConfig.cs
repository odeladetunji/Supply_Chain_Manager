using System.Web.Mvc;
using System.Web.Routing;

namespace Supply_Manager
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
               name: "logingin",
               url: "{controller}/{action}",
               defaults: new { controller = "Login", action = "Index"}
            );

            routes.MapRoute(
               name: "registerUsers",
               url: "{controller}/{action}",
               defaults: new { controller = "Registration", action = "Index"}
             );

            routes.MapRoute(
               name: "addingProducts",
               url: "{controller}/{action}",
               defaults: new { controller = "AddProduct", action = "Index"}
            );
        }
    }
}
