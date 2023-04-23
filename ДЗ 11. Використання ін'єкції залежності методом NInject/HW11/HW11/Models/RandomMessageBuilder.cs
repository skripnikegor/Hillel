using HW11.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Models
{
    internal class RandomMessageBuilder : IRandomMessageBuilder
    {
        private readonly IDateTimeGenerator _dateTimeGenerator;
        private readonly INamesGenerator _nameGenerator;
        private readonly IGreetingsGenerator _greetingsGenerator;
        private bool _isNowDateTime;
        private string _date;
        private string _name;
        private string _greeting;

        public RandomMessageBuilder(IDateTimeGenerator dateTimeGenerator, IGreetingsGenerator greetingsGenerator, INamesGenerator namesGenerator)
        {
            Random _random = new Random();
            this._isNowDateTime = Convert.ToBoolean(_random.Next(0, 2));
            this._dateTimeGenerator = dateTimeGenerator;
            this._nameGenerator = namesGenerator;
            this._greetingsGenerator = greetingsGenerator;
        }
        public void AddDateTime()
        {
            if (_isNowDateTime)
            {
                _date += $"{_dateTimeGenerator.GetRandomDateTime()}";
            }
            else
            {
                _date += $"{_dateTimeGenerator.GetCurrentDateTime()}";
            }
        }

        public void AddGreeting()
        {
            _greeting = $"{_greetingsGenerator.ReturnRandomGreeting()}";
        }

        public void AddName()
        {
            _name = $"{_nameGenerator.ReturnRandomName()}";
        }

        public string Result()
        {
            return $"{_name} {_greeting} {_date}";
        }
    }
}
