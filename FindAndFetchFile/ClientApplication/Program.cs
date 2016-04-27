using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Controller c = new Controller();
            Console.Write("In MyFolder, fetch file: ");
            Console.Write(c.ReadFile(Console.ReadLine()));
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Insert 'e' or 'exit' followed by Enter to exit application. Any other key to fetch a file!");
            String input = Console.ReadLine();
            if (string.Equals(input, "e", StringComparison.OrdinalIgnoreCase) || string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
            {
                goto End;
            }
            else
            {
                goto Start;
            }
        End:
            Environment.Exit(1);
            
        }
    }
}
