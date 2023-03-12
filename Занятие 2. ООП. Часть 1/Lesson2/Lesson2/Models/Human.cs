using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models
{
    public class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public Human()
        {
            Console.WriteLine("Human");
        }

        public Human(string name, string lastName, int age, string country)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Country = country;
        }
    }
}
