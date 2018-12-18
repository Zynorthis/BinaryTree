using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node<T>
    {
        private T data;
        public T Data { get { return data; } set { data = value; } }
        public Node<T> left;
        public Node<T> right;
        private int level;
        public int Level { get { return level; } set { level = value; } }

        public Node()
        {
            left = null;
            right = null;
        }
    }
}
