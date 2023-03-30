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
            var listFor10 = Enumerable.Range(1, 10).Select(_ => Lottery.Emit(100)).ToList();
            var listFor50 = Enumerable.Range(1, 50).Select(_ => Lottery.Emit(100)).ToList();
            var listFor100 = Enumerable.Range(1, 100).Select(_ => Lottery.Emit(100)).ToList();

            var neverApp10 = StatOperations.NeverAppeared(listFor10);
            var neverApp50 = StatOperations.NeverAppeared(listFor50);
            var neverApp100 = StatOperations.NeverAppeared(listFor100);

            foreach (var item in neverApp100)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var mostApp10 = StatOperations.MostAppeared(listFor10, 4);
            var mostApp50 = StatOperations.MostAppeared(listFor50, 5);
            var mostApp100 = StatOperations.MostAppeared(listFor100, 10);
            
            foreach (var item in mostApp100)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
