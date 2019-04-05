using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Http.Cors;
using Supply_Manager.Cors;

namespace Supply_Manager.Controllers
{
    [AllowCrossSiteOrigins]
    public class HomeController : Controller
    {
        //[HttpGet]
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;  

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";
            Console.WriteLine("home controller ran");
            var data = new { product = "supply_chain_manager",  
                             message = "something_is_budding"};
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}



