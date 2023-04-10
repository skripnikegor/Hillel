using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson10
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            MakePreparations();
        }
        static async Task<int> GetSomeValue()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(200);
                return 97;
            });
        }

        static async void MakePreparations()
        {
            var result = await GetSomeValue();

            Console.WriteLine("Some Preparations");
            Thread.Sleep(500);
            Console.WriteLine("Finished Preparations");

            Console.Write(result + 1);

        }

    }
}
