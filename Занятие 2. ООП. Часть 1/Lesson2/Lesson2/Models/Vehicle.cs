using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models
{
    public abstract class Vehicle
    {
        public int Cylinders { get; set; }
        public void Ignite()
        {
            Console.WriteLine("Ignited");
        }

        public abstract void Move();
    }
}
