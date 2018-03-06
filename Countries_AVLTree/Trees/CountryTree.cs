using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries_AVLTree
{
    class CountryTree<T> : AVLTree<T> where T : IComparable<T>
    {
        public T FindItemByName(string name)
        {
            if (name == String.Empty)
                return default(T);

            return findItemByName(name, root);
        }

        private T findItemByName(string name, Node<T> node)
        {
            if (node.Data.ToString().CompareTo(name) == 0)
                return node.Data;
            if (node.Data.ToString().CompareTo(name) > 0)
                return findItemByName(name, node.leftChild);
            if (node.Data.ToString().CompareTo(name) < 0)
                return findItemByName(name, node.rightChild);

            return default(T);
        }

        public int RemoveItemByName(string name)
        {
            if (name == String.Empty)
                return -1;

            return removeItemByName(name, root);
        }

        private int removeItemByName(string name, Node<T> node)
        {
            if (node.Data.ToString().CompareTo(name) == 0)
            {
                RemoveItem(node.Data);
                return 0;
            }
            if (node.Data.ToString().CompareTo(name) > 0)
                return removeItemByName(name, node.leftChild);
            if (node.Data.ToString().CompareTo(name) < 0)
                return removeItemByName(name, node.rightChild);

            return -1;
        }

        public List<T> KeywordSearch(string searchTerm)
        {
            List<T> list = new List<T>();

            keywordSearch(ref list, searchTerm, root);

            return list;
        }

        private void keywordSearch(ref List<T> list, string searchTerm, Node<T> node) //Doesn't return Vietnam or Turkey for some reason...
        {
            if (node == null)
                return;

            if (node.leftChild != null)
                keywordSearch(ref list, searchTerm, node.leftChild);
            if (node.Data.ToString().ToLower().StartsWith(searchTerm.ToLower()))
                list.Add(node.Data);
            if (node.rightChild != null)
                keywordSearch(ref list, searchTerm, node.rightChild);
        }

    }
}
