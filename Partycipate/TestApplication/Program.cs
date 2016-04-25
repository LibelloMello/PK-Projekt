using System;
using Partycipate;
using System.Data.SqlClient;

namespace TestApplication

{
    class Programm
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("innan vi skapar initierar DBCOnn");
            DbUtil d = new DbUtil();

            Console.WriteLine("Innan SQL");
            SqlConnection myConnection = d.Connection();
            if (myConnection != null)
            {
                SqlCommand myCommand = new SqlCommand("INSERT INTO dbo.USERS (USER_NAME, AGE, EMAIL, NAME, PASSWORD, PHONE_NBR, SEX) " +
                                    "Values ('testunamn', 1955, 'otto@gmail.com', 'Test', 'testpw', '0999', 'Male')", myConnection);
                myCommand.ExecuteNonQuery();
                Console.WriteLine("Efter SQL");
            }
            else
            {
                Console.WriteLine("null");
            }
            d.closeConn(myConnection);
            Console.WriteLine("Klar med conn");
            Console.Read();
            
            
         
        }
    }
}

