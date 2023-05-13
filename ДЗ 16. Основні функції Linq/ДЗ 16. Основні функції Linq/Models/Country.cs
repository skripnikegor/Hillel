using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_16.Основні_функції_Linq.Models
{
    public class Country
    {
        public string Name { get; set; }
        public Mainland Mainland { get; set; }

        public Country(string name, Mainland mainland)
        {
            this.Name = name;
            this.Mainland = mainland;
        }
    }
}
