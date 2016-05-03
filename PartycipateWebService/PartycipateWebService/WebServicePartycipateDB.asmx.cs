using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using PartycipateWebService;

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
        DbUtil db = new DbUtil();

        [WebMethod]
        public List<Event> GetEvents()
        {
            List<Event> GetEvents = db.GetEvents();

            return GetEvents;

        }


        [WebMethod]
        public List<User> GetUsers()
        {
            List<User> GetUsers = db.GetUsers();

            return GetUsers;

        }

    }
}
    

