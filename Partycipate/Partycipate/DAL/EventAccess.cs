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

        public Event FindEvent(int eventId) {

            DbUtil d = new DbUtil();
            Console.WriteLine("Innan SQL");
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
                    e.eventId = int.Parse(myReader["EVENT_ID"].ToString());
                    e.Age = int.Parse(myReader["AGE"].ToString());
                    Console.WriteLine(myReader["USER_NAME"].ToString());
                    Console.WriteLine(myReader["AGE"].ToString());

                }
                return u;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }


        }
}
