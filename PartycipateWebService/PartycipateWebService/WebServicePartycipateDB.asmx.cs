using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Partycipate;

namespace PartycipateWebService
{
    /// <summary>
    /// Summary description for WebServicePartycipateDB
    /// </summary>
    [WebService(Namespace = "http://grupp11.ics.lu.se/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePartycipateDB : System.Web.Services.WebService
    {

        /*[WebMethod]
        public List<string> GetUsers()
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT USER_NAME, EMAIL, AGE FROM USERS", myConnection);

                DataSet usersDS = new DataSet();

                adapter.Fill(usersDS, "USERS");
                List<string> userList = new List<string>();
                foreach (DataRow dataRow in usersDS.Tables["USERS"].Rows)
                {
                    userList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
                }
                return userList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }*/
        [WebMethod]
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
                return eventsList;
            }

            catch (Exception e1)
            {
                return null;
            }


        }


        [WebMethod]
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
                return usersList;
            }

            catch (Exception e1)
            {
                return null;
            }


        }
    }
}
