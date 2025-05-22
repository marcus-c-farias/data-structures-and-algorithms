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
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 170);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 15);
            binaryTree.Root = binaryTree.Insert(binaryTree.Root, 1);


            var success = binaryTree.LookUp(binaryTree.Root, 21);

            binaryTree.Transverse(binaryTree.Root);
            Console.WriteLine();
            binaryTree.Invert(binaryTree.Root);
            Console.WriteLine();
            binaryTree.Transverse(binaryTree.Root);
        }
    }
}
