using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    public class NodeList
    {
        public NodeList(string key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }

        public string Key { get; private set; }
        public int Value { get; private set; }
        public NodeList Next { get; set; }
    }

    public class Hashtable
    {
        private NodeList[] Elements;
        private int Length;
        public Hashtable(int length)
        {
            Length = length;
            Elements = new NodeList[length];
        }
        private int Hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % this.Length;
            }
            return hash;
        }
        public void Add(string key, int value)
        {
            int index = Hash(key);

            if (Elements[index] == null)
            {
                Elements[index] = new NodeList(key, value);
            }
            else
            {
                NodeList current = Elements[index];
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new NodeList(key, value);
            }
        }
        public int Get(string key)
        {
            int index = Hash(key);

            if (Elements[index] != null)
            {
                NodeList current = Elements[index];

                while (current.Next != null && current.Key != key)
                {
                    current = current.Next;
                }

                if (current.Key == key)
                    return current.Value;
            }

            return 0;
        }

        public void Print()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"Index i:{i}");
                if (this.Elements[i] != null)
                {
                    NodeList current = Elements[i];
                    Console.Write($"Elements: \"{current.Key},{current.Value}\", ");
                    
                    while (current.Next != null)
                    {
                        current = current.Next;
                        Console.Write($"\"{current.Key},{current.Value}\", ");
                    }
                }
                else
                {
                    Console.WriteLine("Empty index");
                }
            }
        }
    }
}
