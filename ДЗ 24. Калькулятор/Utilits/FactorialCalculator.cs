using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_24._Калькулятор.Utilits
{
    public static class FactorialCalculator
    {
        public static int CalculateFactorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Number must be non-negative.");

            if (number == 0 || number == 1)
                return 1;

            int factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
