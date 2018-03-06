using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries_AVLTree
{
    class AVLTree<T> : BinarySearchTree<T> where T : IComparable<T>
    {
        public new void InsertItem(T item)
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

            tree.BalanceFactor = height(tree.leftChild) - height(tree.rightChild);

            Console.WriteLine("DATA: " + tree.Data + " " + "BALANCE: " + tree.BalanceFactor);

            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);
        }

        public new void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref Node<T> tree)
        {
            Console.WriteLine("REMOVAL");
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
                    return;
                }
                else if (tree.rightChild == null)
                {
                    tree = tree.leftChild;
                    return;
                }
                else
                {
                    Node<T> smallest = leastItem(tree.rightChild);
                    tree.Data = smallest.Data;
                    removeItem(smallest.Data, ref tree.rightChild);
                    //return;
                }
                tree.BalanceFactor = height(tree.leftChild) - height(tree.rightChild);

                Console.WriteLine("DATA: " + tree.Data + " " + "BALANCE: " + tree.BalanceFactor);

                if (tree.BalanceFactor <= -2)
                    rotateLeft(ref tree);
                if (tree.BalanceFactor >= 2)
                    rotateRight(ref tree);
            }

        }

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.rightChild.BalanceFactor > 0)
            {
                Console.WriteLine("DOUBLE");
                rotateRight(ref tree.rightChild);
            }

            Console.WriteLine("Rotate left");
            Node<T> newRoot = tree.rightChild;
            tree.rightChild = newRoot.leftChild;
            newRoot.leftChild = tree;

            tree = newRoot;
        }

        private void rotateRight(ref Node<T> tree)
        {

            if (tree.leftChild.BalanceFactor < 0)
            {
                Console.WriteLine("DOUBLE");
                rotateLeft(ref tree.leftChild);
            }

            Console.WriteLine("Rotate right");
            Node<T> newRoot = tree.leftChild;
            tree.leftChild = newRoot.rightChild;
            newRoot.rightChild = tree;

            tree = newRoot;
        }
    }
}

