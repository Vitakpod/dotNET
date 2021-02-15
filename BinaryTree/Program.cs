using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree\n");

            Tree binaryTree = new Tree();

            binaryTree.Insert(12);
            binaryTree.Insert(30);
            binaryTree.Insert(77);
            binaryTree.Insert(73);
            binaryTree.Insert(59);
            binaryTree.Insert(33);
            binaryTree.Insert(62);
            binaryTree.Insert(85);
            binaryTree.Insert(3);
            binaryTree.Insert(99);
            binaryTree.Insert(100);

            Console.WriteLine("In Order Traversal (Left->Root->Right)");
            binaryTree.InorderTraversal();

            Console.WriteLine("\nFinding 85:");
            var node = binaryTree.Find(85);
            Console.WriteLine(node.Data);

            Console.WriteLine("Delete a Node (62)");
            binaryTree.Remove(62);

            Console.WriteLine("In Order Traversal (Left->Root->Right)");
            binaryTree.InorderTraversal();
        }
    }
}
