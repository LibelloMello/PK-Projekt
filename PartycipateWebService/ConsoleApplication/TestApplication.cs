using ConsoleApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication
{
    class TestApplication
    {
        static void Main(string[] args)
        {
            Controller c = new Controller();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(c.TestUser());
            Console.ReadKey();

        }
    }
}
