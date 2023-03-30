using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW6.Models
{
    public static class Lottery
    {
        public static List<int> Emit(int number)
        {
            List<int> result = new List<int>();
            var rand = new Random();

            for (int i = 0; i < number; i++)
            {
                result.Add(rand.Next(1,number));
            }

            return result;
        }
    }
}
