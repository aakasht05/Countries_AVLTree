using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries_AVLTree
{
    class BinaryTree<T> where T : IComparable<T>
    {
        protected Node<T> root;

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(Node<T> node)
        {
            root = node;
        }

        public List<T> PreOrder()
        {
            List<T> list = new List<T>();
            preOrder(root, list);

            return list;
        }

        private void preOrder(Node<T> node, List<T> list)
        {
            list.Add(node.Data);
            if (node.leftChild != null)
                preOrder(node.leftChild, list);
            if (node.rightChild != null)
                preOrder(node.rightChild, list);
            return;
        }

        public List<T> InOrder()
        {
            List<T> list = new List<T>();
            if (root == null)
                return list;

            inOrder(root, list);

            return list;
        }

        private void inOrder(Node<T> node, List<T> list)
        {
            if (node.leftChild != null)
                inOrder(node.leftChild, list);

            list.Add(node.Data);

            if (node.rightChild != null)
                inOrder(node.rightChild, list);

            return;
        }

        public List<T> PostOrder()
        {
            List<T> list = new List<T>();
            postOrder(root, list);

            return list;
        }

        private void postOrder(Node<T> node, List<T> list)
        {
            if (node.leftChild != null)
                postOrder(node.leftChild, list);
            if (node.rightChild != null)
                postOrder(node.rightChild, list);

            list.Add(node.Data);
            return;
        }

        public void Copy(BinaryTree<T> tree2)
        {
            copy(ref root, tree2.root);
        }

        private void copy(ref Node<T> tree, Node<T> tree2)
        {
            if (tree == null)
                return;

            tree2.Data = tree.Data;

            if (tree.leftChild != null)
            {
                copy(ref tree.leftChild, tree2.leftChild);
            }

            if (tree.rightChild != null)
            {
                copy(ref tree.rightChild, tree2.rightChild);
            }
        }

        public int Count()
        {
            int num = 0;

            if (root == null)
                return 0;

            count(ref num, root);

            return num;
        }

        private void count(ref int counter, Node<T> node)
        {
            counter++;

            if (node.leftChild != null)
                count(ref counter, node.leftChild);

            if (node.rightChild != null)
                count(ref counter, node.rightChild);
        }
    }
}
