using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries_AVLTree
{
    class Node<T> where T : IComparable<T>
    {
        public Node<T> leftChild;
        public Node<T> rightChild;

        private int balanceFactor = 0;

        public T data;

        public Node(T data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
        }

        public T Data
        {
            set { data = value; }
            get { return data; }
        }

        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }

    }
}
