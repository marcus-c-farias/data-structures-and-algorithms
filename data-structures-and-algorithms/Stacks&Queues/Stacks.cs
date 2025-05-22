using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Queues
{
    internal class Node
    {
        public Node(int value)
        {
            this.Value = value;
            this.Next = null;
        }

        public int Value { get; private set; }
        public Node? Next { get; set; }
    }

    public class Stacks
    {
        private Node top;
        public void Push(int value)
        {
            var newNode = new Node(value);
            var prevNode = this.top;

            newNode.Next = prevNode;
            this.top = newNode;        
        }

        public void Pop()
        {
            var temp = this.top.Next;
            this.top = null;
            this.top = temp;
        }

        public void Peek()
        {
            Console.WriteLine($"Top element: {this.top.Value}");
        }
    }
}
