using HW5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW5.Program;

namespace HW5.Logics
{
    public class ArrayHandler
    {
        public delegate bool CheckNumbers(double number);
        public event EventHandler<DoubleEvent> WholeNumberFind;
        private List<double> doubles { get; set; }

        public ArrayHandler()
        {
            this.doubles = new List<double>() { 3, 4, 5, 6, 7, 8, 9, 25, 100, 125, 225, 500, 400, 325 };
        }

        public ArrayHandler(List<double> doubles)
        {
            this.doubles = doubles;
        }

        //Delegate
        public IEnumerable<double> SquareRoots(CheckNumbers checkNumber)
        {
            foreach(var number in doubles)
            {
                var squareRoot = SquareCalculator.SquareRoot(number);
                if (checkNumber(squareRoot))
                {
                    WholeNumberFind?.Invoke(this, new DoubleEvent(number, squareRoot));
                    yield return squareRoot;
                }
            }
        } 
    }
}
