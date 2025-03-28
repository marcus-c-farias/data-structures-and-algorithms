using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal static class Exercises
    {
        public static char[] ReverseString(string s)
        {
            char[] result = new char[s.Length];
            int i = 0;
            int j = s.Length - 1;
            
            while (i <= j)
            {
                result[i] = s[j];
                result[j] = s[i];
                i++;
                j--;
            }

            return result;
        }
    }
}
