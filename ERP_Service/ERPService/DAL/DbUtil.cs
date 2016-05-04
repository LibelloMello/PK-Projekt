using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace ERPService
{
    public class DbUtil
    {
        public SqlConnection Connection()
        {

            SqlConnection myConnection = new SqlConnection("user id=gurra;" +
                                           "password=hejsan;Server=localhost;" +
                                           "Trusted_Connection=yes;" +
                                           "database=Demo Database NAV (5-0); " +
                                           "connection timeout=30");

            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            return myConnection;

        }
        public void closeConn(SqlConnection myConnection)
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        public List<List<string>> Mash(SqlDataReader input)
        {
            if (input != null)
            {
                List<List<string>> listToReturn = new List<List<string>>();
                
                
                    List<string> col = new List<string>();
                    for (int i = 0; i < input.FieldCount; i++)
                    {
                        string colPart = "";
                        try
                        {
                            colPart = input.GetName(i).ToString();
                        }
                        catch (NotSupportedException)
                        {
                            colPart = "null";
                        }
                        col.Add(colPart);
                    }
                    listToReturn.Add(col);
                
                


                while (input.Read())
                {
                    List<string> row = new List<string>();
                    for (int i = 0; i < input.FieldCount; i++)
                    {
                        string part = "";
                        try
                        { 
                            part = input.GetValue(i).ToString();
                        }
                        catch (NotSupportedException)
                        {
                            part = "null";
                        }
                        row.Add(part);
                    }
                    listToReturn.Add(row);
                }
                return listToReturn;
            }
            return null;

        }

        //A

        public List<List<string>> GetAllEmployees()
        {
            SqlConnection con = Connection();
            SqlCommand s = new SqlCommand("SELECT TOP 100 *"
                                           + "FROM [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]", con);
            return Mash(s.ExecuteReader());
        }

        public List<List<string>> GetAllEmployeesRelatives()
        {
            SqlConnection con = Connection();
            SqlCommand s = new SqlCommand("SELECT * FROM [CRONUS Sverige AB$Employee Relative]", con);
            return Mash(s.ExecuteReader());
        }

        public List<List<string>> GetAllSickEmployees2004()
        {
            SqlConnection con = Connection();
            SqlCommand s = new SqlCommand("SELECT * FROM [CRONUS Sverige AB$Employee Absence] WHERE Description = 'Sjuk' AND DATEPART(yy, [From Date]) = 2004", con);

            return Mash(s.ExecuteReader());
        }

        public List<List<string>> GetEmployeeWithMostAbsence()
        {
            SqlConnection con = Connection();
            SqlCommand s = new SqlCommand("SELECT TOP 1 [First Name]"
                                          + "  from [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee Absence] a"
                                          + "  join [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee] b"
                                          + "  on a.[Employee No_] = b.No_"
                                          + "  and [Cause of Absence Code] = 'SJUK'"
                                          + "  group by [Employee No_], [First Name]"
                                          + "  order by count(*) desc"
                                          , con);
            return Mash(s.ExecuteReader());
        }

        //B

        public List<List<string>> GetCronusKeys()
        {
            SqlConnection con = Connection();
            SqlCommand s = new SqlCommand("SELECT NAME, TYPE_DESC FROM sys.key_constraints", con);

            return Mash(s.ExecuteReader());
        }

        public List<List<string>> GetCronusIndexes()
            {
            SqlConnection con = Connection();
            SqlCommand s = new SqlCommand("SELECT OBJECT_ID, NAME FROM sys.indexes", con);
            
            return Mash(s.ExecuteReader());

            }

        public List<List<string>> GetCronusTableConstraints()
        {
            SqlConnection con = Connection();
            SqlCommand s = new SqlCommand("SELECT TABLE_NAME, CONSTRAINT_TYPE FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS", con);

            return Mash(s.ExecuteReader());
        }

        public List<List<string>> GetCronusTables()
        {
            SqlConnection con = Connection();
            SqlCommand s = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", con);

            return Mash(s.ExecuteReader());
        }

        public List<List<string>> GetCronusTables1()
        {
            SqlConnection con = Connection();
            SqlCommand s = new SqlCommand("SELECT NAME FROM sys.tables", con);

            return Mash(s.ExecuteReader());
        }

        public List<List<string>> GetCronusEmployeeColumns()
        {
            SqlConnection con = Connection();
            SqlCommand s = new SqlCommand("SELECT COLUMN_NAME " +
                                          "FROM INFORMATION_SCHEMA.COLUMNS " +
                                          "WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'", con);

            return Mash(s.ExecuteReader());
        }

        public List<List<string>> GetCronusEmployeeColumns1()
        {
            SqlConnection con = Connection();
            SqlCommand s = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'", con);

            return Mash(s.ExecuteReader());
        }

        //Add and Remove



    }
}