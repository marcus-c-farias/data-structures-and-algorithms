namespace Stacks_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stacks stacks = new Stacks();
            stacks.Push(1);
            stacks.Push(2);
            stacks.Push(3);
            stacks.Pop();
            stacks.Peek();
        }
    }
}
