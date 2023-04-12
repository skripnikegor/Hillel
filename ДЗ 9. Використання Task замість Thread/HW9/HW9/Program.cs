using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW9
{
    internal class Program
    {
        static ManualResetEvent mre = new ManualResetEvent(false);
        static void Main(string[] args)
        {

            Run();
            
        }

        public static async void Run()
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
            bool check = await Checker(list);
            //Create Task for summaring and run it
            Console.WriteLine("Run summer");
            result += await Summer(list);
            Console.WriteLine($"Result is {result}");

            Console.ReadLine();
        }

        public static async Task<int> Summer(List<int> list)
        {
            int result = 0;
            int threadsQty = 4;
            int quantity = list.Count / threadsQty;
            mre.WaitOne();

            for (int i = 0; i < threadsQty; i++)
            {
                result += await SummerWorker(list.Skip(i * quantity).Take(quantity).ToList());
            }

            Console.WriteLine("Summer finished work");
            return result;
        }

        public static async Task<int> SummerWorker(List<int> list)
        {
            int result = 0;
            foreach (int i in list)
            {
                result += i;
            }
            Console.WriteLine($"Result from summerWorker {Thread.CurrentThread.Name}: {result}");
            return result;
        }

        public static async Task<bool> Checker(List<int> list)
        {
            foreach (int i in list)
            {
                if (list[i] <= 0)
                {
                    Console.WriteLine("I have found a number less than zero!");
                    return false;
                }

            }
            Console.WriteLine("Checker finished work");
            mre.Set();
            return true;
        }
    }
}
