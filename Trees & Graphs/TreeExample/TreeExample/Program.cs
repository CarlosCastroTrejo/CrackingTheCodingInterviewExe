using System;

namespace TreeExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Node nudo = new Node(5);
            nudo.Insert(10);
            nudo.Insert(21);
            nudo.Insert(30);
            nudo.Insert(1);
            nudo.Insert(100);
            nudo.Insert(400);

            nudo.PrintInOrder();
        }
    }

    class Node
    {
        Node right, left;
        int data = 0;
        public Node(int data)
        {
            this.data = data;
        }

        public void Insert(int value)
        {
            if (value <= data)
            {
                if (left == null)
                {
                    left = new Node(value);
                }
                else
                {
                    left.Insert(value);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new Node(value);
                }
                else
                {
                    right.Insert(value);
                }

            }

        }

        public bool Contains(int value)
        {
            if(value==data)
            {
                return true;
            }else if(value<=data)
            {
                if (left==null)
                {
                    return false;
                }else
                {
                    return left.Contains(value);
                }
            }else 
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.Contains(value);
                }
            }

        }

        public void PrintInOrder()
        {
            if(left!=null)
            {
                left.PrintInOrder();
            }
            Console.WriteLine(data);
            if(right!=null)
            {
                right.PrintInOrder();
            }

        }

    }
}
