using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    public class User
    {
        public User() { }
        public User(string userName, int age)
        {
            userName = this.userName;
            age = this.age;
        }
        private string userName;
        private String phoneNbr;
        private String name;
        private String email;
        private String password;
        private String sex;
        private int age; 
        private List<Event> events;
        private List<EventAttendee> eventAttendees;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
    }
}
