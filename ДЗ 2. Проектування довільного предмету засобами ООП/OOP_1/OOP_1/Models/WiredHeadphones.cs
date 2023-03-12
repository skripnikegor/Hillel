using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1.Models
{
    public class WiredHeadphones : HeadPhonesBase
    {
        public double WireLength { get; }

        public WiredHeadphones(string brand, string model,
            string type, string connectionType, string color, double wireLength) : base(
                brand, model, type, connectionType, color)
        {
            this.WireLength = wireLength;
        }

        public override void Connect()
        {
            IsActive = true;
            Console.WriteLine("Wire inserted into the phone");
        }

        public override void Disconnect()
        {
            if (IsActive)
            {
                IsActive = false;
                Console.WriteLine("Wire pulled out of the phone");
            }
            else
            {
                Console.WriteLine("Insert wire at first");
            }
        }

        public override void ListenToMusic()
        {
            if (!IsActive)
            {
                Console.WriteLine("Please insert wire into the phone at first");
            }
            else
            {
                Console.WriteLine("Listening some track");
            }
        }

        public override string ToString()
        {
            return $"{SerialNumber} {Brand} {Model} {Type} {ConnectionType} {Color} {WireLength}m";
        }
    }
}
