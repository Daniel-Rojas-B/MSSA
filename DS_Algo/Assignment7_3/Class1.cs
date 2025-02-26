using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment7_3
{
    class Node
    {
        public int data;
        public Node right;
        public Node left;
        public Node(int data, Node right, Node left)
        {
            this.data = data;
            this.right = right;
            this.left = left;
        }
    }
    class BinarySearchTree
    {
        public Node root;//starting point

        //private Node root;
        //public Node Root
        //{
        //    get { return this.root; }
        //}
        public BinarySearchTree()
        {
            root = null;
        }

        public bool Search(int val)
        {
            Node temp = root;
            while (temp != null)
            {
                if (temp.data == val)
                    return true;
                else if (val < temp.data)
                    temp = temp.left;
                else if (val > temp.data)
                    temp = temp.right;
            }
            return false;
        }
        public void InsertNode(Node temproot, int val)
        {
            Node newNode = new Node(val, null, null);
            Node temp = null;

            if (root != null)
            {

                while (temproot != null)
                {
                    temp = temproot;
                    if (temproot.data == val)// no duplicates
                        return;
                    else if (val < temproot.data)
                        temproot = temproot.left;
                    else if (val > temproot.data)
                        temproot = temproot.right;
                }
                // you have reached the leaf node and temp points to that leaf node
                if (val < temp.data)
                    temp.left = newNode;
                else if (val > temp.data)
                    temp.right = newNode;
            }
            else
            {
                root = newNode;// tree was empty and newnode is now the root
            }

        }


        public void Inorder(Node temproot)
        {
            if (temproot != null)
            {
                Inorder(temproot.left);
                Console.Write(temproot.data + " ");
                Inorder(temproot.right);
            }
        }
        public void Preorder(Node temproot)
        {
            if (temproot != null)
            {
                Console.Write(temproot.data + " ");
                Preorder(temproot.left);
                Preorder(temproot.right);
            }

        }
        public void PostOrder(Node temproot)
        {
            if (temproot != null)
            {
                PostOrder(temproot.left);
                PostOrder(temproot.right);
                Console.Write(temproot.data + " ");
            }
        }
        public Node SearchSubtree(Node temproot, int val)
        {

            while (temproot != null)
            {
                if (temproot.data == val)
                    return temproot; 
                else if (val < temproot.data)
                    temproot = temproot.left;
                else
                    temproot = temproot.right;
            }
            return null; 
        }
    }
}
    
