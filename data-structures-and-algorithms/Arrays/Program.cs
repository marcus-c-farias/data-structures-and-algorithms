using System.Reflection;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 0, 1, 2, 3, 8 };
            int[] a2 = { 2, 3, 7, 9 };

            // 0,1,2,2,3,3,7,8
            var result = Exercises.MergeSortedArrays(a1, a2);
        }
    }
}
