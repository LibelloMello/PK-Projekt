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

                /* while (myReader.Read())
                 {
                     u.UserName = myReader["USER_NAME"].ToString();
                     u.PhoneNumber = myReader["PHONE_NUMBER"].ToString();
                     u.Name = myReader["NAME"].ToString();
                     u.Email = myReader["EMAIL"].ToString();
                     u.Password = myReader["PASSWORD"].ToString();
                     u.Sex = myReader["SEX"].ToString();
                     u.Age = int.Parse(myReader["AGE"].ToString());

            }
               return u;
                */
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return;
            }

        }
        public void CreateUser2()
        {

            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;


            try
            {
                string serName = "serName";
                int honeNumber = 5432;
                string ame = "ame";
                string mail = "mail";
                string assword = "assword";
                string ex = "ex";
                int ge = 92;
                SqlCommand myCommand = new SqlCommand("INSERT INTO USERS VALUES(@UserName, @Age, @Name, @Email, @Password, @PhoneNumber, @Sex)", myConnection);
                myCommand.Parameters.AddWithValue("@UserName", serName);
                myCommand.Parameters.AddWithValue("@Age", ge);
                myCommand.Parameters.AddWithValue("@Name", ame);
                myCommand.Parameters.AddWithValue("@Email", mail);
                myCommand.Parameters.AddWithValue("@Password", assword);
                myCommand.Parameters.AddWithValue("@Sex", ex);
                myCommand.Parameters.AddWithValue("@Age", ge);
                myCommand.Parameters.AddWithValue("@PhoneNumber", honeNumber);
                myCommand.ExecuteNonQuery();
                myConnection.Close();

                /* while (myReader.Read())
                 {
                     u.UserName = myReader["USER_NAME"].ToString();
                     u.PhoneNumber = myReader["PHONE_NUMBER"].ToString();
                     u.Name = myReader["NAME"].ToString();
                     u.Email = myReader["EMAIL"].ToString();
                     u.Password = myReader["PASSWORD"].ToString();
                     u.Sex = myReader["SEX"].ToString();
                     u.Age = int.Parse(myReader["AGE"].ToString());

            }
               return u;
                */

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return;
            }

        }


    }

}


