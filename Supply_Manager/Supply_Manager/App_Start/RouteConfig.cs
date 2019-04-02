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
              "Default",
              "{controller}/{action}",
              new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
             "CompanyRegistration",
             "{controller}/{action}",
              defaults: new { controller = "Company", action = "RegisterCompany"}
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
