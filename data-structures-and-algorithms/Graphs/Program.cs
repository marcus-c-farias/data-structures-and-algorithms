namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();

            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(3);
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(3, 1);
            graph.Print();
        }
    }
}
