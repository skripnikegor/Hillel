using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Less6_7
{
    internal class Program
    {
        private static int count = 0;
        static void Main(string[] args)
        {
            var lockObject = new Object();
            //Thread t1 = new Thread(() =>
            //{
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        lock (lockObject)
            //        {
            //            count++;
            //        }

            //    }
            //});


            //Thread t2 = new Thread(() =>
            //{
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        lock (lockObject)
            //        {
            //            count++;
            //        }
            //    }
            //});

            //t1.Start();
            //t2.Start();

            //t1.Join();
            //t2.Join();




            Thread[] threads = new Thread[10];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() =>
                {
                    lock (lockObject)
                    {
                        count += 10;
                    }
                });
            }

            foreach (var t in threads)
                {
                    t.Start();
                }

            foreach (var t in threads)
            {
                t.Join();
            }


            Console.WriteLine($"{count}");



            Console.ReadLine();
            
        }
    }
}
