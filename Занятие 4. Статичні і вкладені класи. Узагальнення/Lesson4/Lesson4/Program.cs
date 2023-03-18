using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str1 = "1111";
            var str2 = "2222";

            var strBuilder = new StringBuilder();
            strBuilder.Append(str1);
            strBuilder.Append(str2);

            var res = strBuilder.ToString();
            Console.WriteLine(res);

            str1 = "3333";

            Console.WriteLine(res);
            Console.WriteLine(strBuilder);

            Console.ReadKey();
        }
    }
}
