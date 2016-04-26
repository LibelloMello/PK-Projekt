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

    }
}
