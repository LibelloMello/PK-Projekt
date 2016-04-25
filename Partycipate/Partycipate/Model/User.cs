using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    public class User
    {
        public string userName { get; set; }
        public String phoneNbr { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public String sex { get; set; }
        public int age { get; set; }
        public List<Event> events;
        public List<EventAttendee> eventAttendees;

        public User() { }
        public User(string userName, int age)
        {
            userName = this.userName;
            age = this.age;
        }


    }
}
