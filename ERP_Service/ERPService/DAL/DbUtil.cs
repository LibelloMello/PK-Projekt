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
            try {                
                SqlCommand s = new SqlCommand("SELECT TOP 100 *"
                                               + "FROM [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]", con);
                
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
              Console.WriteLine(e.ToString());
                return null;

            }
            finally
            {
                closeConn(con);
            }

        }

        public List<List<string>> GetAllEmployeesRelatives()
        {
            SqlConnection con = Connection();
            try {
                SqlCommand s = new SqlCommand("SELECT [CRONUS Sverige AB$Employee].No_, [CRONUS Sverige AB$Employee].[First Name], [CRONUS Sverige AB$Employee].[Job Title], [CRONUS Sverige AB$Employee Relative].[Relative Code], [CRONUS Sverige AB$Employee Relative].[First Name] AS [FirstName]"
                                            + " FROM[CRONUS Sverige AB$Employee]"
                                            + " INNER JOIN[CRONUS Sverige AB$Employee Relative]"
                                            + " ON[CRONUS Sverige AB$Employee].No_ = [CRONUS Sverige AB$Employee Relative].[Employee No_]"
                                            + " ORDER BY[CRONUS Sverige AB$Employee].No_", con);
                return Mash(s.ExecuteReader());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                closeConn(con);
            }
        }

        public List<List<string>> GetAllSickEmployees2004()
        {
            SqlConnection con = Connection();
            try {
                SqlCommand s = new SqlCommand("SELECT * FROM [CRONUS Sverige AB$Employee Absence] WHERE Description = 'Sjuk' AND DATEPART(yy, [From Date]) = 2004", con);
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                closeConn(con);
            }
        }

        public List<List<string>> GetEmployeeWithMostAbsence()
        {
            SqlConnection con = Connection();
            try {
                SqlCommand s = new SqlCommand("SELECT TOP 10 [First Name]"
                                              + "  FROM [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee Absence] A"
                                              + "  JOIN [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee] B"
                                              + "  ON A.[Employee No_] = B.No_"
                                              + "  AND [Cause of Absence Code] = 'SJUK'"
                                              + "  GROUP BY [Employee No_], [First Name]"
                                              + "  ORDER BY COUNT(*) DESC", con);
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;

            }
            finally
            {
                closeConn(con);
            }
        }

        //B

        public List<List<string>> GetCronusKeys()
        {
            SqlConnection con = Connection();
            try {
                SqlCommand s = new SqlCommand("SELECT NAME, TYPE_DESC FROM sys.key_constraints", con);
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
                e.ToString();
                return null;
            }
            finally
            {
                closeConn(con);
            }
        }

        public List<List<string>> GetCronusIndexes()
            {
            SqlConnection con = Connection();
            try {                
                SqlCommand s = new SqlCommand("SELECT OBJECT_ID, NAME FROM sys.indexes", con);
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                closeConn(con);
            }
          }

        public List<List<string>> GetCronusTableConstraints()
        {
            SqlConnection con = Connection();
            try {
                SqlCommand s = new SqlCommand("SELECT TABLE_NAME, CONSTRAINT_TYPE FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS", con);
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                closeConn(con);
            }
        }

        public List<List<string>> GetCronusTables()
        {
            SqlConnection con = Connection();
            try {
                SqlCommand s = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", con);
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                closeConn(con);
            }
        }

        public List<List<string>> GetCronusTables1()
        {
            SqlConnection con = Connection();
            try {
                SqlCommand s = new SqlCommand("SELECT NAME FROM sys.tables", con);
                return Mash(s.ExecuteReader());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                closeConn(con);
            }
        }

        public List<List<string>> GetCronusEmployeeColumns()
        {
            SqlConnection con = Connection();
            try {
                SqlCommand s = new SqlCommand("SELECT TOP 0 * FROM [CRONUS Sverige AB$Employee]", con);
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                closeConn(con);
            }
        }

        public List<List<string>> GetCronusEmployeeColumns1()
        {
            SqlConnection con = Connection();
            try {
                SqlCommand s = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'", con);
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                closeConn(con);
            }
        }

        public List<List<string>> GetEmployeeKeys()
        {
            SqlConnection con = Connection();
            try
            {
                SqlCommand s = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME LIKE 'CRONUS Sverige AB$Employ%'", con);
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                closeConn(con);
            }
        }

        public List<List<string>> GetEmployeeConstraints()
        {
            SqlConnection con = Connection();
            try
            {
                SqlCommand s = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE TABLE_NAME LIKE 'CRONUS Sverige AB$Employ%'", con);
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                closeConn(con);
            }
        }
        

         public List<List<string>> GetEmployeeIndexes()
        {
            SqlConnection con = Connection();
            try
            {
                SqlCommand s = new SqlCommand("SELECT * FROM sys.indexes WHERE name LIKE 'CRONUS Sverige AB$Employ%'", con);
                return Mash(s.ExecuteReader());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                closeConn(con);
            }
        }



















        //Add, Update and Remove


        public void DeleteEmployee(string id)
        {
            SqlConnection con = Connection();
            try {
                SqlCommand s = new SqlCommand("DELETE"
                                              + " FROM [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]"
                                              + " WHERE No_ = @id", con);
                s.Parameters.AddWithValue("@id", id);
                s.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                closeConn(con);
            }

        }


        public void AddEmployee(string id, string name)
        {
            SqlConnection con = Connection();
            try {
                SqlCommand s = new SqlCommand("INSERT INTO [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]"
                                             + " (No_, [First Name])"
                                             + " VALUES(@id, @name)", con);
                s.Parameters.AddWithValue("@id", id);
                s.Parameters.AddWithValue("@name", name);
                s.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                closeConn(con);
            }
        }


        public void UpdateEmployee(string id, string name)
        {
            SqlConnection con = Connection();
            try
            {
                SqlCommand s = new SqlCommand("UPDATE [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]"
                                            + " SET [First Name]=@name"
                                            + " WHERE No_=@id; "
                                            , con);
                s.Parameters.AddWithValue("@id", id);
                s.Parameters.AddWithValue("@name", name);
                s.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                closeConn(con);
            }
        }




    }
}