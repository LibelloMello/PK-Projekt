using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PartycipateWebService
{
    public class DbUtil
    {

        public SqlConnection Connection()
        {

            SqlConnection myConnection = new SqlConnection("user id=gurra;" +
                                           "password=hejsan;Server=localhost;" +
                                           "Trusted_Connection=yes;" +
                                           "database=trappa; " +
                                           "connection timeout=30");

            Console.WriteLine("Connection");

            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            return myConnection;


        }
        public void closeConn(SqlConnection myConnection)
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public List<Event> GetEvents()
        {

            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;


            List<Event> eventsList = new List<Event>();


            try
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM PARTY", myConnection);
                // myCommand.Parameters.AddWithValue("@EventId", eventId);
                myReader = myCommand.ExecuteReader();


                while (myReader.Read())
                {
                    Event e = new Event();
                    e.EventId = int.Parse(myReader["EVENT_ID"].ToString());
                    e.Location = myReader["LOCATION"].ToString();
                    e.EventName = myReader["EVENT_NAME"].ToString();
                    e.Note = myReader["NOTE"].ToString();
                    e.OpenSlots = int.Parse(myReader["OPEN_SLOTS"].ToString());
                    e.EventTime = myReader["EVENT_TIME"].ToString();

                    eventsList.Add(e);

                }
                return eventsList.ToList();
            }

            catch (Exception)
            {
                return null;
            }
        }

            public List<User> GetUsers()
        {

            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;


            List<User> usersList = new List<User>();


            try
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM USERS", myConnection);
                // myCommand.Parameters.AddWithValue("@EventId", eventId);
                myReader = myCommand.ExecuteReader();


                while (myReader.Read())
                {

                    User u = new User();
                    u.UserName = myReader["USER_NAME"].ToString();
                    u.Age = int.Parse(myReader["AGE"].ToString());
                    u.Email = myReader["EMAIL"].ToString();
                    u.Name = myReader["NAME"].ToString();
                    u.Password = myReader["PASSWORD"].ToString();
                    u.Sex = myReader["SEX"].ToString();

                    usersList.Add(u);

                }
                myConnection.Close();
                return usersList.ToList();
            }

            catch (Exception)
            {
                return null;
            }
        }

        public List<EventAttendee> GetEventAttendees()
        {

            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;


            List<EventAttendee> attendeeList = new List<EventAttendee>();


            try
            {
                SqlCommand myCommand = new SqlCommand("SELECT eID, uID FROM EVENT_ATTENDEE", myConnection);
                // myCommand.Parameters.AddWithValue("@EventId", eventId);
                myReader = myCommand.ExecuteReader();


                while (myReader.Read())
                {

                    EventAttendee ea = new EventAttendee();
                    ea.EventId = myReader["eID"].ToString();
                    ea.UserId = myReader["uID"].ToString();

                    attendeeList.Add(ea);

                }
                myConnection.Close();
                return attendeeList.ToList();
            }

            catch (Exception)
            {
                return null;
            }
        }

    }
}