using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.Models
{
    public class DoubleEvent : EventArgs
    {
        public double Number { get; set; }
        public double SquareRoot { get; set; }

        public DoubleEvent(double number, double squareRoot)
        {
            this.Number = number;
            this.SquareRoot = squareRoot;
        }
    }
}
