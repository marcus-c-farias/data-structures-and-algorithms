using System;
using System.Collections;
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
            this.Left = null;
            this.Right = null;
        }
        public int Value { get; set; }
        public BinaryTreeNode? Left { get; set; }
        public BinaryTreeNode? Right { get; set; }
    }
    public class BinaryTree
    {
        public BinaryTreeNode? Root { get; set; }
        public BinaryTree()
        {

        }

        //return the founded node
        public BinaryTreeNode? LookUp(BinaryTreeNode? node, int value)
        {
            if (node == null || node.Value == value)
                return node;

            if (node.Value > value)
                return this.LookUp(node.Left, value);

            return this.LookUp(node.Right, value);
        }
        //return the root
        public BinaryTreeNode? Insert(BinaryTreeNode? node, int value)
        {
            if (node == null)
                return new BinaryTreeNode(value);

            if (node.Value > value)
                node.Left = this.Insert(node.Left, value);
            else
                node.Right = this.Insert(node.Right, value);

            return node;
        }

        //return the root
        public BinaryTreeNode? Remove(BinaryTreeNode node, int value)
        {
            if (node == null)
                return node;

            if (node.Value > value)
                node.Left = this.Remove(node.Left, value);
            else if (node.Value < value)
                node.Right = this.Remove(node.Right, value);
            else
            {
                //case 1 and 2: delete leaf or node with single child
                if (node.Left == null)
                    return node.Right;

                if (node.Right == null)
                    return node.Left;

                //case 3: find the successor and change
                BinaryTreeNode succ = this.GetSuccessor(node);
                node.Value = succ.Value;
                node.Right = this.Remove(node.Right, succ.Value);
            }

            return node;
        }
        private BinaryTreeNode GetSuccessor(BinaryTreeNode curr)
        {
            curr = curr.Right;
            while (curr != null && curr.Left != null)
            {
                curr = curr.Left;
            }
            return curr;
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

                //            9
                //         /     \
                //        4       20
                //      /   \     / \
                //     1     6   15 99
                //    / \   / \
                //   0   3 5   7

                //      9
                //    /   \
                //   20    4
                //  / \    / \
                // 99 15  6   1
            }
        }
        public void DepthFirsthSearch_InOrder(BinaryTreeNode node)
        {
            var currentNode = node;

            if (currentNode != null)
            {
                this.DepthFirsthSearch_InOrder(node.Left);
                Console.Write($"{node.Value},");
                this.DepthFirsthSearch_InOrder(node.Right);
            }
        }
        public void DepthFirsthSearch_PreOrder(BinaryTreeNode node)
        {
            var currentNode = node;

            if (currentNode != null)
            {
                Console.Write($"{node.Value},");
                this.DepthFirsthSearch_PreOrder(node.Left);
                this.DepthFirsthSearch_PreOrder(node.Right);
            }
        }
        public void DepthFirsthSearch_PostOrder(BinaryTreeNode node)
        {
            var currentNode = node;

            if (currentNode != null)
            {
                this.DepthFirsthSearch_PostOrder(node.Left);
                this.DepthFirsthSearch_PostOrder(node.Right);
                Console.Write($"{node.Value},");
            }
        }

        public void BreadthFirstSearch()
        {
            //            9
            //         /     \
            //        4       20
            //      /   \     / \
            //     1     6   15 99
            //    / \   / \
            //   0   3 5   7
            var currentNode = this.Root;

            Queue<BinaryTreeNode> values = new Queue<BinaryTreeNode>();
            values.Enqueue(currentNode);

            while (values.Count > 0)
            {
                currentNode = values.Peek();
                Console.Write($"{currentNode.Value},");
                values.Dequeue();

                if (currentNode.Left is not null)
                {
                    values.Enqueue(currentNode.Left);
                }

                if (currentNode.Right is not null)
                {
                    values.Enqueue(currentNode.Right);
                }
            }
        }
    }
}
