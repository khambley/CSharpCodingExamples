## Programming Solutions using C# ##
1. Calculate Tree Height
   - A tree is an abstract data structure consisting of nodes. Each node has only one parent node and zero or more child nodes. Each tree has one special node, called a root, which has no parent node. A node is called a leaf if it has no child nodes. The height of a tree is the largest distance (number of parent-child connections) from the root to a leaf.
   - **Write a function that calculates the height of a given tree.** *For example, the tree below has a height of 2 since the longest distance (number of parent-child connections) from the root to a leaf is 2 (the connections are the root to a node and then the node to leaf 1)*
   - There are many practical applications for calculating the height of a tree structure. It can help shorten the time in searching a large list of items, like names. The left child could be last names starting with A - M and the right side could be last names starting with L - Z. So, it only has to search through half the list to find a match. With only a few DNA samples, it can help determine ancestry trees and several generations, and help find the root ancestor from DNA samples.
```
       root
       /   \
   node   leaf2
   /
leaf1

```

```
using System;

public static void Main(string[] args)
{
   Node leaf1 = new Node(null, null);
   Node leaf2 = new Node(null, null);
   Node node = new Node(leaf1, null);
   Node root = new Node(node, leaf2);

   Console.WriteLine(root.Height());
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
       throw new NotImplementedException("Waiting to be implemented.");
   } 
}

```
