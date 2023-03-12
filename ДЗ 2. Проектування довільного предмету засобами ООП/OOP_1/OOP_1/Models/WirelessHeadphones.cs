using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1.Models
{
    public class WirelessHeadphones : HeadPhonesBase
    {
        public int Charge { get; set; }

        public WirelessHeadphones(string brand, string model,
            string type, string connectionType, string color, int charge) : base(
                brand, model, type, connectionType, color)
        {
            this.Charge = charge;
        }

        public override void Connect()
        {
            IsActive = true;
            Console.WriteLine("Connected to the phone");
        }

        public override void Disconnect()
        {
            if (IsActive)
            {
                IsActive = false;
                Console.WriteLine("Disconnected");
            }
            else
            {
                Console.WriteLine("Connect at first");
            }
        }

        public override void ListenToMusic()
        {
            if (!IsActive)
            {
                Console.WriteLine("Please connect to the phone at first");
            }
            else if (IsActive && Charge >= 20)
            {
                Console.WriteLine("Listening some track");
                Charge -= 20;
            }
            else
            {
                Console.WriteLine("The battery is low. Please charge");
            }
        }

        public void Charging()
        {
            if (Charge < 100)
            {
                Charge = 100;
                Console.WriteLine("Charged to 100%");
            }
            else
            {
                Console.WriteLine("Full battery");
            }
            
        }

        public override string ToString()
        {
            return $"{SerialNumber} {Brand} {Model} {Type} {ConnectionType} {Color} {Charge}%";
        }
    }
}
