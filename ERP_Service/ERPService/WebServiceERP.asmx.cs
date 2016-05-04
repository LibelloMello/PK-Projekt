using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ERPService
{
    /// <summary>
    /// Summary description for WebServiceERP
    /// </summary>
    [WebService(Namespace = "http://grupp11.ics.lu.se/ERP/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceERP : System.Web.Services.WebService
    {
        DbUtil db = new DbUtil();
        

        [WebMethod]
        public string Hello()
        {
            return "HelloWorld";
        }
        
        [WebMethod]
        public List<List<String>> GetColumns()
        {
            SqlConnection con = db.Connection();
            SqlCommand s = new SqlCommand("select top 100 Table_Name, Column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'CRONUS Sverige AB$Employee'", con);
            
            return convert(s.ExecuteReader());
           

        } 
        [WebMethod]
        public List<List<string>> GetAllEmployeesRelatives()
        {
            
        }

        





    }
}
