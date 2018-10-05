using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace Persons.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var hostConfigs = new HostConfiguration()
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };
            var nancyHost = new NancyHost(hostConfigs, new Uri("http://localhost:1234"));
            
            nancyHost.Start();
            Console.WriteLine("Service started!");
            Console.ReadLine();
            nancyHost.Stop();
            Console.WriteLine("Service stoped!");
        }
    }
}
