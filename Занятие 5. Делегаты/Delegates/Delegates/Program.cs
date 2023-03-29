using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var res = CustomWhere(x => x > 2);
            foreach (var item in res)
            {
                Console.WriteLine($"{item}");
            }

            var p = new Person();

            Del1 del1;
            del1 = p.Hello;
            del1 += p.World;


            del1("AAAAAAAAAAAAA");

            Console.ReadKey();


        }

        public static IEnumerable<int> CustomWhere(Func<int, bool> lambda)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                if (lambda(i))
                {
                    yield return i;
                }
            }
        }

        public void H()
        {
            Console.WriteLine("HHHHH");
        }


        public class Person
        {
            public string Hello(string x)
        {
                Console.WriteLine($"Hello {x}");
            return $"Hello {x}";
        }
            public string World(string x)
            {
                Console.WriteLine($"World {x}");
                return $"World {x}";
            }
        }

        public delegate string Del1(string str);

    }
}
