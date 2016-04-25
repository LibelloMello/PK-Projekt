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
            public User CreateUser(string userName, string phoneNumber, string name, string email, string password, string sex, int age) {

            DbUtil d = new DbUtil();
            Console.WriteLine("Innan SQL");
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;
            User u = new User();

            try
            {
                SqlCommand myCommand = new SqlCommand("INSERT INTO PARTY VALUES(@UserName, @PhoneNumber, @Name, @Email, @Password, @Sex, @Age", myConnection);
                myCommand.Parameters.AddWithValue("@UserName", userName);
                myCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                myCommand.Parameters.AddWithValue("@Name", name);
                myCommand.Parameters.AddWithValue("@Email", email);
                myCommand.Parameters.AddWithValue("@Password", password);
                myCommand.Parameters.AddWithValue("@Sex", sex);
                myCommand.Parameters.AddWithValue("@Age", age);
                myReader = myCommand.ExecuteReader();


                while (myReader.Read())
                {
                    u.UserName = myReader["USER_NAME"].ToString();
                    u.PhoneNumber = myReader["PHONE_NUMBER"].ToString();
                    u.Name = myReader["NAME"].ToString();
                    u.Email = myReader["EMAIL"].ToString();
                    u.Password = myReader["PASSWORD"].ToString();
                    u.Sex = myReader["SEX"].ToString();
                    u.Age = int.Parse(myReader["AGE"].ToString());
                    Console.WriteLine(myReader["USER_NAME"].ToString());
                    Console.WriteLine(myReader["PHONE_NUMBER"].ToString());
                    Console.WriteLine(myReader["NAME"].ToString());
                    Console.WriteLine(myReader["EMAIL"].ToString());
                    Console.WriteLine(myReader["PASSWORD"].ToString());
                    Console.WriteLine(myReader["SEX"].ToString());      
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


