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
        public static int[] MergeSortedArrays(int[] a1, int[] a2)
        {
            int n = a1.Length, m = a2.Length;
            int[] result = new int[n + m];
            int i = 0, j = 0, k = 0;

            while (i < n || j < m) //O(m + n)
            {
                if (i < n && (j >= m || a1[i] < a2[j]))
                {
                    result[k] = a1[i];
                    i++;
                }
                else
                {
                    result[k] = a2[j];
                    j++;
                }

                k++;
            }

            return result;
        }
    }
}
