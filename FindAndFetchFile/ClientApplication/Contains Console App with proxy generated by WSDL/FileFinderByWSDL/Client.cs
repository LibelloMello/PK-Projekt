using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 public class Client
    {
        static void Main(string[] args)
        {
            FileService fs = new FileService();
            Console.Write("In MyFolder, fetch file: ");
            Console.Write(fs.ReadFile(Console.ReadLine()));
            Console.ReadKey();
        }
    }

