using System.Reflection;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new DynammicArray();

            array.Push(1);
            array.Push(2);
            array.Push(3);
            array.Push(4);
            array.Push(5);
            //array.Push(6);
            //array.Push(7);
            //array.Push(8);
            array.Pop();

            array.Set(1, 10);
            var x = array.Get(1);

            array.Insert(2, 15);
            array.Remove(3);

            array.Print();
        }
    }
}
