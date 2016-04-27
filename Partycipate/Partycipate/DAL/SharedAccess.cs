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

        public void DeleteAttendee(int eId, string uId)
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();


            try
            {
                Console.WriteLine("Trying to delete attendee");
                SqlCommand myCommand = new SqlCommand("DELETE FROM ATTENDING WHERE U_ID = @UId AND E_ID=@EId", myConnection);
                myCommand.Parameters.AddWithValue("@EventId", eId);
                myCommand.Parameters.AddWithValue("@UserId", uId);
                myCommand.ExecuteNonQuery();
                Console.WriteLine("Delete attendee executed");
                myConnection.Close();

            }

            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void CreateAttendee(int eId, string uId)
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();

            try
            {
                SqlCommand myCommand = new SqlCommand("INSERT INTO ATTENDING VALUES(@EID, @UId)", myConnection);
                myCommand.Parameters.AddWithValue("@EId", eId);
                myCommand.Parameters.AddWithValue("@UId", uId);
                myCommand.ExecuteNonQuery();
                Console.WriteLine("Attendee successfully created");
                myConnection.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
    
