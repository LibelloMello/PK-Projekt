using ConsoleApplication.WebServiceReference;
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

            foreach (String s in ws.GetUsers())
            {
                Console.Beep(frequency:10000, duration:200);
                
                Console.WriteLine(s);
            }

            Console.ReadKey();
            
        }
    }
}
