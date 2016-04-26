using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    public class EventAccess
    {

        public Event FindEvent(int eventId)
        {

            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;
            Event e = new Event();

            try
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM PARTY WHERE EVENT_ID = @eventId", myConnection);
                myCommand.Parameters.AddWithValue("@eventId", eventId);
                myReader = myCommand.ExecuteReader();


                while (myReader.Read())
                {
                    e.EventId = int.Parse(myReader["EVENT_ID"].ToString());
                    e.Location = (myReader["Location"].ToString());

                }
                return e;

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
                return null;
            }


        }

        public void CreateEvent(int eventId, string eventName, string eventTime, string location, string note, int openSlots, string owner)
        {

            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;


            try
            {

                SqlCommand myCommand = new SqlCommand("INSERT INTO PARTY VALUES(@EventId, @EventName, @EventTime, @Location, @Note, @OpenSlots, @Owner)", myConnection);
                myCommand.Parameters.AddWithValue("@EventId", eventId);
                myCommand.Parameters.AddWithValue("@EventName", eventName);
                myCommand.Parameters.AddWithValue("@EventTime", eventTime);
                myCommand.Parameters.AddWithValue("@Location", location);
                myCommand.Parameters.AddWithValue("@Note", note);
                myCommand.Parameters.AddWithValue("@OpenSlots", openSlots);
                myCommand.Parameters.AddWithValue("@Owner", owner);
                myCommand.ExecuteNonQuery();
                myConnection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        public void DeleteEvent(int eventId)
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();

            try
            {
                Console.WriteLine("I try delete");
                SqlCommand myCommand = new SqlCommand("DELETE FROM PARTY WHERE EVENT_ID = @EventId", myConnection);
                myCommand.Parameters.AddWithValue("@EventId", eventId);
                myCommand.ExecuteNonQuery();
                Console.WriteLine("Event delete executed");
                myConnection.Close();

            }

            catch(SqlException e)
            {
                Console.WriteLine(e.ToString());

            }
        }

        public void UpdateEvent(int eventId, string eventName, string eventTime, string location, string note, int openSlots)
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();

            try
            {
                Console.WriteLine("I try to update event");
                SqlCommand myCommand = new SqlCommand("UPDATE PARTY SET EVENT_NAME = @EventName, EVENT_TIME = @EventTime, LOCATION = @Location, NOTE = @Note, OPEN_SLOTS = @OpenSlots WHERE EVENT_ID = @EventId", myConnection);
                myCommand.Parameters.AddWithValue("@EventId", eventId);
                myCommand.Parameters.AddWithValue("@EventName", eventName);
                myCommand.Parameters.AddWithValue("@EventTime", eventTime);
                myCommand.Parameters.AddWithValue("@Location", location);
                myCommand.Parameters.AddWithValue("@Note", note);
                myCommand.Parameters.AddWithValue("@OpenSlots", openSlots);
                myCommand.ExecuteNonQuery();
                Console.WriteLine("Update executed");
                myConnection.Close();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Update failed");
            }
        }

        public static List<Event> FindEventsByLocation(string location)
        {
            {
                DbUtil d = new DbUtil();
                Console.WriteLine("Innan SQL");
                SqlConnection myConnection = d.Connection();
                SqlDataReader myReader = null;
                Event e = new Event();
                List<Event> events = new List<Event>();

                try
                {
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM PARTY WHERE LOCATION = @Location", myConnection);
                    myCommand.Parameters.AddWithValue("@Location", location);
                    myReader = myCommand.ExecuteReader();


                    while (myReader.Read())
                    {
                        e.EventId = int.Parse(myReader["AGE"].ToString());
                        e.EventName = myReader["EVENT_NAME"].ToString();
                        e.EventTime = myReader["EVENT_TIME"].ToString();
                        events.Add(e);

                    }
                    return events;

                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1.ToString());
                    return null;
                }
            }
        }
    }
}
