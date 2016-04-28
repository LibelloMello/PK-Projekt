using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PartycipateWebService
{
    /// <summary>
    /// Summary description for WebServicePartycipateDB
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
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

            try {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT USER_NAME, EMAIL, AGE FROM USERS", myConnection);
                myCommand.Parameters.AddWithValue("@UserName", userName);
                myCommand.Parameters.AddWithValue("@Email", email);
                myCommand.Parameters.AddWithValue("@Age", age);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
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
