using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_16.Основні_функції_Linq.Models
{
    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public DateTime DateOfFoundation { get; set; }
        public Country Country { get; set; }
        public bool IsCapital { get; set; }

        public City(string name, int population, DateTime dateOfFoundation, Country country, bool isCapital)
        {
            this.Name = name;
            this.Population = population;
            this.DateOfFoundation = dateOfFoundation;
            this.Country = country;
            this.IsCapital = isCapital;
        }
    }
}
