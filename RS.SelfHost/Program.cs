using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using RS.Hosting;

namespace RS.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Assembly.Load("RS.Services");

            using (var server = WebApp.Start<Startup>("http://localhost:7777"))
            {
                Console.WriteLine("Server running...");
                Console.ReadLine();
            }
        }
    }
}
