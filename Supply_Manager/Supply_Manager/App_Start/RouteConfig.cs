using System.Web.Mvc;
using System.Web.Routing;

namespace Supply_Manager
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
             "CompanyRegistration",
             "Company/{action}",
             defaults: new { controller = "Company", action = "registercompany" }
            );

            routes.MapRoute(
              "Default",
              "{controller}/{action}",
              new { controller = "Home", action = "Index" }
            );


            //routes.MapRoute(
            //  name: "logingin",
            //  url: "{controller}/{action}",
            //  defaults: new { controller = "Login", action = "Index" }
            //);


            //routes.MapRoute(
            //   name: "addingProducts",
            //   url: "{controller}/{action}",
            //   defaults: new { controller = "AddProduct", action = "Index" }
            //);

        }
    }
}
