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
        
        /*
        [TEST TEMPLATE, OR NOT... i dunno]
        public List<List<String>> GetColumns()
        {
            SqlConnection con = db.Connection();
            SqlCommand s = new SqlCommand("select top 100 Table_Name, Column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'CRONUS Sverige AB$Employee'", con);
            
            return convert(s.ExecuteReader());
        } 
        */
        [WebMethod]
        public List<List<string>> GetAllEmployeesRelatives()
        {
            return db.GetAllEmployeesRelatives();
            
        }
        [WebMethod]
        public List<List<string>> GetAllEmployees()
        {
            return db.GetAllEmployees();
        }
        [WebMethod]
        public List<List<string>> GetAllSickEmployees2004()
        {
            return db.GetAllSickEmployees2004();
        }
        [WebMethod]
        public List<List<string>> GetEmployeeWithMostAbsence()
        {
            return db.GetEmployeeWithMostAbsence();
        }
        [WebMethod]
        public List<List<string>> GetCronusKeys()
        {
            return db.GetCronusKeys();
        }
        [WebMethod]
        public List<List<string>> GetCronusIndexes()
        {
            return db.GetCronusIndexes();
        }
        [WebMethod]
        public List<List<string>> GetCronusTableConstraints()
        {
            return db.GetCronusTableConstraints();
        }
        [WebMethod]
        public List<List<string>> GetCronusTables()
        {
            return db.GetCronusTables();
        }
        [WebMethod]
        public List<List<string>> GetCronusTables1()
        {
            return db.GetCronusTables1();
        }
        [WebMethod]
        public List<List<string>> GetCronusEmployeeColumns()
        {
            return db.GetCronusEmployeeColumns();
        }
        [WebMethod]
        public List<List<string>> GetCronusEmployeeColumns1()
        {
            return db.GetCronusEmployeeColumns1();
        }

        /* Example of method
        [WebMethod]
        public List<List<string>> Example()
        {
            return db.Example();
        }
        */







    }
    }
