using HW3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Models
{
    public class RAM : IAddable, IRAM
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }
        public int Value { get; }
        public int Frequency { get; }
        public string Type { get; }

        public RAM(string name, int value, int frequency, string type)
        {
            this.Name = name;
            this.Value = value;
            this.Frequency = frequency;
            this.Type = type;
        }

        public void Add()
        {
            Console.WriteLine("RAM added");
        }

        public void Eject()
        {
            Console.WriteLine("RAM ejected");
        }
    }
}
