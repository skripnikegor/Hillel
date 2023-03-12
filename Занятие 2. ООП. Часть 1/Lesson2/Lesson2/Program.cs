using Lesson2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student Tom = new Student();

            //Student Tim = new Student("Tim", "Cook", 25, "USA", 1, "Cook");

            //Console.WriteLine(Tim.ToString());

            JuicePackage juicePackage = new JuicePackage("Sandora");
            juicePackage.Unpack();
            juicePackage.Fill(0.2);
            juicePackage.Fill(0.2);
            juicePackage.Fill(0.2);
            juicePackage.Fill(0.2);
            juicePackage.Fill(0.2);

            Console.ReadKey();
        }
    }
}
