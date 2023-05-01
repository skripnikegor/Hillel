using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW12.Models
{
    [Serializable]
    public abstract class HeadPhonesBase
    {
        [XmlElement]
        public Guid SerialNumber { get; set; }
        [XmlElement]
        public string Brand { get; set; }
        [XmlElement]
        public string Model { get; set; }
        [XmlElement]
        public string Type { get; set; }
        [XmlElement]
        public string ConnectionType { get; set; }
        [XmlElement]
        public string Color { get; set; }
        protected bool IsActive { get; set; } = false;

        public HeadPhonesBase()
        {
            this.SerialNumber = Guid.NewGuid();
        }

        public HeadPhonesBase(string brand, string model,
            string type, string connectionType, string color)
        {
            this.Brand = brand;
            this.Model = model;
            this.Type = type;
            this.ConnectionType = connectionType;
            this.Color = color;
            this.SerialNumber = Guid.NewGuid();
        }

        public virtual void ListenToMusic()
        {
            Console.WriteLine("Listening some track");
        }


        public abstract void Connect();
        public abstract void Disconnect();

    }
}
