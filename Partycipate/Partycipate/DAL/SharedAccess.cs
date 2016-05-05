using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate
{
    public class SharedAccess
    {

        public static bool DeleteAttendee(int eId, string uId)
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();


            try
            {
                SqlCommand myCommand = new SqlCommand("DELETE FROM EVENT_ATTENDEE WHERE eID = @EventId AND uID = @UserId", myConnection);
                myCommand.Parameters.AddWithValue("@EventId", eId);
                myCommand.Parameters.AddWithValue("@UserId", uId);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                return true;

            }

            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public static bool CreateAttendee(int eId, string uId)
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();

            try
            {
                SqlCommand myCommand = new SqlCommand("INSERT INTO EVENT_ATTENDEE VALUES(@EId, @UId)", myConnection);
                myCommand.Parameters.AddWithValue("@EId", eId);
                myCommand.Parameters.AddWithValue("@UId", uId);
                myCommand.ExecuteNonQuery();

                myConnection.Close();
                return true;

            }
            catch (SqlException e)
            {

                Console.WriteLine(e.ToString());
                return false;
            }

        }

        /*public static DataTable GetAllAttendeesByEvent(int eId, string uId)
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

                myCommand = new SqlCommand("SELECT uID AS 'Username' FROM EVENT_ATTENDEE WHERE eID = @EventId", myConnection);
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
        */
    }
}

