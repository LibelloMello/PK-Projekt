using ConsoleApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication;


namespace ConsoleApplication
{
    public class Controller
    {
        WebServicePartycipateDB ws = new WebServicePartycipateDB();
        public string TestUser()
        {
            User ut = ws.GetSingleUser();
            String output;
            output = "Name: " + ut.Name + "Email: " + ut.Email + "Age: " + ut.Age;
            return output;
        }
        public string GetUsers()
        {
            //String output = "";
            User[] userString = ws.GetUsers();
            List<User> usersList = ws.GetUsers();
            foreach (User u in usersList)
            {
                Console.WriteLine("Name: {0} Email: {1} Age: {2}", u.Name, u.Email, u.Age);
            }

           
            
            foreach (User u in ws.GetUsers())
            {
                User u1 = u;

                return u1;
               
            }
            return u;
        }
        public string GetEvents()
        {
            String output = "";
            foreach (String s in ws.GetEvents())
            {
                
                output = output + s + " \n";
            }
            return output;
        }
        
    }
}
