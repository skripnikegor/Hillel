using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models
{
    public class Student : Human
    {

        public int Group { get; set; }
        public string University { get; set; }

        public Student() 
        {
            Console.WriteLine("Student");
        }

        public Student(string name, string lastName, int age, string country, int group, string university) : base(name, lastName, age, country)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Country = country;
            this.Group = group;
            this.University = university;
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.LastName}";
        }
    }
}
