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
            Controller c = new Controller();
            Start:
            Console.WriteLine("Insert 'u' followed by Enter to display all users.");
            Console.WriteLine("Insert 'e' followed by Enter to displat all events.");
            Console.WriteLine("Insert 'exit' followed by Enter to exit application.");
            String caseSwitch = Console.ReadLine();
            switch (caseSwitch)
            {
                case "u":
                    Console.WriteLine(c.GetUsers());
                    break;
                case "e":
                    Console.WriteLine(c.GetEvents());
                    break;
                case "exit";
                    Environment.Exit(1);
                    break;
                default:
                    Console.Clear();
                    goto Start;
                    break;
            }
            goto Start;

            
            
            

            Console.ReadKey();
            
        }
    }
}
