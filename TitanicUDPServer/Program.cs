using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Globalization;
using TitanicWeather.Models;
using TitanicWeather.Managers;
using TitanicWeather.TitanicContext;
using TitanicWeather;

namespace TitanicUDPServer
{
    public static class Program
    {
        private static TitanicManagerDB managerDB = new TitanicManagerDB();
        
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
                string[] measArray = dataString.Split(',');

                Console.WriteLine("Received from Sense Hat: " + dataString /*+ " - " + from.Address*/);

                Measurement newMeasure = new Measurement()
                {
                    DateAndTime = DateTime.Now,
                    Temperature = Math.Round(decimal.Parse(measArray[0], CultureInfo.InvariantCulture), 4),
                    Humidity = Math.Round(decimal.Parse(measArray[1], CultureInfo.InvariantCulture), 4),
                    Pressure = Math.Round(decimal.Parse(measArray[2], CultureInfo.InvariantCulture), 4)
                };
                AddMeasurementToDB(newMeasure);


                dataString = "move: " + dataString;
                byte[] toBeSend = Encoding.UTF8.GetBytes(dataString);
                //echo back data
                socket.Send(toBeSend, toBeSend.Length, from);
            }
        }
        public static void AddMeasurementToDB(Measurement measurement)
        {
            managerDB.Add(measurement);
        }
        
    }
}
