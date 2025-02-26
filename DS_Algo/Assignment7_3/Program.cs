namespace Assignment7_3
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

            Node subtree = tree.SearchSubtree(tree.root, 300);
            if (subtree != null)
            {
                Console.WriteLine("Subtree found with root: " + subtree.data); 
            }
            else
            {
                Console.WriteLine("Node not found");
            }
            Console.ReadKey();
        }
    }
}
