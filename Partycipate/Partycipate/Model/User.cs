using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    public class User
    {
        /* Constructors start */
        public User() { }
        public User(string userName, int age)
        {
            this.userName = userName;
            this.age = age;
        }
        public User(String userName, String phoneNbr, String name, String email, String password, String sex, int age)
        {
            this.userName = userName;
            this.phoneNbr = phoneNbr;
            this.name = name;
            this.email = email;
            this.password = password;
            this.sex = sex;
            this.age = age;
        }
        /* Constructors end */

        /* Members start */
        private String userName;
        private String phoneNbr;
        private String name;
        private String email;
        private String password;
        private String sex;
        private int age;
        private List<Event> events;
        private List<EventAttendee> eventAttendees;
        /* Mambers end */

        /*Properties start*/
        public String UserName
        {
            get
            {
                return userName;
            }

            set
            {
                this.userName = value;
            }
        }
        public String Phonebr
        {
            get
            {
                return phoneNbr;
            }
            set
            {
                this.phoneNbr = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                this.email = value;
            }
        }
        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                this.password = value;
            }
        }
        public String Sex
        {
            get
            {
                return sex;
            }
            set
            {
                this.sex = value;
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
                this.age = value;
            }
        }
        public List<Event> Eventsasd
        {
            get { return events; }
            set { this.events = value; }
        }
        /* Properties end */

        /* Methods start */
        /* Methods end */

    }
}
