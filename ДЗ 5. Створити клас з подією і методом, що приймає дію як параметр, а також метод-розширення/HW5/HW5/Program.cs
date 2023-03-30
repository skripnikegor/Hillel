using HW5.Logics;
using HW5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrWorker = new ArrayHandler();
            arrWorker.WholeNumberFind += HadnleWholeNumberEvent;

            //Реалізація через делегати
            var deleg = arrWorker.SquareRoots(number => number > 5 && number % 1 == 0);

            foreach (var del in deleg)
            {
                Console.WriteLine(del);
            }
            Console.ReadKey();
        }

        public static void HadnleWholeNumberEvent(object sender, DoubleEvent e)
        {
            Console.WriteLine($"Finded sqrt {e.SquareRoot} for {e.Number}");
        }

        
    }

    
}
