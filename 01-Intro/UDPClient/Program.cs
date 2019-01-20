using System;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            String server = "127.0.0.1"; // loop back address
            int servPort = 5000;

            String message = "Supanat";

            byte[] sendPacket = Encoding.ASCII.GetBytes(message);

            UdpClient client = new UdpClient();

            try{

                client.Send(sendPacket,sendPacket.Length,server,servPort);

            }catch(SocketException e){
                Console.WriteLine(e.ErrorCode+" "+e.Message);
            }


        }
    }
}
