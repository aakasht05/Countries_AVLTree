using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries_AVLTree
{
    class BinarySearchTree<T> : BinaryTree<T> where T : IComparable<T>
    {
        public BinarySearchTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.leftChild);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.rightChild);
        }

        public int Height()
        {
            int highest;
            highest = 0;

            highest = height(root);

            return highest;
        }

        protected int height(Node<T> node)
        {
            int leftSide = 0;
            int rightSide = 0;

            if (node == null)
                return 0;

            if (node.leftChild != null)
                leftSide = height(node.leftChild);
            if (node.rightChild != null)
                rightSide = height(node.rightChild);

            if (leftSide > rightSide)
                return leftSide + 1;
            else
                return rightSide + 1;

        }

        public Boolean Contains(T item)
        {
            return contains(item, root);
        }

        private Boolean contains(T item, Node<T> node)
        {
            if (node.Data.CompareTo(item) == 0)
                return true;
            else
            {
                if (node.leftChild != null)
                    return contains(item, node.leftChild);
                if (node.rightChild != null)
                    return contains(item, node.rightChild);

                return false;
            }
        }

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                return;
            if (tree.Data.CompareTo(item) > 0)
                removeItem(item, ref tree.leftChild);
            if (tree.Data.CompareTo(item) < 0)
                removeItem(item, ref tree.rightChild);

            if (tree.Data.CompareTo(item) == 0)
            {
                if (tree.leftChild == null)
                {
                    tree = tree.rightChild;
                }
                else if (tree.rightChild == null)
                {
                    tree = tree.leftChild;
                }
                else
                {
                    Node<T> smallest = leastItem(tree.rightChild);
                    tree.Data = smallest.Data;
                    removeItem(smallest.Data, ref tree.rightChild);
                }
            }

        }

        protected Node<T> leastItem(Node<T> tree)
        {
            if (tree.leftChild == null)
                return tree;
            else
                return leastItem(tree.leftChild);
        }

        public void CopyTo(ref BinarySearchTree<T> tree)
        {
            if (root == null)
                return;
            copyTo(ref tree, root);
        }

        private void copyTo(ref BinarySearchTree<T> tree, Node<T> node)
        {
            tree.InsertItem(node.Data);

            if (node.leftChild != null)
                copyTo(ref tree, node.leftChild);
            if (node.rightChild != null)
                copyTo(ref tree, node.rightChild);
        }

        public bool Equals(BinarySearchTree<T> tree)
        {
            if (tree.root != null && root != null)
                return equals(tree.root, root, true);
            else if (tree.root == null && root == null)
                return true;
            else
                return false;
        }

        private bool equals(Node<T> tree1, Node<T> thisTree, bool equal)
        {

            if (tree1.data.CompareTo(thisTree.data) != 0)
                equal = false;

            if (tree1.leftChild != null && thisTree.leftChild != null)
                equal = equals(tree1.leftChild, thisTree.leftChild, equal);
            else if (tree1.leftChild == null ^ thisTree.leftChild == null)
                equal = false;

            if (tree1.rightChild != null && thisTree.rightChild != null)
                equal = equals(tree1.rightChild, thisTree.rightChild, equal);
            else if (tree1.rightChild == null ^ thisTree.rightChild == null)
                equal = false;

            return equal;
        }

        //TODO: public bool SubTree(BSTree<T> tree)

    }
}
