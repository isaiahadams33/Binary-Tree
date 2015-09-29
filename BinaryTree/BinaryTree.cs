
using System;
using System.Drawing;

namespace BinaryTree
{
    public class BinaryTree :Form1
    {
        /// <summary>
        /// the root nod, it won't be seen on the graph!
        /// </summary>
        public Node RootNode { get;  set; }

        public BinaryTree() 
        {
            RootNode = new Node(int.MinValue);
        }

     
        /// adds a node to the tree
      
        public bool Add(Node node)
        {
            return RootNode.Add(node);
        }
       
   
        // draw
        public Image Draw()
        {
            GC.Collect();// collects the unreffered locations on the memory
            int temp;
            return RootNode.Right == null ? null : RootNode.Right.Draw(out temp);
        }

        /// <summary>
        /// returns true if the current node or it's childs containd the inserted value
        /// </summary>
        public bool Exists(int item)
        {
            return RootNode.Exists(item);
        }

        
    public Node LCA(Node root, Node n1, Node n2) {

        root = new Node(25);
        root.Left = new Node(20);
        root.Right = new Node(30);
        root.Left.Left = new Node(10);
        root.Left.Right = new Node(23);
        root.Right.Right = new Node(35);
        root.Left.Left.Left = new Node(5);
        root.Left.Right.Left = new Node(21);
        root.Right.Right.Left = new Node(32);
       
              
        while (root != null)
        {
            // If root>n1 and root>n2 then lowest common ancestor will be in
            // left
            // subtree.
            if (root.Value > n1.Value && root.Value > n2.Value)
            {
                root = root.Left;
            }
            // If root<n1 and root<n2 then lowest common ancestor will be in
            // right
            // subtree.
            else if (root.Value <= n1.Value && root.Value < n2.Value)
            {
                root = root.Right;
            }
            // if I am here that means i am at the root which is lowest common
            // ancestor
            else
            {
                return root;
            }
        }
        return root;
    }
 

    }

}
