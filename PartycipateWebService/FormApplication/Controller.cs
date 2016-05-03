using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormApplication.WebServiceReference;

namespace FormApplication
{
    class Controller
    {
        WebServicePartycipateDB ws = new WebServicePartycipateDB();

        public List<User> GetUsers()
        {
            try
            {
                return ws.GetUsers().ToList();
            
            }

            catch (Exception) {
                return null;
            }

        }

        public List<Event> GetEvents()
        {
            try
            {
                return ws.GetEvents().ToList();

            }

            catch (Exception)
            {
                return null;
            }

        }



        /* public string GetEvents()
         {
             String output = "";
             Event[] eventList = ws.GetEvents();
             foreach (Event e in eventList)
             {
                 output = output + "Event id: " + e.EventId + " \nEvent name: " + e.EventName + "\nLocation: " + e.Location + "\n\n";
             }
             return output;
         }*/
    }
}
