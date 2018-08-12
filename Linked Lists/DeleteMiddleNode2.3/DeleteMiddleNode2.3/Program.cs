using System;
using System.Collections.Generic;
using System.Collections;

namespace DeleteMiddleNode2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList<char> list = new LinkedList<char>();
            list.AddLast('a');
            list.AddLast('b');
            list.AddLast('c');
            list.AddLast('d');
            list.AddLast('e');
            list.AddLast('f');
            Print(list.Find('a'));
          

            deleteMiddleNode(list.Find('c'));
            Console.WriteLine("\n");
            Print(list.Find('a'));
        }

        public static void deleteMiddleNode(LinkedListNode<char> node)
        {
            //LinkedListNode<char> next = node.Next;
            node = node.Next;
            node.Value= node.Next.Value;

        }
        public static void Print(LinkedListNode<char> node)
        {
            LinkedListNode<char> Nudo = node;

            while(Nudo!=null)
            {
                Console.Write("|" + Nudo.Value + "|->");
                Nudo = Nudo.Next;
            }

           

        }
    }
}
