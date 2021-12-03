﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TitanicWeather.Models;

namespace RestClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            Console.WriteLine("Starting");
            Worker _worker = new Worker();

            //Receive loop
            while (true)
            {
                ReceiveLoop(_worker);
                Thread.Sleep(10000);
            }
        }

        public static void SendMessage(string message)
        {
            //send data to the server
            byte[] data = Encoding.UTF8.GetBytes(message);
            UdpClient socket = new UdpClient();
            socket.Send(data, data.Length, "255.255.255.255", 5005);

        }
        public async static void ReceiveLoop(Worker worker)
        {
            int command = worker.GetCommand().Result;

            //Resetting the command to 0
            worker.PostItem(new Command() {integer = 3 });

            //Sending to Pi
            if (command == 3)
            {
                Console.WriteLine($"Sending {command} to Pi");
                SendMessage(command.ToString());
#warning Known bug
                //ReadKey is here to stop the program from exiting before async finishes.
                //Exception gets thrown but the program goes on so I don't care.
                //Console.ReadKey();
            }
        }
    }
}
