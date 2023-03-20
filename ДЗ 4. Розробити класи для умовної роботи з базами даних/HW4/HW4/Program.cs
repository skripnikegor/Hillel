using HW4.Models;
using HW4.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pw = PasswordGenerator.GeneratePassword(5);
            var pw1 = PasswordGenerator.GeneratePassword(10);
            var pw2 = PasswordGenerator.GeneratePassword(8);
            Console.WriteLine(pw);
            Console.WriteLine(pw1);
            Console.WriteLine(pw2);


            DatabaseEngine<string> de = new DatabaseEngine<string>(pw);
            de.WriteValue("Ufufuf", pw);
            Console.ReadLine();
        }
    }
}
