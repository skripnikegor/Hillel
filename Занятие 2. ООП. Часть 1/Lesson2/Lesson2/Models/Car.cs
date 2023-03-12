using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models
{
    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Moving by wheel");
        }
    }
}
