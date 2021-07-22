using System;

namespace DatastructureBinaryTree
{
//general application of trees
    //1. to represent hierachichal data
    //2. databases
    //3. Autocompletion
    //4. Compilers
    //5. compression (jpeg,MP3).
    //look up O(logn)
    //Insert O(logn)
    //Delete O(logn)


    public class Tree
    {
        internal class Node
        {
            internal int value;
            internal Node leftChild;
            internal Node rightChild;
            internal Node(int value)
            {
                this.value = value;
            }

            public override string ToString()
            {
                return "Node  " + value;
            }
        }

        private Node root;

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if(root == null)
            {
                root = newNode;
                return;
            }

            var current = root;
            while (true)
            {
                if(value < current.value)
                {
                    if(current.leftChild == null)
                    {
                        current.leftChild = newNode;
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if(current.rightChild == null)
                    {
                        current.rightChild = newNode;
                        break;
                    }
                    current = current.rightChild;
                }
            }
        }

        public bool Find(int value)
        {
            Node current = root;
            while(current != null)
            {
                if (value < current.value)
                {
                    current = current.leftChild;
                }
                else if (value > current.value)
                {
                    current = current.rightChild;
                }
                else return true;
            }

            return false;
        }

        //Traversing trees
        //two methods: 
        //1. bredth first approach also called level order cos we traverse nodes level by level and 
        //2. depth first approach: also has three types; 1. pre-order, 2. in-order, 3. post-order

        //pre-order => visit: root, leftChild and rightChild,
        //7 4 1 6 9 8 10
        //in-order => visist: leftChild, root and rightChild. This gives output in an ascending order
        //post-order => visit:leftChild, rightChild and root

        public ulong Factorial(ulong value)
        {
            if(value == 0)
            {
                return 1;
            }

            return (value * Factorial(value - 1));
        }

        public void TreePreOrderTransversal()
        {
            TreePreOrderTransversal(root);
        }

        private void TreePreOrderTransversal(Node root)
        {
            if(root == null)
            {
                return;
            }
            Console.WriteLine(root.value);

            TreePreOrderTransversal(root.leftChild);

            TreePreOrderTransversal(root.rightChild);
        }

        public void TreeInOrderTransversal()
        {
            TreeInOrderTransversal(root);
        }
        private void TreeInOrderTransversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            TreeInOrderTransversal(root.leftChild);

            Console.WriteLine(root.value);

            TreeInOrderTransversal(root.rightChild);
        }

        public void TreePostOrderTransversal()
        {
            TreePostOrderTransversal(root);
        }
        private void TreePostOrderTransversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            TreePostOrderTransversal(root.leftChild);

            TreePostOrderTransversal(root.rightChild);

            Console.WriteLine(root.value);
        }



    }

}
