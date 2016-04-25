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


        public User FindUser(string userName) //I GUI skall man skapa en text input field, sen döpa värdet man får
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
                SqlCommand myCommand = new SqlCommand("SELECT * FROM USERS WHERE USER_NAME = @UserName", myConnection);
                myCommand.Parameters.AddWithValue("@UserName", userName);
                myReader = myCommand.ExecuteReader();


                while (myReader.Read())
                {
                    u.UserName = myReader["USER_NAME"].ToString();
                    u.Age = int.Parse(myReader["AGE"].ToString());

                }
                return u;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }


        public void CreateUser(string userName, int age, string name, string email, string password, string phoneNumber, string sex)
        {

            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;

            try
            {

                SqlCommand myCommand = new SqlCommand("INSERT INTO USERS VALUES(@UserName, @Age, @Name, @Email, @Password, @PhoneNumber, @Sex)", myConnection);
                myCommand.Parameters.AddWithValue("@UserName", userName);
                myCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                myCommand.Parameters.AddWithValue("@Name", name);
                myCommand.Parameters.AddWithValue("@Email", email);
                myCommand.Parameters.AddWithValue("@Password", password);
                myCommand.Parameters.AddWithValue("@Sex", sex);
                myCommand.Parameters.AddWithValue("@Age", age);
                myCommand.ExecuteNonQuery();
                myConnection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return;
            }

        }
        public Boolean GetLoginAuthentication(string userName, string password)
        {

            DbUtil d = new DbUtil();
            Console.WriteLine("Innan SQL");
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;
            User u = new User();
            bool b = new bool();

            try
            {
                SqlCommand myCommand = new SqlCommand("SELECT USER_NAME, PASSWORD FROM USERS WHERE USER_NAME = @UserName", myConnection);
                myCommand.Parameters.AddWithValue("@UserName", userName);
               
                myReader = myCommand.ExecuteReader();


                while (myReader.Read())
                {
                    u.UserName = myReader["USER_NAME"].ToString();
                    b = password == myReader["PASSWORD"].ToString();

                }
                return b;
            }
            catch (Exception e)
            {

                
            }

            return false; 
        }



}

}


