using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models
{
    public abstract class PackegeBase
    {
        protected double _volume = 0.95;
        public abstract void Unpack();
        public abstract void Pack();
        public abstract void Fill(double filledVolume);
        public virtual void Spoil()
        {
            Console.WriteLine("Rotting");
        }
    }
}
