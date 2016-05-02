using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterSoloutionClient.InterSoloutionREadFileServiceReference;
using System.IO;

namespace InterSoloutionClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FileService fs = new FileService();
            Console.WriteLine(fs.ReadFile("test.txt"));
            Console.ReadKey();
        }
    }
}
