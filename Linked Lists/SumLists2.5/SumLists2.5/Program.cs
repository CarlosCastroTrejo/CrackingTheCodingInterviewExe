using System;
using System.Collections;
using System.Collections.Generic;

namespace SumLists2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList<int> lista1 = new LinkedList<int>();
            LinkedList<int> lista2 = new LinkedList<int>();
            LinkedList<int> lista3 = new LinkedList<int>();

            lista1.AddLast(7);
            lista1.AddLast(1);
            lista1.AddLast(6);
            lista2.AddLast(5);
            lista2.AddLast(9);
            lista2.AddLast(2);
            lista2.AddLast(2);
            lista3 = sumList(lista1.First, lista2.First);

            Print(lista1.First);
            Print(lista2.First);
            Print(lista3.First);


            void Print(LinkedListNode<int> headnode)
            {
               
                while(headnode!=null)
                {
                    Console.Write("|" + headnode.Value + "|->");
                    headnode = headnode.Next;
                }
                Console.WriteLine("\n");
            }

        }
        public static LinkedList<int> sumList(LinkedListNode<int> node1,LinkedListNode<int> node2)
        {
            LinkedList<int> lista3 = new LinkedList<int>();

            int number = 1;
            int sum = 0;
            decimal sum2 = 0;
            while(node1!=null)
            {
                sum += node1.Value * number;
                number *= 10;
                node1 = node1.Next;
            }
            number = 1;
            while (node2 != null)
            {
                sum += node2.Value * number;
                number *= 10;
                node2= node2.Next;
            }
            number = 10;
            while(sum>0)
            {
                sum2 = (int)sum;
                sum /= number;
                sum2 /= number;
                lista3.AddLast((int)((sum2-sum)*number));
            }
            return lista3;
        }
    }
}
