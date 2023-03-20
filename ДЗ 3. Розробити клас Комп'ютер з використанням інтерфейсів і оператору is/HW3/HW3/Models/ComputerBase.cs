using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Models
{
    public class ComputerBase
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Brand { get; }
        public string Color { get; }
        public int RamQuantity { get; }
        public int HardDiscQuantity { get; }
        public int ProcessorQuantity { get; } = 1;

        public ComputerBase(string brand, string color, int ramQuantity, int hardDiscQuantity)
        {
            this.Brand = brand;
            this.Color = color;
            this.RamQuantity = ramQuantity;
            this.HardDiscQuantity = hardDiscQuantity;
        }

    }
}
