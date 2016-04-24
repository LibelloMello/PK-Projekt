using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    public class UserAccess
    {
       
        public static User FindUser(string userName) //I GUI skall man skapa en text input field, sen döpa värdet man får
                                                    //och skapa en string som sedan skickas med till denna metod
                                                    // och sen returna SQLDataAdapter som kan håll SQLdata och sedan
                                                    //loopa igenom för att skriva ut datan i en lista
        {
            DbUtil d = new DbUtil();
            Console.WriteLine("Innan SQL");
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;
            User u = new User();

            try
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@UserName";
                param.Value = userName;

                SqlCommand myCommand = new SqlCommand("SELECT * FROM USERS WHERE USER_NAME = @UserName", myConnection);

                myReader = myCommand.ExecuteReader(); //här hoppar den till catch
                u.UserName = myReader["USER_NAME"].ToString();
             

               
                while (myReader.Read())
                {
                    Console.WriteLine(myReader["USER_NAME"].ToString());
                    Console.WriteLine(myReader["AGE"].ToString());
                    
                }
                return u;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
         
        }
       





    }
}

