using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ДЗ_16.Основні_функції_Linq.Models;

namespace ДЗ_16.Основні_функції_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mainland Eurasia = new Mainland("Eurasia");
            Mainland Africa = new Mainland("Africa");
            Mainland NorthAmerica = new Mainland("North America");

            List<Mainland> Mainlands = new List<Mainland>();
            Mainlands.Add(Eurasia);
            Mainlands.Add(Africa);
            Mainlands.Add(NorthAmerica);

            Country Ukraine = new Country("Ukraine", Eurasia);
            Country France = new Country("France", Eurasia);
            Country Italy = new Country("Italy", Eurasia);
            Country Spain = new Country("Spain", Eurasia);

            Country USA = new Country("USA", NorthAmerica);
            Country Canada = new Country("Canada", NorthAmerica);
            Country Mexico = new Country("Mexico", NorthAmerica);

            Country Nigeria = new Country("Nigeria", Africa);
            Country Ethiopia = new Country("Ethiopia", Africa);
            Country Egypt = new Country("Egypt", Africa);

            List<Country> Countries = new List<Country>();

            Countries.Add(Ukraine);
            Countries.Add(France);
            Countries.Add(Italy);
            Countries.Add(Spain);
            Countries.Add(USA);
            Countries.Add(Canada);
            Countries.Add(Mexico);
            Countries.Add(Nigeria);
            Countries.Add(Ethiopia);
            Countries.Add(Egypt);

            City Kiev = new City("Kiev", 2884000, new DateTime(482, 05, 31), Ukraine, true);
            City Lviv = new City("Lviv", 721000, new DateTime(1256, 01, 01), Ukraine, false);
            City Odesa = new City("Odesa", 1100000, new DateTime(1794, 09, 02), Ukraine, false);

            City Paris = new City("Paris", 2140526, new DateTime(100, 02, 01), France, true);
            City Marseille = new City("Marseille", 861635, new DateTime(100, 09, 02), France, false);

            City Rome = new City("Rome", 2873494, new DateTime(100, 02, 01), Italy, true);
            City Milan = new City("Rome", 1366037, new DateTime(100, 02, 01), Italy, false);

            City Madrid = new City("Rome", 3334730, new DateTime(923, 02, 01), Spain, true);
            City Barcelona = new City("Rome", 1629343, new DateTime(100, 02, 01), Spain, false);

            City Washington = new City("Washington", 705749, new DateTime(1790, 07, 16), USA, true);
            City NewYork = new City("New York", 8336817, new DateTime(1624, 02, 01), USA, false);

            City Ottawa = new City("Ottawa", 934243, new DateTime(1826, 01, 01), Canada, true);
            City Toronto = new City("Toronto", 2731571, new DateTime(1750, 02, 01), Canada, false);

            City MexicoCity = new City("Mexico", 934243, new DateTime(1325, 08, 13), Mexico, true);
            City Guadalajara = new City("Guadalajara", 2731571, new DateTime(1542, 02, 14), Mexico, false);

            City Lagos = new City("Mexico", 14368332, new DateTime(1670, 06, 01), Nigeria, false);
            City Abuja = new City("Abuja", 1590400, new DateTime(1991, 12, 12), Nigeria, true);

            City AddisAbaba = new City("Addis Ababa", 3384569, new DateTime(1886, 08, 13), Ethiopia, true);
            City DireDawa = new City("Dire Dawa", 162602, new DateTime(1902, 02, 14), Ethiopia, false);

            City Cairo = new City("Cairo", 9500000, new DateTime(8, 08, 13), Egypt, true);
            City Alexandria = new City("Alexandria", 5200000, new DateTime(5, 02, 14), Egypt, false);

            List<City> Cities = new List<City>();
            Cities.Add(Kiev);
            Cities.Add(Lviv);
            Cities.Add(Odesa);
            Cities.Add(Paris);
            Cities.Add(Marseille);
            Cities.Add(Rome);
            Cities.Add(Milan);
            Cities.Add(Madrid);
            Cities.Add(Barcelona);
            Cities.Add(Alexandria);
            Cities.Add(Cairo);
            Cities.Add(Washington);
            Cities.Add(NewYork);
            Cities.Add(Ottawa);
            Cities.Add(Toronto);
            Cities.Add(MexicoCity);
            Cities.Add(Guadalajara);
            Cities.Add(Lagos);
            Cities.Add(Abuja);
            Cities.Add(AddisAbaba);
            Cities.Add(DireDawa);

            Console.WriteLine("виводять кількість країн по континентах");
            foreach (Mainland mainland in Mainlands)
            {
                Console.WriteLine($"{mainland.Name} : {Countries.Where(c => c.Mainland == mainland).Count()}");
            }
            Console.WriteLine("виводять топ - 3 міст за населенням без урахування тих, що були засновані після 1200 року");
            var date = new DateTime(1200, 01, 01);
            List<City> topPopulation = Cities.Where(p => p.DateOfFoundation < date).OrderByDescending(x => x.Population).Take(3).ToList();

            foreach (City city in topPopulation)
            {
                Console.WriteLine($"{city.Name} : {city.Population}");
            }

            Console.WriteLine("виводить країну з найбільшим населенням і її столицю");

            var countryRange = Countries.Join(Cities,
                country => country.Name,
                city => city.Country.Name,
                (country, city) => new 
                { 
                    countryName = country.Name, 
                    countryPopulation = Cities.Where(c => c.Country.Name == country.Name).Sum(x => x.Population), 
                    capital = Cities.Where(c => c.Country.Name == country.Name && c.IsCapital).FirstOrDefault().Name
                }).OrderByDescending(p => p.countryPopulation).FirstOrDefault();

            Console.WriteLine($"{countryRange.countryName} : {countryRange.countryPopulation}, {countryRange.capital}");

            Console.WriteLine("виводить континенти з найбильшою кількістю міст, в яких населення перевищує 1.000.000");

            var largestsMainlands = Mainlands.Join(Countries,
                mainland => mainland.Name,
                country => country.Mainland.Name,
                (mainland, country) => new
                {
                    mainlandName = mainland.Name,
                    countryName = country.Name
                }).Distinct().Join(Cities,
                    country => country.countryName,
                    city => city.Country.Name,
                    (joined, city) => new
                    {
                        mainlandName = joined.mainlandName,
                        citiesOverMillon = Cities.Where(c => c.Country.Mainland.Name == joined.mainlandName && c.Population >= 1000000).Count(),
                    }
                    ).Distinct().ToList();

            foreach ( var main in largestsMainlands)
            {
                Console.WriteLine($"{main.mainlandName} : {main.citiesOverMillon}");
            }

            Console.ReadLine();
        }
    }
}
