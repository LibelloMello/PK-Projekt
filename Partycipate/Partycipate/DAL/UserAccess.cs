﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partycipate.DAL
{
    class UserAccess
    {
      /*  public static FindUser(String userName)
        {
            Connection con = null;
            SqlCommand myCom = new SqlCommand("SELECT u FROM User u WHERE userName = ?");

        }*/
        public static void CreateUser(String userName, int age, String email, String name, String password, String phoneNbr, String sex)
        {
            SqlCommand myCommand = new SqlCommand("INSERT INTO USERS VALUES ('testnamn', 1990, 'mail@test', 'testnamn', 'pwtest', '077test', 'Male", myConnection);
        }








    }
}