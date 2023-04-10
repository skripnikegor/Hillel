using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW10
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
                list.Add(rnd.Next(1,20));
            }

            //Create mre objects for different functions
            ManualResetEvent mreChecker = new ManualResetEvent(false);
            ManualResetEvent mreSummer = new ManualResetEvent(false);

            //Create Thread for checking and run it
            Console.WriteLine("Run checker");
            Thread check = new Thread(() => Checker(list, mreChecker));
            check.Start();
            mreChecker.WaitOne();

            //Create Thread for summaring and run it
            Console.WriteLine("Run summer");
            Thread summer = new Thread(() => result += Summer(list, mreSummer));
            summer.Start();
            mreSummer.WaitOne();

            Console.WriteLine($"Result is {result}");

            Console.ReadLine();
        }


        public static int Summer(List<int> list, ManualResetEvent mre)
        {
            int result = 0;
            int threadsQty = 4;
            int quantity = list.Count / threadsQty;

            for (int i = 0; i < threadsQty; i++)
            {
                Thread th = new Thread(() => result += SummerWorker(list.Skip(i * quantity).Take(quantity).ToList()));
                th.Name = i.ToString();
                th.Start();
                th.Join();
            }                

            Console.WriteLine("Summer finished work");
            mre.Set();

            return result;
        }

        public static int SummerWorker(List<int> list)
        {
            int result = 0;
            foreach(int i in list)
            {
                result += i;
            }
            Console.WriteLine($"Result from summerWorker {Thread.CurrentThread.Name}: {result}");
            return result;
        }

        public static void Checker(List<int> list, ManualResetEvent mre)
        {
            foreach (int i in list)
            {
                if (list[i] <= 0)
                {
                    Console.WriteLine("I have found a number less than zero!"); 
                }
                    
            }
            Console.WriteLine("Checker finished work");
            mre.Set();
        }

    }
}
