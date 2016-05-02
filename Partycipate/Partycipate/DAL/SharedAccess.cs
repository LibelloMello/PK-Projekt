using System;
using System.Collections.Generic;
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
    }
}
    
