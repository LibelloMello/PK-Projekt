using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public DataSet GetAllEmployees()
        {
            DataSet ds = db.GetEmployees();
            return ds;
        }


        public List<List<string>> ExecuteSQL(string query)
        {
            SqlConnection myConnection = db.Connection();
            SqlDataAdapter adapter = new SqlDataAdapter(query, myConnection);
            DataTable dataTable = new DataTable();
            List<List<string>> listToReturn = new List<List<string>>();
            List<string> tableColumns = new List<string>();
            try
            {
                myConnection.Open();
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adapter.Fill(dataTable);
                myConnection.Close();

                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    tableColumns.Add(dataTable.Columns[i].ColumnName);
                }
                listToReturn.Add(tableColumns);
                foreach (DataRow row in dataTable.Rows)
                {
                    List<string> oneRow = new List<string>();
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        oneRow.Add(row[i].ToString());
                    }
                    listToReturn.Add(oneRow);
                }
                return listToReturn;    
            }
            catch (SqlException sqlE)
            {
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }


   
    }
}
