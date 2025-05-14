using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lists
{
    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
            this.Next = null;
        }

        public int Value { get; private set; }
        public Node Next { get; set; }
    }
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int length;
        public LinkedList(int value)
        {
            this.head = new Node(value);
            this.tail = this.head;
            this.length = 1;
        }
        public void Print()
        {
            var currentNode = this.head;

            int i = 0;
            while (currentNode != null)
            {
                Console.WriteLine($"Length: {this.length}, Head: {this.head.Value}, Tail: {this.tail.Value}, CurrentNode {i}: {currentNode.Value}");
                currentNode = currentNode.Next;
                i++;
            }

            Console.WriteLine();
        }
        public void Append(int value)
        {
            var newNode = new Node(value);
            this.tail.Next = newNode;
            this.tail = newNode;
            this.length++;
        }
        public void Prepend(int value)
        {
            var newNode = new Node(value);
            newNode.Next = this.head;
            this.head = newNode;
            this.length++;
        }
        public void Insert(int value, int index)
        {
            if (index <= 0)
            {
                this.Prepend(value);
                return;
            }

            if (index >= this.length - 1)
            {
                this.Append(value);
                return;
            }

            var currentNode = this.head;

            int i = 0;
            while (i < index - 1 && currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                i++;
            }

            var newNode = new Node(value);
            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;

            this.length++;
        }
        public void RemoveFirst()
        {
            this.head = this.head.Next;
            this.length--;
        }
        public void RemoveLast()
        {
            var currentNode = this.head;

            while (currentNode.Next.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = null;
            this.tail = currentNode;
            this.length--;
        }
        public void Remove(int index)
        {
            var currentNode = this.head;

            if (index <= 0)
            {
                this.RemoveFirst();
                return;
            }

            if (index >= this.length - 1)
            {
                this.RemoveLast();
                return;
            }

            int i = 0;
            while (i < index - 1 && currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                i++;
            }

            var nodeToRemove = currentNode.Next;
            currentNode.Next = null;
            currentNode.Next = nodeToRemove.Next;

            this.length--;
        }

        public void Reverse()
        {
            if (this.head == null)
                return;       

            Node curr = this.head;
            Node prev = null;
            this.tail = this.head;

            while (curr != null)
            {
                //salva endereço do próximo
                var temp = curr.Next;

                //o atual aponta para o endereço do anterior
                curr.Next = prev;
                prev = curr;
                curr = temp;
            }

            this.head = prev;
        }
    }
}
