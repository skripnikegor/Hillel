using HW11.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Models
{
    public class NamesGenerator : INamesGenerator
    {
        private List<string> names = new List<string>() {
            "John",
            "Alice",
            "Michael",
            "Sophia",
            "David",
            "Olivia",
            "James",
            "Emma",
            "Daniel",
            "Ava",
            "Benjamin",
            "Isabella",
            "William",
            "Mia",
            "Henry",
            "Charlotte",
            "Alexander",
            "Amelia",
            "Joseph",
            "Harper",
            "Andrew",
            "Evelyn",
            "Jack",
            "Abigail",
            "Samuel",
            "Emily",
            "Matthew",
            "Elizabeth",
            "David",
            "Sofia"
            };
        private Random random = new Random();
        public string ReturnRandomName()
        {
            return names[random.Next(0, names.Count)];
        }
    }
}
