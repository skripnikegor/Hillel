using HW19_c.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HW19_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Sender.Get();
            
            Sender.Post();

            Sender.Put();

            Sender.Delete();


            Console.ReadKey();
        }

    }
}
