using System.Web.Http;

namespace Supply_Manager
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //CORS
            config.EnableCors();
            // Web API routes
            //config.MapHttpAttributeRoutes();
        }
    }
}

