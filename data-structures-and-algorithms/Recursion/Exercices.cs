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

            Console.Write($"{value},");

            return Fibonacci(value - 1) + Fibonacci(value - 2);
        }
        private Dictionary<int, int> cache = new Dictionary<int, int>();
        public int FibonacciDynamic(int value)
        {
            if (cache.ContainsKey(value))
            {
                return cache[value];
            }

            Console.Write($"{value},");

            if (value < 2)
            {
                return value;
            }

            cache.Add(value, FibonacciDynamic(value - 2) + FibonacciDynamic(value - 1));
            return cache[value];
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
