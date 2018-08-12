using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RemoveDups2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();


            list.addToEnd(5);
            list.addToEnd(2);
            list.addToEnd(10);
            list.addToEnd(15);
            list.addToEnd(20);
            list.addToEnd(50);
            list.Print();
            Console.WriteLine("\n");
            RemoveDups(list.headNode);
           // list.Print();

        }
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                next = null;
            }

            public void Print()
            {
                Console.Write("|" + data + "|->");
                if (next != null)
                {
                    next.Print();
                }
            }
            public void addToEnd(int data)
            {
                if (next == null)
                {
                    next = new Node(data);
                }
                else
                {
                    next.addToEnd(data);
                }

            }
        }

        public class LinkedList
        {
            public Node headNode;

            public LinkedList()
            {
                headNode = null;
            }

            public void Print()
            {
                if (headNode != null)
                {
                    headNode.Print();
                }
            }
            public void addToEnd(int data)
            {
                if (headNode == null)
                {
                    headNode = new Node(data);
                }
                else
                {
                    headNode.addToEnd(data);
                }
            }



        }

        public static void RemoveDups(Node head)
        {
            Hashtable table = new Hashtable();
            Node nudo = head;
            int cuenta = 0;

            while(nudo!=null)
            {
                table.Add(cuenta,nudo.data);
                cuenta++;
                nudo = nudo.next;
            }

            foreach( DictionaryEntry x in table)
            {
                Console.WriteLine(x.Key + " - " + x.Value);
            }
            nudo = head;

            while (nudo != null)
            {
                if(table.ContainsValue(nudo.data))
                {
                    
                }
                nudo=nudo.next
            }
           


        }
    }

}

