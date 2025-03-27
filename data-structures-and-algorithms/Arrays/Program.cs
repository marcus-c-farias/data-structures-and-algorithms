using System.Reflection;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myArray = new DynammicArray();

            myArray.Push("A");
            myArray.Push("B");
            myArray.Push("C");
            myArray.Push("D");
            myArray.Push("E"); //double array size
            myArray.Search("E");
            myArray.Insert(3, "Z");
            myArray.Remove(0);

            myArray.Print();
        }
    }
}
