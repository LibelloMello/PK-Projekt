using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebugClient.localhost;

namespace DebugClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServicePartycipateDB ws = new WebServicePartycipateDB();
            User[] ls = ws.GetSingleUser();
            String output;

            output = "Name: " + ut.Name + "Email: " + ut.Email + "Age: " + ut.Age;
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
