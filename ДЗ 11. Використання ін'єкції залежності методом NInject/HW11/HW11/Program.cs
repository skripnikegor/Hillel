using HW11.Interfaces;
using HW11.Modules;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var module = new RandomMessageBuilderModule();
            var kernel = new StandardKernel(module);
            var randomMessageBuilder = kernel.Get<IRandomMessageBuilder>();

            Console.WriteLine(randomMessageBuilder.Result());
            randomMessageBuilder.AddName();
            Console.WriteLine(randomMessageBuilder.Result());
            randomMessageBuilder.AddGreeting();
            Console.WriteLine(randomMessageBuilder.Result());
            randomMessageBuilder.AddDateTime();
            Console.WriteLine(randomMessageBuilder.Result());

            Console.ReadKey();
        }
    }
}
