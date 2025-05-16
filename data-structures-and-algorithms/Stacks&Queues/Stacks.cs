using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Queues
{
    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
            this.Prev = null;
        }

        public int Value { get; private set; }
        public Node? Prev { get; set; }
    }

    public class Stacks
    {
        private Node top;
        public void Push(int value)
        {
            var newNode = new Node(value);
            var prevNode = this.top;

            newNode.Prev = prevNode;
            this.top = newNode;        
        }

        public void Pop()
        {
            var temp = this.top.Prev;
            this.top = null;
            this.top = temp;
        }

        public void Peek()
        {
            Console.WriteLine($"Top element: {this.top.Value}");
        }
    }
}
