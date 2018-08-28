using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client2
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2055);
            sok.Connect(ipe);

            while (true)
            {

                byte[] MsgBuffer = new byte[255];
                int rec = sok.Receive(MsgBuffer, 0, MsgBuffer.Length, 0);
                Array.Resize(ref MsgBuffer, rec);

                Console.WriteLine("SERVER:{0}", Encoding.Default.GetString(MsgBuffer));



                Console.WriteLine("Enter any thing: ");
                String msg = Console.ReadLine();
                if (msg == "exit")
                {
                    break;
                }
                byte[] buffer = Encoding.Default.GetBytes(msg);
                sok.Send(buffer, 0, buffer.Length, 0);




            }


            Console.ReadLine();
            sok.Close();





        }
    }
}
