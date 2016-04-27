using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller c = new Controller();
            Console.Write("In MyFolder, fetch text file: ");
            Console.Write(c.ReadFile(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
