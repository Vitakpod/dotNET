using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Node
    {
        private int data;
        public int Data
        {
            get { return data; }
        }

        private Node rightNode;
        public Node RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        private Node leftNode;
        public Node LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }

        private bool isDeleted;
        public bool IsDeleted
        {
            get { return isDeleted; }
        }

        public Node(int value)
        {
            data = value;
        }

        public void Delete()
        {
            isDeleted = true;
        }

        public Node Find(int value)
        {
            Node currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.data && isDeleted == false)
                {
                    return currentNode;
                }
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            return null;
        }
        public void Insert(int value)
        {
            if (value >= data)
            {   
                if (rightNode == null)
                {
                    rightNode = new Node(value);
                }
                else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new Node(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
        }

        public void InOrderTraversal()
        {
            if (leftNode != null)
                leftNode.InOrderTraversal();
            Console.Write(data + " ");

            if (rightNode != null)
                rightNode.InOrderTraversal();
        }

        public void PreOrderTraversal()
        {
            Console.Write(data + " ");

            if (leftNode != null)
                leftNode.PreOrderTraversal();

            if (rightNode != null)
                rightNode.PreOrderTraversal();
        }

        public void PostorderTraversal()
        {
            if (leftNode != null)
                leftNode.PostorderTraversal();

            if (rightNode != null)
                rightNode.PostorderTraversal();

            Console.Write(data + " ");
        }
    }
}
