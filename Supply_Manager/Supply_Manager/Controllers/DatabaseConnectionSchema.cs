using System;
using System.Data.SqlClient;

namespace Supply_Manager.Controllers
{
    public class DatabaseConnectionSchema
    {
        public SqlConnection con;
        public SqlConnection GetConnection()
        {
            return con;
        }

        public void ConnectionSchema()
        {
            string connectionString = null;
            connectionString = "Data Source=localhost,1433;Initial Catalog=supply_chain_manager;Integrated Security=false;User ID=sa;Password=Root3234!!!;MultipleActiveResultSets=True";
            con = new SqlConnection(connectionString);
            //con.Open();
            Console.WriteLine("connecting to MSSQL Database");
            //try
            //{
            //    con.Open();
            //    Console.WriteLine("connection block");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //return "testing Database Connection";
        }

        public void CloseConnection()
        {
            con.Close();
            Console.WriteLine("Closing Connection");
        }
    }
}



