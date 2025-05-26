using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Exercices
    {
        public int Factorial(int value)
        {
            if (value == 1)
                return 1;

            return value * this.Factorial(value - 1);
        }

        public int Fibonacci(int value)
        {
            if (value <= 0)
                return 0;

            if (value == 1)
                return 1;

            return Fibonacci(value - 1) + Fibonacci(value - 2);
        }

        public string Reverse(string s)
        {
            if (s.Length > 0)
            {
                string substring = s.Substring(1);
                return this.Reverse(substring) + s[0];
            }

            return s;
        }
    }
}
