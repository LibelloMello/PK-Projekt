using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Partycipate.DAL
{
    class Connector
    {
        public SqlConnection connection()
        {

            SqlConnection myConnection = new SqlConnection("user id=root;" +
                                           "password=root;server=localhost;" +
                                           "Trusted_Connection=yes;" +
                                           "database=trappa; " +
                                           "connection timeout=30");

            Console.WriteLine("Connection");
            Console.ReadLine();
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            return myConnection;

        }
    }
}
