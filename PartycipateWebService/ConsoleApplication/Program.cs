﻿using ConsoleApplication.WebServiceReference;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
        Start:
            Console.Clear();
            Console.WriteLine("This application displays all Users and Events currently registred.\n");
            Console.WriteLine("Insert 'u' followed by Enter to display all users.");
            Console.WriteLine("Insert 'e' followed by Enter to display all events.");
            Console.WriteLine("Insert 'a' followed by Enter to display all attendees.");
            Console.WriteLine("Insert 'exit' followed by Enter to exit application.\n");
            String caseSwitch = Console.ReadLine();
            switch (caseSwitch)
            {
                case "u":
                    Console.Clear();
                    Console.WriteLine("All users: \n");
                    Console.WriteLine(c.GetUsers());
                    Console.WriteLine("Hit any key to reload.");
                    Console.ReadKey();
                    break;
                case "e":
                    Console.Clear();
                    Console.WriteLine("All events: \n");
                    Console.WriteLine(c.GetEvents());
                    Console.WriteLine("Hit any key to reload.");
                    Console.ReadKey();
                    break;
                case "a":
                    Console.Clear();
                    Console.WriteLine("All eventattendees: \n");
                    Console.WriteLine(c.GetEventAttendees());
                    Console.WriteLine("Hit any key to reload.");
                    Console.ReadKey();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    goto Start; 
                    
                    
            }
            goto Start;

            
            
            

            
            
        }
    }
}
