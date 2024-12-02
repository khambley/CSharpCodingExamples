using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Diagnostics;

namespace CalculateNodeTreeHeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            //Construct tree 1
            //Node leaf1 = new Node(null, null);
            //Node leaf2 = new Node(null, null);
            //Node node = new Node(leaf1, null);
            //Node root = new Node(node, leaf2);

            //Construct tree 2
            Node leaf1 = new Node(null, null);
            Node leaf2 = new Node(null, null);
            Node leaf3 = new Node(null, null);
            Node leaf4 = new Node(null, null);

            Node node2 = new Node(leaf2, leaf3);
            Node node1 = new Node(leaf1, node2);
            Node node3 = new Node(null, leaf4);
            Node root = new Node(node1, node3);


            Console.WriteLine(root.Height());

            stopwatch.Stop();
            Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
        }

    }

    public class Node
    {
        public Node LeftChild { get; private set; }
        public Node RightChild { get; private set; }

        public Node(Node leftChild, Node rightChild)
        {
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public int Height()
        {
            // Base case: If the node is null, return -1 (empty subtree)
            if (this == null) return -1;

            // Recursively calculate the height of left and right subtrees
            int leftHeight = LeftChild?.Height() ?? -1; // Use null-coalescing operator for null children
            int rightHeight = RightChild?.Height() ?? -1;

            // Height of the current node is max of left and right subtree heights + 1
            return 1 + Math.Max(leftHeight, rightHeight);
        }

    }

}
