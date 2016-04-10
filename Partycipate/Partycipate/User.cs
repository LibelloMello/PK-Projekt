using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    class User
    {
        private int userId;
        private String phoneNbr;
        private String name;
        private String email;
        private String password;
        private String sex;
        private int age; 
        private List<Event> events;
        private List<EventAttendee> eventAttendees;
    }
}
