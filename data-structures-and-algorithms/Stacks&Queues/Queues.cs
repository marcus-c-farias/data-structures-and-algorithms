using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Queues
{
    public class Queues
    {
        private Node first;
        private Node last;
        public void Peek()
        {
            Console.WriteLine($"Top element: {this.first?.Value}");
        }
        public void Enqueue(int value)
        {
            Node newNode = new Node(value);

            if (this.first == null)
            {
                this.first = newNode;
                this.last = newNode;
            }
            else
            {
                this.last.Next = newNode;
                this.last = this.last.Next;
            }
        }

        public void Dequeue()
        {
            var temp = this.first;
            this.first = null;
            this.first = temp.Next;

            if (this.first == this.last)
                this.last = null;
        }
    }
}
