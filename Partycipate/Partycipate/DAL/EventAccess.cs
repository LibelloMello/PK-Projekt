using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Partycipate.DAL
{
    class EventAccess
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
                    e.Location = (myReader["LOCATION"].ToString());

                }
                return e;

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
                return null;
            }


        }
    }
}
