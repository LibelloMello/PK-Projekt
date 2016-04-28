using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

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

        [WebMethod]
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
        }

        [WebMethod]
        public List<string> GetEvents()
        {
            DbUtil d = new DbUtil();
            SqlConnection myConnection = d.Connection();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT EVENT_ID, EVENT_NAME, EVENT_TIME", myConnection);

                DataSet eventsDS = new DataSet();

                adapter.Fill(eventsDS, "USERS");
                List<string> eventList = new List<string>();
                foreach (DataRow dataRow in eventsDS.Tables["USERS"].Rows)
                {
                    eventList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
                }
                return eventList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }

            /* TEMPLATE:
            [WebMethod]
         public List<string> GetPlayers()
         {
             SqlDataAdapter adapter = new SqlDataAdapter("SELECT playername, gamertag FROM player", con);
             DataSet playerDS = new DataSet();
             adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             adapter.Fill(playerDS, "player");
             List<string> playerList = new List<string>();
             foreach (DataRow dataRow in playerDS.Tables["player"].Rows)
             {
                 playerList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
             }
             return playerList;
         }
            */

        }
    }
}
