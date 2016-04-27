﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    class Controller
    {
       

        public static DataTable FindEventsByLocation(string location)
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
    
        public static Boolean GetLoginAuthentication(string userName, string password)
        {
            return UserAccess.GetLoginAuthentication(userName, password);
        }

        public static DataTable GetAllEvents()
        {
            return EventAccess.GetAllEvents(); 
        }
        public static DataTable GetAllEventsByUser(string userName)
        {
            return EventAccess.GetAllEventsByUser(userName);
        }
        public static List<string> ShowLocations()
        {
            return EventAccess.ShowLocations();
        }
        public static void CreateEvent(string eventName, string eventTime, string location, string note, int openSlots, string owner)
        {
            EventAccess.CreateEvent(eventName, eventTime, location, note, openSlots, owner);
        }
        public static Event FindEvent(int eventId)
        {
            return EventAccess.FindEvent(eventId);
        }
        public static void UpdateEvent(int eventId, string eventName, string eventTime, string location, string note, int openSlots)
        {
            EventAccess.UpdateEvent(eventId, eventName, eventTime, location, note, openSlots);
        }



    }
}
