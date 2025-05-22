using System.Collections;

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
            stacks.Pop();
            stacks.Peek();



            Queues queues = new Queues();
            queues.Enqueue(1);
            queues.Enqueue(2);
            queues.Enqueue(3);
            queues.Dequeue();
            queues.Dequeue();
            queues.Peek();
        }
    }
}
