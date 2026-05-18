using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BuzzCafe
{
    public class DBConnection
    {



        //public static string con = "Data Source=.\\SQLEXPRESS01;Initial Catalog=FoodOrdering_DB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"; // elai 
        public static string con = "Data Source=.\\SQLEXPRESS;Initial Catalog=FoodOrdering_DB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"; //Dex server

        //public static string con = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FoodOrdering_DB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";//Kurt Server

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(con);
        }
    }

}
