using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace NetworkPrograming
{
    class CommandLine
    {
        static void Main(string[] args)
        {
            String name = (args.Length < 1) ? Dns.GetHostName() : args[0];
            //String NAME="DELL";
            try
            {
                IPAddress[] addrs = Dns.Resolve(name).AddressList;
                foreach(IPAddress addr in addrs)
                {
                    Console.WriteLine("{0} ==> {1}", name, addr);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
