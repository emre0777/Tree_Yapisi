using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari_Tree
{
    public class Tree
    {
        public Node root;

        public Tree()
        {
            root = null;
        }

        public void Insert(int data)    // düğüm ekle                                       //     10
                                                                                            //    /  \
        {                                                                                   //   5    15
            root = insertR(root, data);                                                     //    \             insert=8
        }                                                                                          

        public Node insertR(Node root, int data)   // düğüm ekle
        {
            if (root == null)
            {
                return new Node(data);
            }

            if (data < root.data)
            {
                root.left = insertR(root.left, data);
            }
            else
            {
                root.right = insertR(root.right, data);
            }

            return root;
        }

        public void Delete(int data)   //  düğüm sil
        {
            root = DeleteR(root, data);
        }

        public Node DeleteR(Node root, int data)   // düğüm sil
        {
            if (root == null)
                return root;

            if (data < root.data)
                root.left = DeleteR(root.left, data);
            else if (data > root.data)
                root.right = DeleteR(root.right, data);
            else
            {
                if (root.left == root.right)  // silinecek düğümün altında dal yok demek
                {
                    root = null;
                    return null;
                }

                root.data = minValue(root.right);
                root.right = DeleteR(root.right, root.data);
            }
            return root;
        }
        public int minValue(Node root)
        {
            int min = root.data;
            while (root.left != null)
            {
                min = root.left.data;
                root = root.left;
            }
            return min;
        }
         


        public bool arama(int data)  // düğüm bul
        {
           
            return aramaR(root, data);
        }

        public bool aramaR(Node root, int data) // düğüm bul 
        {
            if (root == null)
            {
                return false;
            }

            if (data == root.data)
            {
              
                return true;
            }
            else if (root.data > data)
            {
                return aramaR(root.left, data);
            }
            else 
            {
                return aramaR(root.right, data);
            }
           

        }


        public void preOrder(Node root,List<int> list)  // preorder mantığı   r-sol-sağ
        {
            if(root == null)
            {
                return;
            }
            list.Add(root.data);
            preOrder(root.left, list);
            preOrder(root.right, list);
        }

        public void ınOrder(Node root,List<int> list) // ınorder mantığı  sol-r-sağ
        {
            if(root == null)
            {
                return;
            }
            ınOrder(root.left, list);
            list.Add(root.data);
            ınOrder(root.right,list);
        }

        public void postOrder(Node root,List<int> list) // postorder mantığı sol-sağ-r
        {
            if(root == null) 
            { 
                return; 
            }
            postOrder(root.left, list);
            postOrder(root.right, list);
            list.Add(root.data);

        }

        public int dugumsayisi(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            return 1+ dugumsayisi(root.left) + dugumsayisi(root.right);
        }

        public int yukseklik(Node root)
        {
            if(root == null)
            {
                return -1;

            }

            return 1+Math.Max(yukseklik(root.left),yukseklik(root.right));

        }

        public void yaprak(Node root,List<int> list)
        {
            if(root == null)
            {
                return;
            }
            if(root.left == null && root.right==null)
            {
                list.Add(root.data);
            }

            yaprak(root.left,list);
            yaprak(root.right,list);
        }



}
}
