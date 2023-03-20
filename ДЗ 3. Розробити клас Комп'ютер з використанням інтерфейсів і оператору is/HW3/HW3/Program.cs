using HW3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var computer1 = new Computer("Asus", "White", 4, 2);
            RAM ASUS4GB = new RAM("4 GB ASUS RAM", 4, 3200, "DDR4 SDRAM");
            RAM ASUS8GB = new RAM("8 GB ASUS RAM", 8, 3200, "DDR4 SDRAM");

            HardDisc Transcend1TB = new HardDisc("1 TB Transcend", "HDD", 1000);
            HardDisc Transcend2TB = new HardDisc("2 TB Transcend", "HDD", 2000);

            Processor AMDRyzen5 = new Processor("AMD Ryzen 5", "AMD Ryzen 5", 6, 12);
            Processor Interl12400 = new Processor("Interl 12400", "Intel", 12, 24);



            computer1.AddSomething(ASUS4GB);
            computer1.AddSomething(ASUS8GB);
            computer1.AddSomething(ASUS4GB);
            computer1.AddSomething(ASUS8GB);

            computer1.Eject(ASUS4GB);
            computer1.AddSomething(ASUS8GB);
            Console.WriteLine();
            computer1.AddSomething(Interl12400);
            computer1.Unplug(Interl12400);
            computer1.AddSomething(AMDRyzen5);
            Console.WriteLine();
            computer1.AddSomething(Transcend2TB);
            computer1.AddSomething(Transcend1TB);
            computer1.AddSomething(Transcend1TB);
            computer1.Remove(Transcend1TB);
            computer1.AddSomething(Transcend2TB);

            Console.WriteLine(computer1.ToString());

            computer1.Dispose();

            Console.WriteLine(computer1.ToString());

            Console.ReadLine();
        }
    }
}
