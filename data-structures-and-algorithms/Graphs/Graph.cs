using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Graph
    {
        private int numberOfNodes;
        private Dictionary<int, List<int>> adjacentList;

        public Graph()
        {
            adjacentList = new Dictionary<int, List<int>>();
            numberOfNodes = 0;
        }

        public void AddVertex(int value)
        {
            if (!adjacentList.ContainsKey(value))
            {
                adjacentList.Add(value, new List<int>());
                numberOfNodes++;
            }
            else
            {
                Console.WriteLine("Repeatead Value!");
            }
        }

        public void AddEdge(int node1, int node2)
        {
            var bothNodesExists = adjacentList.ContainsKey(node1)
                && adjacentList.ContainsKey(node2);

            if (!bothNodesExists)
            {
                Console.WriteLine("Create a vertex before adding edge");
            }
            else
            {
                adjacentList[node1].Add(node2);
                adjacentList[node2].Add(node1);
            }
        }
        public void Print()
        {
            foreach (var node in adjacentList)
            {
                Console.Write($"Node: {node.Key}, Edges: ");

                foreach (var edge in node.Value)
                {
                    Console.Write($"{edge}, ");
                }
                
                Console.WriteLine();
            }

        }
    }
}
