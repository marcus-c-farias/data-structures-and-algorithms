namespace Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = binaryTree.Insert(null, 9);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 4);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 6);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 20);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 99);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 15);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 1);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 3);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 7);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 5);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 0);

            // var node = binaryTree.LookUp(binaryTree.Root, 4);

            // binaryTree.Root = binaryTree.Remove(binaryTree.Root, 0);
            // binaryTree.Root = binaryTree.Remove(binaryTree.Root, 6);

            // binaryTree.Transverse(binaryTree.Root);
            // Console.WriteLine();
            // binaryTree.Invert(binaryTree.Root);
            // Console.WriteLine();
            // binaryTree.Transverse(binaryTree.Root);
            //binaryTree.BreadthFirstSearch();
            //Console.WriteLine();
            //binaryTree.DepthFirsthSearch_InOrder(binaryTree.Root);
            Console.WriteLine();
            binaryTree.DepthFirsthSearch_PostOrder(binaryTree.Root);
            Console.WriteLine();
        }
    }
}
