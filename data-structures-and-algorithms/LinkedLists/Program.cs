using Lists;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(0);
            list.Append(1);
            list.Append(2);
            //list.Print();
            list.Reverse();
            list.Print();
        }
    }
}
