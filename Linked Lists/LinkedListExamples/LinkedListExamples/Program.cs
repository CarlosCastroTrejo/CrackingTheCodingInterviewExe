using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListExamples
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            Node myNode = new Node(7); // Instantiation of the first node (object)
            myNode.next = new Node(5); // Addding a new node to the first one  
            myNode.next.next=new Node(11); // Adding a new node to the next one of the new node
            myNode.addToEnd(15); // Addding a new Node by the method
            myNode.addToEnd(20); // Adding a new Node by the method

            myNode.Print(); // Print all the Nodes by the method
            */
            /*
            // As I did a MyList class we will arrange them in there
            MyList list = new MyList();
            list.addToEnd(1);
            list.addToEnd(5);
            list.addToEnd(9);
            list.addToBeginning(0);

            list.Print();
            */

            MyList list = new MyList();
            list.addSorted(1);
            list.addSorted(25);
            list.addSorted(1);
            list.addSorted(5);
            list.addSorted(500);
            list.addSorted(9);
            list.addSorted(0);

            list.Print();


        }

        // It is a classs, like in OOP, we will instantiate objects
        public class Node
        {
            // Properties
            public int data;
            public Node next;

            // Constructor of the Node (object)
            public Node(int i)
            {
                data = i;
                next = null;
            }

            // Methods
            public void Print() // Method to print all the Nodes
            {
                Console.Write("|" + data + "|->");
                if(next!=null)
                {
                    next.Print(); // Recursion
                }
            }

            public void addToEnd(int i) // Method to add a new Node
            {
                if(next==null)
                {
                    next = new Node(i);
                }else
                {
                    next.addToEnd(i); // Recursion to finally add to end
                }
            }

            public void addSorted(int data)
            {
                if (next ==null)
                {
                    next = new Node(data);
                }
                else if (data<next.data)
                {
                    Node temp = new Node(data);
                    temp.next = this.next;
                    this.next = temp;
                }else
                {
                    next.addSorted(data);
                }
            }

        }

        // It is a class, like in OOP, we will instantiate an object of this classs
        public class MyList
        {
            // Properties
            public Node headNode;

            // Constructor
            public MyList()
            {
                headNode = null;
            }

            // Methods
            public void addToEnd(int data)
            {
                if(headNode==null)
                {
                    headNode = new Node(data);
                }
                else
                {
                    headNode.addToEnd(data);
                }
                
            }
            public void addToBeginning(int data)
            {
                if(headNode==null)
                {
                    headNode = new Node(data);
                }
                else
                {
                    Node temp = new Node(data);
                    temp.next = headNode;
                    headNode = temp;
                }
            }
            public void addSorted(int data)
            {
                if (headNode == null)
                {
                    headNode = new Node(data);
                }
                else if (data < headNode.data)
                {
                    addToBeginning(data);
                }
                else
                {
                    headNode.addSorted(data);
                }
            }

            public void Print()
            {
                if(headNode!=null)
                {
                    headNode.Print();
                }
            }

        }
    }
}
