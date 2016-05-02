using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebugClient.localhost;

namespace DebugClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServicePartycipateDB ws = new WebServicePartycipateDB();
            User[] ls = ws.GetSingleUserList();          
            foreach (User u in ls)
            {
                Console.WriteLine(u.Name);
            }
            
            Console.ReadKey();
        }
    }
}
