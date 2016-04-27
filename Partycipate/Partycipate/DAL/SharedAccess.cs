using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate.DAL
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
    }
}   
    
