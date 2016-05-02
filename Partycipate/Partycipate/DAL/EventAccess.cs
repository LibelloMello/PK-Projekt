using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Partycipate
{
    public class EventAccess
    {

        public static Event FindEvent(int eventId)
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
                    e.Location = myReader["LOCATION"].ToString();
                    e.EventName = myReader["EVENT_NAME"].ToString();
                    e.Note = myReader["NOTE"].ToString();
                    e.OpenSlots = int.Parse(myReader["OPEN_SLOTS"].ToString());
                    e.EventTime = myReader["EVENT_TIME"].ToString();

                }
                return e;

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
                return null;
            }


        }

        public static bool CreateEvent(string eventName, string eventTime, string location, string note, int openSlots, string owner)
        {

            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();


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
                return true;

            }
            catch (Exception e)
            {
               
            }
            return false;
        }
        public static bool DeleteEvent(int eventId, string userName)
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();

            SqlDataReader myReader = null;


                try
                {
                
                SqlCommand myCommand = new SqlCommand("SELECT OWNER FROM PARTY WHERE EVENT_ID = @EventId", myConnection);
                myCommand.Parameters.AddWithValue("@EventId", eventId);
                myReader = myCommand.ExecuteReader();
                string owner = "";
                while (myReader.Read())
                {
                    owner = myReader["OWNER"].ToString();
                }
                myReader.Close();
                if (owner.Equals(userName))
                    {
                        SqlCommand myCommand2 = new SqlCommand("DELETE FROM PARTY WHERE EVENT_ID = @EventId", myConnection);
                    myCommand2.Parameters.AddWithValue("@EventId", eventId);


                    myCommand2.ExecuteNonQuery();
                       
                        return true;
                    }
                myConnection.Close();
         
            }
                
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);

                }
            return false;
        }

        public static void UpdateEvent(int eventId, string eventName, string eventTime, string location, string note, int openSlots)
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();

            try
            {
                SqlCommand myCommand = new SqlCommand("UPDATE PARTY SET EVENT_NAME = @EventName, EVENT_TIME = @EventTime, LOCATION = @Location, NOTE = @Note, OPEN_SLOTS = @OpenSlots WHERE EVENT_ID = @EventId", myConnection);
                myCommand.Parameters.AddWithValue("@EventId", eventId);
                myCommand.Parameters.AddWithValue("@EventName", eventName);
                myCommand.Parameters.AddWithValue("@EventTime", eventTime);
                myCommand.Parameters.AddWithValue("@Location", location);
                myCommand.Parameters.AddWithValue("@Note", note);
                myCommand.Parameters.AddWithValue("@OpenSlots", openSlots);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Update failed");
            }
        }

        public static DataTable FindEventsByLocation(string location)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand myCommand = new SqlCommand();
            DataTable table = new DataTable();

            try
            {
                DbUtil d = new DbUtil();
                SqlConnection myConnection = d.Connection();
                //myCommand = new SqlCommand("SELECT EVENT_ID AS 'Event ID', EVENT_NAME AS 'Eventname', "
                //  + "EVENT_TIME AS 'Event time', LOCATION AS 'Location', NOTE AS 'Note' FROM PARTY WHERE USER_NAME = " + userName , myConnection);

                myCommand = new SqlCommand("SELECT EVENT_ID AS 'Event ID', EVENT_NAME AS 'Eventname', EVENT_TIME AS 'Event time', LOCATION AS 'Location', NOTE AS 'Note', OWNER AS Owner FROM PARTY WHERE LOCATION = '" + location + "'", myConnection);
                da.SelectCommand = myCommand;
                da.Fill(table);
                myConnection.Close();
                return table;
            }
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                throw sqlEx;
            }
        }
        public static DataTable GetAllEventsByUser(string userName)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand myCommand = new SqlCommand();
            DataTable table = new DataTable();

            try
            {
                DbUtil d = new DbUtil();
                SqlConnection myConnection = d.Connection();
                //myCommand = new SqlCommand("SELECT EVENT_ID AS 'Event ID', EVENT_NAME AS 'Eventname', "
                //  + "EVENT_TIME AS 'Event time', LOCATION AS 'Location', NOTE AS 'Note' FROM PARTY WHERE USER_NAME = " + userName , myConnection);

                myCommand = new SqlCommand("SELECT EVENT_ID AS 'Event ID', EVENT_NAME AS 'Eventname', EVENT_TIME AS 'Event time', LOCATION AS 'Location', NOTE AS 'Note', OWNER AS 'Owner' FROM PARTY WHERE OWNER = '" + userName + "'", myConnection);
                da.SelectCommand = myCommand;
                da.Fill(table);
                myConnection.Close();
                return table;
            }
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                throw sqlEx;
            }
        }


        public static DataTable GetAllEvents()
        {
            try
            {
                DbUtil d = new DbUtil();
                SqlConnection myConnection = d.Connection();
                string query = ("SELECT EVENT_ID AS 'Event ID', EVENT_NAME AS 'Eventname', EVENT_TIME AS 'Event time', LOCATION AS 'Location', NOTE AS 'Note' FROM PARTY");
                SqlDataAdapter da = new SqlDataAdapter(query, myConnection);
                DataTable table = new DataTable();
                da.Fill(table);
                myConnection.Close();
                return table;
            }
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                throw sqlEx;
            }
        }
        public static List<string> ShowLocations()
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();
            List<string> locations = new List<string>();
            SqlDataReader myReader = null;
            try
            {
                SqlCommand myCommand = new SqlCommand("SELECT DISTINCT LOCATION FROM PARTY", myConnection);
                myReader = myCommand.ExecuteReader();


                while (myReader.Read())
                {
                    locations.Add(myReader["LOCATION"].ToString());

                }
                return locations;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

