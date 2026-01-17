using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari_Tree
{
    public class Node
    {
        public int data;
        public Node right;
        public Node left;

        public Node(int data)
        {
            this.data = data;
            right = null;
            left = null;

        }

    }
}
