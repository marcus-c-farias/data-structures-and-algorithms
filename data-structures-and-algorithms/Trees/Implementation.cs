using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode(int value)
        {
            this.Value = value;
        }

        public int Value { get; private set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
    }
    public class BinaryTree
    {
        public BinaryTreeNode? Root { get; set; }
        public BinaryTree()
        {

        }

        public BinaryTreeNode Insert(BinaryTreeNode node, int value)
        {
            if (node == null)
            {
                node = new BinaryTreeNode(value);
            }
            else if (node.Value > value)
            {
                node.Left = this.Insert(node.Left, value);
            }
            else
            {
                node.Right = this.Insert(node.Right, value);
            }

            return node;
        }


        public bool LookUp(BinaryTreeNode node, int value)
        {
            bool success = false;

            if (node != null)
            {
                if (node.Value == value)
                {
                    return true;
                }
                else if (node.Value > value)
                {
                    success = this.LookUp(node.Left, value);
                }
                else
                {
                    success = this.LookUp(node.Right, value);
                }
            }

            return success;
        }
        public void Invert(BinaryTreeNode node)
        {
            if (node != null)
            {
                var temp = node.Right;
                node.Right = node.Left;
                node.Left = temp;

                this.Invert(node.Right);
                this.Invert(node.Left);

                //      9
                //    /   \
                //   4     20
                //  / \    / \
                // 1   6  15 170

                //      9
                //    /   \
                //   20    4
                //  / \    / \
                //170 15  6   1
            }
        }
        public void Transverse(BinaryTreeNode node)
        {
            var currentNode = node;

            if (currentNode != null)
            {
                this.Transverse(node.Right);
                this.Transverse(node.Left);
                Console.Write($"{node.Value}, ");
            }            
        }

        public BinaryTreeNode Remove(BinaryTreeNode node)
        {

            return new BinaryTreeNode(1);
        }
    }
}
