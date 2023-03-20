using HW3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Models
{
    public class HardDisc : IAddable, IHardDisc
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }
        public string Type { get; }
        public int Storage { get; }

        public HardDisc(string name, string type, int storage)
        {
            this.Name = name;
            this.Type = type;
            this.Storage = storage;
        }

        public void Add()
        {
            Console.WriteLine("Hard disc added");
        }

        public void Remove()
        {
            Console.WriteLine("Hard disc removed");
        }
    }
}
