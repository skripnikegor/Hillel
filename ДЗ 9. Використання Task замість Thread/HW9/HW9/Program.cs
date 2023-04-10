using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            int result = 0;

            //Add elements to list - ints from 1 to 20 (for checking)
            for (int i = 0; i < 100000; i++)
            {
                list.Add(rnd.Next(1, 20));
            }

            //Create Task for checking and run it
            Console.WriteLine("Run checker");
            Task check = new Task(() => Checker(list));
            check.Start();
            check.Wait();

            //Create Task for summaring and run it
            Console.WriteLine("Run summer");
            Task summer = new Task(() => result += Summer(list));
            summer.Start();
            summer.Wait();

            Console.WriteLine($"Result is {result}");

            Console.ReadLine();
        }

        public static int Summer(List<int> list)
        {
            int result = 0;
            int threadsQty = 4;
            int quantity = list.Count / threadsQty;

            for (int i = 0; i < threadsQty; i++)
            {
                Task th = new Task(() => result += SummerWorker(list.Skip(i * quantity).Take(quantity).ToList()));
                th.Start();
                th.Wait();
            }

            Console.WriteLine("Summer finished work");

            return result;
        }

        public static int SummerWorker(List<int> list)
        {
            int result = 0;
            foreach (int i in list)
            {
                result += i;
            }
            Console.WriteLine($"Result from summerWorker {Thread.CurrentThread.Name}: {result}");
            return result;
        }

        public static void Checker(List<int> list)
        {
            foreach (int i in list)
            {
                if (list[i] <= 0)
                {
                    Console.WriteLine("I have found a number less than zero!");
                }

            }
            Console.WriteLine("Checker finished work");
        }
    }
}
