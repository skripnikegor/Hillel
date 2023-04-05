using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object locker = new object();
            Random random = new Random();
            int even = 0;
            int odd = 0;

            List<Thread> threads = new List<Thread>();

            for (int i = 0; i < 10; i++)
            {
                threads.Add(new Thread(Counter));
                threads[i].Name = $"Thread {i}";
            }

            foreach (Thread thread in threads)
            {
                thread.Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine($"Even numbers: {even}, odd numbers: {odd}");

            Console.ReadKey();

            void Counter()
            {
                for (int i = 0; i < 100; i++)
                {
                    int rand = random.Next(0, 100);
                    //для наглядности
                    Console.WriteLine($"{Thread.CurrentThread.Name}, number {rand} ");
                    lock (locker)
                    {
                        if (rand % 2 == 0)
                        {
                            even += 1;
                        }
                        else
                        {
                            odd += 1;
                        }
                    }
                }
            }
        }
    }
}
