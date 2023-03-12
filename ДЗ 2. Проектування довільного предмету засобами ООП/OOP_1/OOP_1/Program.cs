using OOP_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var EarPods = new WiredHeadphones("Apple", "EarPods", "Earbud", "Wire", "White", 1.0);
            Console.WriteLine(EarPods.ToString());
            EarPods.ListenToMusic();
            EarPods.Connect();
            EarPods.ListenToMusic();
            EarPods.Disconnect();

            Console.WriteLine();

            var AirPods = new WirelessHeadphones("Apple", "AirPods", "Vacuum", "Wireless", "White", 100);
            Console.WriteLine(AirPods.ToString());
            AirPods.ListenToMusic();
            AirPods.Connect();
            AirPods.ListenToMusic();
            AirPods.Disconnect();
            Console.WriteLine(AirPods.ToString());
            AirPods.Charging();
            AirPods.Connect();
            for (int i = 0; i <= 5; i++)
            {
                AirPods.ListenToMusic();
            }
            
            AirPods.Charging();
            AirPods.Charging();
            AirPods.ListenToMusic();
            AirPods.Disconnect();



            Console.ReadKey();
        }
    }
}
