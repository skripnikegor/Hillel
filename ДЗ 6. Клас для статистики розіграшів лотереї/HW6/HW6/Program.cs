using HW6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listFor10 = Lottery.Emit(10);
            var listFor50 = Lottery.Emit(50);
            var listFor100 = Lottery.Emit(100);

            var neverApp10 = StatOperations.NeverAppeared(listFor10);
            var neverApp50 = StatOperations.NeverAppeared(listFor50);
            var neverApp100 = StatOperations.NeverAppeared(listFor100);




            Console.ReadKey();

        }
    }
}
