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

        public List<List<string>> AsListInList(SqlDataReader input)
        {
            if (input != null)
            {
                List<List<string>> list = new List<List<string>>();

                while (input.Read())
                {
                    List<string> tmp = new List<string>();
                    for (int i = 0; i < input.FieldCount; i++)
                    {
                        string s = "";
                        try
                        {
                            s = input.GetString(i) as string;
                        }
                        catch (SqlNullValueException)
                        {
                            s = "null";
                        }


                        tmp.Add(s);


                    }
                    list.Add(tmp);
                }
                return list;
            }
            return null;

        }





        // A
        public List<List<string>> GetAllEmployees()
        {
            SqlConnection myConnection = Connection();
            SqlCommand s = new SqlCommand("SELECT * FROM [CRONUS Sverige AB$Employee]", myConnection);
            
            return AsListInList(s.ExecuteReader());
           // myConnection.Close();

        }
        /*
        public List<List<string>> GetAllEmployeeRelatives()
        {
            return ExecuteQuery("SELECT * FROM [CRONUS Sverige AB$Employee Relative]");
        }
        public List<List<string>> GetAllSickEmployees2004()
        {
            return ExecuteQuery("SELECT * FROM [CRONUS Sverige AB$Employee Absence] WHERE Description = 'Sjuk' AND DATEPART(yy, [From Date]) = 2004");
        }

        public List<List<string>> GetEmployeesWithMostAbsence()
        {
            return ExecuteQuery("select top 1 [First Name]"
                                          +"  from [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee Absence] a"
                                          +"  join [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee] b"
                                          +"  on a.[Employee No_] = b.No_"
                                          +"  and [Cause of Absence Code] = 'SJUK'"
                                          +"  group by [Employee No_], [First Name]"
                                          +"  order by count(*) desc"
            );
        }

        // B

        public List<List<string>> GetCronusKeys()
        {
            return ExecuteQuery("SELECT NAME, TYPE_DESC FROM sys.key_constraints");
        }

        public List<List<string>> GetCronusIndexes()
        {
            return ExecuteQuery("SELECT OBJECT_ID, NAME FROM sys.indexes");
        }

        public List<List<string>> GetCronusTableConstraints()
        {
            return ExecuteQuery("SELECT TABLE_NAME, CONSTRAINT_TYPE FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS");
        }

        public List<List<string>> GetCronusTables()
        {
            return ExecuteQuery("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES");
        }
    
        public List<List<string>> GetCronusTables1()
        {
            return ExecuteQuery("SELECT NAME FROM sys.tables");
        }

        public List<List<string>> GetCronusEmployeeColumns()
        {
            return ExecuteQuery("SELECT COLUMN_NAME" +
                "FROM INFORMATION_SCHEMA.COLUMNS " +
                "WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'"
            );
        }
        public List<List<string>> GetAllEmployeeColumns1()
        {
            return ExecuteQuery("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'"
            );
        }
        */


    }
}