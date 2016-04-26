using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    class Controller
    {
       

        public static List<Event> FindEventsByLocation(string location)
        {
           return EventAccess.FindEventsByLocation(location);
        }

        public static void CreateUser(string userName, int age, string name, string email, string password, string phoneNumber, string sex)
        {
            UserAccess.CreateUser(userName, age, name, email, password, phoneNumber, sex);
        }
        public static void DeleteUser(string userName)
        {
            UserAccess.DeleteUser(userName);
        }
        

    }
}
