using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1.Models
{
    public abstract class HeadPhonesBase
    {
        public Guid SerialNumber => Guid.NewGuid();
        public string Brand { get; }
        public string Model { get; }
        public string Type { get; }
        public string ConnectionType { get; }
        public string Color { get; }
        protected bool IsActive { get; set; } = false;

        public HeadPhonesBase()
        {
            Console.WriteLine("Some headphones base");
        }

        public HeadPhonesBase(string brand, string model,
            string type, string connectionType, string color)
        {
            this.Brand = brand;
            this.Model = model;
            this.Type = type;
            this.ConnectionType = connectionType;
            this.Color = color;
        }

        public virtual void ListenToMusic()
        {
            Console.WriteLine("Listening some track");
        }


        public abstract void Connect();
        public abstract void Disconnect();

    }
}
