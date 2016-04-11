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

            SqlConnection myConnection = new SqlConnection("Data Source = GUSTAV - TOSH; Initial Catalog = trappa; Integrated Security = False; User ID = sa; Password = hejsan; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            Console.WriteLine("Connection");
            Console.ReadLine();
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
            Console.WriteLine("Efter connection");

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