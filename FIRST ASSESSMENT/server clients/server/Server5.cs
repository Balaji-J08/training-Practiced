using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace NetworkPrograming
{
    class Server5
    {
        static void Main(string[] args)
        {
            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soc.Bind(new IPEndPoint(0, 2055));
            soc.Listen(0);

            Console.WriteLine("Server is Ready");
            Socket acc = soc.Accept();


            byte[] MsgBuffer = Encoding.Default.GetBytes("hello client....");//converts from String to bytes and store it in the byte[]
            acc.Send(MsgBuffer, 0, MsgBuffer.Length, 0);
         



                byte[] buffer = new byte[255];
                int Rec = acc.Receive(buffer, 0, buffer.Length, 0);
                Array.Resize(ref buffer, Rec);
                Console.WriteLine("From the Client: {0}", Encoding.Default.GetString(buffer));



                while (true)
                {

                    Console.WriteLine("Enter anything");
                    String m = Console.ReadLine();
                    if (m == "exit" || m.Length <= 0)
                    {
                        break;
                    }

                    byte[] mbuffer = Encoding.Default.GetBytes(m);
                    acc.Send(mbuffer, 0, mbuffer.Length, 0);

                }


            // Console.WriteLine("From the Client: {0}", Encoding.Default.GetString(mbuffer));//converts from byte to string.


            soc.Close();
            acc.Close();

            Console.ReadKey();
        }
           



        }

    }

