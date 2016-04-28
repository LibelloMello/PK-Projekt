using ConsoleApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Controller
    {
        WebServicePartycipateDB ws = new WebServicePartycipateDB();
        public string GetUsers()
        {
            String output = "";
            foreach (String s in ws.GetUsers())
            {
                output = output + s + " \n";
            }
            return output;
        }
        public string GetEvents()
        {
            String output = "";
            foreach (String s in ws.GetEvents())
            {
                output = output + s + " \n";
            }
            return output;
        }
    }
}
