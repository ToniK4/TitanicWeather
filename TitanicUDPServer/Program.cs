using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace TitanicUDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Titanic UDP Server");

            //initialize
            UdpClient socket = new UdpClient();
            socket.Client.Bind(new IPEndPoint(IPAddress.Any, 65000));

            while (true)
            {
                //receieve data
                IPEndPoint from = null;
                byte[] data = socket.Receive(ref from);

                string dataString = Encoding.UTF8.GetString(data);
                Console.WriteLine("Received from Sense Hat: " + dataString /*+ " - " + from.Address*/);

                dataString = "move: " + dataString;
                byte[] toBeSend = Encoding.UTF8.GetBytes(dataString);
                //echo back data
                socket.Send(toBeSend, toBeSend.Length, from);
            }
        }
    }
}
