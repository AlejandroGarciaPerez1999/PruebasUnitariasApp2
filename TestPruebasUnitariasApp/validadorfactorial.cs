using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPruebasUnitariasApp
{
    internal class validadorfactorial
    {
        public static long CalcularFactorial(int n)
        {
            if (n < 0) return -1; if (n == 0) return 1;

            long res = 1;
            for (int i = 1; i <= n; i++) res *= i;
            return res;
        }
    }
}