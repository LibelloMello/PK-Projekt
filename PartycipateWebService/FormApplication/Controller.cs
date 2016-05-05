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

        public List<EventAttendee> GetEventAttendees()
        {
            try
            {
                return ws.GetEventAttendees().ToList();

            }

            catch (Exception)
            {
                return null;
            }
        }
    }
}
