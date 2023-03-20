using HW3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Models
{
    public class Processor : IAddable, IProcessor
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Family { get; }
        public string Name { get; }
        public int CoresQuantity { get; }
        public int ThreadsQuantity { get; }

        public Processor(string family, string name, int coresQuantity, int threadsQuantity)
        {
            this.Family = family;
            this.Name = name;
            this.CoresQuantity = coresQuantity;
            this.ThreadsQuantity = threadsQuantity;
        }

        public void Add()
        {
            Console.WriteLine("Processor added");
        }

        public void Unplug()
        {
            Console.WriteLine("Processor unpluged");
        }
    }
}
