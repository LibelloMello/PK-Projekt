﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ERPService
{
    public class DbUtil
    {
        DbUtil db = new DbUtil();
        public SqlConnection Connection()
        {

            SqlConnection myConnection = new SqlConnection("user id=gurra;" +
                                           "password=hejsan;Server=localhost;" +
                                           "Trusted_Connection=yes;" +
                                           "database=Demo Database NAV (5-0); " +
                                           "connection timeout=30");

            Console.WriteLine("I TRY Connection");

            try
            {
                myConnection.Open();
                Console.WriteLine("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine("I FAIL connection");
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


        public DataSet GetEmployees()
        {
            
            SqlConnection myConnection = db.Connection();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [CRONUS Sverige AB$Employee]", myConnection);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(ds, "Employees");

            return ds;
        }
        public DataSet GetEmployeeRelatives()
        {
            return ExecuteQuery("");
        }


    }
}