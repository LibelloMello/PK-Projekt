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

        public Event FindEvent(int eventId) {

            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;
            Event e = new Event();

            try
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM PARTY WHERE EVENT_ID = @EventId", myConnection);
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

        public void CreateEvent(string eventName, string eventTime, string location, string note, int openSlots, string owner)
        {

            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();
            SqlDataReader myReader = null;


            try
            {

                SqlCommand myCommand = new SqlCommand("INSERT INTO PARTY VALUES(@EventName, @EventTime, @Location, @Note, @OpenSlots, @Owner)", myConnection);
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
                return;
            }
        }

            public void DeleteEvent(int eventId) {

            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();

            try
            {
                SqlCommand myCommand = new SqlCommand("DELETE FROM PARTY WHERE EVENT_ID = @EventId", myConnection);
                myCommand.Parameters.AddWithValue("@EventId", eventId);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void UpdateEvent(int eventId)
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();

            try
            {
                SqlCommand myCommand = new SqlCommand("UPDATE PARTY SET EVENT_NAME = @EventName, EVENT_TIME = @EventTime, LOCATION = @Location, NOTE = @Note, OPEN_SLOTS = @OpenSlots WHERE EVENT_ID = @EventId");
                myCommand.Parameters.AddWithValue("@EventId", eventId); 
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
        }

        }
    }

