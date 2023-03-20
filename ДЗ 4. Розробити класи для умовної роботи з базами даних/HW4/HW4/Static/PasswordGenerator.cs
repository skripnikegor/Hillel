using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Static
{
    public static class PasswordGenerator
    {
        private static char[] allowedSymbols = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static Random rndm = new Random();
        private static string result;
        private static int rnd;


        public static string GeneratePassword(int passwordLength)
        {
            result = "";
            for (int i = 0; i < passwordLength; i++)
            {
                rnd = rndm.Next(0, allowedSymbols.Length);
                result += $"{allowedSymbols[rnd]}";
            }
            return result;
        }

    }
}
