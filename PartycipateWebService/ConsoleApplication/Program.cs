using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServicePartycipateDB ws = new WebServicePartycipateDB();
            Console.WriteLine(ws.GetUser());
            Console.ReadKey();
        }
    }
}
