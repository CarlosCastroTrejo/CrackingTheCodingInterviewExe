using System;
using System.Collections;

namespace SortStack3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(10);
            myStack.Push(100);
            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(3);
            myStack.Push(48);
            myStack.Push(12);
            myStack.Push(79);
            myStack.Push(9);

            myStack=SortStack(myStack);

            while(myStack.Count>0)
            {
                Console.WriteLine(myStack.Pop());

            }


        }

        public static Stack SortStack(Stack myStack)
        {
            bool sorted = false;
            Stack otherStack = new Stack();
           otherStack.Push(myStack.Pop());

            while(!sorted)
            {
                

                int number = (int)myStack.Pop();
                if(number>(int)otherStack.Peek())
                {
                    otherStack.Push(number);
                }else
                {
                    while ( otherStack.Count >= 1) 
                    {
                        myStack.Push(otherStack.Pop());

                    }
                  
                    otherStack.Push(number);
                }


                if(myStack.Count==0)
                {
                    sorted = true;
                }


            }

            return otherStack;
        }
    }
}