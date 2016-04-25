using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Partycipate
{
    public class DbUtil

    {
        public SqlConnection Connection()
        {

            SqlConnection myConnection = new SqlConnection("user id=gurra;" +
                                           "password=hejsan;Server=localhost;" +
                                           "Trusted_Connection=yes;" +
                                           "database=trappa; " +
                                           "connection timeout=30");

            Console.WriteLine("Connection");
          
            try
            {
                myConnection.Open();
                Console.WriteLine("Effffter");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            return myConnection;
            

        }
        public void closeConn(SqlConnection myConnection)
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

    }
}