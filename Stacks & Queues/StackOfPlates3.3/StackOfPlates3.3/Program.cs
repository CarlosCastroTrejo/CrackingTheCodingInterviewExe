using System;
using System.Collections;

namespace StackOfPlates3
{
    class MainClass
    {
        static void Main(string[] args)
        {
            StackOfPlates stack = new StackOfPlates(10);
            stack.Push(10);
            stack.Push(50);
            Console.WriteLine(stack.Peek());

        }
    }
    public class StackOfPlates
    {

        ArrayList stacks = new ArrayList();
        private int stackLimit;
        private int numberOfStack=0;

        public StackOfPlates(int limit)
        {
            this.stackLimit = limit;
            Stack uno = new Stack();
        
            stacks.Add(uno);
           
        }

        public void Push(int value)
        {
            Stack temp = (Stack)stacks[numberOfStack];
            if(temp.Count!=stackLimit)
            {
                temp.Push(value);
                stacks[numberOfStack] = temp;
            }else
            {
                AddStack();
                numberOfStack++;
                temp = (Stack)stacks[numberOfStack];
                temp.Push(value);
                stacks[numberOfStack] = temp;
            }
            
            
        }
        public void AddStack()
        {
            this.stacks.Add(new Stack());
        }
        public Object Peek()
        {
            Stack temp = (Stack)stacks[numberOfStack];
            return temp.Peek();
        }

    }

}
