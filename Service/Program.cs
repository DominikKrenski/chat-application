using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Implementations.Server)))
            {
                host.Open();
                Console.WriteLine($"Host started at {DateTime.Now.ToString()}");
                Console.WriteLine("Press enter to close the server");
                Console.ReadKey();
            }
        }
    }
}
