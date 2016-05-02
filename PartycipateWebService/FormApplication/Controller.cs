﻿using System;
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
        public string GetUsers()
        {
            String output = "";
            User[] usersList = ws.GetUsers();
            foreach (User u in usersList)
            {
                output = output + "Username: " + u.UserName + "\nName: " + u.Name + "\nEmail: " + u.Email + "\nAge: " + u.Age + "\n\n";
            }
            return output;
        }
        public string GetEvents()
        {
            String output = "";
            Event[] eventList = ws.GetEvents();
            foreach (Event e in eventList)
            {
                output = output + "Event id: " + e.EventId + " \nEvent name: " + e.EventName + "\nLocation: " + e.Location + "\n\n";
            }
            return output;
        }
    }
}
