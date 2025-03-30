using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class DynammicArray
    {
        private int length;
        private int totalElements;
        private object[] data;
        public DynammicArray()
        {
            this.length = 1;
            this.totalElements = 0;
            this.data = new object[1];
        }
        public void Push(object item)
        {
            if (this.totalElements == this.length)
            {
                int newLength = this.length * 2;
                object[] newArr = new object[newLength];
                Array.Copy(this.data, newArr, totalElements); //use for loop to copy the data, O(n)
                this.data = newArr; // GC deallocate automatically
                this.length = newLength;
            }

            this.data[this.totalElements] = item;
            this.totalElements++;
        }
        public void Pop()
        {
            this.data[this.totalElements - 1] = null;
            totalElements--;
        }
        public object Get(int index)
        {
            return this.data[index];
        }
        public void Set(int index, object item)
        {
            this.data[index] = item;
        }
        public void Insert(int index, object item)
        {
            ShiftToRight(index);

            this.data[index] = item;
        }
        private void ShiftToRight(int index)
        {
            for (int i = totalElements - 1; i > index; i--)
            {
                this.data[i] = this.data[i - 1];
            }
        }
        public void Remove(int index)
        {
            ShiftToLeft(index);
            
            totalElements--;
        }
        private void ShiftToLeft(int index)
        {
            for (int i = index; i < totalElements - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            this.data[totalElements - 1] = null;
        }
        public bool Search(object item)
        {
            for (int i = 0; i < totalElements; i++)
            {
                if (this.data[i] == item)
                {
                    return true;
                }
            }

            return false;
        }
        public int GetLength()
        {
            return this.length;
        }
        public int GetTotalElements()
        {
            return this.totalElements;
        }
        public void Print()
        {
            Console.Write("{ ");
            for (int i = 0; i <= this.totalElements - 1; i++)
            {
                Console.Write($"{this.data[i]},");
            }
            Console.WriteLine(" }");
        }
    }
}
