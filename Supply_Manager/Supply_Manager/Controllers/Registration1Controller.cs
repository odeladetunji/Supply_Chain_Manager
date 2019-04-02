using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Supply_Manager.Cors;

namespace Supply_Manager.Controllers
{
    [AllowCrossSiteOrigins]
    public class Registration1Controller : Controller
    {
        [HttpPost]
        public ActionResult Index()
        {
            DatabaseConnectionSchema dataSchema= new DatabaseConnectionSchema();
            ThreadStart ChildThread = new ThreadStart(() => dataSchema.ConnectionSchema());
            Thread parentThread = new Thread(ChildThread);
            parentThread.Start();
            Thread.Sleep(3000);  //this will be needed in other for database connection to be ex
            //tablished successfully
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            sql = "select * from registration";
            command = new SqlCommand(sql, dataSchema.GetConnection());
            dataReader = command.ExecuteReader();
            Console.WriteLine(dataReader);
            var data = new { message = "From Registration Controller" };
            return Json(data);
        }
    }
}

