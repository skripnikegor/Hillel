using HW11.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Models
{
    public class DateTimeGenerator : IDateTimeGenerator
    {
        private Random _random = new Random();

        public string GetCurrentDateTime()
        {
            DateTime today = DateTime.Today;
            return today.ToString("dd/MM/yyyy");
        }

        public string GetRandomDateTime()
        {
            DateTime start = new DateTime(1990, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_random.Next(range)).ToString("dd/MM/yyyy");
        }
    }
}
