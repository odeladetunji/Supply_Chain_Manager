using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Web.Http.Cors;
using Supply_Manager.Cors;
using System.Net.Http.Formatting;

namespace Supply_Manager.Controllers
{     
    [AllowCrossSiteOrigins]
    public class CompanyController : Controller
    {     
        //[HttpPost]
        [Route("Company/RegisterCompany")]
        public ActionResult RegisterCompany(FormCollection collection)
        { 
            Console.WriteLine(collection["phoneNumber"]);
            DatabaseConnectionSchema dataSchema = new DatabaseConnectionSchema();
            ThreadStart ChildThread = new ThreadStart(() => dataSchema.ConnectionSchema());
            Thread parentThread = new Thread(ChildThread);
            parentThread.Start();
            Thread.Sleep(3000);  //this will be needed in other for database connection to be ex
            //tablished successfully 
            //SqlCommand command;
            //SqlDataReader dataReader;
            //String sql;
            //sql = "select * from registration";
            //command = new SqlCommand(sql, dataSchema.GetConnection());
            //dataReader = command.ExecuteReader();
            //Console.WriteLine(dataReader);
            //Console.WriteLine("check data reader above");
            var data = new { message = "From Registration Controller" };
            return Json(data);
            //return View ();
        }
    }
}
