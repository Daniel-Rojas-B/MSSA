namespace Mod8BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.InsertNode(tree.root, 100);
            tree.InsertNode(tree.root, 200);
            tree.InsertNode(tree.root, 20);
            tree.InsertNode(tree.root, 300);
            tree.InsertNode(tree.root, 10);
            tree.InsertNode(tree.root, 30);
            tree.InsertNode(tree.root, 150);
            Console.WriteLine(tree.Search(300));
            Console.WriteLine("Inorder");
            tree.Inorder(tree.root);
            Console.WriteLine();
            Console.WriteLine("Preorder");
            tree.Preorder(tree.root);
            Console.WriteLine();
            Console.WriteLine("Postorder");
            tree.PostOrder(tree.root);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
