using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW7
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<int> numbers = Enumerable.Range(1, 100000).ToList();
            List<int> results = new List<int>();


            Func<int, int, List<int>> FindSquares = (from, to) =>
            {
                List<int> ints = new List<int>();
                for (int i = from; i < to; i++)
                {
                    if (Math.Sqrt(numbers[i]) % 1 == 0)
                    {
                        ints.Add(numbers[i]);
                    }
                }
                return ints;
            };


            int threadsQuantity = 4;
            Thread[] threads = new Thread[threadsQuantity];
            int Volume = numbers.Count/threadsQuantity;


            for (int i = 0; i < threadsQuantity; i++)
            {
                int start = i * Volume;
                int finish = start + Volume;

                threads[i] = new Thread(() =>
                {
                    List<int> threadResult = FindSquares(start, finish);
                    lock (results)
                    {
                        results.AddRange(threadResult);
                    }
                });
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            foreach(var result in results)
            {
                Console.WriteLine(result);
            }


            Console.ReadLine();
        }
    }
}
